using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DiHaoOA.DataContract.DAO
{
    public class UnSubordinateCustomerDAO
    {
        public DataSet GetAll()
        {
            using (SqlConnection conn = new SqlConnection(DBHelper.GetConnection()))
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = @"select CompanyName,ContactPerson,
                                    ContactPersonNumber,City,Email,
                                    DecorationAddress,CustomerType
                                    from dbo.Customer
                                    where InformationAssistantId is null and
                                    EmployeeId is null";
                try
                {
                    conn.Open();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(ds);
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
                return ds;
            }
        }
    }
}
