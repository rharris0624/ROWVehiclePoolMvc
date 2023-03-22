using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RowVehiclePoolMVC.Models
{
    [Table("ORAINF_EquipmentTemp", Schema = "EQP")]
    public partial class OrainfEquipmentTemp
    {
        [Required]
        [Column("VEHYEAR")]
        [StringLength(30)]
        public string Vehyear { get; set; }
        [Required]
        [Column("VEHMAKE")]
        [StringLength(30)]
        public string Vehmake { get; set; }
        [Column("VEHMODEL")]
        [StringLength(50)]
        public string Vehmodel { get; set; }
        [Column("SERIAL_CODE")]
        [StringLength(5)]
        public string SerialCode { get; set; }
        [Column("LICENSE")]
        [StringLength(5)]
        public string License { get; set; }
        [Column("PREVIOUS_LICENSE")]
        [StringLength(5)]
        public string PreviousLicense { get; set; }
        [Column("AGENCY_ID")]
        [StringLength(50)]
        public string AgencyId { get; set; }
        [Column("ACQUIRED")]
        [StringLength(50)]
        public string Acquired { get; set; }
        [Column("ASSIGNED_TO")]
        [StringLength(50)]
        public string AssignedTo { get; set; }
        [Column("BUDGET")]
        [StringLength(10)]
        public string Budget { get; set; }
        [Column("LICENSE_PLATE_STATUS")]
        [StringLength(25)]
        public string LicensePlateStatus { get; set; }
        [Column("DRIVE_HOME")]
        [StringLength(3)]
        public string DriveHome { get; set; }
        [Column("DATE_UPDATED", TypeName = "datetime")]
        public DateTime DateUpdated { get; set; }
    }
}
