using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyCocktails.Models;
using Newtonsoft.Json.Linq;

namespace MyCocktails.DtoMappers
{
    public class UserDto
    {
        public static User FromJson(JObject json)
        {
            var id = json["id"].ToObject<int?>();
            var username = json["username"].ToObject<string>();
            var firstName = json["firstName"].ToObject<string>();
            var lastName = json["lastName"].ToObject<string>();
            var email = json["email"].ToObject<string>();
            var password = json["password"].ToObject<string>();

            return new User(id, username, password, firstName,lastName,email);
        }
    }
}
