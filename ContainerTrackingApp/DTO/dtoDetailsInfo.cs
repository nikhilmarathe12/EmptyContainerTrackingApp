using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContainerTrackingApp.DTO
{
    public class dtoDetailsInfo
    {
        public string transport_mode { get; set; }
        public string pos_datetime { get; set; }
        public string longitude { get; set; }
        public string latitude { get; set; }
        public string message { get; set; }
        public string pos_name { get; set; }
    }
}