using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContainerTrackingApp.DTO
{
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public class dtoEventInfo
    {
        [JsonProperty(PropertyName = "id")]
        public int id { get; set; }

        [JsonProperty(PropertyName = "shipment_id")]
        public string shipment_id { get; set; }

        [JsonProperty(PropertyName = "details")]
        public dtoDetailsInfo detailsInfo { get; set; }

        [JsonProperty(PropertyName = "shipment")]
        public string shipment { get; set; }

        [JsonProperty(PropertyName = "code")]
        public string code { get; set; }

        [JsonProperty(PropertyName = "severity")]
        public string severity { get; set; }

        [JsonProperty(PropertyName = "walltime")]
        public DateTime walltime { get; set; }

        [JsonProperty(PropertyName = "created")]
        public DateTime created { get; set; }
    }
}