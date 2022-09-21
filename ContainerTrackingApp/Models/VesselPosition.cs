using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContainerTrackingApp.Models
{
    public class VesselPosition
    {
        public string latitude { get; set; }
        public string timestamp { get; set; }
        public string heading { get; set; }
        public string longitude { get; set; }
    }
}