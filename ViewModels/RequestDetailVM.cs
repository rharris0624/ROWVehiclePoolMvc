using RowVehiclePoolMVC.Common;
using RowVehiclePoolMVC.Models.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RowVehiclePoolMVC.ViewModels
{
    public class RequestDetailVM
    {
        [Key]
        public int VehicleRequestNumber { get; set; }
        [Display(Name ="Requestor")]
        public string Requestor { get; set; }
        public string Destination { get; set; }
        public string Duties { get; set; }
        [Display(Name ="Number In Party")]
        [DisplayFormat(DataFormatString ="{0:n0}")]
        public decimal NoInParty { get; set; }
        public string Budget { get; set; }
        [Display(Name ="Job Number")]
        public string JobNo { get; set; }
        public string Function { get; set; }
        [Display(Name = "FAP")]
        public string Fap { get; set; }
        public string Comments { get; set; }
        [Display(Name = "Departure Date")]
        public DateTime DepartDate { get; set; }
        [Display(Name = "Return Date")]
        public DateTime ReturnDate { get; set; }
        [Display(Name ="User ID")]
        public string UserId { get; set; }
        public string TagNumber { get; set; }
    }
}
