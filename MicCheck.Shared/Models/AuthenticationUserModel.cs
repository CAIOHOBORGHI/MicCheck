using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicCheck.Shared.Models
{
    public class AuthenticationUserModel
    {
        public AuthenticationUserModel () { }
        public AuthenticationUserModel(int id, string name, string role)
        {
            this.UserId = id;
            this.Name = name;
            this.Role = role;
        }

        public int UserId { get; set; }

        public string Name { get; set; }

        public string Role { get; set; }
    }
}
