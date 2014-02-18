using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using DiHaoOA.DataContract.Entity;

namespace DiHaoOA.DataContract.DAO
{
    public class CustomerTraceDAO
    {
        const string PRO_OrderPaging = "pro_OrdersPaging";

        public DataSet GetAllOrders(int pageIndex, int pageSize, string eventCode, string input,string employeeId)
        {
            using (SqlConnection conn = new SqlConnection(DBHelper.GetConnection()))
            {
                DataSet result = new DataSet();
                SqlCommand cmd = null;
                SqlDataAdapter sda = null;
                try
                {
                    conn.Open();
                    cmd = new SqlCommand(PRO_OrderPaging, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@pageIndex", pageIndex);
                    cmd.Parameters.AddWithValue("@pageSize", pageSize);
                    cmd.Parameters.AddWithValue("@orderStatus", eventCode);
                    cmd.Parameters.AddWithValue("@input", input);
                    cmd.Parameters.AddWithValue("@EmployeeId", employeeId);
                    sda = new SqlDataAdapter(cmd);
                    sda.Fill(result);
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


        public int GetTotalRecords(string orderStaus, string input,string employeeId)
        {
            using (SqlConnection conn = new SqlConnection(DBHelper.GetConnection()))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = @"select count(*) 
                                    from CustomerOrder o left outer join Customer c on o.CustomerId = c.CustomerId
	                                left outer join Employee d on d.EmployeeId = o.DesignerId
	                                left outer join InformationAssistant i on c.InformationAssistantId = i.InformationAssistantId
	                                left outer join Employee e on e.EmployeeId = c.EmployeeId
                                    where o.orderStatus = @orderStatus
                                    and  c.EmployeeId = @EmployeeId
                                    and (o.OrderNumber like '%'+@input+'%'
                                    or c.CompanyName like '%'+@input+'%'
                                    or o.RecordDate like '%'+@input+'%'
                                    or o.OrderStatus like '%'+@input+'%'
                                    or c.DecorationAddress like '%'+@input+'%'
                                    or i.InformationAssistantName like '%'+@input+'%'
                                    or e.Name like '%'+@input+'%'
                                    or c.City like '%'+@input+'%'
                                    or c.ContactPersonNumber like '%'+@input+'%' 
                                    or c.ContactPerson2Number like '%'+@input+'%' 
                                    or c.ContactPerson3Number like '%'+@input+'%' 
                                    or @input='')";
                cmd.Parameters.AddWithValue("@orderStatus", orderStaus);
                cmd.Parameters.AddWithValue("@input", input);
                cmd.Parameters.AddWithValue("@EmployeeId",employeeId);
                int result = 0;
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
                    cmd.Dispose();
                    conn.Close();
                }
                return result;
            }
        }

        public int GetOrderNumber()
        {
            using (SqlConnection conn = new SqlConnection(DBHelper.GetConnection()))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = @"select Max(OrderNumber) 
                                    from CustomerOrder";
                int result = 0;
                try
                {
                    conn.Open();
                    result = cmd.ExecuteScalar() == DBNull.Value ? 8000 : Convert.ToInt32(cmd.ExecuteScalar());
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
                return result + 1;
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
                        informationAssistant.RecordDateTime =  reader.GetDateTime(12);
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
    }
}
