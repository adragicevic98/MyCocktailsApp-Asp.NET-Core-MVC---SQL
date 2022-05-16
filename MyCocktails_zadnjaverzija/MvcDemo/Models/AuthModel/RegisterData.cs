using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MyCocktails.Models.AuthModel
{
    public class LoginModel
    {
        [Required] public string Username { get; set; }

        [Required] public string Password { get; set; }
    }
    public class RegisterData:LoginModel
    {
        [Required] public string FirstName { get; set; }
        [Required] public string LastName { get; set; }
        [Required] [EmailAddress] public string Email { get; set; }
        
        [Required]
        [Compare("Password")]
        public string PasswordConfirmation { get; set; }
    }
}
