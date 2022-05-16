using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using MyCocktails.DbModels;
using MyCocktails.Mappers;

namespace MyCocktails.Repositories
{
    public class AdminRepository
    {
        private readonly COCKTAILSContext _dbContext;

        public AdminRepository(COCKTAILSContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IEnumerable<Models.User> GetAll()
        {

            return _dbContext.User.Select(x => UserMapper.FromDatabase(x));

        }
        public async Task<Models.User> Getuser(int id)
        {
            var result = await _dbContext.User.SingleOrDefaultAsync(x => x.Id == id);
            return UserMapper.FromDatabase(result);
        }

        public void UserEdit(Models.User user)
        {
          
                var dbUser = UserMapper.ToDatabase(user);
                _dbContext.User.Update(dbUser);
                _dbContext.SaveChanges();
            
            
        }

        public void DeleteUser(int id)
        {
            Console.WriteLine("Repository is deleting user and his cocktails...");
            while (_dbContext.UserCocktail.Where(x => x.IdUser.Equals(id)).FirstOrDefault() != null)
            {
                var usr_cocktail = _dbContext.UserCocktail.Where(x => x.IdUser.Equals(id)).FirstOrDefault();
                _dbContext.UserCocktail.Remove(usr_cocktail);
                _dbContext.SaveChanges();
            }
            var user = _dbContext.User.Where(x => x.Id == id).FirstOrDefault();
            _dbContext.User.Remove(user);
            _dbContext.SaveChanges();
        }
        public void Save(Models.User user)
        {
            var dbUser = UserMapper.ToDatabase(user);
            _dbContext.User.Add(dbUser);
            _dbContext.SaveChanges();
        }


    }
}
