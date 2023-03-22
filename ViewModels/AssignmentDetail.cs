using System;

namespace RowVehiclePoolMVC.ViewModels
{
    public class AssignmentDetail
    {
        public int VehReqNo { get; set; }
        public string Duties { get; set; }
        public DateTime VehReqDate { get; set; }
        public string Requestor { get; set; }
        public string VehType { get; set; }
        public string Destination { get; set; }
        public DateTime ReqDepartDate { get; set; }
        public DateTime ReqReturnDate { get; set; }
        public string ReqDivision { get; set; }
        public string ReqBudget { get; set; }
        public string AssignTagNo { get; set; }
        public string VehReqStatus { get; set; }
        public int NoInParty { get; set; }
        public string ReqComments { get; set; }
        public string JobNumber { get; set; }
        public string Function { get; set; }
        public string FAP { get; set; }
    }
}
