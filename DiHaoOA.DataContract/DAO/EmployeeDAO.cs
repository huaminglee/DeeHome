using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using DiHaoOA.DataContract.Entity;
using System.Data;

namespace DiHaoOA.DataContract
{
    public class EmployeeDAO
    {
        public bool ValidateEmployee(string employeeId, string password)
        {
            string result = null;
            SqlConnection conn = null; ;
            SqlCommand cmd = null;
            try
            {
                using (conn = new SqlConnection(DBHelper.GetConnection()))
                {
                    cmd = new SqlCommand();
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.CommandText = @"Select Password 
                                        From Employee
                                        Where EmployeeId = @EmployeeId";
                    cmd.Parameters.AddWithValue("@EmployeeId", employeeId);
                    result = Convert.ToString(cmd.ExecuteScalar());
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
                conn.Dispose();
                cmd.Dispose();
            }
            if (result == password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Employee GetEmployeeById(string employeeId)
        {
            Employee emp = new Employee();
            using (SqlConnection conn = new SqlConnection(DBHelper.GetConnection()))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = @"Select EmployeeId,Name,Password,
                                    Department,PhoneNumber,RoleId,IsActive 
                                    from Employee
                                    where EmployeeId = @employeeId";
                cmd.Parameters.AddWithValue("@employeeId", employeeId);
                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        emp.EmployeeId = employeeId;
                        emp.Name = reader.GetString(1);
                        emp.Password = reader.GetString(2);
                        emp.Department = reader.GetString(3);
                        emp.PhoneNumber = reader.GetString(4);
                        emp.Roles = GetRolesById(reader.GetInt32(5));
                        emp.IsActive = reader.GetBoolean(6);
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
                return emp;
            }
        }

        private Role GetRolesById(int roleId)
        {
            Role role = new Role();
            using (SqlConnection conn = new SqlConnection(DBHelper.GetConnection()))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = @"select Id,Role,ActivitId
                                    from SecurityRoles
                                    where Id = @roleId";
                try
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@roleId", roleId);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        role.RoleId = roleId;
                        role.Roles = reader.GetString(1);
                        role.Acitivities = GetAcitivities(reader.GetInt32(2));
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
                return role;
            }
        }

        private string GetAcitivities(int acitivityId)
        {
            using (SqlConnection conn = new SqlConnection(DBHelper.GetConnection()))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = @"select Id,Activity
                                    from SecurityActivities
                                    where Id = @acitivityId";
                string result = string.Empty;
                try
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@acitivityId", acitivityId);
                    result = cmd.ExecuteScalar().ToString();
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

        public DataSet GetAll()
        {
            using (SqlConnection conn = new SqlConnection(DBHelper.GetConnection()))
            {
                SqlCommand cmd = new SqlCommand();
                DataSet ds = new DataSet();
                cmd.Connection = conn;
                cmd.CommandText = @"select EmployeeId,Name
                                    from Employee
                                    where EmployeeId != 'swb800024'";
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
