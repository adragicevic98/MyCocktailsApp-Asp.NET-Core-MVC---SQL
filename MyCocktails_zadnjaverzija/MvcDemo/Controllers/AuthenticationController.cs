using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using MyCocktails.DbModels;
using MyCocktails.Mappers;
using MyCocktails.Models;
using MyCocktails.Models.AuthModel;
using Microsoft.AspNetCore.Components;

namespace MyCocktails.Controllers
{
    public class AuthenticationController : Controller
    {
        private readonly COCKTAILSContext _dbContext;
        

        public AuthenticationController(COCKTAILSContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult SignIn()
        {

            return View();
        }

        [HttpPost]
        public IActionResult SignIn([FromForm] RegisterData register)
        {
            Console.WriteLine("username signIn: " + register.Username);
            var valid = Verify(register.Username, register.Password);
            if (valid != null)
            {
                return RedirectToRoute(new
                {
                    controller = "Home",
                    action = "Pocetna"
                });
            }
            else
            {
                return View();
            }
        }
        public IActionResult SignUp()
        {

            return View();
        }
        [HttpPost]
        public IActionResult SignUp(string username, string email,string firstName, string lastName, string password, string passwordConfirmation)
        {
            Console.WriteLine("username signIn: " + username);
            var valid = VerifySignUp(username, password,firstName,lastName, passwordConfirmation, email);
            if (valid != null)
            {
                return RedirectToRoute(new
                {
                    controller = "Home",
                    action = "Pocetna"
                });
            }
            else
            {
                return View();
            }

        }
        public IActionResult AdminSignIn()
        {

            return View();
        }
        [HttpPost]

        public IActionResult AdminSignIn([FromForm] RegisterData register)
        {

            var valid = VerifyAdmin(register.Username, register.Password);
            if (valid != null)
            {
                return RedirectToRoute(new
                {
                    controller = "Admin",
                    action = "adminHome"
                });
            }
            else
            {
                return View();

            }
        }
        [HttpPost]
        public IActionResult Register(RegisterData registerData)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // redirektanje na pocetnu da refreshamo User.Identity
            return RedirectToRoute("/");

        }
        public DbModels.User Verify(string username, string password)
        {
            var result = _dbContext.User.Where(x => (x.Username.Equals(username) && x.Password.Equals(password))).FirstOrDefault();
            if (result == null)
            {
                return null;
            }
            else
            {
                Console.WriteLine("Id usera: " + result.Id);
                Console.WriteLine(result);
                var userInfo = new UserInfo() { Username = result.Username, UserId = result.Id };
                HttpContext.Session.SetString("SessionUser", JsonConvert.SerializeObject(userInfo));
                HttpContext.Session.SetString("uloga", "user");
        
                return result;
            }

        }
        public DbModels.User VerifySignUp(string username, string password,string firstName,string lastName, string passwordConfirm, string email)
        {
            Console.WriteLine("Username: " + username + " password: " + password +"firstname: "+firstName+"lastname:"+lastName+ "confirmpassword: " + passwordConfirm + " email: " + email);
            if (username == null || password == null || firstName== null|| lastName==null || passwordConfirm == null || email == null || password != passwordConfirm)
            {
                return null;
            }
            else
            {
                var result = _dbContext.User.Where(x => x.Username.Equals(username)).FirstOrDefault();
                if (result == null)
                {
                    Models.User user = new Models.User(null, username,  password,firstName,lastName,email);
                    var dbUser = UserMapper.ToDatabase(user);
                    _dbContext.User.Add(dbUser);
                    _dbContext.SaveChanges();
                    var result2 = _dbContext.User.Where(x => x.Username.Equals(username)).FirstOrDefault();
                    var userInfo = new UserInfo() { Username = result2.Username, UserId = result2.Id };
                    HttpContext.Session.SetString("SessionUser", JsonConvert.SerializeObject(userInfo));
                    HttpContext.Session.SetString("uloga", "user");
                    return result2;
                }
                else
                {
                    Console.WriteLine("User exists!");
                    return null;
                }
            }

        }
        public DbModels.User VerifyAdmin(string username, string password)
        {
            var result = _dbContext.User.Where(x => (x.Username.Equals("adragice1") && x.Username.Equals(username) && x.Password.Equals(password))).FirstOrDefault();
            if (result == null)
            {
                return null;
            }
            else
            {
                var userInfo = new UserInfo() { Username = result.Username, UserId = result.Id };
                HttpContext.Session.SetString("SessionAdmin", JsonConvert.SerializeObject(userInfo));
                HttpContext.Session.SetString("uloga", "admin");
                return result;
            }

        }
    }
}