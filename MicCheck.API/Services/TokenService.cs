using MicCheck.Shared.Models;
using MicCheck.API.Requests;
using MicCheck.Shared.Responses;
using MicCheck.API.Services.Interfaces;
using MicCheck.Core.Repositories.Interfaces;
using MicCheck.Data.Entities;
using MicCheck.Data.Repositories.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace MicCheck.API.Services
{
    public class TokenService : ITokenService
    {
        private IConfiguration _config;

        private ISecurityService _securityService;

        private IBandRepository _bandRepository;
        private IFanRepository _fanRepository;

        public TokenService(IConfiguration config, ISecurityService securityService, IBandRepository bandRepository, IFanRepository fanRepository)
        {
            _config = config;

            _bandRepository = bandRepository;
            _fanRepository = fanRepository;

            _securityService = securityService;
        }

        public string GenerateToken(AuthenticationUserModel model)
        {
            JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
            string jwtSecret = _config.GetValue<string>("JWTSecret");

            byte[] key = Encoding.ASCII.GetBytes(jwtSecret);
            SecurityTokenDescriptor tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.NameIdentifier, model.UserId.ToString()),
                    new Claim(ClaimTypes.Name, model.Name),
                    new Claim(ClaimTypes.Role, model.Role)
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            SecurityToken token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

        public BaseDataResponse<AuthenticationUserModel> ValidateUser(AuthenticationRequest user)
        {
            BaseDataResponse<AuthenticationUserModel> response = new BaseDataResponse<AuthenticationUserModel>();
            if (string.IsNullOrWhiteSpace(user.Email) || string.IsNullOrWhiteSpace(user.Password))
            {
                response.Error("User email and password are required!");
                return response;
            }

            AuthenticationUserModel tokenModel;

            /* For demo simplicity I'm using role as a string to define if user is band or fan */
            switch (user.Role.ToUpper())
            {
                case "BAND":
                    tokenModel = ValidateBand(user.Email, user.Password);
                    break;

                case "FAN":
                    tokenModel = ValidateFan(user.Email, user.Password);
                    break;

                default:
                    throw new ArgumentException("Role is invalid!");
            }

            if (tokenModel != null)
            {
                response.Success = true;
                response.Data = tokenModel;
                response.Message = "User validated successfully!";
            }
            else
                response.Error("Invalid Credentials!");

            return response;
        }

        private AuthenticationUserModel ValidateBand(string email, string password)
        {
            Band entity = _bandRepository.Get(b => b.Email == email);

            // Validates password
            if(entity != null && _securityService.ComparePasswords(password, entity.HashedPassword))
                return new AuthenticationUserModel (entity.Id, entity.Name, "Band");

            return null;
        }

        private AuthenticationUserModel ValidateFan(string email, string password)
        {
            Fan entity = _fanRepository.Get(f => f.Email == email);

            // Here we compare the modelPassword with the hashedpassword
            if (entity != null && _securityService.ComparePasswords(password, entity.HashedPassword))
                return new AuthenticationUserModel (entity.Id, entity.Name, "Fan");

            return null;
        }
    }
}
