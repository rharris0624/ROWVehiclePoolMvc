using System;
using System.Collections.Generic;
using System.Linq;
using RowVehiclePoolMVC.Models;

namespace RowVehiclePoolMVC.ViewModels
{
    public class WeeklyVehicleUsage
    {
        public IList<UsageDay> UsageWeek { get; }

        public WeeklyVehicleUsage(DateTime startDate, DateTime endDate, Vehicle vehicle, UsageInstance usageInstance)
        {
            var weeklyDates = Enumerable.Range(0, 1 + endDate.Subtract(startDate).Days).Select(offset => startDate.AddDays(offset)).ToList();
            var usageDateRange = Enumerable.Range(0, 1 + usageInstance.UsageDepartDate.Subtract(usageInstance.UsageReturnDate).Days).Select(offset => usageInstance.UsageDepartDate.AddDays(offset)).ToList();
            var usageDays = new List<UsageDay>();

            UsageWeek = weeklyDates.GroupJoin(usageDays,wd=>wd.Date,ud=>ud.UsageDate.Date,(wd,ud) => new { wd, ud })
                .SelectMany(a=>a.ud.DefaultIfEmpty(), (a,b) => new UsageDay
                {
                    AssignNo = (b != null) ? b.AssignNo : 0,
                    UsageDate = a.wd.Date,
                    Requestor = b?.Requestor,
                    TagNumber = vehicle.TagNumber,
                    VehicleType = vehicle.VehicleType,
                }).ToList();
        }
    }
}
