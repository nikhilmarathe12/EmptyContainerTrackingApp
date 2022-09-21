using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContainerTrackingApp.DTO
{
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public class dtoConainerRequest
    {
        [JsonProperty(PropertyName = "request_carrier_code")]
        public string request_carrier_code { get; set; }

        [JsonProperty(PropertyName = "request_key")]
        public string request_key { get; set; }

        [JsonProperty(PropertyName = "request_type")]
        public string request_type { get; set; }
    }
}