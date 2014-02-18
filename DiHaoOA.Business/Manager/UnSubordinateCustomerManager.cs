using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DiHaoOA.DataContract.DAO;
using System.Data;

namespace DiHaoOA.Business.Manager
{
    public class UnSubordinateCustomerManager
    {
        UnSubordinateCustomerDAO unsubordinateDao;

        public UnSubordinateCustomerManager()
        {
            unsubordinateDao = new UnSubordinateCustomerDAO();
        }

        public DataSet GetAll()
        {
            return unsubordinateDao.GetAll();
        }
    }
}
