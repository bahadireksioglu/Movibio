using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Movibio.DataLayer.Concrete;
using Movibio.DataLayer.Dtos.CommentDtos;
using Movibio.MVC.Models;
using Movibio.ServiceLayer.Abstract;
using Movibio.SharedLayer.Utilities.Results.ComplexTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movibio.MVC.Controllers
{
    public class MovieController : Controller
    {
        private readonly IMovieService _movieService;
        private readonly ICommentService _commentService;
        private readonly UserManager<User> _userManager;
        public MovieController(IMovieService movieService,
            ICommentService commentService,
            UserManager<User> userManager)
        {
            _movieService = movieService;
            _commentService = commentService;
            _userManager = userManager;
        }
        public async Task<IActionResult> Index(int movieId)
        {
            var movie = await _movieService.Get(movieId);
            
            if (movie.ResultStatus == ResultStatus.Success)
            {
                var user = _userManager.GetUserAsync(HttpContext.User).Result;
                if (user != null)
                    return View(new MovieContentViewModel { Movie = movie.Data, User = user });

                else
                    return View(new MovieContentViewModel { Movie = movie.Data, User = null });
            }
            
            return View(null);
        }

        public async Task<IActionResult> IndexByName(string movieName)
        {
            var movie = await _movieService.GetByName(movieName);
            if (movie.ResultStatus == ResultStatus.Success)
            {
                var user = _userManager.GetUserAsync(HttpContext.User).Result;
                if (user != null)
                    return View(new MovieContentViewModel { Movie = movie.Data, User = user });

                else
                    return View(new MovieContentViewModel { Movie = movie.Data, User = null });
            }
            return View(null);
        }

        public async Task<JsonResult> AllMovieNames()
        {
            var movies = await _movieService.GetAll();
            if (movies.ResultStatus == ResultStatus.Success)
            {
                var allMovieNames = movies.Data.Select(m => m.Name).ToList();
                return Json(allMovieNames);
            }

            return Json(null);
        }

        [Authorize]
        public async Task<IActionResult> CommentInsert(CommentInsertDto commentInsertDto)
        {
            var user = _userManager.GetUserAsync(HttpContext.User).Result;
            commentInsertDto.CreatedByUserName = user.UserName;
            commentInsertDto.ModifiedByUserName = user.UserName;
            var comment = await _commentService.Insert(commentInsertDto);
            if (comment.ResultStatus == ResultStatus.Success)
            {
                var scoreUpdate = await _movieService.UpdateAvgScore(
                    commentInsertDto.MovieId, commentInsertDto.Score);
                if(scoreUpdate.ResultStatus==ResultStatus.Success)
                    return Json("Success");
            }
            return Json("Error");
        }
    }
}
