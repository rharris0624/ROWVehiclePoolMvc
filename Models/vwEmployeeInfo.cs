using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RowVehiclePoolMVC.Models
{
    public class vwEmployeeInfo
    {
        [StringLength(9)]
        public string EMPLOYEE_NUMBER { get; set; }
        [StringLength(27)]
        public string NAME_LAST { get; set; }
        [StringLength(15)]
        public string NAME_FIRST { get; set; }
        [StringLength(4)]
        public string SECTION_ID { get; set; }
        [StringLength(25)]
        public string SectionDesc { get; set; }
        [StringLength(4)]
        public string ITEM { get; set; }
        [StringLength(30)]
        public string JOB_TITLE { get; set; }
    }
}
