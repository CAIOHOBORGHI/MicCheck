using MicCheck.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicCheck.API.Services.Interfaces
{
    public interface IFanService
    {
        List<BandModel> ListLikedBands(int FanId);

        //bool UpdateFan(FanModel fan);
    }
}
