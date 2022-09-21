using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ContainerTrackingApp.Models
{
    [Table("RegisterUser")]
    public class RegisterUser
    {
        [Key]
        public int UserID { get; set; }

        [DisplayName("User Name")]
        [Required(ErrorMessage = "Required Username")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "Username Must be Minimum 2 Charaters")]
        public string UserName { get; set; }

        [DataType(DataType.Password)]
        [Column(TypeName = "NVARCHAR(MAX)")]
        [Required(ErrorMessage = "Required Password")]
        [MaxLength(4000, ErrorMessage = "Password cannot be Greater than 30 Charaters")]
        [StringLength(4000, MinimumLength = 7, ErrorMessage = "Password Must be Minimum 7 Charaters")]
        public string Password { get; set; }

        [DisplayName("Email Address")]
        [Required(ErrorMessage = "Required EmailID")]
        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "Please enter Valid Email ID")]
        public string EmailID { get; set; }
        public System.DateTime CreatedOn { get; set; }
    }
}