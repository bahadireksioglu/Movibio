using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Movibio.DataLayer.Concrete;
using Movibio.MVC.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movibio.MVC.Areas.Admin.ViewComponents
{
    public class ManagementPanelMenuViewComponent : ViewComponent
    {
        private readonly UserManager<User> _userManager;
        public ManagementPanelMenuViewComponent(UserManager<User> userManager)
        {
            _userManager = userManager;
        }
        public ViewViewComponentResult Invoke()
        {
            var user = _userManager.GetUserAsync(HttpContext.User).Result; //HttpContext.User KOMUTU LOGIN OLMUŞ KULLANICIYI GETİREBİLİYOR
            var roles = _userManager.GetRolesAsync(user).Result;
            return View(new UserWithRolesViewModel
            { User = user, Roles = roles });
        }
    }
}
