using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicCheck.API.Services.Interfaces
{
    public interface ISecurityService
    {
        bool ComparePasswords(string password, string hashedPassword);
        
        string HashPassword(string password);
    }
}
