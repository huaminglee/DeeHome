using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DiHaoOA.DataContract.Entity;
using System.Data.SqlClient;

namespace DiHaoOA.DataContract.DAO
{
    public class EditEmployeeDAO
    {
        public void EditEmployee(Employee employee)
        {
            using (SqlConnection conn = new SqlConnection(DBHelper.GetConnection()))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = @"update Employee
                                    set Name = @Name,
                                    Password = @Password,
                                    PhoneNumber = @PhoneNumber
                                    where EmployeeId = @EmployeeId";
                cmd.Parameters.AddWithValue("@Name",employee.Name);
                cmd.Parameters.AddWithValue("@Password",employee.Password);
                cmd.Parameters.AddWithValue("@PhoneNumber",employee.PhoneNumber);
                cmd.Parameters.AddWithValue("@EmployeeId",employee.EmployeeId);
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally {
                    cmd.Dispose();
                    conn.Close();
                }
            }
        }
    }
}
