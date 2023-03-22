using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RowVehiclePoolMVC.Models
{
    public partial class Vehicle
    {
        [Key]
        [StringLength(5)]
        public string TagNumber { get; set; }
        [Column(TypeName = "numeric(4, 0)")]
        [DisplayFormat(DataFormatString = "{0:####}")]
        public decimal VehYear { get; set; }
        [Required]
        [StringLength(30)]
        public string Make { get; set; }
        [Required]
        [StringLength(30)]
        public string Model { get; set; }
        [Required]
        [StringLength(30)]
        public string Color { get; set; }
        [Required]
        [StringLength(10)]
        [Display(Name = "Veh.Type")]
        public string VehicleType { get; set; }
        [Required]
        [StringLength(1)]
        public string Status { get; set; }
        [Required]
        [StringLength(3)]
        [Display(Name ="Budget")]
        public string OwnerBudget { get; set; }
        [Column(TypeName = "numeric(6, 0)")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:n0}")]
        public decimal? Mileage { get; set; }
        [Column(TypeName = "datetime")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        [Display(Name ="Out of Svc")]
        public DateTime? OutOfServiceBegin { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? OutOfServiceEnd { get; set; }
    }
}
