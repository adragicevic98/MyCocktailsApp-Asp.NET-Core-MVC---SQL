using MyCocktails.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCocktails.Mappers
{
    public class UserMapper
    {
        public static User FromDatabase(DbModels.User user)
        {
            return new User(
                user.Id,
                user.Username,
                user.Password,
                user.FirstName,
                user.LastName,
                user.Email);
               

        }
        public static DbModels.User ToDatabase(User user)
        {
            return new DbModels.User
            {
                Id = user.Id.HasValue ? user.Id.Value : 0,
                Username = user.Username,
                Password = user.Password,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email

            };
        }

    }
}
