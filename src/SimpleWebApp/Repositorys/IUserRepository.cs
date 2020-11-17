using SimpleWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleWebApp.Repositorys
{
    public interface IUserRepository
    {
        bool CreateUser(User user);

        IEnumerable<User> GetUsers();

        User GetUserByID(int id);

        bool UpdateUser(User user);

        bool DeleteUserByID(int id);
    }
}
