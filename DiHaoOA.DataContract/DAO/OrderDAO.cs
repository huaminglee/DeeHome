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
                                    DesignerId,OrderStatus,CustomerId,[Description],AllocationDate,SubmittedBy
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
                        order.AllocationDate = reader.IsDBNull(6)? DateTime.Now : reader.GetDateTime(6);
                        order.SubmittedBy = reader.IsDBNull(7)?"":reader.GetString(7);
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

        public void UpdateOrderStatus(int orderId, string orderStatus,string submittedBy)
        {
            using (SqlConnection conn = new SqlConnection(DBHelper.GetConnection()))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = @"Update CustomerOrder
                                    Set OrderStatus = @OrderStatus,
                                    SubmittedBy = @SubmittedBy
                                    Where OrderId = @OrderId";
                cmd.Parameters.AddWithValue("@OrderStatus", orderStatus);
                cmd.Parameters.AddWithValue("@OrderId", orderId);
                cmd.Parameters.AddWithValue("@SubmittedBy",submittedBy);
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

        public DataSet GetOrderByOrderStatus(int pageIndex, int pageSize, string input, string orderStatus,string employeeId,string procedureName)
        {
            using (SqlConnection conn = new SqlConnection(DBHelper.GetConnection()))
            {
                DataSet result = new DataSet();
                SqlCommand cmd = new SqlCommand(procedureName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pageIndex", pageIndex);
                cmd.Parameters.AddWithValue("@pageSize", pageSize);
                cmd.Parameters.AddWithValue("@orderStatus", orderStatus);
                cmd.Parameters.AddWithValue("@input", input);
                cmd.Parameters.AddWithValue("@BlackEmployeeId", DBHelper.GetBlackListEmployee());
                cmd.Parameters.AddWithValue("@EmployeeId", employeeId);
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

        public int GetTotalRecords(int pageIndex, int pageSize, string input, string orderStatus, string employeeId, string procedureName)
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
                SqlParameter employeeIdP = cmd.Parameters.Add("@EmployeeId", SqlDbType.NVarChar,50);
                pageIndexP.Value = pageIndex;
                pageSizeP.Value = pageSize;
                inputP.Value = input;
                orderStatusP.Value = orderStatus;
                employeeIdP.Value = employeeId;
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
                                    set DesignerId=@DesignerId,
                                        OrderStatus=N'在谈',
                                        AllocationDate=getdate() 
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

        public int GetCurrentMonthCountByOrderStatus(string employeeId,string orderStatus)
        {
            using (SqlConnection conn = new SqlConnection(DBHelper.GetConnection()))
            {
                SqlCommand cmd = new SqlCommand();
                int result = 0;
                cmd.Connection = conn;
                cmd.CommandText = @"select count(*) as CurrentMonthOnChattingCount,
                                    e.Name as EmployeeName
	                                from Employee e ,dbo.CustomerOrder o
	                                where e.EmployeeId = o.DesignerId
                                    and e.EmployeeId = @EmployeeId
                                    and o.OrderStatus = @OrderStatus
                                    and o.RecordDate > convert(datetime,convert(varchar(8),getdate(),120)+'01',120)
                                    and o.RecordDate < dateadd(ms,-3,DATEADD(mm,DATEDIFF(m,0,getdate())+1,0))
                                    group by e.Name";
                cmd.Parameters.AddWithValue("@EmployeeId", employeeId);
                cmd.Parameters.AddWithValue("@OrderStatus", orderStatus);
                try
                {
                    conn.Open();
                    result = DBNull.Value == cmd.ExecuteScalar() ? 0 : Convert.ToInt32(cmd.ExecuteScalar());
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

        public int GetCurrentMonthCountByOrderStatusForSalesManager(string employeeId, string orderStatus)
        {
            using (SqlConnection conn = new SqlConnection(DBHelper.GetConnection()))
            {
                SqlCommand cmd = new SqlCommand();
                int result = 0;
                cmd.Connection = conn;
                cmd.CommandText = @"select count(*) as Count,
                                    e.Name as EmployeeName
	                                from Employee e 
                                    ,dbo.CustomerOrder o
                                    ,Customer c
                                    ,InformationAssistant i
	                                where e.EmployeeId = i.EmployeeId
                                    and i.InformationAssistantId = c.InformationAssistantId
                                    and o.CustomerId = c.CustomerId
                                    and e.EmployeeId = @EmployeeId
                                    and o.OrderStatus = @OrderStatus
                                    and o.RecordDate > convert(datetime,convert(varchar(8),getdate(),120)+'01',120)
                                    and o.RecordDate < dateadd(ms,-3,DATEADD(mm,DATEDIFF(m,0,getdate())+1,0))
                                    group by e.Name";
                cmd.Parameters.AddWithValue("@EmployeeId", employeeId);
                cmd.Parameters.AddWithValue("@OrderStatus", orderStatus);
                try
                {
                    conn.Open();
                    result = DBNull.Value == cmd.ExecuteScalar() ? 0 : Convert.ToInt32(cmd.ExecuteScalar());
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

        public int GetSalesManagerApprovalCount()
        {
            using (SqlConnection conn = new SqlConnection(DBHelper.GetConnection()))
            {
                SqlCommand cmd = new SqlCommand();
                int result = 0;
                cmd.Connection = conn;
                cmd.CommandText = @"select count(*) 
                                    from  CustomerOrder o
                                    where (o.OrderStatus = N'已提交'
                                           and  o.SubmittedBy = 'SalesMan')
                                           or ((o.OrderStatus = N'提交不准'
                                           or o.OrderStatus = N'提交未签'
                                           or o.OrderStatus = N'提交已签')
                                           and (o.SubmittedBy = 'DesignerManager'))";
                try
                {
                    conn.Open();
                    result = DBNull.Value == cmd.ExecuteScalar() ? 0 : Convert.ToInt32(cmd.ExecuteScalar());
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

        public int GetDesignerManagerApprovalCount()
        {
            using (SqlConnection conn = new SqlConnection(DBHelper.GetConnection()))
            {
                SqlCommand cmd = new SqlCommand();
                int result = 0;
                cmd.Connection = conn;
                cmd.CommandText = @"select count(*) 
                                    from  CustomerOrder o
                                    where (o.OrderStatus = N'已提交'
		                            and o.SubmittedBy = 'MarketingManager')
                                   or ((o.OrderStatus = N'提交不准'
                                   or o.OrderStatus = N'提交未签'
                                   or o.OrderStatus = N'提交已签')
                                   and (o.SubmittedBy = 'SalesMan'
                                   or o.SubmittedBy = 'Designer'))";
                try
                {
                    conn.Open();
                    result = DBNull.Value == cmd.ExecuteScalar() ? 0 : Convert.ToInt32(cmd.ExecuteScalar());
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

        public DataSet GetAllOrdersByOrderStatus(int pageIndex, int pageSize, string input, string orderStatus)
        {
            using (SqlConnection conn = new SqlConnection(DBHelper.GetConnection()))
            {
                DataSet result = new DataSet();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = @"declare @startRow int
                                    declare @lastRow int
                                    

                                    set @startRow = (@pageIndex -1)*@pageSize + 1
                                    set @lastRow = @pageIndex * @pageSize

                                    select * from(
                                    select Row_Number() over(order by o.OrderId desc) rowNumber,
	                                      o.OrderId,
	                                      c.CustomerId,
	                                      o.OrderNumber as orderNumber,
	                                      o.OrderStatus as OrderStatus,
	                                      c.CompanyName,
	                                      o.RecordDate as RecordDate,
	                                      c.DecorationAddress as decorateAddress,
                                          i.InformationAssistantName as InformationAssistantName,
	                                      e.Name as BAName,
	                                      d.Name as DesignerName,
	                                      c.City as city
                                    from CustomerOrder o left outer join Customer c on o.CustomerId = c.CustomerId
	                                    left outer join Employee d on d.EmployeeId = o.DesignerId
	                                    left outer join InformationAssistant i on c.InformationAssistantId = i.InformationAssistantId
	                                    left outer join Employee e on e.EmployeeId = c.EmployeeId
                                    where e.EmployeeId != @BlackEmployeeId
                                       and o.OrderStatus = @orderStatus
                                       and (o.OrderNumber like '%'+@input+'%'
                                       or c.CompanyName like '%'+@input+'%'
                                       or o.RecordDate like '%'+@input+'%'
                                       or o.OrderStatus like '%'+@input+'%'
                                       or (cast(o.OrderNumber as nvarchar(50))+o.OrderStatus) like '%'+@input+'%' 
                                       or c.DecorationAddress like '%'+@input+'%'
                                       or i.InformationAssistantName like '%'+@input+'%'
                                       or e.Name like '%'+@input+'%'
                                       or c.City like '%'+@input+'%'
                                       or c.ContactPersonNumber like '%'+@input+'%' 
                                       or c.ContactPerson2Number like '%'+@input+'%' 
                                       or c.ContactPerson3Number like '%'+@input+'%' 
                                       or @input='')
                                      )as tempTable
                                    where rowNumber between @startRow and @lastRow";
                cmd.Parameters.AddWithValue("@pageIndex", pageIndex);
                cmd.Parameters.AddWithValue("@pageSize", pageSize);
                cmd.Parameters.AddWithValue("@orderStatus", orderStatus);
                cmd.Parameters.AddWithValue("@input", input);
                cmd.Parameters.AddWithValue("@BlackEmployeeId", DBHelper.GetBlackListEmployee());
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

        public int GetAllOrdersCountByOrderStatus(int pageIndex, int pageSize, string input, string orderStatus)
        {
            using (SqlConnection conn = new SqlConnection(DBHelper.GetConnection()))
            {
                int totalCount = 0;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = @"select count(*) TotalCount
                                    from CustomerOrder o left outer join Customer c on o.CustomerId = c.CustomerId
	                                    left outer join Employee d on d.EmployeeId = o.DesignerId
	                                    left outer join InformationAssistant i on c.InformationAssistantId = i.InformationAssistantId
	                                    left outer join Employee e on e.EmployeeId = c.EmployeeId
                                    where e.EmployeeId != @BlackEmployeeId
                                       and o.OrderStatus = @orderStatus
                                       and (o.OrderNumber like '%'+@input+'%'
                                       or c.CompanyName like '%'+@input+'%'
                                       or o.RecordDate like '%'+@input+'%'
                                       or o.OrderStatus like '%'+@input+'%'
                                       or (cast(o.OrderNumber as nvarchar(50))+o.OrderStatus) like '%'+@input+'%' 
                                       or c.DecorationAddress like '%'+@input+'%'
                                       or i.InformationAssistantName like '%'+@input+'%'
                                       or e.Name like '%'+@input+'%'
                                       or c.City like '%'+@input+'%'
                                       or c.ContactPersonNumber like '%'+@input+'%' 
                                       or c.ContactPerson2Number like '%'+@input+'%' 
                                       or c.ContactPerson3Number like '%'+@input+'%' 
                                       or @input='')";
                cmd.Parameters.AddWithValue("@pageIndex", pageIndex);
                cmd.Parameters.AddWithValue("@pageSize", pageSize);
                cmd.Parameters.AddWithValue("@orderStatus", orderStatus);
                cmd.Parameters.AddWithValue("@input", input);
                cmd.Parameters.AddWithValue("@BlackEmployeeId", DBHelper.GetBlackListEmployee());
                try
                {
                    conn.Open();
                    totalCount = Convert.ToInt32(cmd.ExecuteScalar());
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
                return totalCount;

            }
        }

        public DataSet GetCurrentMonthOrdersByOrderStatus(int pageIndex, int pageSize, string input, string orderStatus)
        {
            using (SqlConnection conn = new SqlConnection(DBHelper.GetConnection()))
            {
                DataSet result = new DataSet();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = @"declare @startRow int
                                    declare @lastRow int
                                    

                                    set @startRow = (@pageIndex -1)*@pageSize + 1
                                    set @lastRow = @pageIndex * @pageSize

                                    select * from(
                                    select Row_Number() over(order by o.OrderId desc) rowNumber,
	                                      o.OrderId,
	                                      c.CustomerId,
	                                      o.OrderNumber as orderNumber,
	                                      o.OrderStatus as OrderStatus,
	                                      c.CompanyName,
	                                      o.RecordDate as RecordDate,
	                                      c.DecorationAddress as decorateAddress,
                                          i.InformationAssistantName as InformationAssistantName,
	                                      e.Name as BAName,
	                                      d.Name as DesignerName,
	                                      c.City as city
                                    from CustomerOrder o left outer join Customer c on o.CustomerId = c.CustomerId
	                                    left outer join Employee d on d.EmployeeId = o.DesignerId
	                                    left outer join InformationAssistant i on c.InformationAssistantId = i.InformationAssistantId
	                                    left outer join Employee e on e.EmployeeId = c.EmployeeId
                                    where e.EmployeeId != @BlackEmployeeId
                                       and o.OrderStatus = @orderStatus
                                       and o.RecordDate > convert(datetime,convert(varchar(8),getdate(),120)+'01',120)
                                       and o.RecordDate < dateadd(ms,-3,DATEADD(mm,DATEDIFF(m,0,getdate())+2,0))
                                       and (o.OrderNumber like '%'+@input+'%'
                                       or c.CompanyName like '%'+@input+'%'
                                       or o.RecordDate like '%'+@input+'%'
                                       or o.OrderStatus like '%'+@input+'%'
                                       or (cast(o.OrderNumber as nvarchar(50))+o.OrderStatus) like '%'+@input+'%' 
                                       or c.DecorationAddress like '%'+@input+'%'
                                       or i.InformationAssistantName like '%'+@input+'%'
                                       or e.Name like '%'+@input+'%'
                                       or c.City like '%'+@input+'%'
                                       or c.ContactPersonNumber like '%'+@input+'%' 
                                       or c.ContactPerson2Number like '%'+@input+'%' 
                                       or c.ContactPerson3Number like '%'+@input+'%' 
                                       or @input='')
                                      )as tempTable
                                    where rowNumber between @startRow and @lastRow";
                cmd.Parameters.AddWithValue("@pageIndex", pageIndex);
                cmd.Parameters.AddWithValue("@pageSize", pageSize);
                cmd.Parameters.AddWithValue("@orderStatus", orderStatus);
                cmd.Parameters.AddWithValue("@input", input);
                cmd.Parameters.AddWithValue("@BlackEmployeeId", DBHelper.GetBlackListEmployee());
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

        public int GetCurrentMonthTotalCountByOrderStatus(int pageIndex, int pageSize, string input, string orderStatus)
        {
            using (SqlConnection conn = new SqlConnection(DBHelper.GetConnection()))
            {
                int totalCount = 0;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = @"select Count(*) as totalCount
                                    from CustomerOrder o left outer join Customer c on o.CustomerId = c.CustomerId
	                                    left outer join Employee d on d.EmployeeId = o.DesignerId
	                                    left outer join InformationAssistant i on c.InformationAssistantId = i.InformationAssistantId
	                                    left outer join Employee e on e.EmployeeId = c.EmployeeId
                                    where e.EmployeeId != @BlackEmployeeId
                                       and o.OrderStatus = @orderStatus
                                       and o.RecordDate > convert(datetime,convert(varchar(8),getdate(),120)+'01',120)
                                       and o.RecordDate < dateadd(ms,-3,DATEADD(mm,DATEDIFF(m,0,getdate())+1,0))
                                       and (o.OrderNumber like '%'+@input+'%'
                                       or c.CompanyName like '%'+@input+'%'
                                       or o.RecordDate like '%'+@input+'%'
                                       or o.OrderStatus like '%'+@input+'%'
                                       or (cast(o.OrderNumber as nvarchar(50))+o.OrderStatus) like '%'+@input+'%' 
                                       or c.DecorationAddress like '%'+@input+'%'
                                       or i.InformationAssistantName like '%'+@input+'%'
                                       or e.Name like '%'+@input+'%'
                                       or c.City like '%'+@input+'%'
                                       or c.ContactPersonNumber like '%'+@input+'%' 
                                       or c.ContactPerson2Number like '%'+@input+'%' 
                                       or c.ContactPerson3Number like '%'+@input+'%' 
                                       or @input='')
                                      )as tempTable
                                    where rowNumber between @startRow and @lastRow";
                cmd.Parameters.AddWithValue("@pageIndex", pageIndex);
                cmd.Parameters.AddWithValue("@pageSize", pageSize);
                cmd.Parameters.AddWithValue("@orderStatus", orderStatus);
                cmd.Parameters.AddWithValue("@input", input);
                cmd.Parameters.AddWithValue("@BlackEmployeeId", DBHelper.GetBlackListEmployee());
                try
                {
                    conn.Open();
                    totalCount = Convert.ToInt32(cmd.ExecuteScalar());
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
                return totalCount;
            }
        }


        public DataSet GetLastMonthToCurrentMonthOrdersByOrderStatus(int pageIndex, int pageSize, string input, string orderStatus)
        {
            using (SqlConnection conn = new SqlConnection(DBHelper.GetConnection()))
            {
                DataSet result = new DataSet();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = @"declare @startRow int
                                    declare @lastRow int
                                    

                                    set @startRow = (@pageIndex -1)*@pageSize + 1
                                    set @lastRow = @pageIndex * @pageSize

                                    select * from(
                                    select Row_Number() over(order by o.OrderId desc) rowNumber,
	                                      o.OrderId,
	                                      c.CustomerId,
	                                      o.OrderNumber as orderNumber,
	                                      o.OrderStatus as OrderStatus,
	                                      c.CompanyName,
	                                      o.RecordDate as RecordDate,
	                                      c.DecorationAddress as decorateAddress,
                                          i.InformationAssistantName as InformationAssistantName,
	                                      e.Name as BAName,
	                                      d.Name as DesignerName,
	                                      c.City as city
                                    from CustomerOrder o left outer join Customer c on o.CustomerId = c.CustomerId
	                                    left outer join Employee d on d.EmployeeId = o.DesignerId
	                                    left outer join InformationAssistant i on c.InformationAssistantId = i.InformationAssistantId
	                                    left outer join Employee e on e.EmployeeId = c.EmployeeId
                                    where e.EmployeeId != @BlackEmployeeId
                                       and o.OrderStatus = @orderStatus
                                       and o.RecordDate > convert(datetime,DATEADD(mm,DATEDIFF(mm,0,dateadd(mm,-1,getdate())),0),120)
                                       and o.RecordDate < dateadd(ms,-3,DATEADD(mm,DATEDIFF(m,0,getdate())+2,0))
                                       and (o.OrderNumber like '%'+@input+'%'
                                       or c.CompanyName like '%'+@input+'%'
                                       or o.RecordDate like '%'+@input+'%'
                                       or o.OrderStatus like '%'+@input+'%'
                                       or (cast(o.OrderNumber as nvarchar(50))+o.OrderStatus) like '%'+@input+'%' 
                                       or c.DecorationAddress like '%'+@input+'%'
                                       or i.InformationAssistantName like '%'+@input+'%'
                                       or e.Name like '%'+@input+'%'
                                       or c.City like '%'+@input+'%'
                                       or c.ContactPersonNumber like '%'+@input+'%' 
                                       or c.ContactPerson2Number like '%'+@input+'%' 
                                       or c.ContactPerson3Number like '%'+@input+'%' 
                                       or @input='')
                                      )as tempTable
                                    where rowNumber between @startRow and @lastRow";
                cmd.Parameters.AddWithValue("@pageIndex", pageIndex);
                cmd.Parameters.AddWithValue("@pageSize", pageSize);
                cmd.Parameters.AddWithValue("@orderStatus", orderStatus);
                cmd.Parameters.AddWithValue("@input", input);
                cmd.Parameters.AddWithValue("@BlackEmployeeId", DBHelper.GetBlackListEmployee());
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

        public int GetLastMonthToCurrentMonthTotalCountByOrderStatus(int pageIndex, int pageSize, string input, string orderStatus)
        {
            using (SqlConnection conn = new SqlConnection(DBHelper.GetConnection()))
            {
                int totalCount = 0;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = @"select Count(*) as totalCount
                                    from CustomerOrder o left outer join Customer c on o.CustomerId = c.CustomerId
	                                    left outer join Employee d on d.EmployeeId = o.DesignerId
	                                    left outer join InformationAssistant i on c.InformationAssistantId = i.InformationAssistantId
	                                    left outer join Employee e on e.EmployeeId = c.EmployeeId
                                    where e.EmployeeId != @BlackEmployeeId
                                       and o.OrderStatus = @orderStatus
                                       and o.RecordDate > convert(datetime,DATEADD(mm,DATEDIFF(mm,0,dateadd(mm,-1,getdate())),0),120)
                                       and o.RecordDate < dateadd(ms,-3,DATEADD(mm,DATEDIFF(m,0,getdate())+1,0))
                                       and (o.OrderNumber like '%'+@input+'%'
                                       or c.CompanyName like '%'+@input+'%'
                                       or o.RecordDate like '%'+@input+'%'
                                       or o.OrderStatus like '%'+@input+'%'
                                       or (cast(o.OrderNumber as nvarchar(50))+o.OrderStatus) like '%'+@input+'%' 
                                       or c.DecorationAddress like '%'+@input+'%'
                                       or i.InformationAssistantName like '%'+@input+'%'
                                       or e.Name like '%'+@input+'%'
                                       or c.City like '%'+@input+'%'
                                       or c.ContactPersonNumber like '%'+@input+'%' 
                                       or c.ContactPerson2Number like '%'+@input+'%' 
                                       or c.ContactPerson3Number like '%'+@input+'%' 
                                       or @input='')
                                      )as tempTable
                                    where rowNumber between @startRow and @lastRow";
                cmd.Parameters.AddWithValue("@pageIndex", pageIndex);
                cmd.Parameters.AddWithValue("@pageSize", pageSize);
                cmd.Parameters.AddWithValue("@orderStatus", orderStatus);
                cmd.Parameters.AddWithValue("@input", input);
                cmd.Parameters.AddWithValue("@BlackEmployeeId", DBHelper.GetBlackListEmployee());
                try
                {
                    conn.Open();
                    totalCount = Convert.ToInt32(cmd.ExecuteScalar());
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
                return totalCount;
            }
        }
    }
}
