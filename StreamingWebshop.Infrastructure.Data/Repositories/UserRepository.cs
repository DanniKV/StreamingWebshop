using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using StreamingWebshop.Core.ApplicationService;
using StreamingWebshop.Core.DomainService;
using StreamingWebshop.Core.Entity;

namespace StreamingWebshop.Infrastructure.Data.Repositories
{
    public class UserRepository: IUserRepository
    {
        private readonly Context _ctx;

        public UserRepository(Context ctx)
        {
            _ctx = ctx;
        }
        //Creates a user with the given user info.
        public User CreateUser(User user)
        {
            if (_ctx.Users.FirstOrDefault(u => u.UserName == user.UserName) == null)
            {
                var usr = _ctx.Users.Add(user).Entity;
                _ctx.SaveChanges();
                return usr;
            } else
            {
                throw new System.Exception();
            }
            
            
        }
        //Finds the user with the given Id
        public User FindUserById(int id)
        {
            return _ctx.Users.FirstOrDefault(u => u.Id == id);
        }
        //Gets all the users.
        public IEnumerable<User> GetAllUsers()
        {
            return _ctx.Users;
        }
        /**
         * Updates the user with the updated user information.
         */
        public User UpdateUser(User userUpdate)
        {
            _ctx.Attach(userUpdate).State = EntityState.Modified;
            _ctx.SaveChanges();
            return userUpdate;
        }
        /**
         * Deletes the user with the given Id.
         */
        public User DeleteUser(int id)
        {
            var userRemoved = _ctx.Remove(new User {Id = id}).Entity;
            _ctx.SaveChanges();
            return userRemoved;
        }
    }
}