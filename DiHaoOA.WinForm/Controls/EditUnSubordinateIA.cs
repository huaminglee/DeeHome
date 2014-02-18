using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DiHaoOA.Controls;
using DiHaoOA.DataContract.Entity;
using DiHaoOA.Business.Manager;
using DiHaoOA.WinForm.Common;

namespace DiHaoOA.WinForm.Controls
{
    public partial class EditUnSubordinateIA : BaseUserControl
    {
        public InformationAssistant _informationAssistant;
        EditUnSubordinateIAManager editUnSubordinateIAManager;

        public EditUnSubordinateIA()
        {
            InitializeComponent();
            editUnSubordinateIAManager = new EditUnSubordinateIAManager();
        }

        public void ClearContent()
        {
            txtEmployeeNo.Clear();
            lblSuccessMsg.Hide();
            lblEmpMsg.Hide();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string employeeId = txtEmployeeNo.Text;
            if (ValidateHelper.ValidateEmployeeId(employeeId) || editUnSubordinateIAManager.IsEmployeeIdExist(employeeId))
            {
                editUnSubordinateIAManager.TransferInformationAssistant(employeeId,
                   _informationAssistant.InformationAssistantId);// Transfer information Assistant

                if (rbYes.Checked)
                {
                    editUnSubordinateIAManager.TransferCustomer(employeeId,
                    _informationAssistant.InformationAssistantId);//Transfer Customer
                }
                lblSuccessMsg.Show();
                lblEmpMsg.Hide();
            }
            else
            {
                lblEmpMsg.Show();
            }
        }

        private void EditUnSubordinateIA_Load(object sender, EventArgs e)
        {
            lblName.Text = _informationAssistant.InformationAssistantName;
            lblCompany.Text = _informationAssistant.Company;
            lblPhone.Text = _informationAssistant.PhoneNumber;
            lblLevel.Text = _informationAssistant.InformationLevel;
        }

        
    }
}
