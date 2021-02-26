using MicCheck.API.Models;
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
    public class TokenService
    {
        private IConfiguration _config;
        private IUserRepository _userRepository;
        public TokenService(IConfiguration config, IUserRepository userRepository)
        {
            _config = config;
            _userRepository = userRepository;
        }

        public string GenerateToken(UserModel user)
        {
            JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
            string jwtSecret = "";
            _config.GetSection("JWTSecret").Bind(jwtSecret);

            byte[] key = Encoding.ASCII.GetBytes(jwtSecret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, user.Name),
                    new Claim(ClaimTypes.Role, user.Role)
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            SecurityToken token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

        public UserModel ValidateUser(UserModel userModel)
        {
            if (string.IsNullOrWhiteSpace(userModel.Email) || string.IsNullOrWhiteSpace(userModel.Password))
                return null;

            User userEntity = _userRepository.Get(u => u.Email == userModel.Email);

            // Here we compare the modelPassword with the hashedpassword
            if (userEntity == null || !BCrypt.Net.BCrypt.Verify(userModel.Password, userEntity.HashedPassword))
                return null;

            // Updates user role from database
            userModel.Role = userEntity.Role;
            return userModel;
        }
    }
}
