using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Movibio.DataLayer.Concrete;
using Movibio.DataLayer.Dtos.MovieDtos;
using Movibio.MVC.Extensions;
using Movibio.ServiceLayer.Abstract;
using Movibio.SharedLayer.Utilities.Results.ComplexTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movibio.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin,Editor")]
    public class MovieController : Controller
    {

        private readonly IMovieService _movieService;
        private readonly IDirectorService _directorService;
        private readonly ICastService _castService;
        private readonly IScenaristService _scenaristService;
        private readonly IGenreService _genreService;
        private readonly ILanguageService _langugageService;
        private readonly IWebHostEnvironment _env;
        private readonly UserManager<User> _userManager;

        public MovieController(IMovieService movieService,
            IDirectorService directorService,
            ICastService castService,
            IScenaristService scenaristService,
            IGenreService genreService,
            ILanguageService languageService,
            IWebHostEnvironment env,
            UserManager<User> userManager)
        {
            _movieService = movieService;
            _directorService = directorService;
            _castService = castService;
            _scenaristService = scenaristService;
            _langugageService = languageService;
            _genreService = genreService;
            _env = env;
            _userManager = userManager;
        }
        public async Task<IActionResult> Index()
        {
            var movies = await _movieService.GetAll();
            
            if (movies.ResultStatus==ResultStatus.Success)
                return View(movies.Data);
            return View(null);
        }

        [HttpGet]
        public async Task<IActionResult> Insert()
        {
            var directors = await _directorService.GetAll();
            var casts = await _castService.GetAll();
            var scenarists = await _scenaristService.GetAll();
            var genres = await _genreService.GetAll();
            var languages = await _langugageService.GetAll();

            if (directors.ResultStatus == ResultStatus.Success &&
                casts.ResultStatus == ResultStatus.Success &&
                scenarists.ResultStatus == ResultStatus.Success)
            {

                ViewBag.Directors = directors.Data;
                ViewBag.Casts = casts.Data;
                ViewBag.Scenarists = scenarists.Data;
                ViewBag.Genres = genres.Data;
                ViewBag.Languages = languages.Data;
            }
            else
            {
                ViewBag.Directors = null;
                ViewBag.Casts = null;
                ViewBag.Scenarists = null;
                ViewBag.Genres = null;
                ViewBag.Languages = null;
            }
            return View();
        }

        [HttpPost]
        public async Task<JsonResult> Insert(MovieInsertDto movieInsertDto)
        {
            var user = _userManager.GetUserAsync(HttpContext.User).Result;
            movieInsertDto.CreatedByUserName = user.UserName;
            movieInsertDto.ModifiedByUserName = user.UserName;
            movieInsertDto.PosterPath = await ImageExtensions.ImageUpload(
                movieInsertDto.Name, $"movies/{movieInsertDto.Name}",
                movieInsertDto.Poster, 
                _env);
            //Username
            var insertedMovie = await _movieService.Insert(movieInsertDto);
            if (insertedMovie.ResultStatus == ResultStatus.Success)
                return Json(0);
            return Json(1);
        }
    }
}
