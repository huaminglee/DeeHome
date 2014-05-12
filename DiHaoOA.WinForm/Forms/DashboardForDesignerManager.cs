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
using DiHaoOA.Business.Manager;

namespace DiHaoOA.WinForm.Forms
{
    public partial class DashboardForDesignerManager : BaseForm
    {
        OrderList orderList;
        ApprovalList approvalList;
        AllocateDesignerGroup allocateDesignerGroup;
        ManagerOrderList managerOrderList;
        MyDesigner myDesigner;
        OrderManager orderManager;
        const string pro_ApprovalListForDesignManager = "pro_ApprovalListForDesignManager";
        BusinessStatisticsForMarketing businessStatisticsForMarketing;
        BusinessStatisticsForDesign businessStaticsForDesign;

        public DashboardForDesignerManager()
        {
            InitializeComponent();
            orderManager = new OrderManager();
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
                HandManagerMenu(btn.Name);
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
            if (menu == DiHaoMenu.Business)
            {
                ShowSpecificMenu();
                if (btn.Name == "商务部")
                {
                    AddBusinessStatics(btn.Name);
                }
                if (btn.Name == "主案部")
                {
                    AddBusinessStaticsForDesign();
                }
            }
            if (menu == DiHaoMenu.Orders)
            {
                ShowSpecificMenu();
                AddManagerOrderList(btn.Name);
                managerOrderList.ClearSearchText();
            }
        }

        private void AddBusinessStaticsForDesign()
        {
            if (!panelContent.Contains(businessStaticsForDesign))
            {
                businessStaticsForDesign = new BusinessStatisticsForDesign();
                businessStaticsForDesign.Name = DiHaoUserControl.OrderList;
                businessStaticsForDesign.ParentPanel = pMainContent;
                businessStaticsForDesign.NavigationBar = navBarForDesignerManager;
                businessStaticsForDesign.employee = employee;
                businessStaticsForDesign.Dock = DockStyle.Fill;
                pMainContent.Controls.Add(businessStaticsForDesign);
            }
            businessStaticsForDesign.LoadData();
            businessStaticsForDesign.Show();
        }

        private void AddBusinessStatics(string department)
        {
            if (!panelContent.Contains(businessStatisticsForMarketing))
            {
                businessStatisticsForMarketing = new BusinessStatisticsForMarketing();
                businessStatisticsForMarketing.Name = DiHaoUserControl.OrderList;
                businessStatisticsForMarketing.ParentPanel = pMainContent;
                businessStatisticsForMarketing.NavigationBar = navBarForDesignerManager;
                businessStatisticsForMarketing.employee = employee;
                businessStatisticsForMarketing.Dock = DockStyle.Fill;
                pMainContent.Controls.Add(businessStatisticsForMarketing);
            }
            businessStatisticsForMarketing.Show();
        }

        private void HandManagerMenu(string childMenu)
        {
            if (childMenu == ManagerChildMenu.Approval)
            {
                AddApprovalList();
                approvalList.ClearSearchText();
                approvalList.ReLoadData();
            }
            if (childMenu == ManagerChildMenu.MySubordinate)
            {
                AddMyDesigner();
                myDesigner.LoadData();
            }
        }

        private void AddMyDesigner()
        {
            if (!panelContent.Contains(myDesigner))
            {
                myDesigner = new MyDesigner();
                myDesigner.ParentPanel = pMainContent; ;
                //myDesigner.procedureName = pro_ApprovalListForDesignManager;
                //myDesigner.approvaler = Approvaler.DesignerManager;
                myDesigner.NavigationBar = navBarForDesignerManager;
                myDesigner.employee = employee;
                myDesigner.Dock = DockStyle.Fill;
                pMainContent.Controls.Add(myDesigner);
            }
            myDesigner.Show();
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
                orderList.role = Roles.Designer;
                pMainContent.Controls.Add(orderList);
            }
            orderList.orderStatus = status;
            orderList.ReLoadData();
            orderList.Show();
        }

        private void AddManagerOrderList(string status)
        {
            if (!panelContent.Contains(managerOrderList))
            {
                managerOrderList = new ManagerOrderList();
                managerOrderList.Name = DiHaoUserControl.OrderList;
                managerOrderList.orderStatus = OrderStatus.SubmittedToDesigner;
                managerOrderList.ParentPanel = pMainContent; ;
                managerOrderList.NavigationBar = navBarForDesignerManager;
                managerOrderList.employee = employee;
                managerOrderList.Dock = DockStyle.Fill;
                pMainContent.Controls.Add(managerOrderList);
            }
            managerOrderList.orderStatus = status;
            managerOrderList.ReLoadData();
            managerOrderList.Show();
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
                approvalList.procedureName = pro_ApprovalListForDesignManager;
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
            AddOrderList(OrderStatus.OnChatting);
            navBarForDesignerManager.ChangeNavItem("CustomerChat", "在谈");
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
            int count = orderManager.GetDesignerManagerApprovalCount();
            lblApproval.Text = "你有" + count + "条审批信息";
            if (count > 0)
            {
                pApproval.Visible = true;
            }
            else
            {
                pApproval.Visible = false;
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            dashboardEntryForDesigner.ClearContent();
            dashboardEntryForDesigner.Show();
            this.Hide();
        }

        private void lblApproval_Click(object sender, EventArgs e)
        {
            if (orderManager.GetDesignerManagerApprovalCount() > 0)
            {
                ShowSpecificMenu();
                AddApprovalList();
                approvalList.ClearSearchText();
                approvalList.ReLoadData();
                navBarForDesignerManager.ChangeNavItem("Manager", "审批栏");
            }
        }
    }
}
