using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace RowVehiclePoolMVC.ViewModels
{
    public class VehicleAssignVM
    {
        public int Page { get; set; }
        public int TotalPages { get; set; }
        public VehicleAssignVM()
        {

        }
        public VehicleAssignVM(int page, int totalPages)
        {
            Page = page;
            TotalPages = totalPages;    
        }
        public IEnumerable<AssignmentDetail> VehicleAssignments { get; set; }
    }
}
