using System;
using System.Collections.Generic;

namespace MyCocktails.DbModels
{
    public partial class UserCocktail
    {
        public int IdUser { get; set; }
        public int IdCocktail { get; set; }
        public string Comment { get; set; }

        public virtual Cocktail IdCocktailNavigation { get; set; }
        public virtual User IdUserNavigation { get; set; }
    }
}
