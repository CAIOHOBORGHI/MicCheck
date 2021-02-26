using MicCheck.Data.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicCheck.API.Models
{
    // Here in Model we decide what kind of data will be displayed on the Web Client
    public class BandModel
    {
        // We can use Data Annotations to format json properties
        [JsonProperty(PropertyName = "fans_count")]
        public int FansCount{ get; set; }

        //We can also tell the serialize to ignore properties 
        [JsonIgnore]
        public int BandId { get; set; }
        public List<string> GenreTags { get; set; }
        public string Name { get; set; }
        public string Hometown { get; set; }
    }
}
