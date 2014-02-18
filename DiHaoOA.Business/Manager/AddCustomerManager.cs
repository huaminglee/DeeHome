using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DiHaoOA.DataContract.DAO;
using DiHaoOA.DataContract.Entity;

namespace DiHaoOA.Business.Manager
{
    public class AddCustomerManager
    {
        AddCustomerDAO addCustomerDao;

        public AddCustomerManager()
        {
            addCustomerDao = new AddCustomerDAO();
        }

        public void SaveCustomer(Customer customer,Order order)
        {
            addCustomerDao.SaveCustomer(customer, order);
        }

        public int GetCustomId()
        {
            return addCustomerDao.GetCustomerId();
        }

        public bool IsPhoneNumberExist(string phoneNumber)
        {
            return addCustomerDao.IsPhoneNumberExist(phoneNumber);
        }

        public bool IsPhoneNumber2Exist(string phoneNumber2)
        {
            return addCustomerDao.IsPhoneNumber2Exist(phoneNumber2);
        }

        public bool IsPhoneNumber3Exist(string phoneNumber3)
        {
            return addCustomerDao.IsPhoneNumber3Exist(phoneNumber3);
        }

        public string GetNotifyMsgIfNumberExist(string phoneNumber)
        {
            return addCustomerDao.GetNotifyMsgIfNumberExist(phoneNumber);   
        }

        public string GetNotifyMsgIfNumber2Exist(string phoneNumber2)
        {
            return addCustomerDao.GetNotifyMsgIfNumber2Exist(phoneNumber2);   
        }

        public string GetNotifyMsgIfNumber3Exist(string phoneNumber3)
        {
            return addCustomerDao.GetNotifyMsgIfNumber3Exist(phoneNumber3);
        }

        public void UpdateLevelToCopper(InformationAssistant ia)
        {
            addCustomerDao.UpdateLevelToCopper(ia);
        }

    }
}
