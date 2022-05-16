using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyCocktails.Models;
using MyCocktails.Repositories;

namespace MyCocktails.Services
{
    public class AdminService
    {

        public AdminRepository _adminRepository;

        public AdminService(AdminRepository adminRepository)
        {
            _adminRepository = adminRepository;
        }
        public IEnumerable<User> GetAll()
        {
            return _adminRepository.GetAll();
        }
        public async Task<User> Getuser(int id)
        {
            return await _adminRepository.Getuser(id);
        }

        public void UserEdit(User user)
        {
            _adminRepository.UserEdit(user);
        }

        public void DeleteUser(int id)
        {
            _adminRepository.DeleteUser(id);
        }
        public void Save(User user)
        {
            _adminRepository.Save(user);
        }
    }
}
