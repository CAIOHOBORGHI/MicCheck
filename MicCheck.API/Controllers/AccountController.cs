using MicCheck.Shared.Models;
using MicCheck.API.Requests;
using MicCheck.Shared.Responses;
using MicCheck.API.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicCheck.API.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class AccountController : Controller
    {
        private IBandService _bandService;
        private ITokenService _tokenService;

        public AccountController(IBandService bandService, ITokenService tokenService)
        {
            _bandService = bandService;
            _tokenService = tokenService;
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Test()
        {
            return Ok("ok!");
        }

        [HttpPost]
        [AllowAnonymous]
        public IActionResult Authenticate([FromBody] AuthenticationRequest user)
        {
            TokenResponse tokenResponse = new TokenResponse();
            BaseDataResponse<AuthenticationUserModel> serviceResponse = _tokenService.ValidateUser(user);
            if (serviceResponse.Success)
            {
                AuthenticationUserModel model = serviceResponse.Data;
                tokenResponse.Message = "User is authenticated!";
                tokenResponse.Token = _tokenService.GenerateToken(model);
                return Ok(tokenResponse);
            }

            return Ok(tokenResponse.Error("Invalid credentials!"));
        }


        [HttpPost]
        [AllowAnonymous]
        public IActionResult RegisterBand([FromBody]RegisterBandModel requestModel)
        {
            TokenResponse tokenResponse = new TokenResponse();
            if (!ModelState.IsValid)
            {
                return Ok(tokenResponse.Error("Inserted data is not valid!"));
            }

            BaseDataResponse<BandModel> serviceResponse = _bandService.RegisterBand(requestModel);
            if (serviceResponse.Success)
            {
                BandModel dbModel = serviceResponse.Data;
                AuthenticationUserModel tokenModel = new AuthenticationUserModel(dbModel.BandId, requestModel.Name, "Band");
                tokenResponse.Token = _tokenService.GenerateToken(tokenModel);
            }
            return Ok(tokenResponse);
        }
    }
}
