using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContainerTrackingApp.Models
{
    public class RequestDetailHist
    {
        public int ID { get; set; }

        public int HistID { get; set; }

        public int RequestID { get; set; }

        public string request_carrier_name { get; set; }

        public string suspicious_key { get; set; }

        public string descriptive_name { get; set; }

        public string status_verbose { get; set; }

        public string url { get; set; }

        public string request_type { get; set; }

        public string request_key { get; set; }

        public string contractual_eta_pod { get; set; }

        public string contractual_eta_dlv { get; set; }

        public string owner_internal_id { get; set; }

        public string created { get; set; }

        public string modified { get; set; }

        public string last_carrier_update { get; set; }

        public string last_actuals_update { get; set; }

        public string status { get; set; }

        public string on_hold { get; set; }
        public virtual ICollection<ContainershipmentDetailHist> containershipments { get; set; }
    }
}