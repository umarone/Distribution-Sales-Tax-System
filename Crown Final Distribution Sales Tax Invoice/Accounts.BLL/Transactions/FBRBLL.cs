using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.SqlClient;
using System.Data;
using Accounts.DAL;
using Accounts.Common;
using Accounts.EL;

namespace Accounts.BLL
{
    public class FBRBLL
    {
        FBRDAL dal;
        public FBRBLL()
        {
            dal = new FBRDAL();  
        }
        public List<VouchersEL> GetFBRReportsByDate(Int64 IdProject, Int64 BookNo, int ITemSaleTaxType, DateTime StartDate, DateTime EndDate)
        {
            SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objConn.Open();
                return dal.GetFBRReportsByDate(IdProject, BookNo, ITemSaleTaxType, StartDate, EndDate, objConn);
            }
            catch (Exception ex)
            {
                objConn.Close();
                objConn.Dispose();
                throw ex;
            }
            finally
            {
                if (objConn.State == System.Data.ConnectionState.Open)
                {
                    objConn.Close();
                    objConn.Dispose();
                }
            }
        }
    }
}
