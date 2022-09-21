using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContainerTrackingApp.DTO
{
    public class dtoVesselnextport
    {
        [JsonProperty(PropertyName = "eta")]
        public string eta { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string name { get; set; }

        [JsonProperty(PropertyName = "locode")]
        public string locode { get; set; }
    }
}