using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using MyCocktails.Models;

namespace MyCocktails.Controllers
{
    public class GlassesController : Controller
    {
        public IActionResult Glasses()
        {
            if (HttpContext.Session.GetString("SessionUser") == null)
            {
                return RedirectToRoute(new
                {
                    controller = "Authentication",
                    action = "SignIn"
                });
            }
            else
            {
                var userInfo = JsonConvert.DeserializeObject<UserInfo>(HttpContext.Session.GetString("SessionUser"));
                return View();
            }
        }
        public IActionResult Glass()
        {
            if (HttpContext.Session.GetString("SessionUser") == null)
            {
                return RedirectToRoute(new
                {
                    controller = "Authentication",
                    action = "SignIn"
                });
            }
            else
            {
                var userInfo = JsonConvert.DeserializeObject<UserInfo>(HttpContext.Session.GetString("SessionUser"));
                return View();
            }
        }
    }
}