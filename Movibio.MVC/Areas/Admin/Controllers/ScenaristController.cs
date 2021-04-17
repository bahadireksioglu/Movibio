using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Movibio.DataLayer.Dtos.ScenaristDtos;
using Movibio.MVC.Extensions;
using Movibio.ServiceLayer.Abstract;
using Movibio.SharedLayer.Utilities.Extensions;
using Movibio.SharedLayer.Utilities.Results.ComplexTypes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Movibio.MVC.Areas.Admin.Controllers
{
    public class ScenaristController : Controller
    {
        private readonly IScenaristService _scenaristService;
        private readonly IMapper _mapper;
        private readonly IWebHostEnvironment _env;
        public ScenaristController(IScenaristService scenaristService,
            IMapper mapper, IWebHostEnvironment env)
        {
            _scenaristService = scenaristService;
            _mapper = mapper;
            _env = env;
        }

        public async Task<IActionResult> Index()
        {
            var scenarists = await _scenaristService.GetAll();
            
            if (scenarists.ResultStatus == ResultStatus.Success)
                return View(scenarists.Data);
            
            return View(null);
        }
        [HttpGet]
        public IActionResult Insert()
        {
            return PartialView("_ScenaristInsertPartial");
        }

        [HttpPost]
        public async Task<IActionResult> Insert(ScenaristInsertDto scenaristInsertDto)
        {

            scenaristInsertDto.CreatedByUserName = "admin";
            scenaristInsertDto.ModifiedByUserName = "admin";
            scenaristInsertDto.PicturePath = await ImageExtensions.ImageUpload(
                scenaristInsertDto.FirstName + scenaristInsertDto.LastName, 
                "scenarists", scenaristInsertDto.Picture, _env);

            var insertedScenarist = await _scenaristService.Insert(scenaristInsertDto);
            if (insertedScenarist.ResultStatus == ResultStatus.Success)
                return Json(0);
            return Json(1);
        }

        [HttpGet]
        public async Task<IActionResult> Update(int scenaristId)
        {
            var scenarist = await _scenaristService.Get(scenaristId);
            if (scenarist.ResultStatus == ResultStatus.Success)
                return PartialView("_ScenaristEditPartial",
                    _mapper.Map<ScenaristUpdateDto>(scenarist.Data));
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Update(ScenaristUpdateDto scenaristUpdateDto)
        {

            bool isNewPicUploaded = false;
            var oldUserPic = scenaristUpdateDto.PicturePath;

            if (scenaristUpdateDto.Picture != null)
            {
                scenaristUpdateDto.PicturePath = await ImageExtensions.ImageUpload(
                    scenaristUpdateDto.FirstName + scenaristUpdateDto.LastName,
                    "scenarists", scenaristUpdateDto.Picture, _env);
                isNewPicUploaded = true;
            }
            scenaristUpdateDto.ModifiedByUserName = "admin";

            var updatedScenarist = await _scenaristService.Update(scenaristUpdateDto);

            if (updatedScenarist.ResultStatus == ResultStatus.Success)
            {
                if (isNewPicUploaded)
                    ImageExtensions.ImageDelete(oldUserPic, "scenarists", _env);
                return Json(0);
            }

            return Json(1);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int scenaristId)
        {
            var deletedScenarist= await _scenaristService.Delete(scenaristId);
            if (deletedScenarist != null)
            {
                ImageExtensions.ImageDelete(deletedScenarist.Data.PicturePath, "scenarists", _env);
                return Json(0);
            }
            return Json(1);
        }
        //public async Task<string> ImageUpload(string castName, IFormFile picFile)
        //{
        //    //  ~/img/user.Picture
        //    string wwwroot = _env.WebRootPath;
        //    //string fileName = Path.GetFileNameWithoutExtension(picFile.FileName);
        //    string fileExtension = Path.GetExtension(picFile.FileName);
        //    DateTime dateTime = DateTime.Now;
        //    string fileName = $"{castName}_" +
        //        $"{dateTime.FullDateAndTimeStringWithUnderscore()}{fileExtension}";
        //    var path = Path.Combine($"{wwwroot}/images/scenarists", fileName);

        //    await using (var stream = new FileStream(path, FileMode.Create))
        //    {
        //        await picFile.CopyToAsync(stream);
        //    }

        //    return fileName;
        //}

        //public bool ImageDelete(string pictureName)
        //{
        //    string wwwroot = _env.WebRootPath;
        //    var fileToDelete = Path.Combine($"{wwwroot}/images/scenarists", pictureName);
        //    if (System.IO.File.Exists(fileToDelete))
        //    {
        //        System.IO.File.Delete(fileToDelete);
        //        return true;
        //    }
        //    return false;
        //}
    }
}
