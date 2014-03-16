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
    public partial class DashboardForDesignerLeader : BaseForm
    {
        OrderList orderList;

        public DashboardForDesignerLeader()
        {
            InitializeComponent();
        }

        private void LoadMenu()
        {
            ArrayList NavItems = new ArrayList();
            string path = Application.StartupPath + @"\Menu.xml";
            XElement menus = XElement.Load(path);
            foreach (var menu in menus.Elements("DesignerLeaderMenu"))
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
            navBarForDesignerLeader.MenuItems = NavItems;
            navBarForDesignerLeader.RenderMenu();
            navBarForDesignerLeader.OnMenuSelection += new EventHandler(childbtnbtn_Click);

        }

        public void SetUserInfor(string userName)
        {
            userInfo.SetUserInfor(userName);
        }

        private void ShowSpecificMenu()
        {
            foreach (Control control in pMainContent.Controls)
            {
                control.Visible = false;
            }
        }

        private void childbtnbtn_Click(object sender, EventArgs e)
        {
            Label btn = (Label)sender;
            string menu = btn.Parent.Name;
            if (menu == DiHaoMenu.CustomerChat)
            {
                ShowSpecificMenu();
                AddOrderList(btn.Name);
            }
            if (menu == DiHaoMenu.Allocate)
            {
                ShowSpecificMenu();
                AddOrderList(btn.Name);
            }
        }

        public void LoadDashboardForDesigner()
        {
            this.Height = 768;
            this.Width = 1250;
            lblDateTime.Text = GetDateInfor();
        }

        private void DashboardForDesignerLeader_Load(object sender, EventArgs e)
        {
            this.Height = 768;
            this.Width = 1250;
            LoadMenu();
            lblDateTime2.Text = GetDateInfor();
            lblDateTime.Text = GetDateInfor();
            lblDateTime2.Location = new Point(panelfooter.Location.X - lblDateTime.Width, lblDateTime.Location.Y);
            AddOrderList(OrderStatus.OnChatting);
            navBarForDesignerLeader.ChangeNavItem("CustomerChat", "在谈");
        }

        private void AddOrderList(string status)
        {
            if (!panelContent.Contains(orderList))
            {
                orderList = new OrderList();
                orderList.Name = DiHaoUserControl.OrderList;
                orderList.orderStatus = OrderStatus.SubmittedToDesigner;
                orderList.ParentPanel = pMainContent;
                orderList.NavigationBar = navBarForDesignerLeader;
                orderList.employee = employee;
                orderList.Dock = DockStyle.Fill;
                orderList.role = Roles.Designer;
                pMainContent.Controls.Add(orderList);
            }
            orderList.orderStatus = status;
            orderList.ReLoadData();
            orderList.Show();

        }

        private void DashboardForDesignerLeader_FormClosed(object sender, FormClosedEventArgs e)
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
    }
}
