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
    public class RegionsDAL
    {
        IDataReader objReader;
        public EntityoperationInfo CreateRegion(RegionsEL oelRegion, SqlConnection objConn)
        {
            EntityoperationInfo infoResult = new EntityoperationInfo();
            using (SqlCommand cmdRegion = new SqlCommand("[Setup].[Proc_CreateRegion]", objConn))
            {
                cmdRegion.CommandType = CommandType.StoredProcedure;
                cmdRegion.Parameters.Add(new SqlParameter("@IdRegion", DbType.Int64)).Value = oelRegion.IdRegion;
                cmdRegion.Parameters.Add(new SqlParameter("@IdCity ", DbType.Int64)).Value = oelRegion.IdCity;
                cmdRegion.Parameters.Add(new SqlParameter("@IdUser", DbType.Int64)).Value = oelRegion.UserId;
                cmdRegion.Parameters.Add(new SqlParameter("@RegionCode", DbType.Int64)).Value = oelRegion.RegionCode;
                cmdRegion.Parameters.Add(new SqlParameter("@RegionName", DbType.String)).Value = oelRegion.RegionName;
                cmdRegion.Parameters.Add(new SqlParameter("@RegionType", DbType.String)).Value = oelRegion.RegionType;
                cmdRegion.Parameters.Add(new SqlParameter("@CreatedDateTime", DbType.DateTime)).Value = oelRegion.CreatedDateTime;
                cmdRegion.Parameters.Add(new SqlParameter("@IsActive", DbType.Boolean)).Value = oelRegion.IsActive;

                if (cmdRegion.ExecuteNonQuery() > -1)
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
        public EntityoperationInfo UpdateRegion(RegionsEL oelRegion, SqlConnection objConn)
        {
            EntityoperationInfo infoResult = new EntityoperationInfo();
            using (SqlCommand cmdRegion = new SqlCommand("[Setup].[Proc_UpdateRegion]", objConn))
            {
                cmdRegion.Parameters.Add(new SqlParameter("@IdRegion", DbType.Int64)).Value = oelRegion.IdRegion;
                cmdRegion.Parameters.Add(new SqlParameter("@IdCity ", DbType.Int64)).Value = oelRegion.IdCity;
                cmdRegion.Parameters.Add(new SqlParameter("@IdUser", DbType.Int64)).Value = oelRegion.UserId;
                cmdRegion.Parameters.Add(new SqlParameter("@RegionCode", DbType.Int64)).Value = oelRegion.RegionCode;
                cmdRegion.Parameters.Add(new SqlParameter("@RegionName", DbType.String)).Value = oelRegion.RegionName;
                cmdRegion.Parameters.Add(new SqlParameter("@RegionType", DbType.String)).Value = oelRegion.RegionType;
                cmdRegion.Parameters.Add(new SqlParameter("@CreatedDateTime", DbType.DateTime)).Value = oelRegion.CreatedDateTime;
                cmdRegion.Parameters.Add(new SqlParameter("@IsActive", DbType.Boolean)).Value = oelRegion.IsActive;
                if (cmdRegion.ExecuteNonQuery() > -1)
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
        public EntityoperationInfo DeleteRegion(Int64 IdRegion, SqlConnection objConn)
        {
            EntityoperationInfo infoResult = new EntityoperationInfo();
            using (SqlCommand cmdRegion = new SqlCommand("[Setup].[Proc_DeleteRegion]", objConn))
            {
                cmdRegion.CommandType = CommandType.StoredProcedure;
                cmdRegion.Parameters.Add(new SqlParameter("@IdRegion", DbType.Int64)).Value = IdRegion;

                //if (cmdItems.ExecuteNonQuery() > -1 && cmdAccounts.ExecuteNonQuery() > -1)
                if (cmdRegion.ExecuteNonQuery() > -1)
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
        public List<RegionsEL> GetRegionById(Int64 IdRegion, SqlConnection objConn)
        {
            List<RegionsEL> list = new List<RegionsEL>();
            SqlCommand cmdCity = new SqlCommand("[Setup].[Proc_GetRegionById]", objConn);

            cmdCity.Parameters.Add("@IdRegion", SqlDbType.BigInt).Value = IdRegion;

            cmdCity.CommandType = CommandType.StoredProcedure;
            objReader = cmdCity.ExecuteReader();
            while (objReader.Read())
            {
                RegionsEL oelRegion = new RegionsEL();
                
                oelRegion.IdRegion = Validation.GetSafeLong(objReader["Region_Id"]);
                oelRegion.IdCity = Validation.GetSafeLong(objReader["City_Id"]);
                oelRegion.RegionCode = Validation.GetSafeString(objReader["Region_Code"]);
                oelRegion.RegionName = Validation.GetSafeString(objReader["Region_Name"]);
                oelRegion.RegionType = Validation.GetSafeInteger(objReader["Region_Type"]);
                oelRegion.RegionSubType = Validation.GetSafeString(objReader["RegionType"]);
                oelRegion.UserId = Validation.GetSafeLong(objReader["User_Id"]);
                oelRegion.IsActive = Validation.GetSafeBooleanNullable(objReader["IsActive"]);
                oelRegion.CreatedDateTime = Validation.GetSafeDateTime(objReader["Created_DateTime"]);
                
                list.Add(oelRegion);
            }
            return list;
        }
        public List<RegionsEL> GetAllRegions(SqlConnection objConn)
        {
            List<RegionsEL> list = new List<RegionsEL>();
            SqlCommand cmdCategory = new SqlCommand("[Setup].[Proc_GetAllRegions]", objConn);
            cmdCategory.CommandType = CommandType.StoredProcedure;
            objReader = cmdCategory.ExecuteReader();
            while (objReader.Read())
            {
                RegionsEL oelRegion = new RegionsEL();

                oelRegion.IdRegion = Validation.GetSafeLong(objReader["Region_Id"]);
                oelRegion.IdCity = Validation.GetSafeLong(objReader["City_Id"]);
                oelRegion.RegionCode = Validation.GetSafeString(objReader["Region_Code"]);
                oelRegion.RegionName = Validation.GetSafeString(objReader["Region_Name"]);
                oelRegion.CityName = Validation.GetSafeString(objReader["City_Name"]);
                oelRegion.RegionType = Validation.GetSafeInteger(objReader["Region_Type"]);
                oelRegion.RegionSubType = Validation.GetSafeString(objReader["RegionType"]);
                oelRegion.UserId = Validation.GetSafeLong(objReader["User_Id"]);
                oelRegion.IsActive = Validation.GetSafeBooleanNullable(objReader["IsActive"]);
                oelRegion.CreatedDateTime = Validation.GetSafeDateTime(objReader["Created_DateTime"]);

                list.Add(oelRegion);

            }
            return list;
        }
        public List<RegionsEL> GetAllRegionsByCity(Int64 IdCity, SqlConnection objConn)
        {
            List<RegionsEL> list = new List<RegionsEL>();
            SqlCommand cmdRegion = new SqlCommand("[Setup].[Proc_GetRegionByCityId]", objConn);
            cmdRegion.Parameters.Add("@IdCity", SqlDbType.BigInt).Value = IdCity;
            cmdRegion.CommandType = CommandType.StoredProcedure;
            objReader = cmdRegion.ExecuteReader();
            while (objReader.Read())
            {
                RegionsEL oelRegion = new RegionsEL();

                oelRegion.IdRegion = Validation.GetSafeLong(objReader["Region_Id"]);
                oelRegion.IdCity = Validation.GetSafeLong(objReader["City_Id"]);
                oelRegion.RegionCode = Validation.GetSafeString(objReader["Region_Code"]);
                oelRegion.RegionName = Validation.GetSafeString(objReader["Region_Name"]);
                oelRegion.CityName = Validation.GetSafeString(objReader["City_Name"]);
                oelRegion.RegionType = Validation.GetSafeInteger(objReader["Region_Type"]);
                oelRegion.RegionSubType = Validation.GetSafeString(objReader["RegionType"]);
                oelRegion.UserId = Validation.GetSafeLong(objReader["User_Id"]);
                oelRegion.IsActive = Validation.GetSafeBooleanNullable(objReader["IsActive"]);
                oelRegion.CreatedDateTime = Validation.GetSafeDateTime(objReader["Created_DateTime"]);

                list.Add(oelRegion);

            }
            return list;
        }
    }
}
