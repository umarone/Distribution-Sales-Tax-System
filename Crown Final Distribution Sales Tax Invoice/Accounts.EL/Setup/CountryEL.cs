using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Accounts.EL
{
    public class CountryEL : AccountsEL
    {
        public Int64? IdCountry { get; set; }
        public string CountryCode { get; set; }
        public string CountryName { get; set; }
    }
}
