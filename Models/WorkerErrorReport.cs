using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RowVehiclePoolMVC.Models
{
    [Table("Worker_Error_Report")]
    public partial class WorkerErrorReport
    {
        [Column("UI USER KEY")]
        [StringLength(255)]
        public string UiUserKey { get; set; }
        [Column("MESSAGE TEXT")]
        [StringLength(255)]
        public string MessageText { get; set; }
    }
}
