using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace DiHaoOA.DataContract.DAO
{
    public class EditUnSubordinateIADAO
    {

        /// <summary>
        /// update Information Assistant table
        /// </summary>
        /// <param name="employeeId"></param>
        /// <param name="informationAssistantId"></param>
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

        /// <summary>
        /// Check Employee whether exist
        /// </summary>
        /// <param name="employeeId"></param>
        /// <returns></returns>
        public bool IsEmployeeIdExist(string employeeId)
        {
            using (SqlConnection conn = new SqlConnection(DBHelper.GetConnection()))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = @"select EmployeeId
                                    from dbo.Employee
                                    where EmployeeId = @EmployeeId";
                cmd.Parameters.AddWithValue("@EmployeeId", employeeId);
                bool result = false;
                try
                {
                    conn.Open();
                    cmd.ExecuteScalar();
                    if (cmd.ExecuteScalar() != null)
                    {
                        result = true;
                    }
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    cmd.Dispose();
                    conn.Close();
                }
                return result;
            }
        }

        public void TransferCustomer(string employeeId, int informationAssistantId)
        {
            using (SqlConnection conn = new SqlConnection(DBHelper.GetConnection()))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
//                cmd.CommandText = @"select CustomerId
//                                    from Customer
//                                    where InformationAssistantId = @InformationAssistantId";
                cmd.CommandText = @"Update Customer
                                    Set EmployeeId=@EmployeeId
                                    Where InformationAssistantId = @InformationAssistantId";
                cmd.Parameters.AddWithValue("@InformationAssistantId", informationAssistantId);
                cmd.Parameters.AddWithValue("@EmployeeId", employeeId);
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    //SqlDataReader reader = cmd.ExecuteReader();
                    //while (reader.Read())
                    //{
                    //    UpdateCustomer(reader.GetInt32(0), employeeId);
                    //}
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


        /// <summary>
        /// Update employeeId in customer which need to transfer
        /// </summary>
        /// <param name="customerId"></param>
        /// <param name="employeeId"></param>
        private void UpdateCustomer(int customerId, string employeeId)
        {
            using (SqlConnection conn = new SqlConnection(DBHelper.GetConnection()))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = @"Update dbo.Customer
                                    Set EmployeeId=@EmployeeId
                                    where CustomerId = @CustomerId";
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
                finally
                {
                    cmd.Dispose();
                    conn.Close();
                }
            }
        }
    }
}
