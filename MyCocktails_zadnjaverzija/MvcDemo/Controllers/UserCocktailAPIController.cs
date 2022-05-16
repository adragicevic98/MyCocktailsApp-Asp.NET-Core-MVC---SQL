using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using MyCocktails.Models;
using MyCocktails.DtoMappers;
using MyCocktails.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MyCocktails.Controllers
{
    [Route("api/usercocktail")]
    [ApiController]
    public class UserCocktailAPIController : Controller
    {
        private UserCocktailService _userCocktailService;


        public UserCocktailAPIController(UserCocktailService UCService)
        {
            _userCocktailService = UCService;

        }



        [HttpGet]
        public ActionResult<List<UserCocktail>> Get()
        {
        
        
            var userInfo = JsonConvert.DeserializeObject<UserInfo>(HttpContext.Session.GetString("SessionUser"));
            var userId = userInfo.UserId;
         
            return _userCocktailService.GetAll(userId).ToList();
      
        }

        [HttpGet("{idCocktail}")] 
        public ActionResult<UserCocktail> GetOne(int idCocktail)
        {
                var userInfo = JsonConvert.DeserializeObject<UserInfo>(HttpContext.Session.GetString("SessionUser"));
                var userId = userInfo.UserId;
             return  _userCocktailService.GetOne(userId, idCocktail);
            

 
        }

        [HttpDelete("delete/{idCocktail}")]
       
        public void Delete(int idCocktail)
        {
            var userInfo = JsonConvert.DeserializeObject<UserInfo>(HttpContext.Session.GetString("SessionUser"));
            var userId = userInfo.UserId;
            _userCocktailService.Delete(userId, idCocktail);
            
        }


      

        [HttpPost("savecourse11")]
        public ActionResult Save([FromBody] JObject json)
        {
            var usercocktail = CocktailDto.FromJson1(json);
            var userInfo = JsonConvert.DeserializeObject<UserInfo>(HttpContext.Session.GetString("SessionUser"));
            var userId = userInfo.UserId;
            //tamo smo poslali nulu zbog nemogucnosti dohvacanja id user-a u view-u i ode postavljamo pravu vrijednost
            usercocktail.IdUser.Id = userId;
            _userCocktailService.Save(usercocktail);
            return Ok();
        }
        [HttpPut("cocktailedit")]
        public void Edit([FromBody] JObject json)
        {
            var userInfo = JsonConvert.DeserializeObject<UserInfo>(HttpContext.Session.GetString("SessionUser"));
            var cocktailCh = JObject.Parse(json.ToString());
            cocktailCh["id_user"] = userInfo.UserId;
            var usCocktail = CocktailDto.FromJson1(cocktailCh);

            _userCocktailService.Edit(usCocktail);
        }


    }
}