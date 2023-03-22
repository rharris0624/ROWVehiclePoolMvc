using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RowVehiclePoolMVC.Common;
using System.ComponentModel.DataAnnotations;

namespace RowVehiclePoolMVC.Models
{
    public class ShowPaging
    {
        [Required(ErrorMessage ="Value is Required!.")]
        [RegularExpression(@"^\n+$", ErrorMessage = "Only positive numbers allowed.")]
        [Range(1, 500, ErrorMessage = "Please enter a number between 1 and 500")]
        public int InputNumber { get; set; }
        public List<VehicleRequisition> DisplayResult { get; set; }

        public PageInfo PageInfo;
    }
}
