using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Accounts.EL
{
    public class PersonsEL : RegionsEL
    {
        #region Persons
        public Int64? PAccountId
        {
            get;
            set;
        }
        public string Number
        {
            get;
            set;
        }
        public string PersonName
        {
            get;
            set;
        }
        public string Contact
        {
            get;
            set;
        }
        public string Salary
        {
            get;
            set;
        }
        public byte[] PersonPic
        {
            get;
            set;
        }
        public string Address
        {
            get;
            set;
        }
        public string PersonType
        {
            get;
            set;
        }
        public string NTN
        {
            get;
            set;
        }
        public string SaleTaxNo
        {
            get;
            set;
        }
        public decimal Balance
        {
            get;
            set;
        }
        public bool IsCustomer
        {
            get; 
            set;
        }
        public Int64 IdRegion
        {
            get;
            set;
        }
        public Int64 IdCity
        {
            get;
            set;
        }
        #endregion
    }
}
