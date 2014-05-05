using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Configuration;
using System.Xml.Linq;
using DiHaoOA.Controls;
using DiHaoOA.WinForm.Forms;
using DiHaoOA.WinForm.Controls;
using DiHaoOA.DataContract;
using DiHaoOA.WinForm.Common;
using DiHaoOA.Business.Manager;

namespace DiHaoOA.WinForm
{
    public partial class DashboardForSalesManager : BaseForm
    {
        AllList allList;
        AllListForMarketing allListForManager;
        CustomerTrace customerTrace;
        UnSubordinateInformationAssistantList unSubordinateIAList;
        UnSubordinateCustomer unSubordinateCustomer;
        AllMarketingCustomer allMarketingCustomer;
        InformationAssistantList informationAssistantList;
        MySubordinate mySubordinate;
        ApprovalList approvalList;
        OrderList orderList;
        OrderManager orderManager;
        BusinessStatisticsForMarketing businessStatisticsForMarketing;

        const string pro_AllCustomersPaging = "pro_AllCustomersPaging";
        const string pro_DeletedCustomersPaging = "pro_DeletedCustomersPaging";
        const string pro_DeletedIAListPaging = "pro_DeletedIAListPaging";
        const string pro_AllListPagingForManager = "pro_AllListPagingForManager";
        const string pro_UnSubordinateCustomersPaging = "pro_UnSubordinateCustomersPaging";
        const string pro_ApprovalListForMarketingManager = "pro_ApprovalListForMarketingManager";


        public DashboardForSalesManager()
        {
            InitializeComponent();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            orderManager = new OrderManager();
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
            if (menu == DiHaoMenu.Manager)
            {
                HandManagerMenu(btn.Name);
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
            }

        }

        private void AddBusinessStatics(string department)
        {
            if (!panelContent.Contains(businessStatisticsForMarketing))
            {
                businessStatisticsForMarketing = new BusinessStatisticsForMarketing();
                businessStatisticsForMarketing.Name = DiHaoUserControl.OrderList;
                businessStatisticsForMarketing.ParentPanel = pMainContent;
                businessStatisticsForMarketing.NavigationBar = navBarForSalesManager;
                businessStatisticsForMarketing.employee = employee;
                businessStatisticsForMarketing.Dock = DockStyle.Fill;
                pMainContent.Controls.Add(businessStatisticsForMarketing);
            }
            businessStatisticsForMarketing.Show();
        }

        private void AddOrderList(string status)
        {
            if (!panelContent.Contains(orderList))
            {
                orderList = new OrderList();
                orderList.Name = DiHaoUserControl.OrderList;
                orderList.ParentPanel = pMainContent;
                orderList.NavigationBar = navBarForSalesManager;
                orderList.employee = employee;
                orderList.Dock = DockStyle.Fill;
                orderList.role = Roles.InformationAssistant;
                pMainContent.Controls.Add(orderList);
            }
            orderList.orderStatus = status;
            orderList.ReLoadData();
            orderList.Show();

        }

        private void HandManagerMenu(string childMenu)
        {
            if (childMenu == ManagerChildMenu.InformationAssistantAList)
            {
                ShowSpecificMenu();
                AddInformationAssistantList(pro_AllListPagingForManager);
                informationAssistantList.ClearSearchText();
                informationAssistantList.ShowDeleteButton();
                informationAssistantList.ReloadData();
            }
            if (childMenu == ManagerChildMenu.CustomerList)
            {
                ShowSpecificMenu();
                AddAllMarketingCustomerList(pro_AllCustomersPaging);
                allMarketingCustomer.ClearSearchText();
                allMarketingCustomer.ShowDeleteButton();
                allMarketingCustomer.ReloadData();
            }
            if (childMenu == ManagerChildMenu.DeleteCustomer)
            {
                ShowSpecificMenu();
                AddAllMarketingCustomerList(pro_DeletedCustomersPaging);
                allMarketingCustomer.ClearSearchText();
                allMarketingCustomer.HideDeleteButton();
                allMarketingCustomer.ReloadData();
            }
            if (childMenu == ManagerChildMenu.DeleteIA)
            {
                ShowSpecificMenu();
                AddInformationAssistantList(pro_DeletedIAListPaging);
                informationAssistantList.ClearSearchText();
                informationAssistantList.HideDeleteButton();
                informationAssistantList.ReloadData();
            }
            if (childMenu == ManagerChildMenu.UnSubordinateCustomer)
            {
                ShowSpecificMenu();
                AddAllMarketingCustomerList(pro_UnSubordinateCustomersPaging);
                allMarketingCustomer.ClearSearchText();
                allMarketingCustomer.HideDeleteButton();
                allMarketingCustomer.ReloadData();
            }
            if (childMenu == ManagerChildMenu.MySubordinate)
            {
                ShowSpecificMenu();
                AddMySubordinate();
            }
            if (childMenu == ManagerChildMenu.Approval)
            {
                ShowSpecificMenu();
                AddApprovalList(pro_ApprovalListForMarketingManager);
                approvalList.ClearSearchText();
                approvalList.ReLoadData();
            }
            if (childMenu == ManagerChildMenu.SecondSigning)
            {
                ShowSpecificMenu();
                AddOrderList(OrderStatus.NotSigned);
            }
        }


