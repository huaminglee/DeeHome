using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DiHaoOA.Business.Manager;
using DiHaoOA.WinForm.Common;
using DiHaoOA.Business;

namespace DiHaoOA.WinForm.Forms
{
    public partial class EditEmployee : BaseForm
    {
        EditEmployeeManager editEmpManager;
        EmployeeManager empManager;
        public DashboardEntry entry;

        public EditEmployee()
        {
            InitializeComponent();
            editEmpManager = new EditEmployeeManager();
            empManager = new EmployeeManager();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                employee.Name = txtEmpName.Text;
                employee.Password = txtPwd.Text;
                employee.PhoneNumber = txtPhone.Text;
                editEmpManager.EditEmployee(employee);
                employee = empManager.GetEmployeeById(lblEmpNo.Text);
                //entry.employee = employee;
                dashboardEntryForDesigner.employee = employee;
                //entry.SetUserInfor(employee.Name);
                this.Hide();
                dashboardEntryForDesigner.Show();
                dashboardEntryForDesigner.ReturnToEntry();
            }
        }

        private bool ValidateInput()
        {
            if (!ValidateHelper.ValidatePhoneNumber(txtPhone.Text))
            {
                lblPhone.Visible = true;
                return false;
            }
            else if (!ValidateHelper.ValidateName(txtEmpName.Text))
            {
                lblNameErrMsg.Visible = true;
                return false;
            }
            else if (txtPwd.Text == "")
            {
                lblPwd.Show();
                return false;
            }
            else
            {
                lblPhone.Visible = false;
                lblNameErrMsg.Visible = false;
                lblPwd.Visible = false;
                return true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            dashboardEntryForDesigner.Show();
            //dashboardEntryForDesigner.ReturnToEntry();
        }

        private void EditEmployee_Load(object sender, EventArgs e)
        {

            SetDefaultValue();
        }


        public void SetDefaultValue()
        {
            lblEmpNo.Text = employee.EmployeeId;
            txtEmpName.Text = employee.Name;
            txtPhone.Text = employee.PhoneNumber;
            txtPwd.Text = employee.Password;
        }
        private void EditEmployee_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}
