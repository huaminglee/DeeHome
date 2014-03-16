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
using System.Configuration;
using DiHaoOA.Controls;
using System.Drawing.Drawing2D;
using DiHaoOA.Security;
using DiHaoOA.DataContract.Entity;
using DiHaoOA.WinForm.Forms;
using DiHaoOA.WinForm;
using DiHaoOA.Business;

namespace DiHaoOA
{
    public partial class DashboardEntry : BaseForm
    {
        RolesManager roleManager;
        string _userName;
        EditEmployee editEmployee;
        DashboardForSalesMan dashboard;
        DashboardForSalesManager managerDashboard;
        DashboardForDesigner designerDashboard;
        DashboardForDesignerManager designerManagerDashboard;
        DashboardForDesignerLeader designerLeaderDashboard;
        EditEmployee editEmployeeboard;
        EmployeeManager empManager;

        public DashboardEntry()
        {
            InitializeComponent();
            empManager = new EmployeeManager();
            roleManager = new RolesManager();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AcceptButton = btnLogin;
        }

        

        private void panelContent_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Color FColor = Color.FromArgb(115, 178, 221);
            Color TColor = Color.FromArgb(100, 178, 200);
            Brush b = new LinearGradientBrush(this.ClientRectangle, FColor, TColor, LinearGradientMode.ForwardDiagonal);
            g.FillRectangle(b, this.ClientRectangle);
        }

        public void SetUserInfor(string userName)
        {
            _userName = userName;
            userInfo.SetUserInfor(userName);
        }

        private void picHome_Click(object sender, EventArgs e)
        {
            string role = roleManager.GetEmployeeRole(this.employee.EmployeeId);
            this.Hide();
            if (role == Roles.SalesMan)
            {
                if (dashboard == null)
                {
                    dashboard = new DashboardForSalesMan();
                }
                dashboard.employee = employee;
                dashboard.dashboardEntry = this;
                dashboard.SetUserInfor(_userName);
                dashboard.Show();
                dashboard.LoadDashboardForSalesMan();
            }
            if (role == Roles.Designer)
            {
                if (designerDashboard == null)
                    designerDashboard = new DashboardForDesigner();
                designerDashboard.employee = employee;
                designerDashboard.dashboardEntry = this;
                designerDashboard.SetUserInfor(_userName);
                designerDashboard.Show();
                designerDashboard.LoadDashboardForDesigner();

            }
            if (role == Roles.SalesManManager)
            {
                if (managerDashboard == null)
                {
                    managerDashboard = new DashboardForSalesManager();
                }
                managerDashboard.employee = employee;
                managerDashboard.dashboardEntry = this;
                managerDashboard.SetUserInfor(employee.Name);
                managerDashboard.Show();
                managerDashboard.LoadDashboardForSalesManager();

            }
            if (role == Roles.DesignerManager)
            {
                if (designerManagerDashboard == null)
                {
                    designerManagerDashboard = new DashboardForDesignerManager();
                }
                designerManagerDashboard.employee = employee;
                designerManagerDashboard.dashboardEntry = this;
                designerManagerDashboard.SetUserInfor(employee.Name);
                designerManagerDashboard.Show();
            }
            if (role == Roles.DesignerLeader)
            {
                if (designerLeaderDashboard == null)
                {
                    designerLeaderDashboard = new DashboardForDesignerLeader();
                }
                designerLeaderDashboard.employee = employee;
                designerLeaderDashboard.dashboardEntry = this;
                designerLeaderDashboard.SetUserInfor(employee.Name);
                designerLeaderDashboard.Show();                 
            }
            if (role == Roles.GeneralManager)
            {
                //TODO
                MessageBox.Show("GeneralManager's Dashboard");
            }
        }

        private void picEditPwd_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (editEmployeeboard == null)
            {
                editEmployeeboard = new EditEmployee();
            }
            editEmployeeboard.entry = this;
            editEmployeeboard.employee = employee;
            editEmployeeboard.SetDefaultValue();
            editEmployeeboard.Show();

        }

        private void picLog_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //login.Show();
        }

        private void DashboardEntry_Resize(object sender, EventArgs e)
        {
            //this.Width = 1024;
            //this.Height = 768;
            //this.panelMenu.Height = 170;
            //this.panelMenu.Width = 1024;
            //this.panelHeader.Height = 70;
            //this.picHome.Height = 61;
            //this.picHome.Width = 61;
            //this.picEditPwd.Height = 61;
            //this.picEditPwd.Width = 61;
            //this.picLogo.Width = 93;
            //this.picLogo.Height = 63;
        }

        private void DashboardEntry_Load(object sender, EventArgs e)
        {
            this.AdjustWindowHeightBasedOnResolution();
            this.Width = 1024;
            this.Height = 768;
            //this.panelHeader.Height = 70;
            //this.panelMenu.Height = 170;
            //this.panelMenu.Width = 1024;
            //this.picHome.Height = 101;
            //this.picHome.Width = 101;
            //this.picEditPwd.Height = 101;
            //this.picEditPwd.Width = 101;
            //this.picLogo.Width = 93;
            //this.picLogo.Height = 63;
            //this.picLogo.Location = new Point(this.panelHeader.Location.X, this.panelHeader.Location.Y);
            this.picHome.Location = new Point(this.MainContent.Location.X + 5, this.MainContent.Location.Y + 15);
            this.picEditPwd.Location = new Point(this.MainContent.Location.X + this.picHome.Width + 5, picHome.Location.Y + 5);
        }

        private void DashboardEntry_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

      

        private void btnLogin_Click(object sender, EventArgs e)
        {
            employee = empManager.GetEmployeeById(txtUserName.Text);
            if (!empManager.ValidateEmployee(txtUserName.Text, txtPassword.Text) ||
                txtPassword.Text == "" || txtUserName.Text == "")
            {
                lblMsg.Visible = true;
            }
            else
            {
                this.SetUserInfor(employee.Name);
                userInfo.SetForeColor();
                this.employee = employee;
                picHome.Enabled = true;
                picEditPwd.Enabled = true;
                MainContent.Visible = false;
            }
        }

        public void ClearContent()
        {
            txtPassword.Clear();
            lblMsg.Visible = false;
        }

        public void SetDefault()
        {
            MainContent.Visible = true;
            picEditPwd.Enabled = false;
            picHome.Enabled = false;
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
        }

    }
}
