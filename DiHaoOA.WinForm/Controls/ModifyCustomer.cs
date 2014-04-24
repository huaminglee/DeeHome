using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DiHaoOA.DataContract.Entity;
using DiHaoOA.Business.Manager;
using DiHaoOA.WinForm.Common;
using DiHaoOA.WinForm;
using DiHaoOA.DataContract;
using DiHaoOA.WinForm.Forms;
using DiHaoOA.WinForm.Controls;

namespace DiHaoOA.Controls
{
    public partial class ModifyCustomer : BaseUserControl
    {
        ModifyCustomerManager modifyCustomerManager;
        public InformationAssistant _informationAssistant;
        public int _customerOrderId;
        public Order order;
        public ReVisitPopUp popUp;
        RevisitPopUpManager revisitManager;
        public OrderDescription orderDescriptionPopUp;
        public CustomerTrace customerTrace;

        public ModifyCustomer()
        {
            InitializeComponent();
            modifyCustomerManager = new ModifyCustomerManager();
            revisitManager = new RevisitPopUpManager();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (order.OrderStatus == OrderStatus.Submitted)
            {
                lblMsg.Text = "订单已经提交，你没权限进行此操作";
                lblMsg.Show();
                return;
            }
            if (ValidateInput())
            {
                Customer customer = order.Customers;
                customer.CompanyName = txtCompany.Text;
                customer.City = cbCity.Text;
                customer.ContactPerson = txtContactPerson.Text;
                customer.ContactPersonNumber = txtContactPersonNumber.Text;
                customer.ContactPerson2 = txtContactPerson2.Text;
                customer.ContactPerson2Number = txtContactPerson2Number.Text;
                customer.ContactPerson3 = txtContactPerson3.Text;
                customer.Contactperson3Number = txtContactPerson3Number.Text;
                customer.AppointDateTime = DecorateDateTime.Value.ToString();
                customer.UsableArea = txtUsableArea.Text;
                customer.DecorationAddress = txtDecorateAddress.Text;
                customer.RidePath = txtRidePath.Text;
                customer.WorkPlace = txtWorkPlace.Text;
                customer.Email = txtEmail.Text;
                //customer.Employees = employee;
                if (rbSingle.Checked)
                {
                    customer.ProviderType = "个人";
                }
                if (rbCooparate.Checked)
                {
                    customer.ProviderType = "合作者";
                }
                if (radioButtonBanGong.Checked)
                {
                    customer.CustomerType = "办公";
                }
                if (radioButtonShop.Checked)
                {
                    customer.CustomerType = "商铺";
                }
                if (radioButtonFollowing.Checked)
                {
                    ModifyOrderStatus(order, customer,OrderStatus.Following);
                }
                if (radioButtonGiveUp.Checked)
                {
                     ModifyOrderStatus(order, customer, OrderStatus.Discard);
                }
                if (radioButtonSubmit.Checked)
                {
                    if (orderDescriptionPopUp == null)
                        orderDescriptionPopUp = new OrderDescription();
                    orderDescriptionPopUp.order = order;
                    orderDescriptionPopUp.customer = customer;
                    orderDescriptionPopUp.ClearContent();
                    orderDescriptionPopUp.OrderStatusChanged += new OrderDescription.ModifyOrderStatus(ModifyOrderStatus);
                    orderDescriptionPopUp.Show();
                }
                if (radioButtonModify.Checked)
                {
                    ModifyOrderStatus(order, customer, order.OrderStatus);
                }
            }
        }

        public void ModifyOrderStatus(Order order,Customer customer,string orderStatus)
        {
            order.OrderStatus = orderStatus;
            order.Customers = customer;
            modifyCustomerManager.UpdateCustomer(order);
            LoadDetailInformation(order.OrderId);
            lblMsg.Text = "修改客户信息成功,当前订单状态为" + order.OrderStatus;
            lblMsg.Show();
            if (radioButtonSubmit.Checked)
            {
                GlobalFormValue.SalesManager.Add(order);
            }
        }

        private bool ValidateInput()
        {

            if (txtContactPerson2Number.Text != "" && modifyCustomerManager.IsPhoneNumber2Exist(txtContactPerson2Number.Text, order.Customers.CustomerId))
            {
                lblMsg.Text = "*联系人2的号码已被录入，请重新输入";
                lblMsg.Show();
                return false;
            }
            else if (txtContactPerson3Number.Text != "" && modifyCustomerManager.IsPhoneNumber3Exist(txtContactPerson3Number.Text, order.Customers.CustomerId))
            {
                lblMsg.Text = "*联系人3的号码已被录入，请重新输入";
                lblMsg.Show();
                return false;
            }
            else
            {
                lblMsg.Hide();
                return true;
            }
        }

