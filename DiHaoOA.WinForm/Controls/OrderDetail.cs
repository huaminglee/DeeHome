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
using DiHaoOA.DataContract;

namespace DiHaoOA.WinForm.Controls
{
    public partial class OrderDetail : BaseUserControl
    {
        OrderManager orderManager;
        public Order order;

        public OrderDetail()
        {
            InitializeComponent();
            orderManager = new OrderManager();
        }


        public void ClearContent()
        {
            txtCompany.Enabled = false;
            txtDecorateAddress.Enabled = false;
            txtEmail.Enabled = false;
            txtRidePath.Enabled = false;
            txtUsableArea.Enabled = false;
            txtWorkPlace.Enabled = false;
            lblMsg.Visible = false;
        }

        public void LoadDetailInformation(int orderId)
        {
            Order order = orderManager.GetOrderById(orderId);
            txtCompany.Text = order.Customers.CompanyName;
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
            txtDescription.Text = order.Description;
            lblCustomerType.Text = order.Customers.CustomerType;
            lblProviderType.Text = order.Customers.ProviderType;
            lblDecorateDate.Text = order.Customers.AppointDateTime;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            orderManager.UpdateOrderStatus(order.OrderId, OrderStatus.SubmittedToDesigner);
            lblMsg.Text = "*订单已提交给设计部经理，状态为提交订单";
            lblMsg.Visible = true;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            orderManager.UpdateOrderStatus(order.OrderId, OrderStatus.Rejected);
            lblMsg.Text = "*订单已打回给业务员，状态为被打回";
            lblMsg.Visible = true;
        }

      
    }
}
