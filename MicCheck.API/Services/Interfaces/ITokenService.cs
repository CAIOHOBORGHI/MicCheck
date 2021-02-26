using MicCheck.API.Models;
using MicCheck.API.Requests;
using MicCheck.API.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicCheck.API.Services.Interfaces
{
    public interface ITokenService
    {
        /// <summary>
        /// Generate's JWT Token with id, name and role.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="role"></param>
        /// <returns>JWT token</returns>
        string GenerateToken(TokenModel model);

        /// <summary>
        /// Validates user email, role and password
        /// </summary>
        /// <param name="user"></param>
        /// <returns>Returns base data response with tokenModel</returns>
        BaseDataResponse<TokenModel> ValidateUser(AuthenticationRequest user);
    }
}