        public void LoadDetailInformation(int orderId)
        {
            order = modifyCustomerManager.GetOrderById(orderId);
            txtCompany.Text = order.Customers.CompanyName;
            txtContactPerson.Text = order.Customers.ContactPerson;
            txtContactPerson2.Text = order.Customers.ContactPerson2;
            txtContactPerson2Number.Text = order.Customers.ContactPerson2Number;
            txtContactPerson3.Text = order.Customers.ContactPerson3;
            txtContactPerson3Number.Text = order.Customers.Contactperson3Number;
            txtContactPersonNumber.Text = order.Customers.ContactPersonNumber;
            txtEmail.Text = order.Customers.Email;
            txtRidePath.Text = order.Customers.RidePath;
            txtUsableArea.Text = order.Customers.UsableArea;
            txtDecorateAddress.Text = order.Customers.DecorationAddress;
            txtWorkPlace.Text = order.Customers.WorkPlace;
            cbCity.Text = order.Customers.City;
            lblOrderNumber.Text = order.OrderNumber.ToString();
            lblRecordDateTime.Text = order.RecordDate.ToLongDateString();
            lblImformationer.Text = order.Customers.InformationAssistants.InformationAssistantName;
            lblOrderStatus.Text = order.OrderStatus;
            lblEmployee.Text = order.Customers.Employees.Name;
            if (order.OrderStatus == OrderStatus.Submitted)
            {
                radioButtonSubmit.Checked = true;
            }
            if (order.OrderStatus == OrderStatus.Following)
            {
                radioButtonFollowing.Checked = true;
            }
            if (order.OrderStatus == OrderStatus.Discard)
            {
                radioButtonGiveUp.Checked = true;
            }
        }

        public void ClareContent()
        {
            lblMsg.Hide();
            txtCompany.Enabled = false;
            txtContactPerson.Enabled = false;
            txtContactPerson2.Enabled = false;
            txtContactPerson2Number.Enabled = false;
            txtContactPerson3.Enabled = false;
            txtContactPerson3Number.Enabled = false;
            txtContactPersonNumber.Enabled = false;
            txtDecorateAddress.Enabled = false;
            txtEmail.Enabled = false;
            txtRidePath.Enabled = false;
            txtUsableArea.Enabled = false;
            txtWorkPlace.Enabled = false;
        }

        private void radioButtonModify_CheckedChanged(object sender, EventArgs e)
        {
            txtCompany.Enabled = true;
            txtContactPerson2.Enabled = true;
            txtContactPerson2Number.Enabled = true;
            txtContactPerson3.Enabled = true;
            txtContactPerson3Number.Enabled = true;
            txtDecorateAddress.Enabled = true;
            txtEmail.Enabled = true;
            txtRidePath.Enabled = true;
            txtUsableArea.Enabled = true;
            txtWorkPlace.Enabled = true;
            DecorateDateTime.Enabled = true;
            radioButtonBanGong.Enabled = true;
            rbCooparate.Enabled = true;
            rbSingle.Enabled = true;
            radioButtonShop.Enabled = true;
        }

        private void btnAddVisit_Click(object sender, EventArgs e)
        {
            if (popUp == null)
            {
                popUp = new ReVisitPopUp();
                popUp.parentForm = this.ParentForm;
                popUp.employee = employee;
                popUp.type = VisitType.type_Customer;
                popUp.ReLoad += new DiHaoOA.WinForm.ReVisitPopUp.GetRevisit(LoadReVisit);
                this.ParentForm.Enabled = false;
                popUp.Show();
            }
            else
            {
                this.ParentForm.Enabled = false;
                popUp.Show();
            }
            popUp.informationAssistantId = _informationAssistant.InformationAssistantId;
            popUp.customerOrderId = _customerOrderId;
            popUp.ClearContent();
        }

        public void LoadReVisit()
        {
            DataSet ds = revisitManager.GetCustomerVisitAll(_customerOrderId);
            dataGridReVisit.AutoGenerateColumns = false;
            dataGridReVisit.DataSource = ds.Tables[0];
        }

        private void txtContactPerson2Number_Leave(object sender, EventArgs e)
        {
            //if(modifyCustomerManager.IsPhoneNumberExist(txtContactPerson2Number.Text,order.Customers.CustomerId))
            //{
            //    lblMsg.Text = "*号码必须为11位数字";
            //    lblMsg.Show();
            //}
        }

        private void txtContactperson3Number_Leave(object sender, EventArgs e)
        {

        }

        private void dataGridReVisit_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                e.Value = e.RowIndex + 1;//set serial number of the table rows.
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (customerTrace != null)
            {
                this.Hide();
                customerTrace.Show();
            }
        }

    }
}
