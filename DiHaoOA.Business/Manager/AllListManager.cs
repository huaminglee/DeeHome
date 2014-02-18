using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DiHaoOA.DataContract;
using DiHaoOA.DataContract.Entity;

namespace DiHaoOA.Business
{
    public class AllListManager
    {
        AllListDAO allListDAO;

        public AllListManager()
        {
            allListDAO = new AllListDAO();
        }

        public DataSet GetAllList(int startrow, int lastRow,string eventCode,string input,string employeeId)
        {
            return allListDAO.GetAllList(startrow, lastRow, eventCode,input,employeeId);
        }

        public int GetTotalRows(string informationLevel,string input,string employeeId)
        {
            return allListDAO.GetTotalRows(informationLevel, input, employeeId);
        }

       
    }
}
