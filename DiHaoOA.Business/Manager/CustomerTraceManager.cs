using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DiHaoOA.DataContract.DAO;
using System.Data;
using DiHaoOA.DataContract.Entity;

namespace DiHaoOA.Business.Manager
{
    public class CustomerTraceManager
    {
        CustomerTraceDAO customerTraceDao;

        public CustomerTraceManager()
        {
            customerTraceDao = new CustomerTraceDAO();
        }

        public DataSet GetAllOrders(int pageIndex, int pageSize, string eventCode, string input,string employeeId)
        {
            return customerTraceDao.GetAllOrders(pageIndex, pageSize, eventCode, input, employeeId);
        }

        public int GetTotalRecords(string orderStaus, string input,string employeeId)
        {
            return customerTraceDao.GetTotalRecords(orderStaus, input, employeeId);
        }

        public int GetOrderNumber()
        {
            return customerTraceDao.GetOrderNumber();
        }

        public InformationAssistant GetInformationAssistantByOrderId(int orderId)
        {
            return customerTraceDao.GetInformationAssistantByOrderId(orderId);
        }
    }
}
