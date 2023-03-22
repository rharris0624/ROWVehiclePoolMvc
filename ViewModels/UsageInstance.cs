using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RowVehiclePoolMVC.ViewModels
{
    public class UsageInstance
    {
        public string TagNumber { get; set; }
        public decimal AssignNo { get; set; }
        public DateTime UsageDepartDate { get; set; }
        public DateTime UsageReturnDate { get; set; }
        public string Requestor { get; set; }
    }
}
