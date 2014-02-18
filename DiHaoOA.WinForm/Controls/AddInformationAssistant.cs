using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DiHaoOA.Controls;
using DiHaoOA.DataContract.Entity;
using DiHaoOA.Business.Manager;
using System.Text.RegularExpressions;
using DiHaoOA.WinForm.Common;
using DiHaoOA.WinForm;
using DiHaoOA.DataContract;


namespace DiHaoOA
{
    public partial class AddInformationAssistant : BaseUserControl
    {
        AddInformationAssistantManager addIAManager;
        public AllList allList;


        public AddInformationAssistant()
        {
            InitializeComponent();
            addIAManager = new AddInformationAssistantManager();
            
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (IsValidateInput())
            {
                InformationAssistant informationAssistant = new InformationAssistant();
                informationAssistant.VisitDateTime = DateTime.Now;
                informationAssistant.InformationAssistantName = txtName.Text;
                informationAssistant.InformationLevel = InformationAssistantLevels.Iron;
                informationAssistant.City = cbCity.Text;
                informationAssistant.Company = txtCompany.Text;
                informationAssistant.HandSet = txtHandSet.Text;
                informationAssistant.Address = txtAddress.Text;
                informationAssistant.RecordDateTime = DateTime.Now;
                if (radioButtonYes.Checked)
                {
                    informationAssistant.IsVisit = true;
                }
                else
                {
                    informationAssistant.IsVisit = false;
                }
                informationAssistant.PhoneNumber = txtPhone.Text;
                informationAssistant.ReVisistPeriod = cbRevisitPeriod.Text;
                informationAssistant.ReVisitTime = "10";
                informationAssistant.Type = radioButtonintermediary.Text;
                informationAssistant.OrderId = null;
                informationAssistant.Employees = employee;
                addIAManager.AddMessenger(informationAssistant);
                lblEmptyMsg.Text = "添加信息员成功";
                lblEmptyMsg.Visible = true;
                if (ParentPanel != null)
                {
                    foreach (Control control in ParentPanel.Controls)
                    {
                        control.Visible = false;
                    }
                    if (allList != null)
                    {
                        allList.Show();
                        allList.LoadDataGrid(1, "InforAllList", SearchInput.NoContent);
                    }
                }
                
            }
            
        }

        private bool IsValidateInput()
        {
            if (txtName.Text == "" || txtPhone.Text == ""
                || txtCompany.Text == ""|| cbRevisitPeriod.Text == "")
            {
                lblEmptyMsg.Visible = true;
                return false;
            }

            //else if (addIAManager.IsNameExist(txtName.Text))
            //{
            //    lblEmptyMsg.Text = "*姓名已存在";
            //    lblEmptyMsg.Visible = true;
            //    return false;
            //}
            else if (addIAManager.IsPhoneNumberExist(txtPhone.Text))
            {

                lblEmptyMsg.Text = addIAManager.GetNotifyMsgIfNumberExist(txtPhone.Text);
                lblEmptyMsg.Visible = true;
                return false;
            }
            else if (!ValidateHelper.ValidateName(txtName.Text))
            {
                lblEmptyMsg.Text = "*不能有特殊字符";
                lblEmptyMsg.Visible = true;
                return false;
            }
            else if (!ValidateHelper.ValidatePhoneNumber(txtPhone.Text))
            {
                lblEmptyMsg.Text = "*手机号码只能有11位";
                lblEmptyMsg.Visible = true;
                return false;
            }
            else
            {
                lblEmptyMsg.Visible = false;
            }
            return true;
        }

        public void ClearControlContent()
        {
            txtAddress.Clear();
            txtCompany.Clear();
            txtHandSet.Clear();
            txtName.Clear();
            txtPhone.Clear();
            lblEmptyMsg.Visible = false;
            lblPhoneErrMsg.Visible = false;
            lblNameErrMsg.Visible = false;
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            if (!ValidateHelper.ValidateName(txtName.Text))
            {
                lblNameErrMsg.Text = "*不能有特殊字符";
                lblNameErrMsg.Visible = true;
            }
            else
            {
                lblNameErrMsg.Visible = false;
            }
        }

        private void txtPhone_Leave(object sender, EventArgs e)
        {
            if (!ValidateHelper.ValidatePhoneNumber(txtPhone.Text))
            {
                lblPhoneErrMsg.Text = "*手机号码只能有11位";
                lblPhoneErrMsg.Visible = true;
            }
            else if (addIAManager.IsPhoneNumberExist(txtPhone.Text))
            {
                lblPhoneErrMsg.Text = addIAManager.GetNotifyMsgIfNumberExist(txtPhone.Text);
                lblPhoneErrMsg.Visible = true;
            }
            else
            {
                lblPhoneErrMsg.Visible = false;
            }
        }
    }
}
