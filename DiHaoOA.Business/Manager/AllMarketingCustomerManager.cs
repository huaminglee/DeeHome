using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DiHaoOA.DataContract.DAO;
using System.Data;

namespace DiHaoOA.Business.Manager
{
    public class AllMarketingCustomerManager
    {
        AllMarketingCustomerDAO allMCDao;

        public AllMarketingCustomerManager()
        {
            allMCDao = new AllMarketingCustomerDAO();
        }

        public int GetTotalRows(string input)
        {
            return allMCDao.GetTotalRows(input);
        }

        public DataSet GetAll(int pageIndex, int pageSize, string input)
        {
            return allMCDao.GetAll(pageIndex,pageSize,input);
        }
    }
}
