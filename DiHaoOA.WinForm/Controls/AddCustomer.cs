using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DiHaoOA.Controls;
using DiHaoOA.Business.Manager;
using DiHaoOA.WinForm.Controls;
using DiHaoOA.DataContract.Entity;
using DiHaoOA.WinForm;
using DiHaoOA.WinForm.Common;
using DiHaoOA.DataContract;

namespace DiHaoOA
{
    public partial class AddCustomer : BaseUserControl
    {
        CustomerTraceManager customerTraceManager;
        AddCustomerManager addcustomerManager;
        CustomerTrace customerTrace;
        public InformationAssistant informationAssistant;

        public AddCustomer()
        {
            InitializeComponent();
            customerTraceManager = new CustomerTraceManager();
            addcustomerManager = new AddCustomerManager();
        }

        private void btnAddCustomerConfirm_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                if (ParentPanel != null)
                {
                    //foreach (Control control in ParentPanel.Controls)
                    //{
                    //    if (control is AddCustomer)
                    //    {
                    //        control.Visible = false;
                    //    }
                    //}
                    SaveCustomer();
                    ClearContent();
                    lblSuccessMsg.Visible = true;
                    //if (!ParentPanel.Controls.Contains(customerTrace))
                    //{
                    //    customerTrace = new CustomerTrace();
                    //    ParentPanel.Controls.Add(customerTrace);
                    //}
                    //customerTrace.Name = "CustomerTrace";
                    //customerTrace.ParentPanel = ParentPanel;
                    //customerTrace.NavigationBar = NavigationBar;
                    //customerTrace.employee = employee;
                    //customerTrace.Menu = this.Menu;
                    //customerTrace.Dock = DockStyle.Fill;
                    //customerTrace._informationAssistant = informationAssistant;
                    //customerTrace.LoadDataGrid(1, OrderStatus.Following, SearchInput.NoContent);
                    //customerTrace.Show();
                }
                //NavigationBar.ChangeNavItem(Menu, ChildMenu);
            }
            else {
                lblSuccessMsg.Visible = false;
            }
        }

        private void SaveCustomer()
        {
            Customer customer = new Customer();
            customer.CustomerId = addcustomerManager.GetCustomId();
            customer.CompanyName = txtCompany.Text;
            customer.AppointDateTime = decorateDate.Text;
            customer.City = city.Text;
            customer.Comments = txtComments.Text;
            customer.Contactperson3Number = txtContactPhone3.Text;
            customer.ContactPerson = txtContact.Text;
            customer.ContactPerson2 = txtContact2.Text;
            customer.ContactPerson2Number = txtContactPhone2.Text;
            customer.ContactPerson3 = txtContact3.Text;
            customer.ContactPersonNumber = txtContactPhone.Text;
            customer.UsableArea = txtAvaiableArea.Text;
            customer.RidePath = txtBusPath.Text;
            customer.WorkPlace = txtWorkPlace.Text;
            customer.Employees = employee;
            if (rbCustmoerTypeWork.Checked)
            {
                customer.CustomerType = "办公";
            }
            else
            {
                customer.CustomerType = "商铺";
            }
            customer.DecorationAddress = txtDecorateAddress.Text;
            customer.Email = txtEmail.Text;
            if (rbCooperator.Checked)
            {
                customer.ProviderType = "合作者";
            }
            else {
                customer.ProviderType = "个人";
            }
            customer.InformationAssistants = informationAssistant;
            Order order = new Order();
            order.OrderNumber = customerTraceManager.GetOrderNumber();
            order.OrderStatus = OrderStatus.Following;
            order.RecordDate = DateTime.Now;
            order.Customers = customer;
            addcustomerManager.SaveCustomer(customer, order);
            addcustomerManager.UpdateLevelToCopper(informationAssistant);
        }

        private bool ValidateInput()
        {
            if (txtCompany.Text == "" || txtContact.Text == ""
                || txtAvaiableArea.Text == "" || txtContactPhone.Text == "")
            {
                lblEmptyMsg.Text = "*不能为空";
                lblEmptyMsg.Visible = true;
                return false;
            }else if(addcustomerManager.IsPhoneNumberExist(txtContactPhone.Text))
            {
                lblEmptyMsg.Text = addcustomerManager.GetNotifyMsgIfNumberExist(txtContactPhone.Text);
                lblEmptyMsg.Visible = true;
                return false;
            }
            else if (txtContactPhone2.Text!="" && addcustomerManager.IsPhoneNumber2Exist(txtContactPhone2.Text))
            {
                lblEmptyMsg.Text = addcustomerManager.GetNotifyMsgIfNumber2Exist(txtContactPhone2.Text);
                lblEmptyMsg.Visible = true;
                return false;
            }
            else if (txtContactPhone3.Text != "" && addcustomerManager.IsPhoneNumber3Exist(txtContactPhone3.Text))
            {
                lblEmptyMsg.Text = addcustomerManager.GetNotifyMsgIfNumber3Exist(txtContactPhone3.Text);
                lblEmptyMsg.Visible = true;
                return false;
            }
            else if (!ValidateHelper.ValidateName(txtContact.Text))
            {
                lblNameErrMsg.Visible = true;
                return false;
            }
            else if (!ValidateHelper.ValidatePhoneNumber(txtContactPhone.Text))
            {
                lblPhoneErrMsg.Visible = true;
                return false;
            }
            else if (txtContactPhone2.Text!=""&&!ValidateHelper.ValidatePhoneNumber(txtContactPhone2.Text))
            {
                lblContact2Number.Visible = true;
                return false;
            }
            else if (txtContactPhone3.Text != "" && !ValidateHelper.ValidatePhoneNumber(txtContactPhone3.Text))
            {
                lblContact3Number.Visible = true;
                return false;
            }
            else if (txtEmail.Text != "" && !ValidateHelper.ValidateEmail(txtEmail.Text))
            {
                lblEmail.Visible = true;
                return false;
            }
            return true;
        }

        private void txtContact_Leave(object sender, EventArgs e)
        {
            if (!ValidateHelper.ValidateName(txtContact.Text))
            {
                lblNameErrMsg.Visible = true;
            }
            else
            {
                lblNameErrMsg.Visible = false;
            } 
        }

        private void txtContact2_Leave(object sender, EventArgs e)
        {

        }

        private void txtContact3_Leave(object sender, EventArgs e)
        {

        }

        private void txtContactPhone_Leave(object sender, EventArgs e)
        {
            if (!ValidateHelper.ValidatePhoneNumber(txtContactPhone.Text))
            {
                lblPhoneErrMsg.Text = "*号码格式不正确";
                lblPhoneErrMsg.Visible = true;
            }
            else if (addcustomerManager.IsPhoneNumberExist(txtContactPhone.Text))
            {
                lblPhoneErrMsg.Text = addcustomerManager.GetNotifyMsgIfNumberExist(txtContactPhone.Text);
                lblPhoneErrMsg.Visible = true;
            }
            else
            {
                lblPhoneErrMsg.Visible = false;
            }
        }

        private void txtContactPhone2_Leave(object sender, EventArgs e)
        {
            if (txtContactPhone2.Text != "" && addcustomerManager.IsPhoneNumber2Exist(txtContactPhone2.Text))
            {
                lblContact2Number.Text = addcustomerManager.GetNotifyMsgIfNumber2Exist(txtContactPhone2.Text);
                lblContact2Number.Visible = true;
            }
            else {
                lblContact2Number.Visible = false;
            }
        }

        private void txtContactPhone3_Leave(object sender, EventArgs e)
        {
            if (txtContactPhone3.Text != "" && addcustomerManager.IsPhoneNumber3Exist(txtContactPhone3.Text))
            {
                lblContact3Number.Text = addcustomerManager.GetNotifyMsgIfNumber3Exist(txtContactPhone3.Text);
                lblContact3Number.Visible = true;
            }
            else {
                lblContact3Number.Hide();
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {

        }

        public void ClearContent()
        {
            txtEmail.Clear();
            txtDecorateAddress.Clear();
            txtContactPhone3.Clear();
            txtContactPhone2.Clear();
            txtContactPhone.Clear();
            txtContact3.Clear();
            txtContact2.Clear();
            txtContact.Clear();
            txtCompany.Clear();
            txtComments.Clear();
            txtBusPath.Clear();
            txtAvaiableArea.Clear();
            txtWorkPlace.Clear();
            lblSuccessMsg.Visible = false;
            lblEmptyMsg.Visible = false;
            lblPhoneErrMsg.Visible = false;
            lblContact2Number.Visible = false;
            lblContact3Number.Visible = false;
            lblEmail.Visible = false;
            lblNameErrMsg.Visible = false;

        }

        

    }
}
