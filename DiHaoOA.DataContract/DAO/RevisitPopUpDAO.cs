using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace DiHaoOA.DataContract.DAO
{
    public class RevisitPopUpDAO
    {
        public void SaveRevisit(string content, DateTime dateTime, int informationAssistantId)
        {
            using (SqlConnection conn = new SqlConnection(DBHelper.GetConnection()))
            {
                SqlTransaction tran = null;
                SqlCommand cmd = new SqlCommand();
                string commandText = string.Empty;
                cmd.Connection = conn;
                commandText = @"Insert into 
                                    Revisit values(@content,@dateTime,@InformationAssistantId)";
                cmd.CommandText = commandText;
                try
                {
                    conn.Open();
                    tran = conn.BeginTransaction();
                    cmd.Transaction = tran;
                    cmd.Parameters.AddWithValue("@content", content);
                    cmd.Parameters.AddWithValue("@dateTime", dateTime.ToString());
                    cmd.Parameters.AddWithValue("@InformationAssistantId", informationAssistantId);
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = @"Update dbo.InformationAssistant
                                        Set VisitDateTime=getdate()
                                        Where InformationAssistantId=@InformationAssistantId2";
                    cmd.Parameters.AddWithValue("@InformationAssistantId2",informationAssistantId);
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

        public void SaveCustomerRevisit(string content, DateTime dateTime, int customerId)
        {
            using (SqlConnection conn = new SqlConnection(DBHelper.GetConnection()))
            {
                SqlCommand cmd = new SqlCommand();
                string commandText = string.Empty;
                cmd.Connection = conn;

                commandText = @"Insert into 
                                    dbo.CustomerRevisit values(@content,@dateTime,@customerId)";

                cmd.CommandText = commandText;
                try
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@content", content);
                    cmd.Parameters.AddWithValue("@dateTime", dateTime.ToString());
                    cmd.Parameters.AddWithValue("@customerId", customerId);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        public void SaveDesignerRevisit(string content, DateTime dateTime, int orderId)
        {
            using (SqlConnection conn = new SqlConnection(DBHelper.GetConnection()))
            {
                SqlCommand cmd = new SqlCommand();
                string commandText = string.Empty;
                cmd.Connection = conn;

                commandText = @"Insert into 
                                    dbo.DesigerRevisit values(@content,@dateTime,@orderId)";
                cmd.CommandText = commandText;
                try
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@content", content);
                    cmd.Parameters.AddWithValue("@dateTime", dateTime.ToString());
                    cmd.Parameters.AddWithValue("@orderId", orderId);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        public DataSet GetAll(int informationAssistantId)
        {
            using (SqlConnection conn = new SqlConnection(DBHelper.GetConnection()))
            {
                DataSet result = new DataSet();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = @"Select [RevisitContent] as RevisitContent,[RevisitDateTime] as RevisitTime
                                  from Revisit
                                  where InformationAssistantId = @informationAssistantId
                                  order by RevisitDateTime desc";
                try
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@informationAssistantId", informationAssistantId);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
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

        public DataSet GetCustomerVisitAll(int customerOrderId)
        {
            using (SqlConnection conn = new SqlConnection(DBHelper.GetConnection()))
            {
                DataSet result = new DataSet();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = @"Select [RevisitContent] as RevisitContent,[RevisitDateTime] as RevisitTime
                                  from dbo.CustomerRevisit
                                  where CustomerOrderId = @customerOrderId
                                  order by RevisitDateTime desc";
                try
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@customerOrderId", customerOrderId);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
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

        public DataSet GetDesignerVisitAll(string designerId, int orderId)
        {
            using (SqlConnection conn = new SqlConnection(DBHelper.GetConnection()))
            {
                DataSet result = new DataSet();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = @"Select [RevisitContent] as RevisitContent,[RevisitDateTime] as RevisitTime
                                  from dbo.DesigerRevisit r,dbo.CustomerOrder o
                                  where o.designerId=@designerId
                                  and o.OrderId = @orderId
                                  and r.OrderId=o.OrderId
                                  order by RevisitDateTime desc";
                try
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@DesignerId", designerId);
                    cmd.Parameters.AddWithValue("@orderId", orderId);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
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

    }
}
