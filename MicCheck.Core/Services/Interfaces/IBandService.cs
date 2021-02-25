using MicCheck.Core.Models;
using MicCheck.Core.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicCheck.Core.Services.Interfaces
{
    public interface IBandService
    {
        BaseResponse<List<BandModel>> GetAll();
    }
}
