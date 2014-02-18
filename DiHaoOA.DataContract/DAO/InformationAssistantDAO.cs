using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace DiHaoOA.DataContract.DAO
{
    public class InformationAssistantDAO
    {
        public bool IsEmployeeActive(int informationAssistantId)
        {
            using (SqlConnection conn = new SqlConnection(DBHelper.GetConnection()))
            {
                SqlCommand cmd = new SqlCommand();
                bool isAcitive = false;
                cmd.Connection = conn;
                cmd.CommandText = @"Select e.IsActive
                                    From [InformationAssistant] i left outer join Employee e
                                    on i.EmployeeId = e.EmployeeId
                                    Where [InformationAssistantId] = @InformationAssistantId";
                cmd.Parameters.AddWithValue("@InformationAssistantId", informationAssistantId);
                try
                {
                    conn.Open();
                    isAcitive = Convert.ToBoolean(cmd.ExecuteScalar() == DBNull.Value ? "false" : cmd.ExecuteScalar());
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    conn.Close();
                    cmd.Dispose();
                }
                return isAcitive;
            }
           
        }

        public DataSet GetAll()
        {
            using (SqlConnection conn = new SqlConnection(DBHelper.GetConnection()))
            {
                SqlCommand cmd = new SqlCommand();
                DataSet ds = new DataSet();
                cmd.Connection = conn;
                cmd.CommandText = @"select InformationAssistantId,InformationAssistantName
                                    from dbo.InformationAssistant";
                try
                {
                    conn.Open();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(ds);
                    sda.Dispose();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    cmd.Dispose();
                    conn.Close();
                }
                return ds;
            }
        }

        public DataSet GetIAByEmployeeId(string employeeId)
        {
            using (SqlConnection conn = new SqlConnection(DBHelper.GetConnection()))
            {
                SqlCommand cmd = new SqlCommand();
                DataSet ds = new DataSet();
                cmd.Connection = conn;
                cmd.CommandText = @"select InformationAssistantId,InformationAssistantName
                                    from dbo.InformationAssistant
                                    where EmployeeId = @EmployeeId";
                cmd.Parameters.AddWithValue("@EmployeeId", employeeId);
                try
                {
                    conn.Open();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(ds);
                    sda.Dispose();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    cmd.Dispose();
                    conn.Close();
                }
                return ds;
            }
        }

        public void Delete(int informationAssistantId)
        {
            using (SqlConnection conn = new SqlConnection(DBHelper.GetConnection()))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = @"Update dbo.InformationAssistant 
                                    Set EmployeeId=@BalckEmployeeId 
                                    Where InformationAssistantId = @InformationAssistantId";
                cmd.Parameters.AddWithValue("@InformationAssistantId", informationAssistantId);
                cmd.Parameters.AddWithValue("@BalckEmployeeId",DBHelper.GetBlackListEmployee());
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    conn.Close();
                    cmd.Dispose();
                }
            }
        }

        public DataSet GetInformationAssistant(int pageIndex,int pageSize,string input,string procedureName)
        {
            DataSet result = new DataSet();
            SqlConnection conn = null;
            SqlCommand cmd = null;
            SqlDataAdapter sda = null;
            try
            {
                using (conn = new SqlConnection(DBHelper.GetConnection()))
                {
                    cmd = new SqlCommand(procedureName, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter pageIndexP = cmd.Parameters.Add("@pageIndex", SqlDbType.Int);
                    SqlParameter pageSizeP = cmd.Parameters.Add("@pageSize", SqlDbType.Int);
                    SqlParameter inputP = cmd.Parameters.Add("@input", SqlDbType.NVarChar, 500);
                    SqlParameter blackEmployeeIdP = cmd.Parameters.Add("@BlackEmployeeId", SqlDbType.NVarChar, 50);
                    SqlParameter totalRecordsP = cmd.Parameters.Add("@TotalRecords", SqlDbType.Int);
                    pageIndexP.Value = pageIndex;
                    pageSizeP.Value = pageSize;
                    inputP.Value = input;
                    blackEmployeeIdP.Value = DBHelper.GetBlackListEmployee();
                    totalRecordsP.Direction = ParameterDirection.Output;
                    sda = new SqlDataAdapter(cmd);
                    sda.Fill(result);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
                conn.Dispose();
                sda.Dispose();
                cmd.Dispose();
            }
            return result;
        }

        public int GetTotalRecords(int pageIndex, int pageSize, string input,string procedureName)
        {
            DataSet result = new DataSet();
            SqlConnection conn = null;
            SqlCommand cmd = null;
            SqlDataAdapter sda = null;
            int totalRecords = 0;
            try
            {
                using (conn = new SqlConnection(DBHelper.GetConnection()))
                {
                    cmd = new SqlCommand(procedureName, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter pageIndexP = cmd.Parameters.Add("@pageIndex", SqlDbType.Int);
                    SqlParameter pageSizeP = cmd.Parameters.Add("@pageSize", SqlDbType.Int);
                    SqlParameter inputP = cmd.Parameters.Add("@input", SqlDbType.NVarChar, 500);
                    SqlParameter blackEmployeeIdP = cmd.Parameters.Add("@BlackEmployeeId", SqlDbType.NVarChar, 50);
                    SqlParameter totalRecordsP = cmd.Parameters.Add("@TotalRecords", SqlDbType.Int);
                    pageIndexP.Value = pageIndex;
                    pageSizeP.Value = pageSize;
                    inputP.Value = input;
                    blackEmployeeIdP.Value = DBHelper.GetBlackListEmployee();
                    totalRecordsP.Direction = ParameterDirection.Output;
                    sda = new SqlDataAdapter(cmd);
                    sda.Fill(result);
                    totalRecords = Convert.ToInt32(totalRecordsP.Value);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
                conn.Dispose();
                sda.Dispose();
                cmd.Dispose();
            }
            return totalRecords;
        }

        public void SetUnSunordinate(int informationAssistantId)
        {
            using (SqlConnection conn = new SqlConnection(DBHelper.GetConnection()))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = @"Update Customer
                                    Set InformationAssistantId=null
                                    where InformationAssistantId=@InformationAssistantId";
                cmd.Parameters.AddWithValue("@InformationAssistantId", informationAssistantId);
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    conn.Close();
                    cmd.Dispose();
                }

            }
        }

        public void TransferInformationAssistant(string employeeId, int informationAssistantId)
        {
            using (SqlConnection conn = new SqlConnection(DBHelper.GetConnection()))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = @"Update dbo.InformationAssistant
                                    Set EmployeeId=@EmployeeId
                                    where InformationAssistantId = @InformationAssistantId";
                cmd.Parameters.AddWithValue("@EmployeeId", employeeId);
                cmd.Parameters.AddWithValue("@InformationAssistantId", informationAssistantId);
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    cmd.Dispose();
                    conn.Close();
                }
            }
        }

    }
}