        private void AddApprovalList(string pro_ApprovalListForMarketingManager)
        {
            if (!panelContent.Contains(approvalList))
            {
                approvalList = new ApprovalList();
                approvalList.approvaler = Approvaler.MarketingManager;
                approvalList.procedureName = pro_ApprovalListForMarketingManager;
                approvalList.ParentPanel = pMainContent; ;
                approvalList.NavigationBar = navBarForSalesManager;
                approvalList.employee = employee;
                approvalList.Dock = DockStyle.Fill;
                pMainContent.Controls.Add(approvalList);
            }
            approvalList.Show();
        }

        /// <summary>
        /// display related user control by user control name
        /// </summary>
        /// <param name="ucName"></param>

        private void ShowSpecificMenu()
        {
            foreach (Control control in pMainContent.Controls)
            {
                control.Visible = false;
            }
        }

        private void AddMySubordinate()
        {
            if (!panelContent.Contains(mySubordinate))
            {
                mySubordinate = new MySubordinate();
                mySubordinate.Name = DiHaoUserControl.MySubordinate;
                mySubordinate.ParentPanel = pMainContent; ;
                mySubordinate.NavigationBar = navBarForSalesManager;
                mySubordinate.employee = employee;
                mySubordinate.Dock = DockStyle.Fill;
                pMainContent.Controls.Add(mySubordinate);
            }
            else
            {
                mySubordinate.Show();
                mySubordinate.LoadData();
            }
        }

        private void AddAllList()
        {
            if (!panelContent.Contains(allList))
            {
                allList = new AllList();
                allList.Name = DiHaoUserControl.AllList;
                allList.ParentPanel = pMainContent;
                allList.NavigationBar = navBarForSalesManager;
                allList.employee = employee;
                allList.Dock = DockStyle.Fill;
                pMainContent.Controls.Add(allList);
            }
            else
            {
                allList.Show();
            }
        }

        private void AddInformationAssistantList(string procedureName)
        {
            if (!panelContent.Contains(informationAssistantList))
            {
                informationAssistantList = new InformationAssistantList();
                informationAssistantList.Name = DiHaoUserControl.AllList;
                informationAssistantList.ParentPanel = pMainContent;
                informationAssistantList.procedureName = procedureName;
                informationAssistantList.NavigationBar = navBarForSalesManager;
                informationAssistantList.employee = employee;
                informationAssistantList.Dock = DockStyle.Fill;
                pMainContent.Controls.Add(informationAssistantList);
            }
            else
            {
                informationAssistantList.Show();
            }
            informationAssistantList.procedureName = procedureName;
        }

        private void DashboardForSalesManager_Load(object sender, EventArgs e)
        {
            LoadMenu();
            lblDateTime2.Text = GetDateInfor();
            lblDateTime.Text = GetDateInfor();
            lblDateTime2.Location = new Point(panelFooter.Location.X - lblDateTime.Width, lblDateTime.Location.Y);
            lblApproval.Text = "你有" + orderManager.GetSalesManagerApprovalCount() + "条审批信息";
        }

        public void LoadDashboardForSalesManager()
        {
            lblDateTime.Text = GetDateInfor();
            this.Width = 1250;
            this.Height = 768;
            AddAllList();
            allList.LoadDataGrid(1, "InforAllList", SearchInput.NoContent);
            navBarForSalesManager.ChangeNavItem("InforManage", "InforAllList");
        }

        private void LoadMenu()
        {
            ArrayList NavItems = new ArrayList();
            //string path = ConfigurationManager.AppSettings["MenuConfiguration"];
            string path = Application.StartupPath + @"\Menu.xml";
            XElement menus = XElement.Load(path);
            foreach (var menu in menus.Elements("SalesManagerMenu"))
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
            navBarForSalesManager.MenuItems = NavItems;
            navBarForSalesManager.RenderMenu();
            navBarForSalesManager.OnMenuSelection += new EventHandler(childbtnbtn_Click);//when click clild menu,display different result

        }

        public void SetUserInfor(string userName)
        {
            userInfo.SetUserInfor(userName);
        }

        private void AddCustomerTrace()
        {
            if (!pMainContent.Contains(customerTrace))
            {
                customerTrace = new CustomerTrace();
                customerTrace.Name = DiHaoUserControl.CustomerTrace;
                customerTrace.ParentPanel = pMainContent;
                customerTrace.NavigationBar = navBarForSalesManager;
                customerTrace.employee = employee;
                customerTrace.Dock = DockStyle.Fill;
                pMainContent.Controls.Add(customerTrace);
            }
            else
            {
                customerTrace.Show();
            }
        }

