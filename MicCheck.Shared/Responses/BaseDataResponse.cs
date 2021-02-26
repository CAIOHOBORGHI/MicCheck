using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicCheck.Shared.Responses
{
    public class BaseDataResponse<T> : BaseResponse
    {
        public T Data { get; set; }

    }
}
