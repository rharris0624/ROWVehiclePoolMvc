using System;
using RowVehiclePoolMVC.Models;
using System.Collections.Generic;

namespace RowVehiclePoolMVC.ViewModels
{
    public class VehicleWeekVM
    {
        public IList<Vehicle> Vehicles { get; }
        public IList<UsageInstance> UsageInstances { get; }
        public DateTime UsageDate { get; }
        public DateTime SelectionDate { get; set; }
        public VehicleWeekVM(IList<Vehicle> vehicles, IList<UsageInstance> usageInstances, DateTime usageDate, DateTime selectionDate)
        {
            Vehicles = vehicles;
            UsageInstances = usageInstances;
            UsageDate = usageDate;
            SelectionDate = selectionDate;
        }
        public VehicleWeekVM(IList<Vehicle> vehicles, IList<UsageInstance> usageInstances, DateTime usageDate)
        {
            Vehicles = vehicles;
            UsageInstances = usageInstances;
            UsageDate = usageDate;
        }
    }
}
