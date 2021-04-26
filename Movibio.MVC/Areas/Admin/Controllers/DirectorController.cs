using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Movibio.DataLayer.Dtos.DirectorDtos;
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
    public class DirectorController : Controller
    {
        private readonly IDirectorService _directorService;
        private readonly IMapper _mapper;
        private readonly IWebHostEnvironment _env;
        public DirectorController(IDirectorService directorService,
            IMapper mapper, IWebHostEnvironment env)
        {
            _directorService = directorService;
            _mapper = mapper;
            _env = env;
        }
        public async Task<IActionResult> Index()
        {
            var directors = await _directorService.GetAll();
            if (directors.ResultStatus == ResultStatus.Success)
                return View(directors.Data);
            return View(null);
        }

        [HttpGet]
        public IActionResult Insert()
        {
            return PartialView("_DirectorInsertPartial");
        }

        [HttpPost]
        public async Task<IActionResult> Insert(DirectorInsertDto directorInsertDto)
        {

            directorInsertDto.CreatedByUserName = "admin";
            directorInsertDto.ModifiedByUserName = "admin";
            directorInsertDto.PicturePath = await ImageExtensions.ImageUpload(
                directorInsertDto.FirstName + directorInsertDto.LastName,
                "directors", directorInsertDto.Picture, _env);

            var insertedDirector = await _directorService.Insert(directorInsertDto);
            if (insertedDirector.ResultStatus == ResultStatus.Success)
                return Json(0);
            return Json(1);
        }

        [HttpGet]
        public async Task<IActionResult> Update(int directorId)
        {
            var director = await _directorService.Get(directorId);
            if (director.ResultStatus == ResultStatus.Success)
                return PartialView("_DirectorEditPartial",
                    _mapper.Map<DirectorUpdateDto>(director.Data));
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Update(DirectorUpdateDto directorUpdateDto)
        {

            bool isNewPicUploaded = false;
            var oldUserPic = directorUpdateDto.PicturePath;

            if (directorUpdateDto.Picture != null)
            {
                directorUpdateDto.PicturePath = await ImageExtensions.ImageUpload(
                    directorUpdateDto.FirstName + directorUpdateDto.LastName,
                    "directors", directorUpdateDto.Picture, _env);
                isNewPicUploaded = true;
            }
            directorUpdateDto.ModifiedByUserName = "admin";

            var updatedDirectors = await _directorService.Update(directorUpdateDto);

            if (updatedDirectors.ResultStatus == ResultStatus.Success)
            {
                if (isNewPicUploaded)
                    ImageExtensions.ImageDelete(oldUserPic, "directors", _env);
                return Json(0);
            }

            return Json(1);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int directorId)
        {
            var deletedDirector = await _directorService.Delete(directorId);
            if (deletedDirector != null)
            {
                ImageExtensions.ImageDelete(deletedDirector.Data.PicturePath, "directors", _env);
                return Json(0);
            }
            return Json(1);
        }
    }
}
