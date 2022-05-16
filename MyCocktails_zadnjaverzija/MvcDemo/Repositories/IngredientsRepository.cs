using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MyCocktails.DbModels;
using MyCocktails.Mappers;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace MyCocktails.Repositories
{
    public class IngredientsRepository
    {
       private readonly COCKTAILSContext _dbContext;

        public IngredientsRepository(COCKTAILSContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Models.Ingredients> GetAll()
        {
            return _dbContext.Cocktail

                .Select(x => IngredientsMapper.FromDatabase(x));

        }
        public void Save(Models.Ingredients cocktail)
        {
            var dbCocktail = IngredientsMapper.ToDatabase(cocktail);
            _dbContext.Cocktail.Add(dbCocktail);
            _dbContext.SaveChanges();
        }
       
    }
}
