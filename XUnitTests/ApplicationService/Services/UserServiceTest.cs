using System;
using System.IO;
using Moq;
using StreamingWebshop.Core.ApplicationService;
using StreamingWebshop.Core.ApplicationService.Services;
using StreamingWebshop.Core.DomainService;
using StreamingWebshop.Core.Entity;
using Xunit;

namespace xUnitTests.ApplicationService.Services
{
    public class UserServiceTest
    {
        

        public void Dispose()
        {
            //Dispose Stuff we dont need anymore
        }
        
        
        [Fact]
        public void CreateUserWithoutFirstName()
        {
            const string someScenario = 
                "R0lGODlhAQABAIAAAAAAAAAAACH5BAAAAAAALAAAAAABAAEAAAICTAEAOw==";

            byte[] bytes = Convert.FromBase64String(someScenario);
            
            var userRepo = new Mock<IUserRepository>();
            IUserService service = 
                new UserService(userRepo.Object);
            var user = new User()
            
            {
                Id = 1,
              //  FirstName = "Timothy",
                LastName = "Theory",
                UserName = "TheoTim",
                PasswordHash = bytes,
                PasswordSalt = bytes,
                Email = "TimsEmail",
                PhoneNumber = "282828",
                Address = "TimAllé",
                IsAdmin = false
            };
            Exception ex = Assert.Throws<InvalidDataException>(() =>
                service.CreateUser(user));
            
            Assert.Equal("Please add a First Name", ex.Message);
        }
        [Fact]
        public void CreateUserWithoutLastName()
        {
            const string someScenario = 
                "R0lGODlhAQABAIAAAAAAAAAAACH5BAAAAAAALAAAAAABAAEAAAICTAEAOw==";

            byte[] bytes = Convert.FromBase64String(someScenario);
            
            var userRepo = new Mock<IUserRepository>();
            IUserService service = 
                new UserService(userRepo.Object);
            var user = new User()
            
            {
                Id = 1,
                FirstName = "Timothy",
             //   LastName = "Theory",
                UserName = "TheoTim",
                PasswordHash = bytes,
                PasswordSalt = bytes,
                Email = "TimsEmail",
                PhoneNumber = "282828",
                Address = "TimAllé",
                IsAdmin = false
            };
            Exception ex = Assert.Throws<InvalidDataException>(() =>
                service.CreateUser(user));
            
            Assert.Equal("Please add a Last Name", ex.Message);
        }
        [Fact]
        public void CreateUserWithoutUserName()
        {
            const string someScenario = 
                "R0lGODlhAQABAIAAAAAAAAAAACH5BAAAAAAALAAAAAABAAEAAAICTAEAOw==";

            byte[] bytes = Convert.FromBase64String(someScenario);
            
            var userRepo = new Mock<IUserRepository>();
            IUserService service = 
                new UserService(userRepo.Object);
            var user = new User()
            
            {
                Id = 1,
                FirstName = "Timothy",
                LastName = "Theory",
                //UserName = "TheoTim",
                PasswordHash = bytes,
                PasswordSalt = bytes,
                Email = "TimsEmail",
                PhoneNumber = "282828",
                Address = "TimAllé",
                IsAdmin = false
            };
            Exception ex = Assert.Throws<InvalidDataException>(() =>
                service.CreateUser(user));
            
            Assert.Equal("Please add a User Name", ex.Message);
        }
        [Fact]
        public void CreateUserWithoutPasswordHash()
        {
            const string someScenario = 
                "R0lGODlhAQABAIAAAAAAAAAAACH5BAAAAAAALAAAAAABAAEAAAICTAEAOw==";

            byte[] bytes = Convert.FromBase64String(someScenario);
            
            var userRepo = new Mock<IUserRepository>();
            IUserService service = 
                new UserService(userRepo.Object);
            var user = new User()
            
            {
                Id = 1,
                FirstName = "Timothy",
                LastName = "Theory",
                UserName = "TheoTim",
                //PasswordHash = bytes,
                PasswordSalt = bytes,
                Email = "TimsEmail",
                PhoneNumber = "282828",
                Address = "TimAllé",
                IsAdmin = false
            };
            Exception ex = Assert.Throws<InvalidDataException>(() =>
                service.CreateUser(user));
            
            Assert.Equal("Something went terribly wrong!", ex.Message);
        }
        [Fact]
        public void CreateUserWithoutPasswordSalt()
        {
            const string someScenario = 
                "R0lGODlhAQABAIAAAAAAAAAAACH5BAAAAAAALAAAAAABAAEAAAICTAEAOw==";

            byte[] bytes = Convert.FromBase64String(someScenario);
            
            var userRepo = new Mock<IUserRepository>();
            IUserService service = 
                new UserService(userRepo.Object);
            var user = new User()
            
            {
                Id = 1,
                FirstName = "Timothy",
                LastName = "Theory",
                UserName = "TheoTim",
                PasswordHash = bytes,
               // PasswordSalt = bytes,
                Email = "TimsEmail",
                PhoneNumber = "282828",
                Address = "TimAllé",
                IsAdmin = false
            };
            Exception ex = Assert.Throws<InvalidDataException>(() =>
                service.CreateUser(user));
            
            Assert.Equal("Something went terribly wrong!", ex.Message);
        }
        [Fact]
        public void CreateUserWithoutEmail()
        {
            const string someScenario = 
                "R0lGODlhAQABAIAAAAAAAAAAACH5BAAAAAAALAAAAAABAAEAAAICTAEAOw==";

            byte[] bytes = Convert.FromBase64String(someScenario);
            
            var userRepo = new Mock<IUserRepository>();
            IUserService service = 
                new UserService(userRepo.Object);
            var user = new User()
            
            {
                Id = 1,
                FirstName = "Timothy",
                LastName = "Theory",
                UserName = "TheoTim",
                PasswordHash = bytes,
                PasswordSalt = bytes,
              //  Email = "TimsEmail",
                PhoneNumber = "282828",
                Address = "TimAllé",
                IsAdmin = false
            };
            Exception ex = Assert.Throws<InvalidDataException>(() =>
                service.CreateUser(user));
            
            Assert.Equal("Please add an Email", ex.Message);
        }
        [Fact]
        public void CreateUserWithoutPhoneNumber()
        {
            const string someScenario = 
                "R0lGODlhAQABAIAAAAAAAAAAACH5BAAAAAAALAAAAAABAAEAAAICTAEAOw==";

            byte[] bytes = Convert.FromBase64String(someScenario);
            
            var userRepo = new Mock<IUserRepository>();
            IUserService service = 
                new UserService(userRepo.Object);
            var user = new User()
            
            {
                Id = 1,
                FirstName = "Timothy",
                LastName = "Theory",
                UserName = "TheoTim",
                PasswordHash = bytes,
                PasswordSalt = bytes,
                Email = "TimsEmail",
              //  PhoneNumber = "282828",
                Address = "TimAllé",
                IsAdmin = false
            };
            Exception ex = Assert.Throws<InvalidDataException>(() =>
                service.CreateUser(user));
            
            Assert.Equal("Please add a Phone Number", ex.Message);
        }
        [Fact]
        public void CreateUserWithoutAddress()
        {
            const string someScenario = 
                "R0lGODlhAQABAIAAAAAAAAAAACH5BAAAAAAALAAAAAABAAEAAAICTAEAOw==";

            byte[] bytes = Convert.FromBase64String(someScenario);
            
            var userRepo = new Mock<IUserRepository>();
            IUserService service = 
                new UserService(userRepo.Object);
            var user = new User()
            
            {
                Id = 1,
                FirstName = "Timothy",
                LastName = "Theory",
                UserName = "TheoTim",
                PasswordHash = bytes,
                PasswordSalt = bytes,
                Email = "TimsEmail",
                PhoneNumber = "282828",
              //  Address = "TimAllé",
                IsAdmin = false
            };
            Exception ex = Assert.Throws<InvalidDataException>(() =>
                service.CreateUser(user));
            
            Assert.Equal("Please add an Address", ex.Message);
        }
    }
}