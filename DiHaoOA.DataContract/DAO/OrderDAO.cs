using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using DiHaoOA.DataContract.Entity;
using System.Data;

namespace DiHaoOA.DataContract.DAO
{
    public class OrderDAO
    {
        EmployeeDAO empDao;
        InformationAssistantDAO iADao;

        public OrderDAO()
        {
            empDao = new EmployeeDAO();
            iADao = new InformationAssistantDAO();
        }

        public void AddOrderDescription(string description,Order order)
        {
            using (SqlConnection conn = new SqlConnection(DBHelper.GetConnection()))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = @"update CustomerOrder
                                    set Description = @Description
                                    where OrderId = @OrderId";
                cmd.Parameters.AddWithValue("@Description", description);
                cmd.Parameters.AddWithValue("@OrderId",order.OrderId);
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


        public InformationAssistant GetInformationAssistantByOrderId(int orderId)
        {
            using (SqlConnection conn = new SqlConnection(DBHelper.GetConnection()))
            {
                SqlCommand cmd = new SqlCommand();
                InformationAssistant informationAssistant = new InformationAssistant();
                cmd.Connection = conn;
                cmd.CommandText = @"select InformationAssistantName,i.PhoneNumber,i.Type,
                                  i.Company,i.City,InformationLevel,ReVisitTime,i.OrderId,Address,
                                  ReVisistPeriod,IsVisit,HandSet,i.RecordDate,i.InformationAssistantId
                                  from InformationAssistant i,dbo.CustomerOrder o,dbo.Customer c
                                  where i.InformationAssistantId = c.InformationAssistantId
                                  and c.CustomerId = o.CustomerId
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
                        informationAssistant.RecordDateTime = reader.GetDateTime(12);
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

        public Order GetOrderById(int orderId)
        {
            using (SqlConnection conn = new SqlConnection(DBHelper.GetConnection()))
            {
                SqlCommand cmd = new SqlCommand();
                Order order = new Order();
                cmd.Connection = conn;
                cmd.CommandText = @"Select OrderNumber,RecordDate,
                                    DesignerId,OrderStatus,CustomerId,[Description]
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
                        string designerId = reader.IsDBNull(2) ? "" : reader.GetString(2);
                        order.Designer = empDao.GetEmployeeById(designerId);
                        order.OrderStatus = reader.GetString(3);
                        order.Customers = GetCustomerById(reader.GetInt32(4));
                        order.Description = reader.IsDBNull(5) ? "" : reader.GetString(5);
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
                        customer.InformationAssistants = iADao.GetInformationAssistantById(informationAssistantId);
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

        public void UpdateOrderStatus(int orderId,string orderStatus)
        {
            using (SqlConnection conn = new SqlConnection(DBHelper.GetConnection()))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = @"Update CustomerOrder
                                    Set OrderStatus = @OrderStatus
                                    Where OrderId = @OrderId";
                cmd.Parameters.AddWithValue("@OrderStatus", orderStatus);
                cmd.Parameters.AddWithValue("@OrderId",orderId);
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

        public DataSet GetOrderByOrderStatus(int pageIndex, int pageSize, string input, string orderStatus)
        {
            using (SqlConnection conn = new SqlConnection(DBHelper.GetConnection()))
            {
                DataSet result = new DataSet();
                SqlCommand cmd = new SqlCommand("pro_GetOrderByOrderStatus", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pageIndex", pageIndex);
                cmd.Parameters.AddWithValue("@pageSize", pageSize);
                cmd.Parameters.AddWithValue("@orderStatus", orderStatus);
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


        public int GetTotalRecords(int pageIndex, int pageSize, string input, string orderStatus)
        {
            using (SqlConnection conn = new SqlConnection(DBHelper.GetConnection()))
            {
                int total = 0;
                SqlCommand cmd = new SqlCommand("pro_GetOrderByOrderStatus", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter pageIndexP = cmd.Parameters.Add("@pageIndex", SqlDbType.Int);
                SqlParameter pageSizeP = cmd.Parameters.Add("@pageSize", SqlDbType.Int);
                SqlParameter inputP = cmd.Parameters.Add("@input", SqlDbType.NVarChar, 500);
                SqlParameter blackEmployeeIdP = cmd.Parameters.Add("@BlackEmployeeId", SqlDbType.NVarChar, 50);
                SqlParameter totalRecordsP = cmd.Parameters.Add("@TotalRecords", SqlDbType.Int);
                SqlParameter orderStatusP = cmd.Parameters.Add("@orderStatus",SqlDbType.NVarChar,50);
                pageIndexP.Value = pageIndex;
                pageSizeP.Value = pageSize;
                inputP.Value = input;
                orderStatusP.Value = orderStatus;
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

        public void AllocateOrderToDesigner(string designerId,int orderId)
        {
            using (SqlConnection conn = new SqlConnection(DBHelper.GetConnection()))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                try
                {
                    conn.Open();
                    cmd.CommandText = @"Update dbo.CustomerOrder
                                    set DesignerId=@DesignerId,OrderStatus=N'在谈'
                                    where OrderId=@OrderId";
                    cmd.Parameters.AddWithValue("@DesignerId", designerId);
                    cmd.Parameters.AddWithValue("@OrderId", orderId);
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
    }
}
