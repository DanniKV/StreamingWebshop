using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using StreamingWebshop.Core.Entity;

namespace StreamingWebshop.Core.ApplicationService.Services
{
    public interface IUserService
    {
        //New User
        User NewUser(string firstName,
            string lastName,
            string userName,
            byte[] passwordHash,
            byte[] passwordSalt,
            string email,
            string phoneNumber,
            string address,
            Boolean isAdmin
        );
        
        //Create/Post
        User CreateUser(User user);
        
        //Read/Get
        User FindUserById(int id);
        List<User> GetAllUsers();
        
        //Update/Put
        User UpdateUser(User userUpdate);
        
        //Delete
        User DeleteUser(int id);

    }
}