using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RowVehiclePoolMVC.Models
{
    public partial class SystemSec
    {
        public string SystemId { get; set; }
        public string Userid { get; set; }
        public string Budget { get; set; }
        public string FunctionalArea { get; set; }
        public string Priority { get; set; }
        public string DefaultPanel { get; set; }
        public string ReceiveMail { get; set; }
        public DateTime UpdDate { get; set; }
        public string UpdatedBy { get; set; }
    }
}
