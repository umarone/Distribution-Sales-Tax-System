using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Accounts.DAL;
using Accounts.Common;
using Accounts.EL;
using System.Data.SqlClient;

namespace Accounts.BLL
{
    public class RegionsBLL
    {
        RegionsDAL dal;
        public RegionsBLL()
        {
            dal = new RegionsDAL();
        }
        public EntityoperationInfo CreateRegion(RegionsEL oelRegion)
        {
            SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objConn.Open();
                return dal.CreateRegion(oelRegion, objConn);
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
        public EntityoperationInfo UpdateRegion(RegionsEL oelRegion)
        {
            SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objConn.Open();
                return dal.UpdateRegion(oelRegion, objConn);
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
        public EntityoperationInfo DeleteRegion(Int64 IdRegion)
        {
            SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objConn.Open();
                return dal.DeleteRegion(IdRegion, objConn);
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
        public List<RegionsEL> GetRegionById(Int64 IdRegion)
        {
            SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objConn.Open();
                return dal.GetRegionById(IdRegion, objConn);
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
        public List<RegionsEL> GetAllRegions()
        {
            SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objConn.Open();
                return dal.GetAllRegions(objConn);
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
        public List<RegionsEL> GetAllRegionsByCity(Int64 IdCity)
        {
            SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objConn.Open();
                return dal.GetAllRegionsByCity(IdCity, objConn);
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
