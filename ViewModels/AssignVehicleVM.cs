using RowVehiclePoolMVC.Models;
using RowVehiclePoolMVC.Models.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RowVehiclePoolMVC.ViewModels
{
    public class AssignVehicleVM
    {
        [Key]
        public decimal AssignNo { get; set; }
        [Key]
        [Required]
        public int VehReqNo { get; set; }
        public string TagNumber { get; set; }
        [Display(Name = "Depart Date")]
        [DataType(DataType.DateTime)]
        //[DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DepartDate { get; set; }
        [DateGreaterThan("DepartDate", ErrorMessage = "Return Date must be greater than Depart Date")]
        [Display(Name = "Return Date")]
        [DataType(DataType.DateTime)]
        //[DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime ReturnDate { get; set; }
        [StringLength(500)]
        public string Comments { get; set; }
        [Display(Name = "Depart Time")]
        public string DepartTime { get; set; }
        [Display(Name = "Return Time")]
        public string ReturnTime { get; set; }
        public VehicleWeekVM VehicleWeek { get; set; }

    }
}
