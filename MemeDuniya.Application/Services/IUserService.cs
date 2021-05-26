using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MemeDuniya.Repository.Entities;

namespace MemeDuniya.Application.Services
{
    public interface IUserService {
        Task<User> Authenticate(string username, string password);

        Task<IEnumerable<User>> GetAll();
    }
}