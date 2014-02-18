using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DiHaoOA.DataContract.DAO;
using System.Data;
using DiHaoOA.DataContract.Entity;

namespace DiHaoOA.Business.Manager
{
    public class UnSubordinateMessengerListManager
    {
        UnSubordinateMessengerListDAO unSubordinateMessengerDao;

        public UnSubordinateMessengerListManager()
        {
            unSubordinateMessengerDao = new UnSubordinateMessengerListDAO();
        }

        public DataSet GetAll(int pageIndex,int pageSize)
        {
            return unSubordinateMessengerDao.GetAll(pageIndex,pageSize);
        }

        public InformationAssistant GetInformationAssistantById(int informationAssistantId)
        {
            return unSubordinateMessengerDao.GetInformationAssistantById(informationAssistantId);
        }
    }
}
