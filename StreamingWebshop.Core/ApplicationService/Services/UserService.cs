using System.Collections.Generic;
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

        //
        public User NewUser(string firstName, string lastName, string userName, byte[] passwordHash,
            byte[] passwordSalt, string email,
            string phoneNumber, string address, bool isAdmin)
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
                Address = address,
                IsAdmin = isAdmin
            };
            return user;
        }


    public User CreateUser(User user)
    {
        return _userRepository.CreateUser(user);
    }

        public User FindUserById(int id)
        {
            return _userRepository.FindUserById(id);
        }

        public List<User> GetAllUsers()
        {
            return _userRepository.GetAllUsers().ToList();
        }

        public User UpdateUser(User userUpdate)
        {
            return _userRepository.UpdateUser(userUpdate);
        }

        public User DeleteUser(int id)
        {
            return _userRepository.DeleteUser(id);
        }
    }
}