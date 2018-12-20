using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using StreamingWebshop.Core.ApplicationService.Services;
using StreamingWebshop.Core.Entity;
using StreamShopRestAPI.Helpers;

namespace StreamShopRestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly IUserService _UserService;
        private IAuthenticationHelper _authenticationHelper;

        public UserController(IUserService userService, IAuthenticationHelper authService)
        {
            _UserService = userService;
            _authenticationHelper = authService;
        }

        // GET api/User
        [HttpGet]
        public ActionResult<IEnumerable<User>> Get()
        {
            return _UserService.GetAllUsers();
        }


        // GET api/User/5
        [HttpGet("{id}")]
        public ActionResult<User> Get(int id)
        {
            return _UserService.FindUserById(id);
        }

        // POST api/User
        [HttpPost]
        public ActionResult<User> Post([FromBody] UserInput model)
        {
            //Creates a space to put the byte[] Hash and Salt
            byte[] passwordHash, passwordSalt;
            //Inserts the given password into the CreatePasswordHash method
            //And inserts the given passwordHash and passwordSalt in the byte[]
            //To store the encrypted password when creating a user.
            _authenticationHelper.CreatePasswordHash(model.Password, out passwordHash, out passwordSalt);
            var user = new User
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                UserName = model.UserName,
                //Password has now been encrypted from the UserInput model.
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                Email = model.Email,
                PhoneNumber = model.PhoneNumber,
                Address = model.Address,
                City = model.City,
                ZipCode = model.ZipCode,
                IsAdmin = model.IsAdmin
                
            };
            return _UserService.CreateUser(user);
        }

        // PUT api/User/5
        [HttpPut("{id}")]
        public ActionResult<User> Put(int id, [FromBody] UserInput model)
        {
            //Creates a space to put the byte[] Hash and Salt
            byte[] passwordHash, passwordSalt;
            //Inserts the given password into the CreatePasswordHash method
            //And inserts the given passwordHash and passwordSalt in the byte[]
            //To store the encrypted password when creating a user.
            _authenticationHelper.CreatePasswordHash(model.Password, out passwordHash, out passwordSalt);
            var user = new User
            {
                Id = model.Id,
                FirstName = model.FirstName,
                LastName = model.LastName,
                UserName = model.UserName,
                //Password has now been encrypted from the UserInput model.
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                Email = model.Email,
                PhoneNumber = model.PhoneNumber,
                Address = model.Address,
                City = model.City,
                ZipCode = model.ZipCode,
                IsAdmin = model.IsAdmin
            };

            return _UserService.UpdateUser(user);
        }

        // DELETE api/User/5
        [HttpDelete("{id}")]
        public ActionResult<User> Delete(int id)
        {
            var usr = _UserService.DeleteUser(id);

            return Ok($"User with the Id of: {id} is deleted!");
        }
    }
}