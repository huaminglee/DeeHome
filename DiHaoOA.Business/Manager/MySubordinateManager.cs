using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DiHaoOA.DataContract.DAO;

namespace DiHaoOA.Business.Manager
{
    public class MySubordinateManager
    {
        MySubordinateDAO mySubordinateDao;

        public MySubordinateManager()
        {
            mySubordinateDao = new MySubordinateDAO();
        }

        public int GetVisitCount(string employeeId)
        {
            return mySubordinateDao.GetVisitCount(employeeId);
        }

        public int GetInformationAssistantCount(string employeeId)
        {
            return mySubordinateDao.GetInformationAssistantCount(employeeId);
        }

        public int GetCustomerCount(string employeeId)
        {
            return mySubordinateDao.GetCustomerCount(employeeId);
        }
    }

}
