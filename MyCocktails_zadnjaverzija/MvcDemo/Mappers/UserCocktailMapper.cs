using MyCocktails.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyCocktails.Repositories;

namespace MyCocktails.Mappers
{
    public class UserCocktailMapper
    {
       
        public static UserCocktail FromDatabase1(DbModels.UserCocktail usercocktail)
        {

            return new UserCocktail(
      

                UserMapper.FromDatabase(usercocktail.IdUserNavigation),
                IngredientsMapper.FromDatabase(usercocktail.IdCocktailNavigation),
                usercocktail.Comment);
             
                 
        }
        
        public static DbModels.UserCocktail ToDatabase1(UserCocktail usercocktail)
        {
            return new DbModels.UserCocktail
            {
                IdUser = usercocktail.IdUser.Id.HasValue ? usercocktail.IdUser.Id.Value : 0,
                IdCocktail = usercocktail.IdCocktail.Id,
          
                Comment = usercocktail.Comment
            };
        }
    }
}
