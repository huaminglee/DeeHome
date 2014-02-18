using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DiHaoOA.DataContract.DAO;
using System.Data;

namespace DiHaoOA.Business.Manager
{
    public class AllListForMarketingManager
    {
        AllListForMarketingDAO allListForMarketingDAO;

        public AllListForMarketingManager()
        {
            allListForMarketingDAO = new AllListForMarketingDAO();   
        }

        public int GetTotalRows(string input)
        {
            return allListForMarketingDAO.GetTotalRows(input);
        }

        public DataSet GetAllList(int pageIndex,int pageSize,string input)
        {
            return allListForMarketingDAO.GetAllList(pageIndex, pageSize, input);
        }
    }
}
