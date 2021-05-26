using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MemeDuniya.Repository.Entities;

namespace MemeDuniya.Application.Services
{
    public class UserService : IUserService
    {
        private IEnumerable<User> _users = new List<User>
        {
            new User{Id=1,FirstName="John", LastName="Doe", UserName="user001", Password="password"},
            new User{Id=2,FirstName="Mary", LastName="Poe", UserName="user002", Password="password"},
            new User{Id=1,FirstName="Pelican", LastName="Steve", UserName="user003", Password="password"},
        };

        public async Task<User> Authenticate(string username, string password)
        {
            var user = await Task.Run(() => _users.SingleOrDefault(x => username == x.UserName && password == x.Password));
            return user;
        }

        public Task<IEnumerable<User>> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}