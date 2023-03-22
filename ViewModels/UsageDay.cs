using System;
using System.Linq;

namespace RowVehiclePoolMVC.ViewModels
{
    public class UsageDay
    {
        public string TagNumber { get; set; }
        public string Requestor { get; set; }
        public DateTime UsageDate { get; set; }
        public decimal AssignNo { get; set; }
        public string VehicleType { get; set; }
    }
}
