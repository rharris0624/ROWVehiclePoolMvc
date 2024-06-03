using RowVehiclePoolMVC.Models;
using System.Collections.Generic;

namespace RowVehiclePoolMVC.ViewModels
{
    public class SetVehicleStatusVM
    {
        public SetVehicleStatusVM() 
        {
            SearchTypes = new Dictionary<string, string>()
            {
                {"Tag","Tag Number" },
                {"Budget","Owner Budget" }
            };
        }
        public string TagNumber { get; set; }
        public string Budget { get; set; }
        public string SearchTypeSelected { get; set; }
        public Dictionary<string, string> SearchTypes { get;}
        public IList<Vehicle> Vehicles { get; set; }

    }
}
