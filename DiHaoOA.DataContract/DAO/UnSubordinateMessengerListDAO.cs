using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DiHaoOA.DataContract.Entity;

namespace DiHaoOA.DataContract.DAO
{
    public class UnSubordinateMessengerListDAO
    {
        const string PRO_UNSUBORDINATEPAGING = "pro_UnSubordinateMessengerList";

        public DataSet GetAll(int pageIndex,int pageSize)
        {
            using (SqlConnection conn = new SqlConnection(DBHelper.GetConnection()))
            {
                SqlCommand cmd = new SqlCommand(PRO_UNSUBORDINATEPAGING,conn);
                cmd.CommandType = CommandType.StoredProcedure;
                DataSet ds = new DataSet() ;
                try
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@pageIndex", pageIndex);
                    cmd.Parameters.AddWithValue("@pageSize", pageSize);
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

        public InformationAssistant GetInformationAssistantById(int informationAssistantId)
        {
            using (SqlConnection con = new SqlConnection(DBHelper.GetConnection()))
            {
                SqlCommand cmd = new SqlCommand();
                InformationAssistant informationAssistant = new InformationAssistant();
                try
                {
                    con.Open();
                    cmd.Connection = con;

                    cmd.CommandText = @"select InformationAssistantName,PhoneNumber,Type,
                                  Company,City,InformationLevel,ReVisitTime,OrderId,Address,
                                  ReVisistPeriod,IsVisit,HandSet
                                  from InformationAssistant
                                  where InformationAssistantId = @InformationAssistantId";
                    cmd.Parameters.AddWithValue("@InformationAssistantId", informationAssistantId);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        informationAssistant.InformationAssistantId = informationAssistantId;
                        informationAssistant.InformationAssistantName = reader.GetString(0);
                        informationAssistant.PhoneNumber = reader.GetString(1);
                        informationAssistant.Type = reader.GetString(2);
                        informationAssistant.Company = reader.GetString(3);
                        informationAssistant.City = reader.GetString(4);
                        informationAssistant.InformationLevel = reader.GetString(5);
                        informationAssistant.ReVisitTime = "10";
                        informationAssistant.Address = reader.IsDBNull(8) ? "" : reader.GetString(8);
                        informationAssistant.IsVisit = reader.IsDBNull(10) ? false : reader.GetBoolean(10);
                        informationAssistant.HandSet = reader.IsDBNull(11) ? "" : reader.GetString(11);
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
                return informationAssistant;
            }
        }
    }
}
