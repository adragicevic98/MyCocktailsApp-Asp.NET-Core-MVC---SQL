using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using MyCocktails.Models;

namespace MyCocktails.Controllers
{
    public class CocktailsController : Controller
    {
        // GET
        public IActionResult Ingredients()
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
        public IActionResult Ingredient()
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
        public IActionResult Cocktail()
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