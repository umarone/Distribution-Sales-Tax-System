using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.SqlClient;
using System.Data;
using Accounts.EL;
using Accounts.Common;


namespace Accounts.DAL
{
    public class FBRDAL
    {
        #region Variables
        IDataReader objReader;      
        #endregion
        public List<VouchersEL> GetFBRReportsByDate(Int64 IdProject, Int64 BookNo, int ITemSaleTaxType, DateTime StartDate, DateTime EndDate, SqlConnection objConn)
        {
            List<VouchersEL> list = new List<VouchersEL>();
            using (SqlCommand cmdVouchers = new SqlCommand("[Transactions].[Proc_GetFBRReportsByDate]", objConn))
            {
                cmdVouchers.CommandType = CommandType.StoredProcedure;
                cmdVouchers.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
                cmdVouchers.Parameters.Add("@BookNo", SqlDbType.BigInt).Value = BookNo;
                cmdVouchers.Parameters.Add("@ITemSaleTaxType", SqlDbType.BigInt).Value = ITemSaleTaxType;
                cmdVouchers.Parameters.Add("@StartDate", SqlDbType.DateTime).Value = StartDate;
                cmdVouchers.Parameters.Add("@EndDate", SqlDbType.DateTime).Value = EndDate;
                objReader = cmdVouchers.ExecuteReader();
                while (objReader.Read())
                {
                    //// Getting Purchases Voucher Header Here...
                    VouchersEL oelVoucher = new VouchersEL();
                    oelVoucher.NTN = Validation.GetSafeString(objReader["NTN"]);
                    oelVoucher.Cnic = Validation.GetSafeString(objReader["NIC"]);
                    oelVoucher.PersonName = Validation.GetSafeString(objReader["BuyerName"]);
                    oelVoucher.PersonType = Validation.GetSafeString(objReader["BuyerType"]);
                    oelVoucher.VoucherType = Validation.GetSafeString(objReader["DocumentType"]);
                    oelVoucher.VoucherNo = Validation.GetSafeLong(objReader["DocumentNumber"]);
                    oelVoucher.VDate = Validation.GetSafeDateTime(objReader["DocumentDate"]);
                    oelVoucher.TransactionMode = Validation.GetSafeString(objReader["SaleType"]);
                    oelVoucher.UnitPrice = Validation.GetSafeDecimal(objReader["Rate"]);
                    oelVoucher.Qty = Validation.GetSafeDecimal(objReader["Quantity"]);
                    oelVoucher.PackingSize = Validation.GetSafeString(objReader["PackingSize"]);
                    oelVoucher.DiscountAmount = Validation.GetSafeDecimal(objReader["ValueOfSalesExcludingSaleTax"]);
                    oelVoucher.SaleTaxFlatAmount = Validation.GetSafeDecimal(objReader["SaleTaxValue"]);
                    oelVoucher.OtherTaxFlatAmount = Validation.GetSafeDecimal(objReader["FurtherTax"]);
                    oelVoucher.TotalAmountAfterTax = Validation.GetSafeDecimal(objReader["FinalAmount"]);

                    list.Add(oelVoucher);
                }
            }
            return list;
        }
    }
}
