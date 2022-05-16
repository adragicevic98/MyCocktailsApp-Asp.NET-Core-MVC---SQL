using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyCocktails.DbModels;
using MyCocktails.Mappers;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;


namespace MyCocktails.Repositories
{
    public class UserCocktailRepository
    {
        private readonly COCKTAILSContext _dbContext;

        public UserCocktailRepository(COCKTAILSContext dbContext)
        {
            _dbContext = dbContext;
        }
    
        public IEnumerable<Models.UserCocktail> GetAll(int user)
        {


            return _dbContext.UserCocktail
         .Include(c => c.IdUserNavigation)
         .Include(c => c.IdCocktailNavigation)
         .Where(c => c.IdUser.Equals(user)).Select(c => UserCocktailMapper.FromDatabase1(c));
         
        }
        public void Save(Models.UserCocktail usercocktail)
        {
           
            var dbUserCocktail = UserCocktailMapper.ToDatabase1(usercocktail);
            _dbContext.UserCocktail.Add(dbUserCocktail);
            _dbContext.SaveChanges();
        }
        public void Delete(int id,int id1)
        {
            Console.WriteLine("u brisanju");
            var result = _dbContext.UserCocktail.Where(x => x.IdUser.Equals(id) && x.IdCocktail.Equals(id1)).FirstOrDefault();
 
            _dbContext.UserCocktail.Remove(result);
            _dbContext.SaveChanges();
        }
        public Models.UserCocktail GetOne(int user,int cocktail)
        {

            var rez = _dbContext.UserCocktail
          .Include(c => c.IdUserNavigation)
          .Include(c => c.IdCocktailNavigation)
          .SingleOrDefault(c => c.IdUser.Equals(user) && c.IdCocktail == cocktail);
            return ( UserCocktailMapper.FromDatabase1(rez));
     

        }
       
        public void Edit(Models.UserCocktail usCocktail)
        {
            var dbUsCocktail = UserCocktailMapper.ToDatabase1(usCocktail);
            _dbContext.UserCocktail.Update(dbUsCocktail);
            _dbContext.SaveChanges();
        }
    }
}
