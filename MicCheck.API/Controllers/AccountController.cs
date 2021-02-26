using MicCheck.API.Models;
using MicCheck.API.Requests;
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
    public class AccountController : Controller
    {
        private IBandService _bandService;
        private ITokenService _tokenService;

        public AccountController(IBandService bandService, ITokenService tokenService)
        {
            _bandService = bandService;
            _tokenService = tokenService;
        }

        [HttpPost]
        [AllowAnonymous]
        public IActionResult Authenticate([FromBody] AuthenticationRequest user)
        {
            TokenResponse tokenResponse = new TokenResponse();
            BaseDataResponse<TokenModel> serviceResponse = _tokenService.ValidateUser(user);
            if (serviceResponse.Success)
            {
                TokenModel model = serviceResponse.Data;
                tokenResponse.Message = "User is authenticated!";
                tokenResponse.Token = _tokenService.GenerateToken(model);
                return Ok(tokenResponse);
            }

            return Ok(tokenResponse.Error("Invalid credentials!"));
        }


        [HttpPost]
        [AllowAnonymous]
        public IActionResult RegisterBand([FromBody] RegisterBandRequest request)
        {
            TokenResponse tokenResponse = new TokenResponse();
            if (!ModelState.IsValid)
            {
                return Ok(tokenResponse.Error("Inserted data is not valid!"));
            }

            BaseDataResponse<BandModel> serviceResponse = _bandService.RegisterBand(request);
            if (serviceResponse.Success)
            {
                BandModel model = serviceResponse.Data;
                TokenModel tokenModel = new TokenModel(model.BandId, model.Name, "Band");
                tokenResponse.Token = _tokenService.GenerateToken(tokenModel);
            }
            return Ok(tokenResponse);
        }
    }
}
