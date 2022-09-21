using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ContainerTrackingApp.Models
{
    public class CompanyMapping
    {
        [Key]
        public int ID { get; set; }
        public int CompanyID { get; set; }
        public int CompanyCode { get; set; }
        public string CompanyName { get; set; }
        public string CompanyDBNames { get; set; }
        public string CompanyDBInfo { get; set; }
    }
}