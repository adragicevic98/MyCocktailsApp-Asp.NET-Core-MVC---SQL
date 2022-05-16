using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using MyCocktails.Models;
using MyCocktails.DtoMappers;
using MyCocktails.Services;
using System.Linq;

namespace MyCocktails.Controllers
{
    [Route("api/ingredients")]
    [ApiController]
    public class CocktailsApiController : Controller
    {
        private IngredientsService _ingredientsService;

        public CocktailsApiController(IngredientsService ingService)
        {
            _ingredientsService = ingService;
        }



        [HttpGet]
        public ActionResult<List<Ingredients>> Get()
        {

            return _ingredientsService.GetAll().ToList();

        }

        [HttpGet("{id}")] 
        public ActionResult<Ingredients> Get(int id)
        {

            return Ok();
        }

        [HttpPost("savecourse")]

        public ActionResult Save([FromBody] JObject json)
        {
            var cocktail = CocktailDto.FromJson(json);
            _ingredientsService.Save(cocktail);
            return Ok();
        }


    }
}