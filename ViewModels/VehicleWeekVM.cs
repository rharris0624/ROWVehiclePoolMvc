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
        public VehicleWeekVM(IList<Vehicle> vehicles, IList<UsageInstance> usageInstances, DateTime usageDate)
        {
            Vehicles = vehicles;
            UsageInstances = usageInstances;
            UsageDate = usageDate;
        }
    }
}
