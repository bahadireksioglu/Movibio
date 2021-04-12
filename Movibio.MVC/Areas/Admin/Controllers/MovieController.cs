using Microsoft.AspNetCore.Mvc;
using Movibio.ServiceLayer.Abstract;
using Movibio.SharedLayer.Utilities.Results.ComplexTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movibio.MVC.Areas.Admin.Controllers
{
    public class MovieController : Controller
    {

        private readonly IMovieService _movieService;
        public MovieController(IMovieService movieService)
        {
            _movieService = movieService;
        }
        public async Task<IActionResult> Index()
        {
            var movies = await _movieService.GetAll();
            if(movies.ResultStatus==ResultStatus.Success)
                return View(movies.Data);
            return View(null);
        }

        [HttpGet]
        public async Task<IActionResult> Insert()
        {
            return View();
        }
    }
}
