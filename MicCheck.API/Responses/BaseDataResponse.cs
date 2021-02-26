using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicCheck.API.Responses
{
    public class BaseDataResponse<T> : BaseResponse
    {
        public T Data { get; set; }
    }
}
