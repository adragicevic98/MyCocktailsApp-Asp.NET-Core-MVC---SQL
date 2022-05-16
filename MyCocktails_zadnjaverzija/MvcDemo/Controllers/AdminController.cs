using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using MyCocktails.Models;

namespace MyCocktails.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult adminHome()
        {
            if (HttpContext.Session.GetString("SessionAdmin") == null)
            {
                return RedirectToRoute(new
                {
                    controller = "Authentication",
                    action = "AdminSignIn"
                });
            }
            else
            {
                var userInfo = JsonConvert.DeserializeObject<UserInfo>(HttpContext.Session.GetString("SessionAdmin"));
                ViewBag.user = userInfo.Username;
                return View();
            }
        }
    }
}