using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicCheck.API.Requests
{
    public class AddFanToBandRequest
    {
        [JsonRequired]
        public int FanId { get; set; }

        [JsonRequired]
        public int BandId { get; set; }

        [JsonRequired]
        public bool Liked { get; set; }

    }
}
