using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DiHaoOA.DataContract.DAO;
using System.Data;

namespace DiHaoOA.Business.Manager
{
   

    public class CustomerManager
    {
        CustomerDAO customerDao;

        public CustomerManager()
        {
            customerDao = new CustomerDAO();
        }

        public void TransferCustomer(int customerId, string employeeId)
        {
            customerDao.TransferCustomer(customerId,employeeId);
        }

        public void Delete(int customerId)
        {
            customerDao.Delete(customerId);
        }

        public DataSet GetCustomerList(int pageIndex, int pageSize, string input, string procedureName)
        {
            return customerDao.GetCustomerList(pageIndex, pageSize, input, procedureName);
        }

        public int GetTotalRecords(int pageIndex, int pageSize, string input, string procedureName)
        {
            return customerDao.GetTotalRecords(pageIndex, pageSize, input, procedureName);
        }

        public void SetUnSunordinate(int informationAssistantId)
        {
            customerDao.SetUnSunordinate(informationAssistantId);
        }

        public int GetInformationAssistantIdByCustomerId(int customerId)
        {
            return customerDao.GetInformationAssistantIdByCustomerId(customerId);
        }
    }
}
