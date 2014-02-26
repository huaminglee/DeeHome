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
using DiHaoOA.WinForm.Controls;
using DiHaoOA.DataContract;

namespace DiHaoOA.WinForm.Forms
{
    public partial class DashboardForDesignerManager : BaseForm
    {
        OrderList orderList;
        ApprovalList approvalList;
        AllocateDesignerGroup allocateDesignerGroup;
        const string pro_ApprovalListForMarketingManager = "pro_ApprovalListForMarketingManager";

        public DashboardForDesignerManager()
        {
            InitializeComponent();
        }

        private void LoadMenu()
        {
            ArrayList NavItems = new ArrayList();
            string path = Application.StartupPath + @"\Menu.xml";
            XElement menus = XElement.Load(path);
            foreach (var menu in menus.Elements("DesignerManagerMenu"))
            {
                string menuItem = menu.Attribute("name").Value;
                string eventCode = menu.Attribute("eventCode").Value;
                NavBar.NavItem nv = new NavBar.NavItem(menuItem, eventCode);
                if (eventCode == "CustomerChat")
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
            navBarForDesignerManager.MenuItems = NavItems;
            navBarForDesignerManager.RenderMenu();
            navBarForDesignerManager.OnMenuSelection += new EventHandler(childbtnbtn_Click);

        }

        public void LoadDashboardForDesigner()
        {
            this.Height = 768;
            this.Width = 1250;
            lblDateTime.Text = GetDateInfor();
        }

        public void SetUserInfor(string userName)
        {
            userInfo.SetUserInfor(userName);
        }

        private void childbtnbtn_Click(object sender, EventArgs e)
        {
            Label btn = (Label)sender;
            string menu = btn.Parent.Name;
            if (menu == DiHaoMenu.Manager)
            {
                ShowSpecificMenu();
                AddApprovalList();
                approvalList.ClearSearchText();
                approvalList.ReLoadData();
            }
            if (menu == DiHaoMenu.Allocate)
            {
                ShowSpecificMenu();
                AddAllocateDesignerGroup();
                allocateDesignerGroup.ClearContent();
            }
            if (menu == DiHaoMenu.CustomerChat)
            {
                ShowSpecificMenu();
                AddOrderList(btn.Name);
            }
        }

        private void AddOrderList(string status)
        {
            if (!panelContent.Contains(orderList))
            {
                orderList = new OrderList();
                orderList.Name = DiHaoUserControl.OrderList;
                orderList.orderStatus = OrderStatus.SubmittedToDesigner;
                orderList.ParentPanel = pMainContent; ;
                orderList.NavigationBar = navBarForDesignerManager;
                orderList.employee = employee;
                orderList.Dock = DockStyle.Fill;
                pMainContent.Controls.Add(orderList);
            }
            orderList.orderStatus = status;
            orderList.ReLoadData();
            orderList.Show();

        }

        private void AddAllocateDesignerGroup()
        {
            if (!panelContent.Contains(allocateDesignerGroup))
            {
                allocateDesignerGroup = new AllocateDesignerGroup();
                allocateDesignerGroup.Name = DiHaoUserControl.OrderList;
                allocateDesignerGroup.ParentPanel = pMainContent; ;
                allocateDesignerGroup.NavigationBar = navBarForDesignerManager;
                allocateDesignerGroup.employee = employee;
                allocateDesignerGroup.Dock = DockStyle.Fill;
                pMainContent.Controls.Add(allocateDesignerGroup);
            }
            else
            {
                allocateDesignerGroup.Show();
            }
        }

        private void AddApprovalList()
        {
            if (!panelContent.Contains(approvalList))
            {
                approvalList = new ApprovalList();
                approvalList.ParentPanel = pMainContent; ;
                approvalList.procedureName = pro_ApprovalListForMarketingManager;
                approvalList.approvaler = Approvaler.DesignerManager;
                approvalList.NavigationBar = navBarForDesignerManager;
                approvalList.employee = employee;
                approvalList.Dock = DockStyle.Fill;
                pMainContent.Controls.Add(approvalList);
            }
            approvalList.Show();
        }

        private void ShowSpecificMenu()
        {
            foreach (Control control in pMainContent.Controls)
            {
                control.Visible = false;
            }
        }


        private void DashboardForDesignerManager_Load(object sender, EventArgs e)
        {
            this.Height = 768;
            this.Width = 1250;
            LoadMenu();
            lblDateTime2.Text = GetDateInfor();
            lblDateTime.Text = GetDateInfor();
            lblDateTime2.Location = new Point(panelfooter.Location.X - lblDateTime.Width, lblDateTime.Location.Y);
        }

        private void DashboardForDesignerManager_FormClosed(object sender, FormClosedEventArgs e)
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
                lblDateTime2.Location = new Point(lblDateTime2.Location.X + 5, lblDateTime2.Location.Y);
                lblDateTime2.Visible = true;
            }
            if ((lblDateTime.Location.X + lblDateTime.Width) > panelfooter.Width + lblDateTime.Width)
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

        private void btnReturn_Click(object sender, EventArgs e)
        {
            dashboardEntry.ClearContent();
            dashboardEntry.Show();
            dashboardEntry.SetDefault();
            this.Hide();
        }
    }
}
