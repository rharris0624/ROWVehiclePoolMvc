using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RowVehiclePoolMVC.Models
{
    [Table("Equip_Rental_Rate")]
    public partial class EquipRentalRate
    {
        [Column("BUD")]
        [StringLength(255)]
        public string Bud { get; set; }
        [Column("TAG NO")]
        [StringLength(255)]
        public string TagNo { get; set; }
        [Column("CODE")]
        [StringLength(255)]
        public string Code { get; set; }
        [Column("BASE")]
        [StringLength(255)]
        public string Base { get; set; }
        [Column("RATE")]
        public double? Rate { get; set; }
    }
}
