using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ContainerTrackingApp.Models
{
    public class TokensManager
    {
        [Key]
        public Int64 TokenID { get; set; }

        [Column(TypeName = "NVARCHAR(MAX)")]
        public string TokenKey { get; set; }
        public System.DateTime IssuedOn { get; set; }
        public System.DateTime ExpiredOn { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public int CompanyID { get; set; }
    }
}