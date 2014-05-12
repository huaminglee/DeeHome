using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DiHaoOA.DataContract.DAO
{
    public class DisplayVisitContentDAO
    {
        private const string pro_VisitContentPaging = "pro_VisitContentPaging";

        public DataSet GetVisitContent(string employeeId,int pageIndex,int pageSize)
        {
            DataSet result = new DataSet();
            SqlConnection conn = null;
            SqlCommand cmd = null;
            SqlDataAdapter sda = null;
            try
            {
                using (conn = new SqlConnection(DBHelper.GetConnection()))
                {
                    cmd = new SqlCommand(pro_VisitContentPaging, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter pageIndexP = cmd.Parameters.Add("@pageIndex", SqlDbType.Int);
                    SqlParameter pageSizeP = cmd.Parameters.Add("@pageSize", SqlDbType.Int);
                    SqlParameter employeeIdP = cmd.Parameters.Add("@EmployeeId", SqlDbType.NVarChar, 50);
                    SqlParameter totalRecordsP = cmd.Parameters.Add("@TotalRecords", SqlDbType.Int);
                    pageIndexP.Value = pageIndex;
                    pageSizeP.Value = pageSize;
                    employeeIdP.Value = employeeId;
                    totalRecordsP.Direction = ParameterDirection.Output;
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

        public int GetTotalRecords(string employeeId, int pageIndex, int pageSize)
        {
            DataSet result = new DataSet();
            SqlConnection conn = null;
            SqlCommand cmd = null;
            SqlDataAdapter sda = null;
            int totalRecords = 0;
            try
            {
                using (conn = new SqlConnection(DBHelper.GetConnection()))
                {
                    cmd = new SqlCommand(pro_VisitContentPaging, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter pageIndexP = cmd.Parameters.Add("@pageIndex", SqlDbType.Int);
                    SqlParameter pageSizeP = cmd.Parameters.Add("@pageSize", SqlDbType.Int);
                    SqlParameter employeeIdP = cmd.Parameters.Add("@EmployeeId", SqlDbType.NVarChar, 50);
                    SqlParameter totalRecordsP = cmd.Parameters.Add("@TotalRecords", SqlDbType.Int);
                    pageIndexP.Value = pageIndex;
                    pageSizeP.Value = pageSize;
                    employeeIdP.Value = employeeId;
                    totalRecordsP.Direction = ParameterDirection.Output;
                    sda = new SqlDataAdapter(cmd);
                    sda.Fill(result);
                    totalRecords = Convert.ToInt32(totalRecordsP.Value);
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
            return totalRecords;;
        }

        public DataSet GetDesignerVisitContent(int OrderId, int pageIndex, int pageSize)
        {
            DataSet result = new DataSet();
            SqlConnection conn = null;
            SqlCommand cmd = null;
            SqlDataAdapter sda = null;
            try
            {
                using (conn = new SqlConnection(DBHelper.GetConnection()))
                {
                    cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = @"
                                declare @startRow int
                                declare @lastRow int
                                set @startRow = (@pageIndex -1)*@pageSize + 1
                                set @lastRow = @pageIndex * @pageSize

                                select * from (
                                        Select Row_Number() over(order by RevisitDateTime) rowNumber ,
                                        [RevisitContent] as RevisitContent,
                                        [RevisitDateTime] as RevisitTime
                                        from dbo.DesigerRevisit r
                                        where r.OrderId = @OrderId
                                       --and CONVERT(varchar(100), r.RevisitDateTime, 111)=CONVERT(varchar(100), getdate(), 111)
                                        ) as tempTable
                                        where rowNumber between @startRow and @lastRow";
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
                conn.Dispose();
                cmd.Dispose();
            }
            return result;
        }

        public int GetTotalRecordsForDesignerVisit(int OrderId)
        {
            using (SqlConnection con = new SqlConnection(DBHelper.GetConnection()))
            {
                SqlCommand cmd = new SqlCommand();
                int result = 0;
                cmd.Connection = con;
                cmd.CommandText = @"select count(*) 
                               from dbo.DesigerRevisit r
                               where r.OrderId = @OrderId";
                try
                {
                    con.Open();
                    result = Convert.ToInt32(cmd.ExecuteScalar());
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    con.Close();
                    con.Dispose();
                    cmd.Dispose();
                }
                return result;
            }
        }
    }
}
