using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace DiHaoOA.DataContract.DAO
{
    public class AllListForMarketingDAO
    {
        const string PRO_ALLLISTPAGING = "pro_AllListPagingForManager";

        public int GetTotalRows(string input)
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
                                      from InformationAssistant i, Employee e
                                      where i.EmployeeId = e.EmployeeId
                                      and i.EmployeeId != @BalckEmployeeId
                                      and (InformationAssistantName like '%'+@input+'%'
                                      or [Type] like '%'+@input+'%'
                                      or Company like '%'+@input+'%'
                                      or InformationLevel like '%'+@input+'%'
                                      or InformationAssistantName like '%'+@input+'%'
                                      or e.Name like '%'+@input+'%'
                                      or @input = '')";
                    cmd.Parameters.AddWithValue("@input", input);
                    cmd.Parameters.AddWithValue("@BalckEmployeeId",DBHelper.GetBlackListEmployee());
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

        public DataSet GetAllList(int pageIndex,int pageSize,string input)
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
                    cmd.Parameters.AddWithValue("@input", input);
                    cmd.Parameters.AddWithValue("@BlackEmployeeId", DBHelper.GetBlackListEmployee());
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
    }
}
