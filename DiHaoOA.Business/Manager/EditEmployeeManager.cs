using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DiHaoOA.DataContract.Entity;
using DiHaoOA.DataContract.DAO;

namespace DiHaoOA.Business.Manager
{
    public class EditEmployeeManager
    {
        EditEmployeeDAO editEmployeeDao;

        public EditEmployeeManager()
        {
            editEmployeeDao = new EditEmployeeDAO();
        }
        public void EditEmployee(Employee employee)
        {
            editEmployeeDao.EditEmployee(employee);
        }
    }
}
