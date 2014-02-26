using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Xml.Linq;
using DiHaoOA.Controls;
using System.Configuration;
using DiHaoOA.WinForm;
using DiHaoOA.DataContract.Entity;
using DiHaoOA.WinForm.Forms;
using DiHaoOA.WinForm.Controls;
using DiHaoOA.DataContract;

namespace DiHaoOA
{
    public partial class DashboardForSalesMan : BaseForm
    {
        AllList allList;
        CustomerTrace customerTrace;

        public DashboardForSalesMan()
        {
            InitializeComponent();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
        }

        private void childbtnbtn_Click(object sender, EventArgs e)
        {
            Label btn = (Label)sender;
            string menu = btn.Parent.Name;
            if (menu == DiHaoMenu.InforManage)
            {
                ShowSpecificMenu();
                AddAllList();
                allList.LoadDataGrid(1, btn.Name, SearchInput.NoContent);
                allList.ClearSearchContent();
                
            }
            if (menu == DiHaoMenu.CustomerTrace)
            {
                ShowSpecificMenu();
                AddCustomerTrace();
                customerTrace.LoadDataGrid(1, btn.Name, SearchInput.NoContent);
                customerTrace.ClearSearchContent();
                
            }
            if (menu == DiHaoMenu.CustomerChat)
            {
                ShowSpecificMenu();

            }
        }

        private void ShowSpecificMenu()
        {
            foreach (Control control in pMainContent.Controls)
            {
                control.Visible = false;
            }
        }

        private void LoadMenu()
        {
            ArrayList NavItems = new ArrayList();

            //string path = ConfigurationManager.AppSettings["MenuConfiguration"];
            string path = Application.StartupPath + @"\Menu.xml";
            XElement menus = XElement.Load(path);
            foreach (var menu in menus.Elements("SalesManMenu"))
            {
                string menuItem = menu.Attribute("name").Value;
                string eventCode = menu.Attribute("eventCode").Value;
                NavBar.NavItem nv = new NavBar.NavItem(menuItem, eventCode);
                if (menuItem == "信息管理")
                {
                    nv.Selected = true;
                }
                ArrayList childNavItems = new ArrayList();
                foreach (var childMenu in menu.Elements())
                {
                    childNavItems.Add(new NavBar.childNavItems(childMenu.Value, childMenu.Attribute("eventCode").Value));
                }
                nv.childNavItems = childNavItems;

                NavItems.Add(nv);
            }
            navBarForSalesMan.MenuItems = NavItems;
            navBarForSalesMan.RenderMenu();
            navBarForSalesMan.OnMenuSelection += new EventHandler(childbtnbtn_Click);
            
        }

        private void AddAllList()
        {
            if (!pMainContent.Contains(allList))
            {
                allList = new AllList();
                pMainContent.Controls.Add(allList);
            }
            allList.Name = DiHaoUserControl.AllList;
            allList.ParentPanel = pMainContent;
            allList.NavigationBar = navBarForSalesMan;
            allList.employee = employee;
            allList.Dock = DockStyle.Fill;
            allList.Show();
        }

        private void AddCustomerTrace()
        {
            if (!pMainContent.Contains(customerTrace))
            {
                customerTrace = new CustomerTrace();
                pMainContent.Controls.Add(customerTrace);
            }
            customerTrace.Name = DiHaoUserControl.CustomerTrace;
            customerTrace.ParentPanel = pMainContent;
            customerTrace.NavigationBar = navBarForSalesMan;
            customerTrace.employee = employee;
            customerTrace.Dock = DockStyle.Fill;
            customerTrace.Show();
        }

        public void SetUserInfor(string userName)
        {
            userInfo.SetUserInfor(userName);
        }

        private void lblReturn_Click(object sender, EventArgs e)
        {
            dashboardEntry.ClearContent();
            dashboardEntry.Show();
            dashboardEntry.SetDefault();
            this.Hide();
        }

        private void picLog_Click(object sender, EventArgs e)
        {
            login.Show();
            this.Hide();
        }

        private void DashboardForSalesMan_Resize(object sender, EventArgs e)
        {
            //this.Height = 768;
            //this.Width = 1250;

            //navBarForSalesMan.Height = 50;
            //navBarForSalesMan.Height = 500;
            //this.pMainContent.Width = 1050;
            //this.pMainContent.Height = 600;
            //this.panelHeader.Height = 97;
        }

        private void DashboardForSalesMan_Load(object sender, EventArgs e)
        {
            LoadMenu();
            lblDateTime2.Text = GetDateInfor();
            lblDateTime.Text = GetDateInfor();
            lblDateTime2.Location = new Point(panelfooter.Location.X - lblDateTime.Width, lblDateTime.Location.Y);
        }

        private void DashboardForSalesMan_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblDateTime2.Text = GetDateInfor();
            lblDateTime.Text = GetDateInfor();
            lblDateTime.Location = new Point(lblDateTime.Location.X + 5, lblDateTime.Location.Y);
            if ((lblDateTime.Location.X + lblDateTime.Width) > panelfooter.Width)
            {
                lblDateTime2.Location = new Point(lblDateTime2.Location.X+5,lblDateTime2.Location.Y);
                lblDateTime2.Visible = true;
            }
            if ((lblDateTime.Location.X + lblDateTime.Width) > panelfooter.Width+lblDateTime.Width)
            {
                lblDateTime2.Visible = false;
                lblDateTime.Location = new Point(panelfooter.Location.X, lblDateTime.Location.Y);
            }
            if (lblDateTime.Location.X == lblDateTime2.Location.X)
            {
                lblDateTime2.Visible = false;
                lblDateTime2.Location = new Point(panelfooter.Location.X - lblDateTime.Width, lblDateTime.Location.Y);
            }
        }

        public void LoadDashboardForSalesMan()
        {
            this.Height = 768;
            this.Width = 1250;
            //navBarForSalesMan.Height = 500;
            //this.pMainContent.Width = 1050;
            //this.pMainContent.Height = 600;
            //this.panelHeader.Height = 97;
            lblDateTime.Text = GetDateInfor();
            navBarForSalesMan.ChangeNavItem("InforManage", "InforAllList");
            AddAllList();
            allList.LoadDataGrid(1, "InforAllList", SearchInput.NoContent);
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            dashboardEntry.ClearContent();
            dashboardEntry.Show();
            dashboardEntry.SetDefault();
            this.Hide();
        }

    }
}
