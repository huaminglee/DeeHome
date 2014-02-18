using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiHaoOA.DataContract
{
    public class ProcessDAO
    {
        public static bool Execute(Action action)
        {
            try
            {
                action.Invoke();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            { 
                
            }
        }
    }
}
