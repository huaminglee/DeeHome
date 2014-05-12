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
    public partial class NewEntryForSales : BaseForm
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

        public NewEntryForSales()
        {
            InitializeComponent();
            empManager = new EmployeeManager();
            roleManager = new RolesManager();
            //this.AcceptButton = btnLogin;
        }



        private void btnLogin_Paint(object sender, PaintEventArgs e)
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
                dashboard.dashboardEntryForSales = this;
                dashboard.SetUserInfor(_userName);
                dashboard.Show();
                dashboard.LoadDashboardForSalesMan();
            }
            if (role == Roles.Designer)
            {
                if (designerDashboard == null)
                    designerDashboard = new DashboardForDesigner();
                designerDashboard.employee = employee;
                designerDashboard.dashboardEntryForSales = this;
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
                managerDashboard.dashboardEntryForSales = this;
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
                designerManagerDashboard.dashboardEntryForSales = this;
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
                designerLeaderDashboard.dashboardEntryForSales = this;
                designerLeaderDashboard.SetUserInfor(employee.Name);
                designerLeaderDashboard.Show();
            }
            if (role == Roles.GeneralManager)
            {
                //TODO
                MessageBox.Show("GeneralManager's Dashboard");
            }
        }
    }
}
