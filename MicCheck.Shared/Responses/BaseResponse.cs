using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicCheck.Shared.Responses
{
    public class BaseResponse
    {
        public BaseResponse()
        {
            //By default, success is defined as true
            this.Success = true;
        }

        public string Message { get; set; }
        public bool Success { get; set; }

        public BaseResponse Error(string message)
        {
            this.Message = message;
            this.Success = false;
            return this;
        }

        public BaseResponse Ok(string message)
        {
            this.Message = message;
            this.Success = true;
            return this;
        }
    }
}
