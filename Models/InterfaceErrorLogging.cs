using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RowVehiclePoolMVC.Models
{
    public partial class InterfaceErrorLogging
    {
        [Column(TypeName = "datetime")]
        public DateTime Timestamp { get; set; }
        [Column("Error Code")]
        public int ErrorCode { get; set; }
        [Column("Error Message")]
        [StringLength(300)]
        public string ErrorMessage { get; set; }
    }
}
