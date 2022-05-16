using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCocktails.Models
{
    public class User
    {
        public int? Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public User(int? id,string us,string pas,string fn, string ln,string em)
        {
            Id = id;
            Username = us;
            Password = pas;
            FirstName = fn;
            LastName = ln;
            Email = em;
           
        }
    }

}
