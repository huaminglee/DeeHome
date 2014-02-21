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
                nv.Selected = true;
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
            AddOrderList();
            //navBarForDesigner.ChangeNavItem("CustomerChat", "已谈");
            orderList.orderStatus = OrderStatus.OnChatting;
            orderList.ReLoadData();
        }

        private void AddOrderList()
        {
            if (!pMainContent.Contains(orderList))
            {
                orderList = new OrderList();
                pMainContent.Controls.Add(orderList);
            }
            orderList.Name = DiHaoUserControl.OrderList;
            orderList.ParentPanel = pMainContent;
            orderList.NavigationBar = navBarForDesigner;
            orderList.employee = employee;
            orderList.Dock = DockStyle.Fill;
            orderList.Show();
        }

        private void childbtnbtn_Click(object sender, EventArgs e)
        {
            Label btn = (Label)sender;
            orderList.orderStatus = btn.Name;
            orderList.ReLoadData();
        }

        private void DashboardForDesigner_Load(object sender, EventArgs e)
        {
            LoadMenu();
            lblDateTime2.Text = GetDateInfor();
            lblDateTime.Text = GetDateInfor();
            lblDateTime2.Location = new Point(panelfooter.Location.X - lblDateTime.Width, lblDateTime.Location.Y);
        }
    }
}
