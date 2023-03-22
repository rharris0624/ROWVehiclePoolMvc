using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RowVehiclePoolMVC.ViewModels
{
    public class AssignmentSearchVM
    {
        public IList<SelectListItem> BudgetList { get; set; }
        public IList<SelectListItem> RequestorList { get; set; }
        public IList<AssignmentDetail> Assignments { get; set; }
        public IList<SelectListItem> Statuses { get; set; }
        public int FromReqDateDay { get; set; }
        public int FromReqDateMonth { get; set; }
        public int FromReqDateYear { get; set; }
        public int ToReqDateDay { get; set; }
        public int ToReqDateMonth { get; set; }
        public int ToReqDateYear { get; set; }
        public string Requestor { get; set; }
        public string ReqBudget { get; set; }
        public string ReqStatus { get; set; }
        public string AssignTagNumber { get; set; }
        [Display(Name ="Requestor:")]
        public bool SearchRequestor { get; set; }
        [Display(Name ="Budget:")]
        public bool SearchBudget { get; set; }
        [Display(Name ="Status:")]
        public bool SearchStatus { get; set; }
        [Display(Name ="Requisition Date:")]
        public bool SearchRequisitionDate { get; set; }
        [Display(Name ="Assigned Tag Number:")]
        public bool SearchAssignTagNumber { get; set; }
        public int ServiceMonth { get; set; }
        public int ServiceYear { get; set; }
        public int ServiceDay { get; set; }
        public int Page { get; set; } = 1;
        public int PageCount { get; set; } = 0;
    }
}
