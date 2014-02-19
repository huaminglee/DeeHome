using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using DiHaoOA.DataContract.Entity;

namespace DiHaoOA.DataContract.DAO
{
    public class OrderDAO
    {
        public void AddOrderDescription(string description,Order order)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                SqlCommand cmd = new SqlCommand(DBHelper.GetConnection());
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

    }
}
