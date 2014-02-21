using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace DiHaoOA.DataContract.DAO
{
    public class CustomerDAO
    {
        public void TransferCustomer(int customerId,string employeeId)
        {
            using (SqlConnection conn = new SqlConnection(DBHelper.GetConnection()))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = @"Update Customer
                                    Set EmployeeId=@EmployeeId
                                    where CustomerId=@CustomerId";
                cmd.Parameters.AddWithValue("@EmployeeId", employeeId);
                cmd.Parameters.AddWithValue("@CustomerId", customerId);
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally {
                    conn.Close();
                    cmd.Dispose();
                }

            }
        }

        public void Delete(int customerId)
        {
            using (SqlConnection conn = new SqlConnection(DBHelper.GetConnection()))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = @"Update Customer 
                                    Set EmployeeId=@BalckEmployeeId 
                                    Where CustomerId = @CustomerId";
                cmd.Parameters.AddWithValue("@CustomerId", customerId);
                cmd.Parameters.AddWithValue("@BalckEmployeeId", DBHelper.GetBlackListEmployee());
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

        public DataSet GetCustomerList(int pageIndex,int pageSize,string input,string procedureName)
        {
            using (SqlConnection conn = new SqlConnection(DBHelper.GetConnection()))
            {
                DataSet result = new DataSet();
                SqlCommand cmd = new SqlCommand(procedureName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pageIndex", pageIndex);
                cmd.Parameters.AddWithValue("@pageSize", pageSize);
                cmd.Parameters.AddWithValue("@input", input);
                cmd.Parameters.AddWithValue("@BlackEmployeeId", DBHelper.GetBlackListEmployee());
                cmd.Parameters.AddWithValue("@TotalRecords", 0);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                try
                {
                    conn.Open();
                    sda.Fill(result);
                    sda.Dispose();
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
                return result;
            }
        }

        public int GetTotalRecords(int pageIndex, int pageSize, string input, string procedureName)
        {
            using (SqlConnection conn = new SqlConnection(DBHelper.GetConnection()))
            {
                int total = 0;
                SqlCommand cmd = new SqlCommand(procedureName, conn);
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
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    total = Convert.ToInt32(totalRecordsP.Value);
                    sda.Dispose();
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
                return total;
            }
        }

        public void SetUnSunordinate(int informationAssistantId)
        {
            using (SqlConnection conn = new SqlConnection(DBHelper.GetConnection()))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = @"Update Customer
                                    Set InformationAssistantId=null,
                                    InformationAssistantId = @InformationAssistantId
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

        public int GetInformationAssistantIdByCustomerId(int customerId)
        {

            using (SqlConnection conn = new SqlConnection(DBHelper.GetConnection()))
            {
                SqlCommand cmd = new SqlCommand();
                int result = 0;
                cmd.Connection = conn;
                cmd.CommandText = @"select InformationAssistantId
                                    from dbo.Customer
                                    where CustomerId = @CustomerId";
                cmd.Parameters.AddWithValue("@CustomerId", customerId);
                try
                {
                    conn.Open();
                    result = cmd.ExecuteScalar() == DBNull.Value ? -1 : Convert.ToInt32(cmd.ExecuteScalar());
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
                return result;
            }
        }

        public DataSet GetSubmittedCustomer(int pageIndex,int pageSize,string input,string procedureName)
        {
            using (SqlConnection conn = new SqlConnection(DBHelper.GetConnection()))
            {
                DataSet result = new DataSet();
                SqlCommand cmd = new SqlCommand(procedureName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pageIndex", pageIndex);
                cmd.Parameters.AddWithValue("@pageSize", pageSize);
                cmd.Parameters.AddWithValue("@input", input);
                cmd.Parameters.AddWithValue("@BlackEmployeeId", DBHelper.GetBlackListEmployee());
                cmd.Parameters.AddWithValue("@TotalRecords", 0);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                try
                {
                    conn.Open();
                    sda.Fill(result);
                    sda.Dispose();
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
                return result;
            }
        }

        public DataSet GetOrderByOrderStatus(int pageIndex,int pageSize,string input,string orderStatus)
        {
            using (SqlConnection conn = new SqlConnection(DBHelper.GetConnection()))
            {
                DataSet result = new DataSet();
                SqlCommand cmd = new SqlCommand("pro_GetOrderByOrderStatus", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pageIndex", pageIndex);
                cmd.Parameters.AddWithValue("@pageSize", pageSize);
                cmd.Parameters.AddWithValue("@orderStatus",orderStatus);
                cmd.Parameters.AddWithValue("@input", input);
                cmd.Parameters.AddWithValue("@BlackEmployeeId", DBHelper.GetBlackListEmployee());
                cmd.Parameters.AddWithValue("@TotalRecords", 0);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                try
                {
                    conn.Open();
                    sda.Fill(result);
                    sda.Dispose();
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
                return result;
            }
        }
    }
}
