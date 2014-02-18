using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiHaoOA.DataContract.Entity
{
    public class Employee
    {
        public string EmployeeId { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Department { get; set; }
        public string PhoneNumber { get; set; }
        public Role Roles { get; set; }
        public bool IsActive { get; set; }
    }
}
