using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Accounts.EL
{
    public class CityEL : CountryEL
    {
        public Int64? IdCity { get; set; }
        public string CityCode { get; set; }
        public string CityName { get; set; }
    }
}
