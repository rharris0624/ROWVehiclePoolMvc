using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RowVehiclePoolMVC.Models
{
    [Table("VehicleExpenseExport", Schema = "AHTD\\RH41200")]
    public partial class VehicleExpenseExport
    {
        [Key]
        [Column("tag_number")]
        [StringLength(5)]
        public string TagNumber { get; set; }
        [Key]
        [Column("budget")]
        [StringLength(3)]
        public string Budget { get; set; }
        [Required]
        [Column("serial_number")]
        [StringLength(30)]
        public string SerialNumber { get; set; }
        [Required]
        [Column("manufacturer_name")]
        [StringLength(50)]
        public string ManufacturerName { get; set; }
        [Required]
        [Column("model_number")]
        [StringLength(50)]
        public string ModelNumber { get; set; }
        [Column("fuel_cost", TypeName = "money")]
        public decimal? FuelCost { get; set; }
        [Column("lube_cost", TypeName = "money")]
        public decimal? LubeCost { get; set; }
        [Column("parts_cost", TypeName = "money")]
        public decimal? PartsCost { get; set; }
        [Column("tires_cost", TypeName = "money")]
        public decimal? TiresCost { get; set; }
        [Column("rental_cost", TypeName = "money")]
        public decimal? RentalCost { get; set; }
        [Column("repair_cost", TypeName = "money")]
        public decimal? RepairCost { get; set; }
        [Column("labor_cost", TypeName = "money")]
        public decimal? LaborCost { get; set; }
        [Column("total_cost", TypeName = "money")]
        public decimal? TotalCost { get; set; }
        [Column("depreciation_cost", TypeName = "money")]
        public decimal? DepreciationCost { get; set; }
    }
}
