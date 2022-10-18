using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Accounts.EL
{
    public class CategoryEL : PersonsEL
    {
        public Int64? IdCategory { get; set; }        
        public string CategoryCode { get; set; }
        public string CategoryName { get; set; }
    }
}
