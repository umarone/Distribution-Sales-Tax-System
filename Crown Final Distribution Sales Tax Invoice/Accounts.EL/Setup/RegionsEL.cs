using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Accounts.EL
{
    public class RegionsEL : CityEL
    {
        public Int64? IdRegion { get; set; }
        public string RegionCode { get; set; }
        public string RegionName { get; set; }
        public Int32 RegionType { get; set; }
        public string RegionSubType { get; set; }        
    }
}
