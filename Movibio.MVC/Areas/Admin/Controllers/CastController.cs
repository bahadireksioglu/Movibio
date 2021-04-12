using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Movibio.DataLayer.Concrete;
using Movibio.DataLayer.Dtos.CastDtos;
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
    public class CastController : Controller
    {
        private readonly ICastService _castService;
        private readonly IMapper _mapper;
        private readonly IWebHostEnvironment _env;
        public CastController(ICastService castService, 
            IWebHostEnvironment env,
            IMapper mapper)
        {
            _castService = castService;
            _env = env;
            _mapper = mapper;
        }
        public async Task<IActionResult> Index()
        {
            var casts = await _castService.GetAll();
            if(casts.ResultStatus==ResultStatus.Success)
                return View(casts.Data);
            return View(null);
        }

        [HttpGet]
        public IActionResult Insert()
        {
            return PartialView("_CastInsertPartial");
        }

        [HttpPost]
        public async Task<IActionResult> Insert(CastInsertDto castInsertDto)
        {

            castInsertDto.CreatedByUserName = "admin";
            castInsertDto.ModifiedByUserName = "admin";
            castInsertDto.PicturePath = await ImageUpload(
                castInsertDto.FirstName + castInsertDto.LastName,
                castInsertDto.Picture);

            var insertedCast = await _castService.Insert(castInsertDto);
            if (insertedCast.ResultStatus == ResultStatus.Success)
                return Json(0);
            return Json(1);
        }

        [HttpGet]
        public async Task<IActionResult> Update(int castId)
        {
            var cast = await _castService.Get(castId);
            if (cast.ResultStatus == ResultStatus.Success)
                return PartialView("_CastEditPartial",
                    _mapper.Map<CastUpdateDto>(cast.Data));
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Update(CastUpdateDto castUpdateDto)
        {

            bool isNewPicUploaded = false;
            var oldUserPic = castUpdateDto.PicturePath;

            if (castUpdateDto.Picture != null)
            {
                castUpdateDto.PicturePath = await ImageUpload(
                    castUpdateDto.FirstName + castUpdateDto.LastName,
                    castUpdateDto.Picture);
                isNewPicUploaded = true;
            }
            castUpdateDto.ModifiedByUserName = "admin";

            var updatedCast = await _castService.Update(castUpdateDto);

            if (updatedCast.ResultStatus == ResultStatus.Success)
            {
                if (isNewPicUploaded)
                    ImageDelete(oldUserPic);
                return Json(0);
            }

            return Json(1);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int castId)
        {
            var deletedCast = await _castService.Delete(castId);
            if (deletedCast != null)
            {
                ImageDelete(deletedCast.Data.PicturePath);
                return Json(0);
            }
            return Json(1);
        }

        public async Task<string> ImageUpload(string castName, IFormFile picFile)
        {
            //  ~/img/user.Picture
            string wwwroot = _env.WebRootPath;
            //string fileName = Path.GetFileNameWithoutExtension(picFile.FileName);
            string fileExtension = Path.GetExtension(picFile.FileName);
            DateTime dateTime = DateTime.Now;
            string fileName = $"{castName}_" +
                $"{dateTime.FullDateAndTimeStringWithUnderscore()}{fileExtension}";
            var path = Path.Combine($"{wwwroot}/images/casts", fileName);

            await using (var stream = new FileStream(path, FileMode.Create))
            {
                await picFile.CopyToAsync(stream);
            }

            return fileName;
        }

        public bool ImageDelete(string pictureName)
        {
            string wwwroot = _env.WebRootPath;
            var fileToDelete = Path.Combine($"{wwwroot}/images/casts", pictureName);
            if (System.IO.File.Exists(fileToDelete))
            {
                System.IO.File.Delete(fileToDelete);
                return true;
            }
            return false;
        }
    }
}
