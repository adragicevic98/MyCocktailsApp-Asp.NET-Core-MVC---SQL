using MyCocktails.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCocktails.Mappers
{
    public class IngredientsMapper
    {

        public static Ingredients FromDatabase(DbModels.Cocktail cocktail)
        {
            return new Ingredients(
               cocktail.Id,
               cocktail.Name,
               cocktail.Type,
               cocktail.Instructions,
               cocktail.Image,
               cocktail.Ingredient1,
               cocktail.Ingredient2,
               cocktail.Ingredient3,
               cocktail.Ingredient4,
               cocktail.Ingredient5,
               cocktail.Ingredient6,
               cocktail.Ingredient7,
               cocktail.Ingredient8,
               cocktail.Ingredient9,
               cocktail.Ingredient10,
               cocktail.Ingredient11,
               cocktail.Ingredient12,
               cocktail.Ingredient13,
               cocktail.Ingredient14,
               cocktail.Ingredient15,
               cocktail.Measure1,
               cocktail.Measure2,
               cocktail.Measure3,
               cocktail.Measure4,
               cocktail.Measure5,
               cocktail.Measure6,
               cocktail.Measure7,
               cocktail.Measure8,
               cocktail.Measure9,
               cocktail.Measure10,
               cocktail.Measure11,
               cocktail.Measure12,
               cocktail.Measure13,
               cocktail.Measure14,
               cocktail.Measure15);



            


        }
        public static DbModels.Cocktail ToDatabase(Ingredients course)
        {
            return new DbModels.Cocktail
            {
                Id = course.Id,
                Name = course.Name,
                Type = course.Type,
                Instructions = course.Instructions,
                Image = course.Image,
                Ingredient1=course.Ingredient1,
                Ingredient2=course.Ingredient2,
                Ingredient3=course.Ingredient3,
                Ingredient4=course.Ingredient4,
                Ingredient5=course.Ingredient5,
                Ingredient6=course.Ingredient6,
                Ingredient7=course.Ingredient7,
                Ingredient8=course.Ingredient8,
                Ingredient9=course.Ingredient9,
                Ingredient10=course.Ingredient10,
                Ingredient11=course.Ingredient11,
                Ingredient12=course.Ingredient12,
                Ingredient13=course.Ingredient13,
                Ingredient14=course.Ingredient14,
                Ingredient15=course.Ingredient15,
                Measure1=course.Measure1,
                Measure2=course.Measure2,
                Measure3=course.Measure3,
                Measure4=course.Measure4,
                Measure5=course.Measure5,
                Measure6=course.Measure6,
                Measure7=course.Measure7,
                Measure8=course.Measure8,
                Measure9=course.Measure9,
                Measure10=course.Measure10,
                Measure11=course.Measure11,
                Measure12=course.Measure12,
                Measure13=course.Measure13,
                Measure14=course.Measure14,
                Measure15=course.Measure15

            };
        }
        
       
        }
}
