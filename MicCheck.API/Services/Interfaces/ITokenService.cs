using MicCheck.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicCheck.API.Services.Interfaces
{
    public interface ITokenService
    {
        string GenerateToken(UserModel user);
        UserModel ValidateUser(UserModel user);
    }
}
