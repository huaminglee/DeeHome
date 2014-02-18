using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DiHaoOA.DataContract;
using DiHaoOA.DataContract.Entity;

namespace DiHaoOA.Business.Manager
{
    public class AddInformationAssistantManager
    {
        AddInformationAssistantDAO addInformationAssistantDAO;

        public AddInformationAssistantManager()
        {
            addInformationAssistantDAO = new AddInformationAssistantDAO();
        }

        public void AddMessenger(InformationAssistant informationAssistant)
        {
            addInformationAssistantDAO.AddMessenger(informationAssistant);
        }

        public bool IsNameExist(string name)
        {
            return addInformationAssistantDAO.IsNameExist(name);
        }

        public bool IsPhoneNumberExist(string phoneNumber)
        {
            return addInformationAssistantDAO.IsPhoneNumberExist(phoneNumber);
        }

        public string GetNotifyMsgIfNumberExist(string phoneNumber)
        {
            return addInformationAssistantDAO.GetNotifyMsgIfNumberExist(phoneNumber);
        }
    }
}
