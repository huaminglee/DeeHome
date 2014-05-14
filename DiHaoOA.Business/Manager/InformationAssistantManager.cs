using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DiHaoOA.DataContract.DAO;
using System.Data;
using DiHaoOA.DataContract.Entity;

namespace DiHaoOA.Business.Manager
{
    public class InformationAssistantManager
    {
        InformationAssistantDAO informationAssistantDao;

        public InformationAssistantManager()
        {
            informationAssistantDao = new InformationAssistantDAO();
        }

        public bool IsEmployeeActive(int informationAssistantId)
        {
            return informationAssistantDao.IsEmployeeActive(informationAssistantId);
        }

        public DataSet GetAll()
        {
            return informationAssistantDao.GetAll();
        }

        public DataSet GetIAByEmployeeId(string employeeId)
        {
            return informationAssistantDao.GetIAByEmployeeId(employeeId);
        }

        public void Delete(int informationAssistantId)
        {
            informationAssistantDao.Delete(informationAssistantId);
        }

        public DataSet GetInformationAssistant(int pageIndex, int pageSize, string input, string procedureName)
        {
            return informationAssistantDao.GetInformationAssistant(pageIndex, pageSize, input, procedureName);
        }

        public int GetTotalRecords(int pageIndex, int pageSize, string input, string procedureName)
        {
            return informationAssistantDao.GetTotalRecords(pageIndex, pageSize, input, procedureName);
        }

        public void SetUnSunordinate(int informationAssistantId)
        {
            informationAssistantDao.SetUnSunordinate(informationAssistantId);
        }

        public void TransferInformationAssistant(string employeeId, int informationAssistantId)
        {
            informationAssistantDao.TransferInformationAssistant(employeeId, informationAssistantId);
        }

        public InformationAssistant GetInformationAssistantById(int informationAssistantId)
        {
            return informationAssistantDao.GetInformationAssistantById(informationAssistantId);
        }

        public void UpdateLevelToSilver(InformationAssistant ia)
        {
            informationAssistantDao.UpdateLevelToSilver(ia);
        }
        public void UpdateLevelToGold(InformationAssistant ia)
        {
            informationAssistantDao.UpdateLevelToGold(ia);
        }
    }
}
