using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RowVehiclePoolMVC.Models
{
    public partial class VehicleFunction
    {
        [Key]
        [Column("FUNC")]
        [StringLength(4)]
        public string Func { get; set; }
        [Column("FUNCTION_DESC")]
        [StringLength(20)]
        public string FunctionDesc { get; set; }
    }
}