        private void AddAllListForManager()
        {
            if (!panelContent.Contains(allListForManager))
            {
                allListForManager = new AllListForMarketing();
                allListForManager.Name = DiHaoUserControl.AllListForManager;
                allListForManager.ParentPanel = pMainContent; ;
                allListForManager.NavigationBar = navBarForSalesManager;
                allListForManager.employee = employee;
                allListForManager.Dock = DockStyle.Fill;
                pMainContent.Controls.Add(allListForManager);
            }
            else
            {
                allListForManager.Show();
            }
        }

        private void AddunSubordinateIAList()
        {
            if (!pMainContent.Contains(unSubordinateIAList))
            {
                unSubordinateIAList = new UnSubordinateInformationAssistantList();
                unSubordinateIAList.Name = DiHaoUserControl.UnSubordinateInformationAssistantList;
                unSubordinateIAList.ParentPanel = pMainContent;
                unSubordinateIAList.NavigationBar = navBarForSalesManager;
                unSubordinateIAList.employee = employee;
                unSubordinateIAList.LoadData(1);
                pMainContent.Controls.Add(unSubordinateIAList);
            }
            else
            {
                unSubordinateIAList.Show();
            }
        }

        private void AddunSubordinateCustomer()
        {
            if (!pMainContent.Contains(unSubordinateCustomer))
            {
                unSubordinateCustomer = new UnSubordinateCustomer();
                unSubordinateCustomer.Name = DiHaoUserControl.UnSubordinateCustomer;
                unSubordinateCustomer.ParentPanel = pMainContent;
                unSubordinateCustomer.NavigationBar = navBarForSalesManager;
                unSubordinateCustomer.employee = employee;
                unSubordinateCustomer.LoadGridData();
                pMainContent.Controls.Add(unSubordinateCustomer);
            }
            else
            {
                unSubordinateCustomer.Show();
            }
        }

        private void AddAllMarketingCustomerList(string procedureName)
        {
            if (!panelContent.Contains(allMarketingCustomer))
            {
                allMarketingCustomer = new AllMarketingCustomer();
                allMarketingCustomer.Name = DiHaoUserControl.AllMarketingCustomer;
                allMarketingCustomer.ParentPanel = pMainContent;
                allMarketingCustomer.NavigationBar = navBarForSalesManager;
                allMarketingCustomer.employee = employee;
                allMarketingCustomer.procedureName = procedureName;
                allMarketingCustomer.Dock = DockStyle.Fill;
                pMainContent.Controls.Add(allMarketingCustomer);
            }
            else
            {
                allMarketingCustomer.Show();
            }
            allMarketingCustomer.procedureName = procedureName;
        }

        private void lblReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            dashboardEntry.ClearContent();
            dashboardEntry.Show();
            dashboardEntry.SetDefault();
        }

        private void picLog_Click(object sender, EventArgs e)
        {
            this.Hide();
            login.Show();
        }

        private void DashboardForSalesManager_Resize(object sender, EventArgs e)
        {
            this.Width = 1250;
            this.Height = 768;
        }

        private void DashboardForSalesManager_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void userInfo_Load(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblDateTime2.Text = GetDateInfor();
            lblDateTime.Text = GetDateInfor();
            lblDateTime.Location = new Point(lblDateTime.Location.X + 5, lblDateTime.Location.Y);
            if ((lblDateTime.Location.X + lblDateTime.Width) > panelFooter.Width)
            {
                lblDateTime2.Location = new Point(lblDateTime2.Location.X + 5, lblDateTime2.Location.Y);
                lblDateTime2.Visible = true;
            }
            if ((lblDateTime.Location.X + lblDateTime.Width) > panelFooter.Width + lblDateTime.Width)
            {
                lblDateTime2.Visible = false;
                lblDateTime.Location = new Point(panelFooter.Location.X, lblDateTime.Location.Y);
            }
            if (lblDateTime.Location.X == lblDateTime2.Location.X)
            {
                lblDateTime2.Visible = false;
                lblDateTime2.Location = new Point(panelFooter.Location.X - lblDateTime.Width, lblDateTime.Location.Y);
            }
            int count = orderManager.GetSalesManagerApprovalCount();
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
            this.Hide();
            dashboardEntry.ClearContent();
            dashboardEntry.Show();
            dashboardEntry.SetDefault();
        }

        private void lblApproval_Click(object sender, EventArgs e)
        {
            if (orderManager.GetSalesManagerApprovalCount() > 0)
            {
                ShowSpecificMenu();
                AddApprovalList(pro_ApprovalListForMarketingManager);
                approvalList.ClearSearchText();
                approvalList.ReLoadData();
                navBarForSalesManager.ChangeNavItem("Manager", "审批栏");
            }
        }

        private void DashboardForSalesManager_Activated(object sender, EventArgs e)
        {
            panelContent.Focus();
        }
    }
}
