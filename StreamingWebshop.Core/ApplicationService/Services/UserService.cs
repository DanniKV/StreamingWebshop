using System.Collections.Generic;
using System.IO;
using System.Linq;
using StreamingWebshop.Core.DomainService;
using StreamingWebshop.Core.Entity;

namespace StreamingWebshop.Core.ApplicationService.Services
{
    public class UserService : IUserService
    {
        //Dependency Injection.
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        
        public User NewUser(string firstName, string lastName, string userName, byte[] passwordHash,
            byte[] passwordSalt, string email,
            string phoneNumber, string address, string city, int zipcode, bool isAdmin)
        {
            var user = new User()
            {
                FirstName = firstName,
                LastName = lastName,
                UserName = userName,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                Email = email,
                PhoneNumber = phoneNumber,
                City = city,
                ZipCode = zipcode,
                Address = address,
                IsAdmin = isAdmin
            };
            return user;
        }

    /**
     * Checks for missing attributes and then returns the created user.
     */
    public User CreateUser(User user)
    {        if (user.FirstName == null)
            throw new InvalidDataException("Please add a First Name");
        if (user.LastName == null)
            throw new InvalidDataException("Please add a Last Name");
        if (user.UserName == null)
            throw new InvalidDataException("Please add a User Name");
        if (user.PasswordHash == null)
            throw new InvalidDataException("Something went terribly wrong!");
        if (user.PasswordSalt == null)
            throw new InvalidDataException("Something went terribly wrong!");
        if (user.Email == null)
            throw new InvalidDataException("Please add an Email");
        if (user.PhoneNumber == null)
            throw new InvalidDataException("Please add a Phone Number");
        if (user.Address == null)
            throw new InvalidDataException("Please add an Address");
        if (user.IsAdmin == null)
            throw new InvalidDataException("Something went terribly wrong!");

        return _userRepository.CreateUser(user);
    }
        /**
         * Finds and returns the user by id.
         */
        public User FindUserById(int id)
        {
            return _userRepository.FindUserById(id);
        }
        /**
         * Finds and returns all users after turning them into a list.
         */
        public List<User> GetAllUsers()
        {
            return _userRepository.GetAllUsers().ToList();
        }
        /**
         * Checks for missing attributes and then
         * returns the updated user. 
         */
        public User UpdateUser(User userUpdate)
        {
            if (userUpdate.FirstName == null)
                throw new InvalidDataException("Please add a First Name");
            if (userUpdate.LastName == null)
                throw new InvalidDataException("Please add a Last Name");
            if (userUpdate.UserName == null)
                throw new InvalidDataException("Please add a User Name");
            if (userUpdate.PasswordHash == null)
                throw new InvalidDataException("Something went terribly wrong!");
            if (userUpdate.PasswordSalt == null)
                throw new InvalidDataException("Something went terribly wrong!");
            if (userUpdate.Email == null)
                throw new InvalidDataException("Please add an Email");
            if (userUpdate.PhoneNumber == null)
                throw new InvalidDataException("Please add a Phone Number");
            if (userUpdate.Address == null)
                throw new InvalidDataException("Please add an Address");


            return _userRepository.UpdateUser(userUpdate);
        }
        /**
         * Finds the user with the given id and then returns the deleted user.
         */
        public User DeleteUser(int id)
        {
            return _userRepository.DeleteUser(id);
        }
    }
}