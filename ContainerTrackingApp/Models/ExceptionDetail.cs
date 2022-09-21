using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ContainerTrackingApp.Models
{
    public class ExceptionDetail
    {
        [Key]
        public int ID { get; set; }
        public string ExceptionLocation { get; set; }
        public string ExceptionMessage { get; set; }
        public string ExceptionTrace { get; set; }
        public DateTime ExceptionDateTime { get; set; }
    }
}