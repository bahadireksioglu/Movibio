using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Movibio.DataLayer.Concrete;
using Movibio.DataLayer.Dtos.UserDtos;
using Movibio.MVC.Models;
using Movibio.SharedLayer.Utilities.Results.ComplexTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movibio.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UserController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly RoleManager<Role> _roleManager;
        private readonly IWebHostEnvironment _env;
        private readonly IMapper _mapper;
        public UserController(UserManager<User> userManager,
            IWebHostEnvironment env, 
            IMapper mapper, 
            SignInManager<User> signInManager,
            RoleManager<Role> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _env = env;
            _mapper = mapper;
            _roleManager = roleManager;
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
        public async Task<IActionResult> Login(UserLoginDto userLoginDto)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByNameAsync(userLoginDto.UserName);
                if (user != null)
                {
                    var result = await _signInManager.PasswordSignInAsync(
                        user, userLoginDto.Password, false, false);
                    if (result.Succeeded)
                    {

                        return RedirectToAction("Index", "Home", new { Area = "" });
                    }
                    else
                    {
                        ModelState.AddModelError("", "E-Posta adresiniz veya şifreniz yanlıştır.");
                        return View("UserLogin");
                    }

                }
                else
                {
                    ModelState.AddModelError("", "E-Posta adresiniz veya şifreniz yanlıştır.");
                    return View("UserLogin");
                }
            }
            else
            {
                return View("UserLogin");
            }

        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home", new { Area = "" });
        }
       
        [HttpGet]
        public IActionResult Insert()
        {
            
            return View("UserRegister");
        }

        [HttpPost]
        public async Task<IActionResult> Insert(UserInsertViewModel userInsertViewModel)
        {
            var user = new User();
            user.UserName = userInsertViewModel.UserName;
            user.PhoneNumber = userInsertViewModel.PhoneNumber;
            user.Email = userInsertViewModel.Email;
            user.NormalizedEmail = userInsertViewModel.Email.ToUpper();
            user.EmailConfirmed = true;
            user.PhoneNumberConfirmed = true;
            user.SecurityStamp = Guid.NewGuid().ToString();
            var result = await _userManager.CreateAsync(user, userInsertViewModel.Password);
            if (result.Succeeded)
            {
                var role = await _roleManager.FindByIdAsync("3");
                var result2 = await _userManager.AddToRoleAsync(user, role.Name);
                if (result2.Succeeded)
                {
                    return RedirectToAction("Login", "User", new { Area = "Admin" });
                }

            }

            return RedirectToAction("Index", "Home", new { Area = "" });
        }

        [HttpGet]
        public ViewResult AccessDenied()
        {
            return View();
        }
    }
}
