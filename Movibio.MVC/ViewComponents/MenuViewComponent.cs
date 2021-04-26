using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Movibio.DataLayer.Concrete;
using Movibio.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movibio.MVC.ViewComponents
{
    public class MenuViewComponent : ViewComponent
    {
        private readonly UserManager<User> _userManager;
        public MenuViewComponent(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        public ViewViewComponentResult Invoke()
        {
            var user = _userManager.GetUserAsync(HttpContext.User).Result; //HttpContext.User KOMUTU LOGIN OLMUŞ KULLANICIYI GETİREBİLİYOR
            if (user != null)
            {
                var roles = _userManager.GetRolesAsync(user).Result;
                return View(new UserWithRolesViewModel
                { User = user, Roles = roles });

            }
            return View(new UserWithRolesViewModel { User=null, Roles=null});
        }
    }
}
