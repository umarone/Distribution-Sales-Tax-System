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
    public class CountryDAL
    {
        IDataReader objReader;
        public EntityoperationInfo CreateCountry(CountryEL oelCountry, SqlConnection objConn)
        {
            EntityoperationInfo infoResult = new EntityoperationInfo();
            using (SqlCommand cmdCountry = new SqlCommand("[Setup].[Proc_CreateCountry]", objConn))
            {
                cmdCountry.CommandType = CommandType.StoredProcedure;
                cmdCountry.Parameters.Add(new SqlParameter("@IdCountry", DbType.Int64)).Value = oelCountry.IdCountry;
                cmdCountry.Parameters.Add(new SqlParameter("@IdUser", DbType.Int64)).Value = oelCountry.UserId;
                cmdCountry.Parameters.Add(new SqlParameter("@CountryCode", DbType.Int64)).Value = oelCountry.CountryCode;
                cmdCountry.Parameters.Add(new SqlParameter("@CountryName", DbType.String)).Value = oelCountry.CountryName;
                cmdCountry.Parameters.Add(new SqlParameter("@CreatedDateTime", DbType.DateTime)).Value = oelCountry.CreatedDateTime;
                cmdCountry.Parameters.Add(new SqlParameter("@IsActive", DbType.Boolean)).Value = oelCountry.IsActive;

                //if (cmdItems.ExecuteNonQuery() > -1 && cmdAccounts.ExecuteNonQuery() > -1)
                if (cmdCountry.ExecuteNonQuery() > -1)
                {
                    infoResult.IsSuccess = true;
                }
                else
                {
                    infoResult.IsSuccess = false;
                }
            }
            return infoResult;
        }
        public EntityoperationInfo UpdateCountry(CountryEL oelCountry, SqlConnection objConn)
        {
            EntityoperationInfo infoResult = new EntityoperationInfo();
            using (SqlCommand cmdCountry = new SqlCommand("[Setup].[Proc_UpdateCountry]", objConn))
            {
                cmdCountry.CommandType = CommandType.StoredProcedure;
                cmdCountry.Parameters.Add(new SqlParameter("@IdCountry", DbType.Int64)).Value = oelCountry.IdCountry;
                cmdCountry.Parameters.Add(new SqlParameter("@IdUser", DbType.Int64)).Value = oelCountry.UserId;
                cmdCountry.Parameters.Add(new SqlParameter("@CountryCode", DbType.Int64)).Value = oelCountry.CountryCode;
                cmdCountry.Parameters.Add(new SqlParameter("@CountryName", DbType.String)).Value = oelCountry.CountryName;
                cmdCountry.Parameters.Add(new SqlParameter("@CreatedDateTime", DbType.DateTime)).Value = oelCountry.CreatedDateTime;
                cmdCountry.Parameters.Add(new SqlParameter("@IsActive", DbType.Boolean)).Value = oelCountry.IsActive;

                //if (cmdItems.ExecuteNonQuery() > -1 && cmdAccounts.ExecuteNonQuery() > -1)
                if (cmdCountry.ExecuteNonQuery() > -1)
                {
                    infoResult.IsSuccess = true;
                }
                else
                {
                    infoResult.IsSuccess = false;
                }
            }
            return infoResult;
        }
        public EntityoperationInfo DeleteCountry(Int64 IdCountry, SqlConnection objConn)
        {
            EntityoperationInfo infoResult = new EntityoperationInfo();
            using (SqlCommand cmdCountry = new SqlCommand("[Setup].[Proc_DeleteCountry]", objConn))
            {
                cmdCountry.CommandType = CommandType.StoredProcedure;
                cmdCountry.Parameters.Add(new SqlParameter("@IdCountry", DbType.Int64)).Value = IdCountry;

                //if (cmdItems.ExecuteNonQuery() > -1 && cmdAccounts.ExecuteNonQuery() > -1)
                if (cmdCountry.ExecuteNonQuery() > -1)
                {
                    infoResult.IsSuccess = true;
                }
                else
                {
                    infoResult.IsSuccess = false;
                }
            }
            return infoResult;
        }
        public List<CountryEL> GetCountryById(Int64 IdCountry, SqlConnection objConn)
        {
            List<CountryEL> list = new List<CountryEL>();
            SqlCommand cmdCountry = new SqlCommand("[Setup].[Proc_GetCountryById]", objConn);

            cmdCountry.Parameters.Add("@IdCountry", SqlDbType.BigInt).Value = IdCountry;

            cmdCountry.CommandType = CommandType.StoredProcedure;
            objReader = cmdCountry.ExecuteReader();
            while (objReader.Read())
            {
                CountryEL oelCountry = new CountryEL();
                oelCountry.IdCountry = Validation.GetSafeLong(objReader["Country_Id"]);
                oelCountry.CountryCode = Validation.GetSafeString(objReader["Country_Code"]);
                oelCountry.CountryName = Validation.GetSafeString(objReader["Country_Name"]);
                oelCountry.UserId = Validation.GetSafeLong(objReader["User_Id"]);
                oelCountry.IsActive = Validation.GetSafeBooleanNullable(objReader["IsActive"]);
                oelCountry.CreatedDateTime = Validation.GetSafeDateTime(objReader["Created_DateTime"]);
                list.Add(oelCountry);
            }
            return list;
        }
        public List<CountryEL> GetAllCountries(Int64 IdProject, SqlConnection objConn)
        {
            List<CountryEL> list = new List<CountryEL>();
            SqlCommand cmdCountry = new SqlCommand("[Setup].[Proc_GetAllCountries]", objConn);
            cmdCountry.CommandType = CommandType.StoredProcedure;
            objReader = cmdCountry.ExecuteReader();
            while (objReader.Read())
            {
                CountryEL oelCountry = new CountryEL();
                oelCountry.IdCountry = Validation.GetSafeLong(objReader["Country_Id"]);
                oelCountry.CountryCode = Validation.GetSafeString(objReader["Country_Code"]);
                oelCountry.CountryName = Validation.GetSafeString(objReader["Country_Name"]);
                oelCountry.UserId = Validation.GetSafeLong(objReader["User_Id"]);
                oelCountry.IsActive = Validation.GetSafeBooleanNullable(objReader["IsActive"]);
                oelCountry.CreatedDateTime = Validation.GetSafeDateTime(objReader["Created_DateTime"]);
                list.Add(oelCountry);
            }
            return list;
        }
    }
}
