using Microsoft.AspNetCore.Mvc;
using MyCocktails.Models;
using MyCocktails.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCocktails.Services
{
    public class IngredientsService
    {
        public IngredientsRepository _ingredientsRepository;

        public IngredientsService(IngredientsRepository ingredientsRepository)
        {
            _ingredientsRepository = ingredientsRepository;
        }
        public IEnumerable<Ingredients> GetAll()
        {
            return _ingredientsRepository.GetAll();
        }
   
        public void Save(Ingredients cocktail)
        {
            _ingredientsRepository.Save(cocktail);
        }
        
    }
}
