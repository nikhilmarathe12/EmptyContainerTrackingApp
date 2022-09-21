using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ContainerTrackingApp.Models
{
    public class EventPushReceiver
    {
        [Key]
        public int ID { get; set; }
        public string security_token { get; set; }

        public string generated { get; set; }

        public EventInfo eventInfo { get; set; }

        public string event_class { get; set; }

        public ShipmentInfo shipmentInfo { get; set; }
    }
}