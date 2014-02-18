using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using DiHaoOA.DataContract;

namespace DiHaoOA.Security
{
    public class RolesManager
    {
        public string GetEmployeeRole(string employeeId)
        {
            string result = null;
            SqlConnection conn = null;
            SqlCommand cmd = null;
            try
            {
                conn = new SqlConnection(DBHelper.GetConnection());
                conn.Open();
                cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = @"Select r.Role 
                                    from Employee e , SecurityRoles r
                                    where e.RoleId = r.Id
                                    and e.EmployeeId = @employeeId";
                cmd.Parameters.AddWithValue("@employeeId", employeeId);
                result = Convert.ToString(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
                conn.Dispose();
                cmd.Dispose();
            }
            return result;
        }
    }
}
