using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using DiHaoOA.DataContract.Entity;

namespace DiHaoOA.DataContract
{
    public class AllListDAO
    {
        const string PRO_ALLLISTPAGING = "pro_AllListPaging";

        public DataSet GetAllList(int pageIndex, int pageSize,string eventCode,string input,string employeeId)
        {
            DataSet result = new DataSet();
            SqlConnection conn = null;
            SqlCommand cmd = null;
            SqlDataAdapter sda = null;
            try
            {
                using (conn = new SqlConnection(DBHelper.GetConnection()))
                {
                    cmd = new SqlCommand(PRO_ALLLISTPAGING, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@pageIndex", pageIndex);
                    cmd.Parameters.AddWithValue("@pageSize", pageSize);
                    cmd.Parameters.AddWithValue("@InformationLevel", eventCode);
                    cmd.Parameters.AddWithValue("@input", input);
                    cmd.Parameters.AddWithValue("@EmployeeId", employeeId);
                    sda = new SqlDataAdapter(cmd);
                    sda.Fill(result);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
                conn.Dispose();
                sda.Dispose();
                cmd.Dispose();
            }
            return result;
        }

        public int GetTotalRows(string informationLevel, string input, string employeeId)
        {
            SqlConnection conn = null;
            SqlCommand cmd = null;
            int totalRows;
            try
            {
                using (conn = new SqlConnection(DBHelper.GetConnection()))
                {
                    conn.Open();
                    cmd = new SqlCommand();
                    cmd.CommandText = @"select count(*) 
                                      from InformationAssistant i left outer join Employee e
                                      on i.EmployeeId = e.EmployeeId
                                      where (InformationLevel = @InformationLevel or 
                                      @InformationLevel = 'InforAllList')
                                      and i.EmployeeId = @EmployeeId
                                      and (InformationAssistantName like '%'+@input+'%' 
                                      or i.PhoneNumber like  '%'+@input+'%'
                                      or [Type] like '%'+@input+'%'
                                      or Company like '%'+@input+'%'
                                      or City like '%'+@input+'%'
                                      or InformationLevel like '%'+@input+'%'
                                      or ReVisitTime like '%'+@input+'%'
                                      or e.Name like '%'+@input+'%'
                                      or @input = '')";
                    cmd.Parameters.AddWithValue("@InformationLevel", informationLevel);
                    cmd.Parameters.AddWithValue("@input",input);
                    cmd.Parameters.AddWithValue("@EmployeeId", employeeId);
                    cmd.Connection = conn;
                    totalRows = Convert.ToInt32(cmd.ExecuteScalar());
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
                conn.Dispose();
                
            }
            return totalRows;
        }
    }
}
