using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DiHaoOA.DataContract;
using DiHaoOA.DataContract.Entity;
using DiHaoOA.DataContract.DAO;

namespace DiHaoOA.Business.Manager
{
    public class ModifyCustomerManager
    {
        ModifyCustomerDAO modifyCustomerDAO;

        public ModifyCustomerManager()
        {
            modifyCustomerDAO = new ModifyCustomerDAO();
        }
        public void UpdateCustomer(Order order)
        {
            modifyCustomerDAO.UpdateCustomer(order);
        }

        public Customer GetCustomerById(int customerId)
        {
           return  modifyCustomerDAO.GetCustomerById(customerId);
        }

        public Order GetOrderById(int orderId)
        {
            return modifyCustomerDAO.GetOrderById(orderId);
        }

        public InformationAssistant GetInformationAssistantByOrderId(int orderId)
        {
            return modifyCustomerDAO.GetInformationAssistantByOrderId(orderId);
        }

        public bool IsPhoneNumber2Exist(string number, int customerId)
        {
            return modifyCustomerDAO.IsPhoneNumber2Exist(number,customerId);
        }
        public bool IsPhoneNumber3Exist(string number, int customerId)
        {
            return modifyCustomerDAO.IsPhoneNumber3Exist(number, customerId);
        }
    } 
}
