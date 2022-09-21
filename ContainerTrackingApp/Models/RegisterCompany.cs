using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ContainerTrackingApp.Models
{
    public class RegisterCompany
    {
        [Key]
        public int CompanyID { get; set; }

        [Required(ErrorMessage = "Required Company Name")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Company Name Must be Minimum 2 Charaters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Required Description")]
        [StringLength(150, MinimumLength = 2, ErrorMessage = "Description Must be Minimum 2 Charaters")]
        public string Description { get; set; }

        [DisplayName("Person In Charge")]
        [Required(ErrorMessage = "Required Person In Charge")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "PersonInCharge Must be Minimum 2 Charaters")]
        public string PersonInCharge { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }

        [DisplayName("Email Address")]
        [Required(ErrorMessage = "Required EmailID")]
        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "Please enter Valid Email ID")]
        public string EmailID { get; set; }

        [Required(ErrorMessage = "Required Status")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Status Must be Minimum 2 Charaters")]
        public string Status { get; set; }
        public int UserID { get; set; }
    }
}