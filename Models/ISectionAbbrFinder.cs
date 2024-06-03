using System.Collections.Generic;

namespace RowVehiclePoolMVC.Models
{
    public interface ISectionAbbrFinder
    {
        public string Get(string longName);
        public IEnumerable<string> GetAll();
    }
}
