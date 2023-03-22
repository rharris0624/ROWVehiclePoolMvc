using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RowVehiclePoolMVC.ViewModels
{
    public class EmployeeInfoVM
    {
        public string SectionId { get; set; }
        public string EmployeeNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SectionDesc { get; set; }
        public string SectionManagerNum { get; set; }
        public string SectionManagerFirstName { get; set; }
        public string SectionManagerLastName { get; set; }
    }
}
