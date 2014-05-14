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

namespace DiHaoOA.WinForm.Forms
{
    public partial class NewEntryForDesigner : BaseForm
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

        public NewEntryForDesigner()
        {
            InitializeComponent();
            empManager = new EmployeeManager();
            roleManager = new RolesManager();
            this.AcceptButton = btnLogin;
        }

        public void ClearContent()
        {
            txtPassword.Text = "";
            lblMsg.Visible = false;
            panel3.Hide();
            panel2.Show();
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
                this.employee = employee;
                picEditPwd.Enabled = true;
                picHome.Enabled = true;
                picHome.Visible = true;
                picEditPwd.Visible = true;
                panel3.Show();
                panel2.Hide();
            }
            
        }

        private void picHome_Click(object sender, EventArgs e)
        {
            employee = empManager.GetEmployeeById(txtUserName.Text);
            if (!empManager.ValidateEmployee(txtUserName.Text, txtPassword.Text) ||
                txtPassword.Text == "" || txtUserName.Text == "")
            {
                lblMsg.Visible = true;
                return;
            }
            else
            {
                //this.SetUserInfor(employee.Name);
                //userInfo.SetForeColor();
                this.employee = employee;
                //picHome.Enabled = true;
                //picEditPwd.Enabled = true;
                //MainContent.Visible = false;
            }

            string role = roleManager.GetEmployeeRole(this.employee.EmployeeId);
            this.Hide();
            if (role == Roles.SalesMan)
            {
                if (dashboard == null)
                {
                    dashboard = new DashboardForSalesMan();
                }
                dashboard.employee = employee;
                dashboard.dashboardEntryForDesigner = this;
                dashboard.SetUserInfor(employee.Name);
                dashboard.Show();
                dashboard.LoadDashboardForSalesMan();
            }
            if (role == Roles.Designer)
            {
                if (designerDashboard == null)
                    designerDashboard = new DashboardForDesigner();
                designerDashboard.employee = employee;
                designerDashboard.dashboardEntryForDesigner = this;
                designerDashboard.SetUserInfor(employee.Name);
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
                managerDashboard.dashboardEntryForDesigner = this;
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
                designerManagerDashboard.dashboardEntryForDesigner = this;
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
                designerLeaderDashboard.dashboardEntryForDesigner = this;
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
            editEmployeeboard.dashboardEntryForDesigner = this;
            editEmployeeboard.employee = employee;
            editEmployeeboard.SetDefaultValue();
            editEmployeeboard.Show();
        }

        public void ReturnToEntry()
        {
            panel3.Hide();
            panel2.Show();
        }
    }
}
