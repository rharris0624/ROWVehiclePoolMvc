using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using RowVehiclePoolMVC.Models;

namespace RowVehiclePoolMVC.Utilities
{
    public class AvailableVehicleComparer : IEqualityComparer<Vehicle>
    {
        public bool Equals([AllowNull] Vehicle x, [AllowNull] Vehicle y)
        {
            return x.TagNumber == y.TagNumber;
        }

        public int GetHashCode([DisallowNull] Vehicle obj)
        {
            if (object.ReferenceEquals(obj, null))
                return 0;
            return obj.TagNumber.GetHashCode();
        }
    }
}
