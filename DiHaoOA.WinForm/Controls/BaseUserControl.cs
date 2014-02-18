using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DiHaoOA.DataContract.Entity;

namespace DiHaoOA.Controls
{
    public interface IExtServiceProvider : IServiceProvider
    {
        void AddService(Type type, object o);
    }

    public class BaseUserControl2 : UserControl
    {
        private Panel parentPanel;
        private NavBar navigationBar;
        private string menu;
        private string childMenu;
        private Employee employee;

        public Panel ParentPanel { 
            get {
                return parentPanel;
             } 
        }
        public NavBar NavigationBar{
            get{
                return navigationBar;
            }
        }
        public string Menu{
            get{
                return menu;
            }
        }//对应的菜单选项
        public string ChildMenu{
            get{
                return childMenu;
            }
        }//对应的子菜单选项
        public Employee Employee { 
            get{
                return employee;
            }
         }


        protected void InitializeProperties(IExtServiceProvider p)
        {
            p.GetService(typeof(Panel));
        }


    }

    public class BaseUserControl : UserControl
    {
        public Panel ParentPanel;
        public NavBar NavigationBar;
        public string Menu;
        public string ChildMenu;
        public Employee employee;
    }
}
