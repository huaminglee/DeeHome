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
    public partial class DashboardForDesigner : BaseForm
    {
        OrderList orderList;

        public DashboardForDesigner()
        {
            InitializeComponent();
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
            string path = Application.StartupPath + @"\Menu.xml";
            XElement menus = XElement.Load(path);
            foreach (var menu in menus.Elements("DesignerMenu"))
            {
                string menuItem = menu.Attribute("name").Value;
                string eventCode = menu.Attribute("eventCode").Value;
                NavBar.NavItem nv = new NavBar.NavItem(menuItem, eventCode);
                if(eventCode == "CustomerChat")
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
            navBarForDesigner.MenuItems = NavItems;
            navBarForDesigner.RenderMenu();
            navBarForDesigner.OnMenuSelection += new EventHandler(childbtnbtn_Click);

        }

        public void SetUserInfor(string userName)
        {
            userInfo.SetUserInfor(userName);
        }

        public void LoadDashboardForDesigner()
        {
            this.Height = 768;
            this.Width = 1250;
            lblDateTime.Text = GetDateInfor();
            //AddOrderList();
            //navBarForDesigner.ChangeNavItem("CustomerChat", "已谈");
            //orderList.orderStatus = OrderStatus.OnChatting;
            //orderList.ReLoadData();
        }

        private void AddOrderList(string status)
        {
            if (!panelcontent.Contains(orderList))
            {
                orderList = new OrderList();
                orderList.Name = DiHaoUserControl.OrderList;
                orderList.ParentPanel = pMainContent; ;
                orderList.NavigationBar = navBarForDesigner;
                orderList.employee = employee;
                orderList.Dock = DockStyle.Fill;
                orderList.role = Roles.Designer;
                pMainContent.Controls.Add(orderList);
            }
            orderList.orderStatus = status;
            orderList.ReLoadData();
            orderList.Show();

        }

        private void childbtnbtn_Click(object sender, EventArgs e)
        {
            Label btn = (Label)sender;
            ShowSpecificMenu();
            AddOrderList(btn.Name);
        }

        private void DashboardForDesigner_Load(object sender, EventArgs e)
        {
            LoadMenu();
            lblDateTime2.Text = GetDateInfor();
            lblDateTime.Text = GetDateInfor();
            lblDateTime2.Location = new Point(panelfooter.Location.X - lblDateTime.Width, lblDateTime.Location.Y);
            AddOrderList(OrderStatus.OnChatting);
            navBarForDesigner.ChangeNavItem("CustomerChat", "在谈");
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            dashboardEntryForDesigner.ClearContent();
            dashboardEntryForDesigner.Show();
            this.Hide();
        }

        private void DashboardForDesigner_FormClosed(object sender, FormClosedEventArgs e)
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

        private void DashboardForDesigner_Activated(object sender, EventArgs e)
        {
            panelcontent.Focus();
        }

    }
}
