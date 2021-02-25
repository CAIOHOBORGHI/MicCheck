using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicCheck.Core.Responses
{
    public class BaseResponse<T> where T : class
    {
        public BaseResponse()
        {
            //By default, success is defined as true
            this.Success = true;
        }

        public T Data { get; set; }
        public string Message { get; set; }
        public bool Success { get; set; }
    }
}
