using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RowVehiclePoolMVC.Models
{
    public partial class T101BudgetInf
    {
        public string Budget { get; set; }
        public string BudgetDesc { get; set; }
        public string PahrBudget { get; set; }
        public string TimerBudget { get; set; }
        public DateTime? PayrStartDate { get; set; }
        public DateTime? PayrEndDate { get; set; }
        public DateTime? MthStartDate { get; set; }
        public DateTime? MthEndDate { get; set; }
        public DateTime? LastUpdDate { get; set; }
        public TimeSpan? LastUpdTime { get; set; }
        public string LastUpdUserid { get; set; }
        public string LastUpdTermid { get; set; }
        public string CompBudget { get; set; }
        public string T101BudgetInfPrimaryKey { get; set; }
    }
}
