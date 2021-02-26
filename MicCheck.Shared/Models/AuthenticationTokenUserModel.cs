using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicCheck.Shared.Models
{
    public class AuthenticationTokenUserModel : AuthenticationUserModel
    {
        public string Token { get; set; }
    }
}
