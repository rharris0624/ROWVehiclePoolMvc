using RowVehiclePoolMVC.Models;
using RowVehiclePoolMVC.Models.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RowVehiclePoolMVC.ViewModels
{
    public class VehicleAssignmentVM
    {
        public VehicleAssignment VehicleAssignment { get; set; }
        public VehicleWeekVM VehicleWeek { get; set; }
        public int VehReqNo { get; set; }
        public string TagNumber { get; set; }
        [Display(Name = "Depart Date")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DepartDate { get; set; }
        [DateGreaterThan("ReqDepartDate", ErrorMessage = "Return Date must be greater than Depart Date")]
        [Display(Name = "Return Date")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime ReturnDate { get; set; }
        [StringLength(500)]
        public string Comment { get; set; }
        [Display(Name ="Depart Time")]
        public string DepartTime { get; set; }
        [Display(Name ="Return Time")]
        public string ReturnTime { get; set; }
    }
}
