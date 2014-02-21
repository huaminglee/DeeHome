using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DiHaoOA.Business.Manager;
using DiHaoOA.DataContract.Entity;
using DiHaoOA.Controls;
using DiHaoOA.DataContract;

namespace DiHaoOA.WinForm.Forms
{
    public partial class OrderDescription : BaseForm
    {
        OrderManager orderManager;
        public Order order;
        public Customer customer;

        public delegate void ModifyOrderStatus(Order order, Customer customer, string orderStatus);

        public event ModifyOrderStatus OrderStatusChanged;

        public OrderDescription()
        {
            InitializeComponent();
            orderManager = new OrderManager();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            orderManager.AddOrderDescription(txtContent.Text, order);
            this.OrderStatusChanged(order, customer, OrderStatus.Submitted);
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
