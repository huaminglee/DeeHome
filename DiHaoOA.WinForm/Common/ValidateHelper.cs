using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace DiHaoOA.WinForm.Common
{
    public class ValidateHelper
    {
        public static bool ValidateName(string name)
        {
            string reg = @"^[A-Za-z0-9]*[\u4e00-\u9fa5]*[A-Za-z0-9]*$";
            return Regex.IsMatch(name, reg);
        }

        public static bool ValidatePhoneNumber(string number)
        {
            string regStr = @"^\d{11}$";
            return Regex.IsMatch(number, regStr);
        }

        public static bool ValidateHandSet(string number)
        {
            string reg = @"^\d{3}-\d{8}$";
            return Regex.IsMatch(number,reg);
        }


        public static bool ValidateEmail(string email)
        {
            string reg = @"^[\w]+@[\w]+.[a-zA-Z]+$";
            return Regex.IsMatch(email.Trim(),reg);
        }

        public static bool ValidateEmployeeId(string employeeId)
        {
            string reg = @"^\d+$";
            return Regex.IsMatch(employeeId.Trim(), reg);
        }
    }
}
