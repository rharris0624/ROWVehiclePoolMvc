using RowVehiclePoolMVC.Models;
using System.Collections.Generic;

namespace RowVehiclePoolMVC.ViewModels
{
    public class VehicleSelectionVM
    {
        public IList<Vehicle> Vehicles { get; set; }
        public string VehicleType { get; set; }
        public int VehReqNo { get; set; }
    }
}
