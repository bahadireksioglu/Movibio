using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Movibio.DataLayer.Concrete;
using Movibio.DataLayer.Dtos.CastDtos;
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
    public class CastController : Controller
    {
        private readonly ICastService _castService;
        private readonly IMapper _mapper;
        private readonly IWebHostEnvironment _env;
        public CastController(ICastService castService, 
            IMapper mapper, IWebHostEnvironment env)
        {
            _castService = castService;
            _mapper = mapper;
            _env = env;
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
            castInsertDto.PicturePath = await ImageExtensions.ImageUpload(
                castInsertDto.FirstName + castInsertDto.LastName,
                "casts", castInsertDto.Picture, _env);

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
                castUpdateDto.PicturePath = await ImageExtensions.ImageUpload(
                    castUpdateDto.FirstName + castUpdateDto.LastName,
                    "casts", castUpdateDto.Picture, _env);
                isNewPicUploaded = true;
            }
            castUpdateDto.ModifiedByUserName = "admin";

            var updatedCast = await _castService.Update(castUpdateDto);

            if (updatedCast.ResultStatus == ResultStatus.Success)
            {
                if (isNewPicUploaded)
                    ImageExtensions.ImageDelete(oldUserPic, "casts", _env);
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
                ImageExtensions.ImageDelete(deletedCast.Data.PicturePath, "casts", _env);
                return Json(0);
            }
            return Json(1);
        }        
    }
}
