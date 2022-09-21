using ContainerTrackingApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ContainerTrackingApp.Models
{
    public class ClientTokenViewModel
    {
        [Key]
        public int ClientKeyID { get; set; }
        public int CompanyID { get; set; }
        public string CompanyName { get; set; }
        public string ClientID { get; set; }
        public string ClientSecret { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public int UserID { get; set; }
        public string UserName { get; set; }
        public Int64 TokenID { get; set; }
        public string TokenKey { get; set; }
        public System.DateTime IssuedOn { get; set; }
        public System.DateTime ExpiredOn { get; set; }
    }
}