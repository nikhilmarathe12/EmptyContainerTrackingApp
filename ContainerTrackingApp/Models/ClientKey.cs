using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ContainerTrackingApp.Models
{
    public class ClientKey
    {
        [Key]
        [DisplayName("Client Key")]
        public int ClientKeyID { get; set; }

        [DisplayName("Company ID")]
        public int CompanyID { get; set; }

        [DisplayName("Client ID")]
        public string ClientID { get; set; }

        [DisplayName("Client Secret")]
        [Required(ErrorMessage = "Required ClientSecret")]
        [StringLength(150, MinimumLength =1, ErrorMessage = "ClientSecret Must be Minimum 1 Charaters")]
        public string ClientSecret { get; set; }

        [DisplayName("Created On Date")]
        public System.DateTime CreatedOn { get; set; }

        [DisplayName("User ID")]
        public int UserID { get; set; }
    }
}