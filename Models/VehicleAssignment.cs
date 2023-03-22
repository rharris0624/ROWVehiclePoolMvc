using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RowVehiclePoolMVC.Models
{
    public partial class VehicleAssignment
    {
        [Key]
        public int VehReqNo { get; set; }
        [Key]
        [Column(TypeName = "decimal(5, 0)")]
        public decimal AssignNo { get; set; }
        [Required]
        [StringLength(5)]
        public string AssignTagNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime AssignDepartDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime AssignReturnDate { get; set; }
        [Required]
        [StringLength(50)]
        public string Comments { get; set; }
    }
}
