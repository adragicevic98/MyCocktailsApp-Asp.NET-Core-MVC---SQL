using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using MyCocktails.DtoMappers;
using MyCocktails.Models;
using MyCocktails.Services;

namespace MyCocktails.Controllers
{
    [Route("api/admin")]
    [ApiController]
    public class AdminApiController : ControllerBase
    {
        private AdminService _adminService;
        public AdminApiController(AdminService adminService)
        {
            _adminService = adminService;
        }
        [HttpGet("allusers")]
        public ActionResult<List<User>> Get()
        {
            return _adminService.GetAll().ToList();
        }
        [HttpGet("user/{id}")]
        public async Task<ActionResult<User>> Getuser(int id)
        {
            return await _adminService.Getuser(id);
        }
        [HttpPut("useredit")]
        public void UserEdit([FromBody] JObject json)
        {
            var user = UserDto.FromJson(json);
            _adminService.UserEdit(user);
        }
        [HttpDelete("delete/{id}")]
        public void Delete(int id)
        {
            _adminService.DeleteUser(id);
        }
        //[HttpPost("adduser")]
        //public ActionResult Save([FromBody] JObject json)
        //{
        //    var user = UserDto.FromJson(json);
        //    _adminService.Save(user);
        //    return Ok();
        //}

    }
}