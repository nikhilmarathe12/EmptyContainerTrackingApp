using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ContainerTrackingApp.Models
{
    public class OceanInsightShippingMaster
    {
        [Key]
        public int ID { get; set; }
        public string shortname { get; set; }
        public string OfficialName { get; set; }
        public string SCACCode { get; set; }
        public string OICODE { get; set; }

    }
}