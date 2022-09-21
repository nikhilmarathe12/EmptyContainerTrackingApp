using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ContainerTrackingApp.Models
{
    public class DivisionMaster
    {
        [Key]
        public int sid { get; set; }
        public int OI_AccountCode { get; set; }
        public string OI_DivisionName { get; set; }
        public string OI_DivisionShotCode { get; set; }
    }
}