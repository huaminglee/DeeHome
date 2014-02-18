using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DiHaoOA.DataContract.DAO;

namespace DiHaoOA.Business.Manager
{
    public class EditUnSubordinateIAManager
    {
        EditUnSubordinateIADAO editUnSubordinateDao;

        public EditUnSubordinateIAManager()
        {
            editUnSubordinateDao = new EditUnSubordinateIADAO();
        }

        public void TransferInformationAssistant(string employeeId, int informationAssistantId)
        {
            editUnSubordinateDao.TransferInformationAssistant(employeeId, informationAssistantId);
        }

        public bool IsEmployeeIdExist(string employeeId)
        {
            return editUnSubordinateDao.IsEmployeeIdExist(employeeId);
        }

        public void TransferCustomer(string employeeId, int informationAssistantId)
        {
            editUnSubordinateDao.TransferCustomer(employeeId, informationAssistantId);
        }

    }
}
