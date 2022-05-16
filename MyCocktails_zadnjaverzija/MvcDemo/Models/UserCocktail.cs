using MyCocktails.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCocktails.Models
{
    public class UserCocktail
    {
        public User IdUser { get; set; }
        public Ingredients IdCocktail { get; set; }
        public string Comment { get; set; }

        public UserCocktail(User idU,Ingredients idC, string com)
        {
            IdUser = idU;
            IdCocktail = idC;
            Comment = com;
        }
    }
    
}
