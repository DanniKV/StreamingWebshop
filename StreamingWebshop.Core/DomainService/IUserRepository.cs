using System.Collections.Generic;
using StreamingWebshop.Core.Entity;

namespace StreamingWebshop.Core.DomainService
{
    public interface IUserRepository
    {
        //Create
        User CreateUser(User user);
        //Read
        User FindUserById(int id);
        IEnumerable<User> GetAllUsers();
        //Update
        User UpdateUser(User userUpdate);
        //Delete
        User DeleteUser(int id);
    }
}
