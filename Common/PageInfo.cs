using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RowVehiclePoolMVC.Context;

namespace RowVehiclePoolMVC.Common
{
    public class PageInfo 
    {
        private RvpAppContext _context;
        public int TotalItems { get; set; }
        public int ItemsPerPage { get; set; }
        public int CurrentPage { get; set; }
        public PageInfo()
        {
    
        }
        public PageInfo(RvpAppContext context)
        {
            CurrentPage = 1;
            ItemsPerPage = 40;
            _context = context;
            TotalItems = _context.VehicleRequisition.Count();
        }
        public int PageStart { get { return ((CurrentPage - 1) * ItemsPerPage); } }
        public int PageEnd 
        { 
            get 
            {
                int CurrentTotal = (CurrentPage - 1) * ItemsPerPage + ItemsPerPage;
                return (CurrentTotal < TotalItems ? CurrentTotal : TotalItems);
            }
        }
        public int LastPage
        {
            get 
            {
                if (TotalItems == 0)
                    return 1;
                return (int)Math.Ceiling((decimal)TotalItems / ItemsPerPage); 
            }
        }
    }
}
