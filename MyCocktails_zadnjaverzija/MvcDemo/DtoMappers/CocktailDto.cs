using Newtonsoft.Json.Linq;
using MyCocktails.Models;

namespace MyCocktails.DtoMappers
{
    public static class CocktailDto
    {
        public static Ingredients FromJson(JObject json)
        {
            var id = json["id"].ToObject<int>();
            var name = json["name"].ToObject<string>();
            var type = json["type"].ToObject<string>();
            var instructions = json["instructions"].ToObject<string>();
            var image= json["image"].ToObject<string>();
            var ingredient1 = json["ingredient1"].ToObject<string>();
            var ingredient2 = json["ingredient2"].ToObject<string>();
            var ingredient3 = json["ingredient3"].ToObject<string>();
            var ingredient4 = json["ingredient4"].ToObject<string>();
            var ingredient5 = json["ingredient5"].ToObject<string>();
            var ingredient6 = json["ingredient6"].ToObject<string>();
            var ingredient7 = json["ingredient7"].ToObject<string>();
            var ingredient8 = json["ingredient8"].ToObject<string>();
            var ingredient9 = json["ingredient9"].ToObject<string>();
            var ingredient10 = json["ingredient10"].ToObject<string>();
            var ingredient11 = json["ingredient11"].ToObject<string>();
            var ingredient12 = json["ingredient12"].ToObject<string>();
            var ingredient13 = json["ingredient13"].ToObject<string>();
            var ingredient14 = json["ingredient14"].ToObject<string>();
            var ingredient15 = json["ingredient15"].ToObject<string>();
            var measure1 = json["measure1"].ToObject<string>();
            var measure2 = json["measure2"].ToObject<string>();
            var measure3 = json["measure3"].ToObject<string>();
            var measure4 = json["measure4"].ToObject<string>();
            var measure5 = json["measure5"].ToObject<string>();
            var measure6 = json["measure6"].ToObject<string>();
            var measure7 = json["measure7"].ToObject<string>();
            var measure8 = json["measure8"].ToObject<string>();
            var measure9 = json["measure9"].ToObject<string>();
            var measure10 = json["measure10"].ToObject<string>();
            var measure11 = json["measure11"].ToObject<string>();
            var measure12 = json["measure12"].ToObject<string>();
            var measure13 = json["measure13"].ToObject<string>();
            var measure14 = json["measure14"].ToObject<string>();
            var measure15 = json["measure15"].ToObject<string>();



            return new Ingredients(id, name,type,instructions,image, ingredient1, ingredient2,ingredient3,ingredient4,ingredient5,ingredient6,ingredient7,ingredient8,ingredient9,ingredient10,ingredient11,ingredient12,ingredient13,ingredient14,ingredient15,
                measure1,measure2,measure3,measure4,measure5,measure6,measure7,measure8,measure9,measure10,measure11,measure12,measure13,measure14,measure15);
        }
        public static UserCocktail FromJson1(JObject json)
        {
            var id_user = json["id_user"].ToObject<int>();
            var id_cocktail = json["id_cocktail"].ToObject<int>();
            var comment = json["comment"].ToObject<string>();

            var user = new User(id_user, "", "", "", "", "");
            var cocktail = new Ingredients(id_cocktail, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "","", "", "", "", "", "", "", "", "", "", "", "", "", "","");

            return new UserCocktail(user, cocktail,comment);
        }
    }
}