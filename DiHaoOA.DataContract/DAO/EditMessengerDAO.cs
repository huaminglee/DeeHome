using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DiHaoOA.DataContract.Entity;
using System.Data.SqlClient;
using System.Data;

namespace DiHaoOA.DataContract.DAO
{
    public class EditMessengerDAO
    {
        public InformationAssistant GetInformationAssistantById(int informationAssistantId)
        {
            using (SqlConnection con = new SqlConnection(DBHelper.GetConnection()))
            {
                SqlCommand cmd = new SqlCommand();
                InformationAssistant informationAssistant = new InformationAssistant();
                try
                {
                    con.Open();
                    cmd.Connection = con;

                    cmd.CommandText = @"select InformationAssistantName,PhoneNumber,Type,
                                  Company,City,InformationLevel,ReVisitTime,OrderId,Address,
                                  ReVisistPeriod,IsVisit,HandSet
                                  from InformationAssistant
                                  where InformationAssistantId = @InformationAssistantId";
                    cmd.Parameters.AddWithValue("@InformationAssistantId", informationAssistantId);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        informationAssistant.InformationAssistantId = informationAssistantId;
                        informationAssistant.InformationAssistantName = reader.GetString(0);
                        informationAssistant.PhoneNumber = reader.GetString(1);
                        informationAssistant.Type = reader.GetString(2);
                        informationAssistant.Company = reader.GetString(3);
                        informationAssistant.City = reader.GetString(4);
                        informationAssistant.InformationLevel = reader.GetString(5);
                        informationAssistant.ReVisitTime = "10";
                        informationAssistant.Address = reader.IsDBNull(8) ? "" : reader.GetString(8);
                        informationAssistant.IsVisit = reader.IsDBNull(10) ? false : reader.GetBoolean(10);
                        informationAssistant.HandSet = reader.IsDBNull(11) ? "" : reader.GetString(11);
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
                return informationAssistant;
            }
        }

        public void UpdateMessenger(InformationAssistant informationAssistant)
        {
            using (SqlConnection conn = new SqlConnection(DBHelper.GetConnection()))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = @"Update InformationAssistant
                                    set InformationAssistantName =@InformationAssistantName,
                                    PhoneNumber = @PhoneNumber,
                                    Type = @Type,
                                    Company = @Company,
                                    Address = @Address,
                                    IsVisit = @IsVisit,
                                    HandSet = @HandSet
                                    where InformationAssistantId = @InformationAssistantId";
                cmd.Parameters.AddWithValue("@InformationAssistantName", informationAssistant.InformationAssistantName);
                cmd.Parameters.AddWithValue("@PhoneNumber", informationAssistant.PhoneNumber);
                cmd.Parameters.AddWithValue("@Type", informationAssistant.Type);
                cmd.Parameters.AddWithValue("@Company", informationAssistant.Company);
                cmd.Parameters.AddWithValue("@Address", informationAssistant.Address);
                cmd.Parameters.AddWithValue("@IsVisit", informationAssistant.IsVisit);
                cmd.Parameters.AddWithValue("@HandSet", informationAssistant.HandSet);
                cmd.Parameters.AddWithValue("@InformationAssistantId", informationAssistant.InformationAssistantId);
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

        public bool IsNameExist(string name)
        {
            using (SqlConnection con = new SqlConnection(DBHelper.GetConnection()))
            {
                string result;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = @"select InformationAssistantName from InformationAssistant
                                    where InformationAssistantName = @Name";
                cmd.Parameters.AddWithValue("@Name", name);
                try
                {
                    con.Open();
                    result = Convert.ToString(cmd.ExecuteScalar());
                    if (result != "")
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

        public bool IsPhoneNumberExist(string phoneNumber, int informationAssistantId)
        {
            using (SqlConnection con = new SqlConnection(DBHelper.GetConnection()))
            {
                string result;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = @"select PhoneNumber from InformationAssistant
                                    where PhoneNumber = @PhoneNumber 
                                    and InformationAssistantId != @InformationAssistantId";
                cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                cmd.Parameters.AddWithValue("@InformationAssistantId", informationAssistantId);
                try
                {
                    con.Open();
                    result = Convert.ToString(cmd.ExecuteScalar());
                    if (result != "")
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

        public DataSet GetInformList(int informationAssistantId)
        {
            using (SqlConnection conn = new SqlConnection(DBHelper.GetConnection()))
            {
                SqlCommand cmd = new SqlCommand();
                DataSet ds = new DataSet();
                cmd.Connection = conn;
                cmd.CommandText = @"select Row_Number() over(order by o.OrderId desc) rowNumber,
                                          o.OrderId,
	                                      c.CustomerId,
	                                      cast(o.OrderNumber as nvarchar(50))+' '+o.OrderStatus orderNumber,
	                                      o.OrderStatus orderStatus,
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
                                  where c.InformationAssistantId=@InformationAssistantId";
                cmd.Parameters.AddWithValue("@InformationAssistantId", informationAssistantId);
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

        public DataSet GetTraceingInformList(int informationAssistantId)
        {
            using (SqlConnection conn = new SqlConnection(DBHelper.GetConnection()))
            {
                SqlCommand cmd = new SqlCommand();
                DataSet ds = new DataSet();
                cmd.Connection = conn;
                cmd.CommandText = @"select Row_Number() over(order by o.OrderId desc) rowNumber,
                                          o.OrderId,
	                                      c.CustomerId,
	                                      cast(o.OrderNumber as nvarchar(50))+' '+o.OrderStatus orderNumber,
	                                      o.OrderStatus orderStatus,
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
                                  where c.InformationAssistantId=@InformationAssistantId
                                    and o.OrderStatus = N'正跟踪'";
                cmd.Parameters.AddWithValue("@InformationAssistantId", informationAssistantId);
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
    }
}
