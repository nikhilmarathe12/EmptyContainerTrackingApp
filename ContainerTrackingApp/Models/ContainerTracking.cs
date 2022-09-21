using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ContainerTrackingApp.Models
{
    public class ContainerTracking
    {
        [Key]
        public long CID { get; set; }

        [Required(ErrorMessage = "Required SCAC Code")]
        [StringLength(10, MinimumLength = 2, ErrorMessage = "SCAC Code Must be Minimum 2 Charaters")]
        public string SCAC_Code { get; set; }

        public string ShippingLineName { get; set; }

        public string FFAgentName { get; set; }

        public string VesselName { get; set; }

        //[Required(ErrorMessage = "Required ContainerNumber")]
        //[StringLength(30, MinimumLength = 2, ErrorMessage = "ContainerNumber Must be Minimum 2 Charaters")]
        //public string ContainerNumber { get; set; }

        [Required(ErrorMessage = "Required BillOfLading")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "BillOfLading Must be Minimum 2 Charaters")]
        public string BillOfLading { get; set; }

        [Required(ErrorMessage = "Required BookingNumber")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "BookingNumber Must be Minimum 2 Charaters")]
        public string BookingNumber { get; set; }

        public string BookingReferenceNumber { get; set; }

        public string MaterialName { get; set; }

        public string InvoiceNO { get; set; }

        public string SOE { get; set; }

        public string JobRefNumber { get; set; }

        public string DivisionName { get; set; }

        public string CompanyName { get; set; }

        public string ResponseID { get; set; }

        public bool ProcessSend { get; set; }

        [Required(ErrorMessage = "Required ProcessStatus")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "ProcessStatus Must be Minimum 2 Charaters")]
        public string ProcessStatus { get; set; }

        //[Required(ErrorMessage = "Required ContainerStatus")]
        //[StringLength(30, MinimumLength = 2, ErrorMessage = "ContainerStatus Must be Minimum 2 Charaters")]
        //public string ContainerStatus { get; set; }

        public string BLStatus { get; set; }

        public System.DateTime StatusDate { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public System.DateTime ModifiedOn { get; set; }
    }
}