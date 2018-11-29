using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StreamingWebshop.Core.ApplicationService;
using StreamingWebshop.Core.ApplicationService.Services;
using StreamingWebshop.Core.DomainService;
using StreamingWebshop.Core.Entity;
using StreamShopRestAPI.Helpers;

namespace StreamShopRestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokenController : Controller
    {
        private IUserService _service;
        private IAuthenticationHelper authenticationHelper;

        public TokenController(IUserService service, IAuthenticationHelper authService)
        {
            _service = service;
            authenticationHelper = authService;
        }

        [HttpPost]
        public IActionResult Login([FromBody]LoginInput model)
        {
            var user = _service.GetAllUsers().FirstOrDefault(u => u.UserName == model.Username);

            // check if username exists
            if (user == null)
                return Unauthorized();

            // check if password is correct
            if (!authenticationHelper.VerifyPasswordHash(model.Password, user.PasswordHash, user.PasswordSalt))
                return Unauthorized();

            // Authentication successful
            return Ok(new
            {
                username = user.UserName,
                token = authenticationHelper.GenerateToken(user)
            });
        } 
    }
}