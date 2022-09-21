using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContainerTrackingApp.DTO
{
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public class dtoEventPushReceiver
    {
        [JsonProperty(PropertyName = "security_token")]
        public string security_token { get; set; }

        [JsonProperty(PropertyName = "generated")]
        public string generated { get; set; }

        [JsonProperty(PropertyName = "event")]
        public dtoEventInfo eventInfo { get; set; }

        [JsonProperty(PropertyName = "event_class")]
        public string event_class { get; set; }

        [JsonProperty(PropertyName = "shipment")]
        public dtoShipmentInfo shipmentInfo { get; set; }
    }
}