using MyCocktails.Models;
using System;
using System.Collections.Generic;
using MyCocktails.Repositories;
using System.Linq;
using System.Threading.Tasks;

namespace MyCocktails.Services
{
    public class UserCocktailService
    {
        public UserCocktailRepository _userCocktailRepository;

        public UserCocktailService(UserCocktailRepository UCRepository)
        {
            _userCocktailRepository = UCRepository;
        }
        public IEnumerable<UserCocktail> GetAll(int user)
        {
            Console.WriteLine(user);
            return _userCocktailRepository.GetAll(user);
        }
        public void Save(UserCocktail usercocktail)
        {
            _userCocktailRepository.Save(usercocktail);
        }

        public void Delete(int id, int id1)
        {
            _userCocktailRepository.Delete(id,id1);
        }


        public UserCocktail GetOne(int id, int id1)
        {
            return _userCocktailRepository.GetOne(id, id1);

        }
        public void Edit (UserCocktail usCocktail)
        {
            _userCocktailRepository.Edit(usCocktail);
        }

    }
}
