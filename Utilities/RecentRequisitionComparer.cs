using RowVehiclePoolMVC.ViewModels;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace RowVehiclePoolMVC.Utilities
{
    public class RecentRequisitionComparer : IEqualityComparer<DeleteRequestorVM>
    {
        public bool Equals([AllowNull] DeleteRequestorVM x, [AllowNull] DeleteRequestorVM y)
        {
            return x.Requestor == y.Requestor && x.selected != y.selected;
        }

        public int GetHashCode([DisallowNull] DeleteRequestorVM obj)
        {
            if(object.ReferenceEquals(obj, null))
                return 0;
            return obj.Requestor.GetHashCode();
        }
    }
}
