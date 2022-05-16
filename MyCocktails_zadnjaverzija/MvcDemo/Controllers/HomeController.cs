using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyCocktails.Models;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace MyCocktails.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", new { controller = "Home" });
        }

        public IActionResult Categories()
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
        public IActionResult Category()
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

        public IActionResult MyCocktails()
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
                ViewBag.user = userInfo.Username;
                return View();
            }
        }
        public IActionResult CocktailForm()
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
                ViewBag.user = userInfo.Username;
                return View();
            }
        }

        public IActionResult Pocetna()
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
                ViewBag.user = userInfo.Username;
                return View();
            }
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}