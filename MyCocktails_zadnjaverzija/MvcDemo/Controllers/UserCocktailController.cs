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
    public class UserCocktailController : Controller
    {
        public IActionResult UserCocktail()
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