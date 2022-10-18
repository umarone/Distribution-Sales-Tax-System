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
    public class CityDAL
    {
        IDataReader objReader;
        public EntityoperationInfo CreateCity(CityEL oelCity, SqlConnection objConn)
        {
            EntityoperationInfo infoResult = new EntityoperationInfo();
            using (SqlCommand cmdCity = new SqlCommand("[Setup].[Proc_CreateCity]", objConn))
            {
                cmdCity.CommandType = CommandType.StoredProcedure;
                cmdCity.Parameters.Add(new SqlParameter("@IdCity ", DbType.Int64)).Value = oelCity.IdCity;
                cmdCity.Parameters.Add(new SqlParameter("@IdCountry ", DbType.Int64)).Value = oelCity.IdCountry;
                cmdCity.Parameters.Add(new SqlParameter("@IdUser", DbType.Int64)).Value = oelCity.UserId;
                cmdCity.Parameters.Add(new SqlParameter("@CityCode", DbType.Int64)).Value = oelCity.CityCode;
                cmdCity.Parameters.Add(new SqlParameter("@CityName", DbType.String)).Value = oelCity.CityName;
                cmdCity.Parameters.Add(new SqlParameter("@CreatedDateTime", DbType.DateTime)).Value = oelCity.CreatedDateTime;
                cmdCity.Parameters.Add(new SqlParameter("@IsActive", DbType.Boolean)).Value = oelCity.IsActive;

                //if (cmdItems.ExecuteNonQuery() > -1 && cmdAccounts.ExecuteNonQuery() > -1)
                if (cmdCity.ExecuteNonQuery() > -1)
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
        public EntityoperationInfo UpdateCity(CityEL oelCity, SqlConnection objConn)
        {
            EntityoperationInfo infoResult = new EntityoperationInfo();
            using (SqlCommand cmdCity = new SqlCommand("[Setup].[Proc_UpdateCity]", objConn))
            {
                cmdCity.Parameters.Add(new SqlParameter("@IdCity ", DbType.Int64)).Value = oelCity.IdCity;
                cmdCity.Parameters.Add(new SqlParameter("@IdCountry ", DbType.Int64)).Value = oelCity.IdCountry;
                cmdCity.Parameters.Add(new SqlParameter("@IdUser", DbType.Int64)).Value = oelCity.UserId;
                cmdCity.Parameters.Add(new SqlParameter("@CityCode", DbType.Int64)).Value = oelCity.CityCode;
                cmdCity.Parameters.Add(new SqlParameter("@CityName", DbType.String)).Value = oelCity.CityName;
                cmdCity.Parameters.Add(new SqlParameter("@CreatedDateTime", DbType.DateTime)).Value = oelCity.CreatedDateTime;
                cmdCity.Parameters.Add(new SqlParameter("@IsActive", DbType.Boolean)).Value = oelCity.IsActive;

                //if (cmdItems.ExecuteNonQuery() > -1 && cmdAccounts.ExecuteNonQuery() > -1)
                if (cmdCity.ExecuteNonQuery() > -1)
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
        public EntityoperationInfo DeleteCity(Int64 IdCity, SqlConnection objConn)
        {
            EntityoperationInfo infoResult = new EntityoperationInfo();
            using (SqlCommand cmdCity = new SqlCommand("[Setup].[Proc_DeleteCity]", objConn))
            {
                cmdCity.CommandType = CommandType.StoredProcedure;
                cmdCity.Parameters.Add(new SqlParameter("@IdCity", DbType.Int64)).Value = IdCity;

                //if (cmdItems.ExecuteNonQuery() > -1 && cmdAccounts.ExecuteNonQuery() > -1)
                if (cmdCity.ExecuteNonQuery() > -1)
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
        public List<CityEL> GetCityById(Int64 IdCity, SqlConnection objConn)
        {
            List<CityEL> list = new List<CityEL>();
            SqlCommand cmdCity = new SqlCommand("[Setup].[Proc_GetCityById]", objConn);

            cmdCity.Parameters.Add("@IdCity", SqlDbType.BigInt).Value = IdCity;

            cmdCity.CommandType = CommandType.StoredProcedure;
            objReader = cmdCity.ExecuteReader();
            while (objReader.Read())
            {
                CityEL oelCity = new CityEL();
                oelCity.IdCountry = Validation.GetSafeLong(objReader["City_Id"]);
                oelCity.CityCode = Validation.GetSafeString(objReader["City_Code"]);
                oelCity.CityName = Validation.GetSafeString(objReader["City_Name"]);
                oelCity.UserId = Validation.GetSafeLong(objReader["User_Id"]);
                oelCity.IsActive = Validation.GetSafeBooleanNullable(objReader["IsActive"]);
                oelCity.CreatedDateTime = Validation.GetSafeDateTime(objReader["Created_DateTime"]);
                list.Add(oelCity);
            }
            return list;
        }
        public List<CityEL> GetAllCities(SqlConnection objConn)
        {
            List<CityEL> list = new List<CityEL>();
            SqlCommand cmdCity = new SqlCommand("[Setup].[Proc_GetAllCities]", objConn);
            cmdCity.CommandType = CommandType.StoredProcedure;
            objReader = cmdCity.ExecuteReader();
            while (objReader.Read())
            {
                CityEL oelCity = new CityEL();
                oelCity.IdCity = Validation.GetSafeLong(objReader["City_Id"]);
                oelCity.CityCode = Validation.GetSafeString(objReader["City_Code"]);
                oelCity.CityName = Validation.GetSafeString(objReader["City_Name"]);
                //oelCity.UserId = Validation.GetSafeLong(objReader["User_Id"]);
                oelCity.IsActive = Validation.GetSafeBooleanNullable(objReader["IsActive"]);
                oelCity.CreatedDateTime = Validation.GetSafeDateTime(objReader["Created_DateTime"]);
                
                list.Add(oelCity);
            }
            return list;
        }
    }
}
