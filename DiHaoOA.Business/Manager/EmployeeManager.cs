using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DiHaoOA.DataContract;
using DiHaoOA.DataContract.Entity;
using System.Data;

namespace DiHaoOA.Business
{
    public class EmployeeManager
    {
        EmployeeDAO employeeDao;

        public EmployeeManager()
        {
            employeeDao = new EmployeeDAO();
        }

        public bool ValidateEmployee(string employeeId, string password)
        {
            return employeeDao.ValidateEmployee(employeeId, password);
        }

        public Employee GetEmployeeById(string employeeId)
        {
            return employeeDao.GetEmployeeById(employeeId);
        }

        public DataSet GetAll()
        {
            return employeeDao.GetAll();
        }

        public DataSet GetEmployeeGroup()
        {
            return employeeDao.GetEmployeeGroup();
        }

        public DataSet GetDesignerByGroupId(int groupId)
        {
            return employeeDao.GetDesignerByGroupId(groupId);
        }

        public DataSet GetDesigner()
        {
            return employeeDao.GetDesigner();
        }

        public void AllocateDesignerToGroup(string designerId, int groupId)
        {
            employeeDao.AllocateDesignerToGroup(designerId, groupId);
        }

        public DataSet GetSalesMan()
        {
            return employeeDao.GetSalesMan();
        }

        public string GetGroupNameByEmployeeId(string employeeId)
        {
            return employeeDao.GetGroupNameByEmployeeId(employeeId);
        }

    }   
}
