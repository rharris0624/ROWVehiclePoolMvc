using System.Collections.Generic;

namespace RowVehiclePoolMVC.Models
{
    public class SectionAbbrFinder : ISectionAbbrFinder
    {
        private Dictionary<string, string> _sectionAbbreviations = new Dictionary<string, string>()
        {
            {"Right of Way Admin" ,"RWAD"},
            {"Administrative Office","RWAM"},
            {"Right of Way Appraisals" ,"RWAP"},
            {"Right of Way Acquisitions" ,"RWAQ"},
            {"Right of Way Beautifi" ,"RWBE"},
            {"Right of Way Engineering" ,"RWEN"},
            {"Right of Way Relocation" ,"RWRL"},
            {"Right of Way Utilities" ,"RWUT"},
        };
        public string Get(string longName)
        {
            var result =  _sectionAbbreviations[longName];
            return result ?? string.Empty;
        }

        public IEnumerable<string> GetAll()
        {
            return _sectionAbbreviations.Keys;
        }
    }
}
