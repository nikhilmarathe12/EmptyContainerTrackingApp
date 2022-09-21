using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContainerTrackingApp.DTO
{
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public class dtoVesselInfo
    {
        [JsonProperty(PropertyName = "name")]
        public string name { get; set; }

        [JsonProperty(PropertyName = "imo")]
        public string imo { get; set; }

        [JsonProperty(PropertyName = "id")]
        public string id { get; set; }
    }
}