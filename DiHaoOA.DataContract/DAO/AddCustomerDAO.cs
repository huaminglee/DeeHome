using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DiHaoOA.DataContract.Entity;
using System.Data.SqlClient;

namespace DiHaoOA.DataContract.DAO
{
    public class AddCustomerDAO
    {
        EditMessengerDAO editMessengerDao;

        public AddCustomerDAO()
        {
            editMessengerDao = new EditMessengerDAO();
        }

        public void SaveCustomer(Customer customer, Order order)
        {
            using (SqlConnection conn = new SqlConnection(DBHelper.GetConnection()))
            {
                
                SqlTransaction tran = null;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                try
                {
                    conn.Open();
                    tran = conn.BeginTransaction();
                    cmd.Transaction = tran;
                    cmd.CommandText = @"insert into Customer values(@CustomerId,
                                        @CompanyName,@ContactPerson,@ContactPersonNumber,
                                        @ContactPerson2,@ContactPerson2Number,@ContactPerson3,
                                        @ContactPerson3Number,@City,@UsableArea,@Email,@DecorationAddress,
                                        @RidePath,@AppointDateTime,@ProviderType,@CustomerType,@Comments,
                                        @InformationAssistantId,@EmployeeId,@WorkPlace)";
                    cmd.Parameters.AddWithValue("@CustomerId", customer.CustomerId);
                    cmd.Parameters.AddWithValue("@CompanyName", customer.CompanyName);
                    cmd.Parameters.AddWithValue("@ContactPerson", customer.ContactPerson);
                    cmd.Parameters.AddWithValue("@ContactPersonNumber", customer.ContactPersonNumber);
                    cmd.Parameters.AddWithValue("@ContactPerson2", customer.ContactPerson2);
                    cmd.Parameters.AddWithValue("@ContactPerson2Number", customer.ContactPerson2Number);
                    cmd.Parameters.AddWithValue("@ContactPerson3", customer.ContactPerson3);
                    cmd.Parameters.AddWithValue("@ContactPerson3Number", customer.Contactperson3Number);
                    cmd.Parameters.AddWithValue("@City", customer.City);
                    cmd.Parameters.AddWithValue("@UsableArea", customer.UsableArea);
                    cmd.Parameters.AddWithValue("@Email", customer.Email);
                    cmd.Parameters.AddWithValue("@DecorationAddress", customer.DecorationAddress);
                    cmd.Parameters.AddWithValue("@RidePath", customer.RidePath);
                    cmd.Parameters.AddWithValue("@AppointDateTime", customer.AppointDateTime);
                    cmd.Parameters.AddWithValue("@ProviderType", customer.ProviderType);
                    cmd.Parameters.AddWithValue("@CustomerType", customer.CustomerType);
                    cmd.Parameters.AddWithValue("@Comments", customer.Comments);
                    cmd.Parameters.AddWithValue("@InformationAssistantId", customer.InformationAssistants.InformationAssistantId);
                    cmd.Parameters.AddWithValue("@EmployeeId",customer.Employees.EmployeeId);
                    cmd.Parameters.AddWithValue("@WorkPlace", customer.WorkPlace);
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = @"Insert into CustomerOrder values(
                                        @OrderNumber,@RecordDate,
                                        null,@OrderStatus,@CustomerOrderId)";
                    cmd.Parameters.AddWithValue("@OrderNumber", order.OrderNumber);
                    cmd.Parameters.AddWithValue("@RecordDate", order.RecordDate);
                    //cmd.Parameters.AddWithValue("@InformationAssistantOrderId", order.InformationAssistant.InformationAssistantId);
                    cmd.Parameters.AddWithValue("@OrderStatus", order.OrderStatus);
                    cmd.Parameters.AddWithValue("@CustomerOrderId", order.Customers.CustomerId);
                    cmd.ExecuteNonQuery();
                    tran.Commit();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    throw ex;
                }
                finally
                {
                    conn.Close();
                    cmd.Dispose();
                    tran.Dispose();

                }
            }
        }


        public void UpdateLevelToCopper(InformationAssistant ia)
        {
            using (SqlConnection conn = new SqlConnection(DBHelper.GetConnection()))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = @"Update dbo.InformationAssistant
                                    Set InformationLevel = @InformationLevel
                                    Where InformationAssistantId = @InformationAssistantId";
                cmd.Parameters.AddWithValue("@InformationLevel", InformationAssistantLevels.Copper);
                cmd.Parameters.AddWithValue("@InformationAssistantId", ia.InformationAssistantId);
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

        public int GetCustomerId()
        {
            using (SqlConnection conn = new SqlConnection(DBHelper.GetConnection()))
            {
                int result = 0;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = @"select max(CustomerId) from Customer";
                try
                {
                    conn.Open();
                    result = cmd.ExecuteScalar() == DBNull.Value ? 0 : Convert.ToInt32(cmd.ExecuteScalar());
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
                return result + 1;
            }

        }

        public bool IsPhoneNumberExist(string phoneNumber)
        {
            using (SqlConnection con = new SqlConnection(DBHelper.GetConnection()))
            {
                string result;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = @"select ContactPersonNumber 
                                    from Customer
                                    where ContactPersonNumber = @ContactPersonNumber";
                cmd.Parameters.AddWithValue("@ContactPersonNumber", phoneNumber);
                try
                {
                    con.Open();
                    result = Convert.ToString(cmd.ExecuteScalar());
                    if (cmd.ExecuteScalar() != null)
                    {
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {

                    con.Close();
                    cmd.Dispose();
                }
            }
            return false;
        }

        public bool IsPhoneNumber2Exist(string phoneNumber2)
        {
            using (SqlConnection con = new SqlConnection(DBHelper.GetConnection()))
            {
                string result;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = @"select ContactPersonNumber 
                                    from Customer
                                    where ContactPerson2Number = @ContactPerson2Number";
                cmd.Parameters.AddWithValue("@ContactPerson2Number", phoneNumber2);
                try
                {
                    con.Open();
                    result = Convert.ToString(cmd.ExecuteScalar());
                    if (cmd.ExecuteScalar() != null)
                    {
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {

                    con.Close();
                    cmd.Dispose();
                }
            }
            return false;
        }

        public bool IsPhoneNumber3Exist(string phoneNumber3)
        {
            using (SqlConnection con = new SqlConnection(DBHelper.GetConnection()))
            {
                string result;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = @"select ContactPersonNumber 
                                    from Customer
                                    where ContactPerson3Number = @ContactPerson3Number";
                cmd.Parameters.AddWithValue("@ContactPerson3Number", phoneNumber3);
                try
                {
                    con.Open();
                    result = Convert.ToString(cmd.ExecuteScalar());
                    if (cmd.ExecuteScalar() != null)
                    {
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {

                    con.Close();
                    cmd.Dispose();
                }
            }
            return false;
        }

        public string GetNotifyMsgIfNumberExist(string phoneNumber)
        {
            using (SqlConnection conn = new SqlConnection(DBHelper.GetConnection()))
            {
                string result = string.Empty;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = @"select c.InformationAssistantId ,RecordDate,o.OrderNumber,OrderStatus 
                                    from dbo.CustomerOrder o ,dbo.Customer c 
                                    where o.CustomerId = c.CustomerId
                                    and c.ContactPersonNumber = @ContactPersonNumber";
                cmd.Parameters.AddWithValue("@ContactPersonNumber", phoneNumber);
                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        string recordate = reader.GetDateTime(1).ToString();
                        string employeeName = GetEmployeeNameByIAId(reader.GetInt32(0));
                        int OrderNumber = reader.GetInt32(2);
                        string OrderStatus = reader.GetString(3);
                        result = "* " + OrderNumber + " " + OrderStatus + "  " + employeeName + "  " + recordate;
                    }
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

        public string GetNotifyMsgIfNumber2Exist(string phoneNumber2)
        {
            using (SqlConnection conn = new SqlConnection(DBHelper.GetConnection()))
            {
                string result = string.Empty;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = @"select c.InformationAssistantId ,RecordDate,o.OrderNumber,OrderStatus  
                                    from dbo.CustomerOrder o ,dbo.Customer c 
                                    where o.CustomerId = c.CustomerId
                                    and c.ContactPerson2Number = @ContactPerson2Number";
                cmd.Parameters.AddWithValue("@ContactPerson2Number", phoneNumber2);
                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        string recordate = reader.GetDateTime(1).ToString();
                        string employeeName = GetEmployeeNameByIAId(reader.GetInt32(0));
                        int OrderNumber = reader.GetInt32(2);
                        string OrderStatus = reader.GetString(3);
                        result = "* " + OrderNumber + " " + OrderStatus + "  " + employeeName + "  " + recordate;
                    }
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

        public string GetNotifyMsgIfNumber3Exist(string phoneNumber3)
        {
            using (SqlConnection conn = new SqlConnection(DBHelper.GetConnection()))
            {
                string result = string.Empty;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = @"select c.InformationAssistantId ,RecordDate,o.OrderNumber,OrderStatus   
                                    from dbo.CustomerOrder o ,dbo.Customer c 
                                    where o.CustomerId = c.CustomerId
                                    and c.ContactPerson3Number = @ContactPerson3Number";
                cmd.Parameters.AddWithValue("@ContactPerson3Number", phoneNumber3);
                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        string recordate = reader.GetDateTime(1).ToString();
                        string employeeName = GetEmployeeNameByIAId(reader.GetInt32(0));
                        int OrderNumber = reader.GetInt32(2);
                        string OrderStatus = reader.GetString(3);
                        result = "* " + OrderNumber + " " + OrderStatus + "  " + employeeName + "  " + recordate;
                    }
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

        public string GetEmployeeNameByIAId(int informationAssistantId)
        {
            using (SqlConnection con = new SqlConnection(DBHelper.GetConnection()))
            {
                SqlCommand cmd = new SqlCommand();
                string employeeName = string.Empty;
                cmd.Connection = con;
                cmd.CommandText = @"select e.Name
                                    from dbo.InformationAssistant i left outer join
                                    Employee e on e.EmployeeId = i.EmployeeId
                                    where i.InformationAssistantId = @InformationAssistantId";
                cmd.Parameters.AddWithValue("@InformationAssistantId", informationAssistantId);
                try
                {
                    con.Open();
                    employeeName = Convert.ToString(cmd.ExecuteScalar());
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    cmd.Dispose();
                    con.Close();
                    con.Dispose();
                }
                return employeeName;
            }
        }
    }
}
