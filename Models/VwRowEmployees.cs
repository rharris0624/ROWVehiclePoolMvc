using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RowVehiclePoolMVC.Models
{
    public partial class VwRowEmployees
    {
        public string EmployeeNumber { get; set; }
        public string NameLast { get; set; }
        public string NameFirst { get; set; }
        public string SectionId { get; set; }
        public string SectionDesc { get; set; }
        public string Item { get; set; }
        public string JobTitle { get; set; }
    }
}
