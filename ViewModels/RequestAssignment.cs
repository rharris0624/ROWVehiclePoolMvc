namespace RowVehiclePoolMVC.ViewModels
{
    public class RequestAssignment
    {    
        public int VehReqNo { get; set; }
        public decimal AssignNo { get; set; }
        public string Requestor { get; set; }
        public string lname { get; set; }
        public string fname { get; set; }
        public bool selected { get; set; }
    }
}
