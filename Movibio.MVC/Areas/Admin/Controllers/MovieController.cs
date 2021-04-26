using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Movibio.DataLayer.Dtos.MovieDtos;
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

        public MovieController(IMovieService movieService,
            IDirectorService directorService,
            ICastService castService,
            IScenaristService scenaristService)
        {
            _movieService = movieService;
            _directorService = directorService;
            _castService = castService;
            _scenaristService = scenaristService;
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
            if (directors.ResultStatus == ResultStatus.Success &&
                casts.ResultStatus == ResultStatus.Success &&
                scenarists.ResultStatus == ResultStatus.Success)
            {

                ViewBag.Directors = directors.Data;
                ViewBag.Casts = casts.Data;
                ViewBag.Scenarists = scenarists.Data;
            }
            else
            {
                ViewBag.Directors = null;
                ViewBag.Casts = null;
                ViewBag.Scenarists = null;
            }
            return PartialView("_MovieInsertPartial");
        }

        //[HttpPost]
        //public async Task<JsonResult> Insert()
        //{
        //    if (Request.Files.Count > 0)
        //    {
        //        try
        //        {
        //            //  Get all files from Request object  
        //            HttpFileCollectionBase files = Request.Files;
        //            for (int i = 0; i < files.Count; i++)
        //            {
        //                //string path = AppDomain.CurrentDomain.BaseDirectory + "Uploads/";  
        //                //string filename = Path.GetFileName(Request.Files[i].FileName);  

        //                HttpPostedFileBase file = files[i];
        //                string fname;

        //                // Checking for Internet Explorer  
        //                if (Request.Browser.Browser.ToUpper() == "IE" || Request.Browser.Browser.ToUpper() == "INTERNETEXPLORER")
        //                {
        //                    string[] testfiles = file.FileName.Split(new char[] { '\\' });
        //                    fname = testfiles[testfiles.Length - 1];
        //                }
        //                else
        //                {
        //                    fname = file.FileName;
        //                }

        //                // Get the complete folder path and store the file inside it.  
        //                fname = Path.Combine(Server.MapPath("~/Uploads/"), fname);
        //                file.SaveAs(fname);
        //            }
        //            // Returns message that successfully uploaded  
        //            return Json("File Uploaded Successfully!");
        //        }
        //        catch (Exception ex)
        //        {
        //            return Json("Error occurred. Error details: " + ex.Message);
        //        }
        //    }
        //    else
        //    {
        //        return Json("No files selected.");
        //    }
        //}
    }
}
