using MicCheck.Shared.Models;
using MicCheck.API.Requests;
using MicCheck.Shared.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicCheck.API.Services.Interfaces
{
    public interface IBandService
    {
        BaseResponse AddFanRelationship(int BandId, int FanId, bool liked);

        List<BandModel> GetAll();

        List<BandModel> GetByGenre(string genres);

        BaseDataResponse<BandModel> RegisterBand(RegisterBandModel model);
    }
}
