using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DiHaoOA.Business;
using DiHaoOA.Business.Manager;

namespace DiHaoOA.WinForm.Forms
{
    public partial class ModifyAllMarketingCustomer : BaseForm
    {
        public Form parentForm;
        EmployeeManager employeeManager;
        InformationAssistantManager iAManager;
        CustomerManager customerManager;

        public delegate void AllMarketingCustomerReload();
        public event AllMarketingCustomerReload ReLoad;
        public List<int> CustomerId;

        public ModifyAllMarketingCustomer()
        {
            InitializeComponent();
            employeeManager = new EmployeeManager();
            iAManager = new InformationAssistantManager();
            customerManager = new CustomerManager();
        }

        private void cbEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            string employeeId = Convert.ToString(cbEmployee.SelectedValue);
            DataSet messengerDataSource = iAManager.GetIAByEmployeeId(employeeId);
            if (messengerDataSource.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("所选员工没有信息员，请重选");
            }
        }

        private void ModifyAllMarketingCustomer_Load(object sender, EventArgs e)
        {
            cbEmployee.DataSource = employeeManager.GetAll().Tables[0];
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            parentForm.Enabled = true;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            for (int i = 0, len = CustomerId.Count; i < len; i++)
            {
                if (ckYes.Checked)
                {
                    iAManager.TransferInformationAssistant(Convert.ToString(cbEmployee.SelectedValue), customerManager.GetInformationAssistantIdByCustomerId(CustomerId[i]));
                }
                customerManager.TransferCustomer(CustomerId[i], Convert.ToString(cbEmployee.SelectedValue));
            }
            this.Hide();
            parentForm.Enabled = true;
            this.ReLoad();
        }
    }
}
