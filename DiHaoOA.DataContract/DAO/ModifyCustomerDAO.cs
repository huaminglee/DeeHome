using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DiHaoOA.DataContract.Entity;
using System.Data.SqlClient;

namespace DiHaoOA.DataContract.DAO
{
    public class ModifyCustomerDAO
    {
        EmployeeDAO empDao;
        EditMessengerDAO editMessengerDao;

        public ModifyCustomerDAO()
        {
            empDao = new EmployeeDAO();
            editMessengerDao = new EditMessengerDAO();
        }

        public void UpdateCustomer(Order order)
        {
            using (SqlConnection conn = new SqlConnection(DBHelper.GetConnection()))
            {
                conn.Open();
                SqlTransaction tran = conn.BeginTransaction();
                Customer customer = order.Customers;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.Transaction = tran;
                try
                {
                    cmd.CommandText = @"update Customer set CompanyName =@CompanyName
                                        ,ContactPerson=@ContactPerson,ContactPersonNumber=@ContactPersonNumber,
                                        ContactPerson2=@ContactPerson2,ContactPerson2Number=@ContactPerson2Number,
                                        ContactPerson3=@ContactPerson3,ContactPerson3Number=@ContactPerson3Number,
                                        City=@City,UsableArea=@UsableArea,Email=@Email,DecorationAddress=@DecorationAddress,
                                        RidePath=@RidePath,AppointDateTime=@AppointDateTime,WorkPlace=@WorkPlace
                                        where CustomerId = @CustomerId";
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
                    cmd.Parameters.AddWithValue("@WorkPlace",customer.WorkPlace);
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = @"update dbo.CustomerOrder set OrderStatus = @OrderStatus,
                                        SubmittedBy = 'SalesMan'
                                        where OrderId = @OrderId";
                    cmd.Parameters.AddWithValue("@OrderId",order.OrderId);
                    cmd.Parameters.AddWithValue("@OrderStatus", order.OrderStatus);
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
                    cmd.Dispose();
                    conn.Close();
                }
            }
        }

        public Order GetOrderById(int orderId)
        {
            using (SqlConnection conn = new SqlConnection(DBHelper.GetConnection()))
            {
                SqlCommand cmd = new SqlCommand();
                Order order = new Order();
                cmd.Connection = conn;
                cmd.CommandText = @"Select OrderNumber,RecordDate,
                                    DesignerId,OrderStatus,CustomerId
                                    from dbo.CustomerOrder
                                    where OrderId = @OrderId";
                try
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@OrderId", orderId);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        order.OrderId = orderId;
                        order.OrderNumber = reader.GetInt32(0);
                        order.RecordDate = reader.GetDateTime(1);
                        //order.InformationAssistant = editMessengerDao.GetInformationAssistantById(reader.GetInt32(2));
                        //order.Designer = empDao.GetEmployeeById(reader.GetString(3));
                        order.OrderStatus = reader.GetString(3);
                        order.Customers = GetCustomerById(reader.GetInt32(4));
                    }
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
                return order;
            }

        }

        public Customer GetCustomerById(int customerId)
        {
            using (SqlConnection conn = new SqlConnection(DBHelper.GetConnection()))
            {
                SqlCommand cmd = new SqlCommand();
                Customer customer = new Customer();
                string employeeId = "";
                int informationAssistantId = 0;
                cmd.Connection = conn;
                cmd.CommandText = @"select CompanyName,ContactPerson,ContactPersonNumber,
                                    ContactPerson2,ContactPerson2Number,ContactPerson3,ContactPerson3Number,
                                    City,UsableArea,Email,DecorationAddress,RidePath,AppointDateTime,ProviderType,
                                    CustomerType,Comments,InformationAssistantId,EmployeeId,WorkPlace
                                    from dbo.Customer
                                    where CustomerId = @CustomerId";
                cmd.Parameters.AddWithValue("@CustomerId", customerId);
                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        customer.CustomerId = customerId;
                        customer.CompanyName = reader.GetString(0);
                        customer.ContactPerson = reader.GetString(1);
                        customer.ContactPersonNumber = reader.GetString(2);
                        customer.ContactPerson2 = reader.GetString(3);
                        customer.ContactPerson2Number = reader.GetString(4);
                        customer.ContactPerson3 = reader.GetString(5);
                        customer.Contactperson3Number = reader.GetString(6);
                        customer.City = reader.GetString(7);
                        customer.UsableArea = reader.GetString(8);
                        customer.Email = reader.GetString(9);
                        customer.DecorationAddress = reader.GetString(10);
                        customer.RidePath = reader.GetString(11);
                        customer.AppointDateTime = reader.GetString(12);
                        customer.ProviderType = reader.GetString(13);
                        customer.CustomerType = reader.GetString(14);
                        customer.Comments = reader.GetString(15);
                        informationAssistantId = reader.IsDBNull(16) ? 0 : reader.GetInt32(16);
                        employeeId = reader.IsDBNull(17) ? "" : reader.GetString(17);
                        customer.InformationAssistants = editMessengerDao.GetInformationAssistantById(informationAssistantId);
                        customer.Employees = empDao.GetEmployeeById(employeeId);
                        customer.WorkPlace = reader.IsDBNull(18) ? "" : reader.GetString(18);
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
                return customer;
            }
        }

