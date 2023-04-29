using Microsoft.AspNetCore.Mvc.Rendering;
using RowVehiclePoolMVC.Common;
using RowVehiclePoolMVC.Models.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using RowVehiclePoolMVC.Models;

namespace RowVehiclePoolMVC.ViewModels
{
    public class VehicleRequestVM
    {
        private string _orderBy;
        private string _sortOrder;
        private int _page;

        public PageInfo  PageInfo { get; set; }
        public VehicleRequestVM()
        {
            _orderBy = "VehReqDate";
            _sortOrder = "DESCENDING";
            _page = 1;
        }

        public IList<ItemList> DepartTimeList{ get; set; }
        public IList<ItemList> ReturnTimeList { get; set; }

        public static string DefaultSortOrder = "DESCENDING";
        public static string SortingByDefault = "VehReqDate";
        [Display(Name = "Request ID")]
        [Key]
        public int VehReqNo { get; set; }
        [Display(Name = "Request Date")]
        public DateTime VehReqDate { get; set; }
        public string VehReqStatus { get; set; }
        [Display(Name ="Requestor")]
        public string VehRequestor { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name ="First Name")]
        public string RequestFirstName { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Last Name")]
        public string RequestLastName { get; set; }
        [StringLength(50)]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Vehicle Type")]
        public string VehType { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Destination")]
        public string Destination { get; set; }
        [Display(Name = "Last Chg UserId")]
        public string LastChangeUserid { get; set; }
        [Required]
        [StringLength(50)]
        public string Duties { get; set; }
        [Column(TypeName = "Integer")]
        [DisplayFormat(DataFormatString ="{0:n0}")]
        [Display(Name ="Number in Party")]
        public int NoInParty { get; set; }
        [Display(Name = "Division")]
        public string ReqDivision { get; set; }
        [Display(Name = "Section Id")]
        public string ReqSectionId { get; set; }
        [Required]
        [StringLength(3)]
        [Display(Name = "Budget")]
        public string ReqBudget { get; set; }
        [Display(Name = "Div Head")]
        public string NotificationDivHead { get; set; }
        [Display(Name = "Manager")]
        public string NotificationMan { get; set; }
        [Required]
        [StringLength(6)]
        [RegularExpression(@"^[0-9]*$", ErrorMessage = "Characters not allowed")]
        [Display(Name = "Job Number")]
        public string ReqJobNo { get; set; }
        [StringLength(4)]
        [Display(Name ="Function")]
        public string ReqFunction { get; set; }
        [Column("ReqFAP")]
        [StringLength(11)]
        [Display(Name = "FAP")]
        public string ReqFap { get; set; }
        [Display(Name ="Comments")]
        [StringLength(50)]
        public string ReqComments { get; set; }
        [Display(Name ="Depart Date")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime ReqDepartDate { get; set; }
        [Display(Name ="Depart Time")]
        public string ReqDepartTime { get; set; }
        [Display(Name = "Section Id")]
        public string ReqSectionID { get; set; }
        [Display(Name ="Return Date")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        [DateGreaterThan("ReqDepartDate",ErrorMessage = "Return Date must be greater than Depart Date")]
        public DateTime ReqReturnDate { get; set; }
        [Display(Name ="Return Time")]
        public string ReqReturnTime { get; set; }
        public List<VehicleRequisitionVM> VehicleRequisitions { get; set; }
        public bool FilterRequestor { get; set; }
        public bool FilterStatus { get; set; }
        public bool FilterRequestDate { get; set; }
        public IList<ItemList> Requestors { get; set; }
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime ReqFromDate { get; set; }
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime ReqToDate { get; set; }
        [Display(Name ="Tag #")]
        public string AssignedTagNo { get; set; }
        [Display(Name ="User Id")]
        public string UserId { get; set; }
    }
}
