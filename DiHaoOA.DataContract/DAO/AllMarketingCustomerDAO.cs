using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DiHaoOA.DataContract.DAO
{
    public class AllMarketingCustomerDAO
    {
        const string pro_AllCustomersPaging = "pro_AllCustomersPaging";

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
                                     from CustomerOrder o left outer join Customer c on o.CustomerId = c.CustomerId
	                                left outer join Employee d on d.EmployeeId = o.DesignerId
	                                left outer join InformationAssistant i on c.InformationAssistantId = i.InformationAssistantId
	                                left outer join Employee e on e.EmployeeId = c.EmployeeId
                                      where e.EmployeeId != @BlackEmployeeId
                                      and (o.OrderNumber like '%'+@input+'%'
                                      or c.CompanyName like '%'+@input+'%'
                                      or o.RecordDate like '%'+@input+'%'
                                      or o.OrderNumber like '%'+@input+'%'
                                      or c.DecorationAddress like '%'+@input+'%'
                                      or i.InformationAssistantName like '%'+@input+'%'
                                      or e.Name like '%'+@input+'%'
                                      or c.City like '%'+@input+'%'
                                      or @input='')";
                    cmd.Parameters.AddWithValue("@input", input);
                    cmd.Parameters.AddWithValue("@BlackEmployeeId",DBHelper.GetBlackListEmployee());
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

        public DataSet GetAll(int pageIndex,int pageSize,string input)
        {
            using (SqlConnection conn = new SqlConnection(DBHelper.GetConnection()))
            {
                DataSet result = new DataSet();
                SqlCommand cmd = new SqlCommand(pro_AllCustomersPaging, conn);
                SqlParameter pageIndexP = cmd.Parameters.Add("@pageIndex",SqlDbType.Int);
                SqlParameter pageSizeP = cmd.Parameters.Add("@pageSize",SqlDbType.Int);
                SqlParameter inputP = cmd.Parameters.Add("@input",SqlDbType.NVarChar,500);
                SqlParameter blackEmployeeIdP = cmd.Parameters.Add("@BlackEmployeeId", SqlDbType.NVarChar, 50);
                pageIndexP.Value = pageIndex;
                pageSizeP.Value = pageSize;
                inputP.Value = input;
                blackEmployeeIdP.Value = DBHelper.GetBlackListEmployee();
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                try
                {
                    conn.Open();
                    sda.Fill(result);
                    sda.Dispose();
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
