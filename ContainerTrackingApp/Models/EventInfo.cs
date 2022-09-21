using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ContainerTrackingApp.Models
{
    public class EventInfo
    {
        [Key]
        public int id { get; set; }
        public string shipment_id { get; set; }
        public DetailsInfo detailsInfo { get; set; }
        public string shipment { get; set; }
        public string code { get; set; }
        public string severity { get; set; }
        public DateTime walltime { get; set; }
        public DateTime created { get; set; }
    }
}