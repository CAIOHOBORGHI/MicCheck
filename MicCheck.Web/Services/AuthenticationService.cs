﻿using MicCheck.Shared.Models;
using MicCheck.Shared.Requests;
using MicCheck.Shared.Responses;
using MicCheck.Web.Services.Interfaces;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicCheck.Web.Services
{
    public class AuthenticationService : IAuthenticationService
    {

        private const string AUTHENTICATE_ROUTE = "Account/Authenticate";

        private IHttpService _httpService;
        private ILocalStorageService _localStorageService;
        private NavigationManager _navigationManager;

        public string Token { get; private set; }

        public AuthenticationService(
            IHttpService httpService,
            NavigationManager navigationManager,
            ILocalStorageService localStorageService
        )
        {
            _httpService = httpService;
            _navigationManager = navigationManager;
            _localStorageService = localStorageService;
        }

        public async Task Initialize()
        {
            Token = await _localStorageService.GetItem<string>("token");
        }

        public async Task<BaseResponse> Login(string email, string password, string role)
        {
            AuthenticationRequest authRequest = new AuthenticationRequest { Email = email, Password = password, Role = role };
            TokenResponse response = await _httpService.Post<TokenResponse>("http://localhost:5120/api/" + AUTHENTICATE_ROUTE, authRequest);
            if (response.Success)
            {
                Token = response.Token;
                await _localStorageService.SetItem("token", response.Token);
            }
            return response;
        }

        public async Task Logout()
        {
            Token = null;
            await _localStorageService.RemoveItem("token");
            _navigationManager.NavigateTo("login");
        }
    }
}