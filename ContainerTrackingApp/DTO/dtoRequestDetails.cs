using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContainerTrackingApp.DTO
{
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public class dtoRequestDetails
    {
        [JsonProperty(PropertyName = "id")]
        public int ID { get; set; }

        [JsonProperty(PropertyName = "request_carrier_name")]
        public string request_carrier_name { get; set; }

        [JsonProperty(PropertyName = "suspicious_key")]
        public string suspicious_key { get; set; }

        [JsonProperty(PropertyName = "descriptive_name")]
        public string descriptive_name { get; set; }

        [JsonProperty(PropertyName = "status_verbose")]
        public string status_verbose { get; set; }

        [JsonProperty(PropertyName = "containershipments")]
        public List<dtoContainershipments> containershipments { get; set; }

        [JsonProperty(PropertyName = "url")]
        public string url { get; set; }

        [JsonProperty(PropertyName = "request_type")]
        public string request_type { get; set; }

        [JsonProperty(PropertyName = "request_key")]
        public string request_key { get; set; }

        [JsonProperty(PropertyName = "contractual_eta_pod")]
        public string contractual_eta_pod { get; set; }

        [JsonProperty(PropertyName = "contractual_eta_dlv")]
        public string contractual_eta_dlv { get; set; }

        [JsonProperty(PropertyName = "owner_internal_id")]
        public string owner_internal_id { get; set; }

        [JsonProperty(PropertyName = "created")]
        public string created { get; set; }

        [JsonProperty(PropertyName = "modified")]
        public string modified { get; set; }

        [JsonProperty(PropertyName = "last_carrier_update")]
        public string last_carrier_update { get; set; }

        [JsonProperty(PropertyName = "last_actuals_update")]
        public string last_actuals_update { get; set; }

        [JsonProperty(PropertyName = "status")]
        public string status { get; set; }

        [JsonProperty(PropertyName = "on_hold")]
        public string on_hold { get; set; }
    }
}