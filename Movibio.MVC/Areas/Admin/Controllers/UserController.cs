using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Movibio.DataLayer.Concrete;
using Movibio.SharedLayer.Utilities.Results.ComplexTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movibio.MVC.Areas.Admin.Controllers
{
    public class UserController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IWebHostEnvironment _env;
        private readonly IMapper _mapper;
        public UserController(UserManager<User> userManager,
            IWebHostEnvironment env, 
            IMapper mapper, 
            SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _env = env;
            _mapper = mapper;
        }

        //[Authorize(Roles = "Admin")]
        //public async Task<IActionResult> Index()
        //{
        //    var users = await _userManager.Users.ToListAsync();
        //    return View(new UserListDto
        //    {
        //        Users = users,
        //        ResultStatus = ResultStatus.Success
        //    });
        //}

        [HttpGet]
        public IActionResult Login()
        {
            return View("UserLogin");
        }

        [HttpPost]
        //public async Task<IActionResult> Login(UserLoginDto userLoginDto)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var user = await _userManager.FindByEmailAsync(userLoginDto.Email);
        //        if (user != null)
        //        {
        //            var result = await _signInManager.PasswordSignInAsync(
        //                user, userLoginDto.Password, userLoginDto.RememberMe, false);
        //            if (result.Succeeded)
        //            {

        //                return RedirectToAction("Index", "Home");
        //            }
        //            else
        //            {
        //                ModelState.AddModelError("", "E-Posta adresiniz veya şifreniz yanlıştır.");
        //                return View("UserLogin");
        //            }

        //        }
        //        else
        //        {
        //            ModelState.AddModelError("", "E-Posta adresiniz veya şifreniz yanlıştır.");
        //            return View("UserLogin");
        //        }
        //    }
        //    else
        //    {
        //        return View("UserLogin");
        //    }

        //}

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home", new { Area = "" });
        }
    }
}
