using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DiHaoOA.Business.Manager;
using DiHaoOA.DataContract.Entity;
using DiHaoOA.DataContract;
using DiHaoOA.Controls;

namespace DiHaoOA.WinForm.Controls
{
    public partial class ApprovalOrderDetails : BaseUserControl
    {
        OrderManager orderManager;
        public Order order;


        public ApprovalOrderDetails()
        {
            InitializeComponent();
            orderManager = new OrderManager();
        }

        public void ClearContent()
        {
            lblMsg.Visible = false;
        }

        public void LoadDetailInformation()
        {
            lblCompany.Text = order.Customers.CompanyName;
            lblEmail.Text = order.Customers.Email;
            lblRidePath.Text = order.Customers.RidePath;
            lblUsableArea.Text = order.Customers.UsableArea;
            lblDecorateAddress.Text = order.Customers.DecorationAddress;
            lblWorkPlace.Text = order.Customers.WorkPlace;
            lblCity.Text = order.Customers.City;
            lblOrderNumber.Text = order.OrderNumber.ToString();
            lblRecordDateTime.Text = order.RecordDate.ToLongDateString();
            lblImformationer.Text = order.Customers.InformationAssistants.InformationAssistantName;
            lblOrderStatus.Text = order.OrderStatus;
            lblEmployee.Text = order.Customers.Employees.Name;
            txtDescription.Text = order.Description;
            lblCustomerType.Text = order.Customers.CustomerType;
            lblProviderType.Text = order.Customers.ProviderType;
            lblDecorateDate.Text = order.Customers.AppointDateTime;
            lblDesinger.Text = order.Designer.Name;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (order.OrderStatus == OrderStatus.SubmittedNotAllowed)
            {
                orderManager.UpdateOrderStatus(order.OrderId, OrderStatus.SubmittedNotAllowedForMarketing);
            }
            if (order.OrderStatus == OrderStatus.SubmittedNotSignedForDesign)
            {
                orderManager.UpdateOrderStatus(order.OrderId, OrderStatus.SubmittedNotSignedForMarketing);
            }
            if (order.OrderStatus == OrderStatus.SubmittedSignedForDesign)
            {
                orderManager.UpdateOrderStatus(order.OrderId, OrderStatus.SubmittedSignedForMarketing);
            }
            if (order.OrderStatus == OrderStatus.SubmittedNotAllowedForMarketing)
            {
                orderManager.UpdateOrderStatus(order.OrderId, OrderStatus.Denied);
            }
            if (order.OrderStatus == OrderStatus.SubmittedNotSignedForMarketing)
            {
                orderManager.UpdateOrderStatus(order.OrderId, OrderStatus.NotSigned);
            }
            if (order.OrderStatus == OrderStatus.SubmittedSignedForMarketing)
            {
                orderManager.UpdateOrderStatus(order.OrderId, OrderStatus.Signed);
            }
            if (order.SubmittedBy == SubmittedBy.Designer)
            {
                orderManager.UpdateOrderStatus(order.OrderId, order.OrderStatus, SubmittedBy.DesignerManager);
                lblMsg.Text = "*设计部经理审批" + order.OrderStatus;
            }
            else if (order.SubmittedBy == SubmittedBy.DesignerManager)
            {
                if (order.OrderStatus == OrderStatus.SubmittedNotAllowed)
                {
                    orderManager.UpdateOrderStatus(order.OrderId, OrderStatus.Denied, SubmittedBy.MarketingManager);
                }
                if (order.OrderStatus == OrderStatus.SubmittedNotSigned)
                {
                    orderManager.UpdateOrderStatus(order.OrderId, OrderStatus.NotSigned, SubmittedBy.MarketingManager);
                }
                if (order.OrderStatus == OrderStatus.SubmittedSigned)
                {
                    orderManager.UpdateOrderStatus(order.OrderId, OrderStatus.Signed, SubmittedBy.MarketingManager);
                }
                order = orderManager.GetOrderById(order.OrderId);
                lblMsg.Text = "*市场部经理审批" + order.OrderStatus;
            }
            order = orderManager.GetOrderById(order.OrderId);
            lblMsg.Visible = true;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            orderManager.UpdateOrderStatus(order.OrderId, OrderStatus.OnChatting);
            lblMsg.Text = "*订单已打回给设计师，状态为在谈";
            lblMsg.Visible = true;
        }


    }
}
