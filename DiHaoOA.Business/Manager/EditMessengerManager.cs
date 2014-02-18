using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DiHaoOA.DataContract.Entity;
using DiHaoOA.DataContract.DAO;
using System.Data;

namespace DiHaoOA.Business.Manager
{
    public class EditMessengerManager
    {
        EditMessengerDAO editMessengerDao;

        public EditMessengerManager()
        {
            editMessengerDao = new EditMessengerDAO();
        }

        public InformationAssistant GetInformationAssistantById(int informationAssistantId)
        {
            return editMessengerDao.GetInformationAssistantById(informationAssistantId);
        }


        public void UpdateMessenger(InformationAssistant informationAssistant)
        {
            editMessengerDao.UpdateMessenger(informationAssistant);
        }

        public bool IsPhoneNumberExist(string phoneNumber, int informationAssistantId)
        {
            return editMessengerDao.IsPhoneNumberExist(phoneNumber, informationAssistantId);
        }
        public DataSet GetInformList(int informationAssistantId)
        {
            return editMessengerDao.GetInformList(informationAssistantId);
        }

        public DataSet GetTraceingInformList(int informationAssistantId)
        {
            return editMessengerDao.GetTraceingInformList(informationAssistantId);
        }
    }
}
