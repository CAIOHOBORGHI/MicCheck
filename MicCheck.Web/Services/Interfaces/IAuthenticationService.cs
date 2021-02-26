using MicCheck.Shared.Models;
using MicCheck.Shared.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicCheck.Web.Services.Interfaces
{
    public interface IAuthenticationService
    {
        string Token { get; }
        
        Task Initialize();

        Task<BaseResponse> Login(string email, string password, string role);

        Task Logout();
    }
}