        public InformationAssistant GetInformationAssistantByOrderId(int orderId)
        {
            using (SqlConnection conn = new SqlConnection(DBHelper.GetConnection()))
            {
                SqlCommand cmd = new SqlCommand();
                InformationAssistant informationAssistant = new InformationAssistant();
                cmd.Connection = conn;
                cmd.CommandText = @"select InformationAssistantName,PhoneNumber,Type,
                                  Company,City,InformationLevel,ReVisitTime,i.OrderId,Address,
                                  ReVisistPeriod,IsVisit,HandSet,i.RecordDate,i.InformationAssistantId
                                  from InformationAssistant i,dbo.CustomerOrder o
                                  where i.InformationAssistantId = o.InformationAssistantId
                                  and o.OrderId = @OrderId";
                cmd.Parameters.AddWithValue("@OrderId", orderId);
                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        informationAssistant.InformationAssistantId = reader.GetInt32(13);
                        informationAssistant.InformationAssistantName = reader.GetString(0);
                        informationAssistant.PhoneNumber = reader.GetString(1);
                        informationAssistant.Type = reader.GetString(2);
                        informationAssistant.Company = reader.GetString(3);
                        informationAssistant.City = reader.GetString(4);
                        informationAssistant.InformationLevel = reader.GetString(5);
                        informationAssistant.ReVisitTime = reader.GetString(6);
                        informationAssistant.Address = reader.IsDBNull(8) ? "" : reader.GetString(8);
                        informationAssistant.IsVisit = reader.IsDBNull(10) ? false : reader.GetBoolean(10);
                        informationAssistant.HandSet = reader.IsDBNull(11) ? "" : reader.GetString(11);
                        informationAssistant.RecordDateTime = reader.IsDBNull(13) ? DateTime.Now : reader.GetDateTime(13);
                    }
                    reader.Close();
                    reader.Dispose();
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
                return informationAssistant;
            }
        }

        public bool IsPhoneNumber2Exist(string number,int customerId)
        {
            using (SqlConnection con = new SqlConnection(DBHelper.GetConnection()))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = @"select CompanyName
                                    from dbo.Customer
                                    where ContactPerson2Number = @Number 
                                    and CustomerId != @CustomerId";
                cmd.Parameters.AddWithValue("@Number", number);
                cmd.Parameters.AddWithValue("@CustomerId", customerId);
                try
                {
                    con.Open();
                    if (cmd.ExecuteScalar() == null)
                    {
                        return false;
                    }

                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    cmd.Dispose();
                    con.Close();
                }
            }
            return true; ;
        }

        public bool IsPhoneNumber3Exist(string number, int customerId)
        {
            using (SqlConnection con = new SqlConnection(DBHelper.GetConnection()))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = @"select CompanyName
                                    from dbo.Customer
                                    where ContactPerson3Number = @Number 
                                    and CustomerId != @CustomerId";
                cmd.Parameters.AddWithValue("@Number", number);
                cmd.Parameters.AddWithValue("@CustomerId", customerId);
                try
                {
                    con.Open();
                    if (cmd.ExecuteScalar() == null)
                    {
                        return false;
                    }

                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    cmd.Dispose();
                    con.Close();
                }
            }
            return true; ;
        }
    }
}
