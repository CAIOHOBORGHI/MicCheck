using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicCheck.Web.Services.Interfaces
{
    public interface IHttpService
    {
        Task<T> Get<T>(string url);

        Task<T> Post<T>(string url, object value);
    }
}
