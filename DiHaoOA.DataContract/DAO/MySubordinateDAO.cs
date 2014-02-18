using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace DiHaoOA.DataContract.DAO
{
    public class MySubordinateDAO
    {
        public int GetVisitCount(string employeeId)
        {
            using (SqlConnection conn = new SqlConnection(DBHelper.GetConnection()))
            {
                SqlCommand cmd = new SqlCommand();
                int result = 0;
                cmd.Connection = conn;
                cmd.CommandText = @"select count(*) as VisitCount,
                                    e.Name as EmployeeName
	                                from Employee e, Revisit r ,InformationAssistant i
	                                where e.EmployeeId = i.EmployeeId
                                    and e.EmployeeId = @EmployeeId
                                    and i.InformationAssistantId = r.InformationAssistantId
                                    and CONVERT(varchar(100), r.RevisitDateTime, 111)=CONVERT(varchar(100), getdate(), 111)
                                    group by e.Name";
                cmd.Parameters.AddWithValue("@EmployeeId", employeeId);
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

        public int GetInformationAssistantCount(string employeeId)
        {
            using (SqlConnection conn = new SqlConnection(DBHelper.GetConnection()))
            {
                SqlCommand cmd = new SqlCommand();
                int result = 0;
                cmd.Connection = conn;
                cmd.CommandText = @"select count(*) as InformationAssistantCount,
                                    e.Name as EmployeeName
	                                from Employee e ,InformationAssistant i
	                                where e.EmployeeId = i.EmployeeId
                                    and e.EmployeeId = @EmployeeId
                                    and CONVERT(varchar(100), i.RecordDate, 111)=CONVERT(varchar(100), getdate(), 111)
                                    group by e.Name";
                cmd.Parameters.AddWithValue("@EmployeeId", employeeId);
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

        public int GetCustomerCount(string employeeId)
        {
            using (SqlConnection conn = new SqlConnection(DBHelper.GetConnection()))
            {
                SqlCommand cmd = new SqlCommand();
                int result = 0;
                cmd.Connection = conn;
                cmd.CommandText = @"select count(*) as CustomerCount,
                                    e.Name as EmployeeName
	                                from Employee e ,InformationAssistant i,
	                                Customer c,CustomerOrder o
	                                where e.EmployeeId = i.EmployeeId
                                    and e.EmployeeId = @EmployeeId
	                                and c.InformationAssistantId = i.InformationAssistantId
                                    and o.CustomerId = c.CustomerId
                                    and CONVERT(varchar(100), o.RecordDate, 111)=CONVERT(varchar(100), getdate(), 111)
                                    group by e.Name";
                cmd.Parameters.AddWithValue("@EmployeeId", employeeId);
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
    }
}
