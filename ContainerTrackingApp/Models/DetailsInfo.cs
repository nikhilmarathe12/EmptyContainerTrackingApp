using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ContainerTrackingApp.Models
{
    public class DetailsInfo
    {
        [Key]
        public int ID { get; set; }
        public string transport_mode { get; set; }
        public string pos_datetime { get; set; }
        public string longitude { get; set; }
        public string latitude { get; set; }
        public string message { get; set; }
        public string pos_name { get; set; }
    }
}