using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ContainerTrackingApp.Models
{
    public class LAShippingMaster
    {

        [Key]
        public int ID { get; set; }
        public string OISCACCode { get; set; }
        public string ShippingShortCode { get; set; }
        public string ShippingName { get; set; }
        public int IsMapped { get; set; }
    }
}