using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DiHaoOA.DataContract.DAO;
using System.Data;

namespace DiHaoOA.Business.Manager
{
    public class RevisitPopUpManager
    {
        RevisitPopUpDAO revisitPopUpDao;

        public RevisitPopUpManager()
        {
            revisitPopUpDao = new RevisitPopUpDAO();
        }

        public void SaveRevisit(string content, DateTime dateTime, int informationAssistantId)
        {
            revisitPopUpDao.SaveRevisit(content, dateTime, informationAssistantId);
        }

        public DataSet GetAll(int informationAssistantId)
        {
            return revisitPopUpDao.GetAll(informationAssistantId);
        }

        public void SaveCustomerRevisit(string content, DateTime dateTime, int customerId)
        {
            revisitPopUpDao.SaveCustomerRevisit(content, dateTime, customerId);
        }

        public DataSet GetCustomerVisitAll(int customerOrderId)
        {
            return revisitPopUpDao.GetCustomerVisitAll(customerOrderId);
        }
        public DataSet GetDesignerVisitAll(string designgerId,int orderId)
        {
            return revisitPopUpDao.GetDesignerVisitAll(designgerId, orderId);
        }

        public void SaveDesignerRevisit(string content, DateTime dateTime, int orderId)
        {
            revisitPopUpDao.SaveDesignerRevisit(content, dateTime, orderId);
        }
    }   
}
