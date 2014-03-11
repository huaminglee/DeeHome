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
using DiHaoOA.WinForm.Forms;

namespace DiHaoOA.WinForm.Controls
{
    public partial class OrderDetailForManager : BaseUserControl
    {
        OrderManager orderManager;
        public Order order;
        AllocateOrderPopUp allocateOrderPopUp;

        public OrderDetailForManager()
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
            if (this.Name == Approvaler.DesignerManager)
            {
                AllocateOrderToDesigner();
            }
            else
            {
                orderManager.UpdateOrderStatus(order.OrderId, OrderStatus.Submitted,Approvaler.MarketingManager);
                lblMsg.Text = "*订单已提交给设计部经理";
                lblMsg.Visible = true;
            }
        }

        private void AllocateOrderToDesigner()
        {
            if (allocateOrderPopUp == null)
            {
                allocateOrderPopUp = new AllocateOrderPopUp();
                allocateOrderPopUp.order = order;
            }
            allocateOrderPopUp.Show();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            orderManager.UpdateOrderStatus(order.OrderId, OrderStatus.Rejected);
            lblMsg.Text = "*订单已打回给业务员，状态为被打回";
            lblMsg.Visible = true;
        }

        private void OrderDetail_Load(object sender, EventArgs e)
        {
            if (this.Name == Approvaler.DesignerManager)
            {
                btnSubmit.Text = "分单";
            }
            else
            {
                btnSubmit.Text = "提交";
            }
        }



    }
}
