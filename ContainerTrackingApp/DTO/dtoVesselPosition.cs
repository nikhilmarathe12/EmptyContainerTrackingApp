using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContainerTrackingApp.DTO
{
    public class dtoVesselPosition
    {
        [JsonProperty(PropertyName = "latitude")]
        public string latitude { get; set; }

        [JsonProperty(PropertyName = "timestamp")]
        public string timestamp { get; set; }

        [JsonProperty(PropertyName = "heading")]
        public string heading { get; set; }

        [JsonProperty(PropertyName = "longitude")]
        public string longitude { get; set; }
    }
}