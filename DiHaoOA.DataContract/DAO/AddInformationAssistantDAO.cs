using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DiHaoOA.DataContract.Entity;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using DiHaoOA.DataContract.DAO;

namespace DiHaoOA.DataContract
{
    public class AddInformationAssistantDAO
    {
        EmployeeDAO empDao;
       

        public AddInformationAssistantDAO()
        {
            empDao = new EmployeeDAO();
        }

        public void AddMessenger(InformationAssistant informationAssistant)
        {
            using (SqlConnection conn = new SqlConnection(DBHelper.GetConnection()))
            {
                int informationAssistantId = GetMaxId() + 1;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = @"insert into InformationAssistant
                                        values(@InformationAssistantId,@InformationAssistantName,
                                               @PhoneNumber,@Type,@Company,@City,@InformationLevel,@ReVisitTime,
                                               null,@Address,@ReVisistPeriod,@IsVisit,@HandSet,
                                               @EmployeeId,@VisitDateTime,@RecordDateTime)";
                cmd.Parameters.AddWithValue("@InformationAssistantId", informationAssistantId);
                cmd.Parameters.AddWithValue("@InformationAssistantName", informationAssistant.InformationAssistantName);
                cmd.Parameters.AddWithValue("@PhoneNumber", informationAssistant.PhoneNumber);
                cmd.Parameters.AddWithValue("@Type", informationAssistant.Type);
                cmd.Parameters.AddWithValue("@Company", informationAssistant.Company);
                cmd.Parameters.AddWithValue("@City", informationAssistant.City);
                cmd.Parameters.AddWithValue("@InformationLevel", informationAssistant.InformationLevel);
                cmd.Parameters.AddWithValue("@ReVisitTime", informationAssistant.ReVisitTime);
                cmd.Parameters.AddWithValue("@Address", informationAssistant.Address);
                cmd.Parameters.AddWithValue("@ReVisistPeriod", informationAssistant.ReVisistPeriod);
                cmd.Parameters.AddWithValue("@IsVisit", informationAssistant.IsVisit);
                cmd.Parameters.AddWithValue("@HandSet", informationAssistant.HandSet);
                cmd.Parameters.AddWithValue("@EmployeeId", informationAssistant.Employees.EmployeeId);
                cmd.Parameters.AddWithValue("@VisitDateTime", informationAssistant.VisitDateTime);
                cmd.Parameters.AddWithValue("@RecordDateTime", informationAssistant.RecordDateTime);
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
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

        public int GetMaxId()
        {
            using (SqlConnection conn = new SqlConnection(DBHelper.GetConnection()))
            {
                SqlCommand cmd = new SqlCommand();
                int result;
                try
                {
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.CommandText = @"select isNull(max(InformationAssistantId),0) 
                                  from InformationAssistant";
                    result = cmd.ExecuteScalar() == DBNull.Value ? 0 : Convert.ToInt32(cmd.ExecuteScalar());
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
                    if (cmd.ExecuteScalar() != null)
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

        public bool IsPhoneNumberExist(string phoneNumber)
        {
            using (SqlConnection con = new SqlConnection(DBHelper.GetConnection()))
            {
                string result;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = @"select PhoneNumber
                                    from InformationAssistant
                                    where PhoneNumber = @PhoneNumber";
                cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                try
                {
                    con.Open();
                    result = Convert.ToString(cmd.ExecuteScalar());
                    if (cmd.ExecuteScalar() != null)
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

        public string GetNotifyMsgIfNumberExist(string phoneNumber)
        {
            using (SqlConnection conn = new SqlConnection(DBHelper.GetConnection()))
            {
                string result = string.Empty;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = @"select EmployeeId,RecordDate,InformationAssistantName 
                                    from InformationAssistant
                                    where PhoneNumber = @PhoneNumber";
                cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        string recordate = (reader.IsDBNull(1) ? DateTime.Now : reader.GetDateTime(1)).ToString();
                        string iaName = reader.GetString(2);
                        string empName = empDao.GetEmployeeById(reader.GetString(0)).Name;
                        result = "*" + iaName+" " + empName + " ";
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
                return result;
            }
        }


    }
}
