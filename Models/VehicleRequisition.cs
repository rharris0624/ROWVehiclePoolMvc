using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RowVehiclePoolMVC.Models
{
    public partial class VehicleRequisition
    {
        [Key]
        [Column(TypeName = "ID")]
        [Display(Name = "Request Number")]
        public int VehReqNo { get; set; }
        [Column(TypeName = "datetime")]
        [Display(Name ="Date Requested")]
        public DateTime VehReqDate { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name ="Requestor")]
        public string Requestor { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Veh Type")]
        public string VehType { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Destination")]
        public string Destination { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name ="Duties")]
        public string Duties { get; set; }
        [Column(TypeName = "decimal(2, 0)")]
        [DisplayFormat(DataFormatString = "{0:n0}")]
        [Display(Name = "Number in Party")]
        public decimal NoInParty { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name ="Division")]
        public string ReqDivision { get; set; }
        [Required]
        [Column("ReqSectionID")]
        [StringLength(4)]
        [Display(Name = "Section")]
        public string ReqSectionId { get; set; }
        [Required]
        [StringLength(3)]
        [Display(Name ="Budget")]
        public string ReqBudget { get; set; }
        [Required]
        [StringLength(4)]
        [Display(Name = "Function")]
        public string ReqFunction { get; set; }
        [Required]
        [StringLength(6)]
        [RegularExpression(@"^[0-9]*$", ErrorMessage ="Characters not allowed")]
        [Display(Name = "Job No")]
        public string ReqJobNo { get; set; }
        [Required]
        [Column("ReqFAP")]
        [StringLength(11)]
        [Display(Name = "FAP")]
        public string ReqFap { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Comments")]
        public string ReqComments { get; set; }
        [Column(TypeName = "datetime")]
        [Required]
        [Display(Name = "Depart Date")]
        public DateTime ReqDepartDate { get; set; }
        [Column(TypeName = "datetime")]
        [Display(Name = "Return Date")]
        public DateTime ReqReturnDate { get; set; }
        [Required]
        [StringLength(8)]
        [Display(Name = "User ID")]
        public string Userid { get; set; }
        [Required]
        [Display(Name ="Status")]
        [StringLength(1)]
        public string VehReqStatus { get; set; }
        [StringLength(50)]
        [Display(Name = "Division Head")]
        public string NotificationDivHead { get; set; }
        [StringLength(50)]
        [Display(Name="Manager")]
        public string NotificationMan { get; set; }
        [StringLength(50)]
        [Display(Name ="Email Address")]
        public string EmailAddress { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime LastChangeDate { get; set; }
        [StringLength(7)]
        public string LastChangeUserid { get; set; }
    }
}
