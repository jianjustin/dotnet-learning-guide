using SimpleWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleWebApp.Repositorys
{
    public class UserRepository : IUserRepository
    {
        public UserDbContext Context;

        public UserRepository(UserDbContext context)
        {
            Context = context;
        }

        public bool CreateUser(User user)
        {
            Context.Users.Add(user);
            return Context.SaveChanges() > 0;
        }

        public bool DeleteUserByID(int id)
        {
            var student = Context.Users.SingleOrDefault(s => s.id == id);
            Context.Users.Remove(student);
            return Context.SaveChanges() > 0;
        }

        public User GetUserByID(int id)
        {
            return Context.Users.SingleOrDefault(s => s.id == id);
        }

        public IEnumerable<User> GetUsers()
        {
            return Context.Users.ToList();
        }

        public bool UpdateUser(User user)
        {
            Context.Users.Update(user);
            return Context.SaveChanges() > 0;
        }
    }
}
