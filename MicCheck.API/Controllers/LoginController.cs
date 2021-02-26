using MicCheck.API.Models;
using MicCheck.API.Responses;
using MicCheck.API.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicCheck.API.Controllers
{
    [Route("api/{controller}/{action}")]
    public class LoginController : Controller
    {
        private ITokenService _tokenService;

        public LoginController(ITokenService tokenService)
        {
            _tokenService = tokenService;
        }

        [HttpPost]
        [AllowAnonymous]
        public IActionResult Authenticate([FromBody] UserModel user)
        {
            TokenResponse tokenResponse = new TokenResponse();
            UserModel validUser = _tokenService.ValidateUser(user);
            if(validUser == null)
                return Ok(tokenResponse.Error("Invalid credentials!"));

            tokenResponse.Message = "User authenticated!";
            tokenResponse.Token = _tokenService.GenerateToken(validUser);
            return Ok(tokenResponse);
        }
    }
}
