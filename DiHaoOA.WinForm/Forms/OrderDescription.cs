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

namespace DiHaoOA.WinForm.Forms
{
    public partial class OrderDescription : BaseForm
    {
        OrderManager orderManager;
        public Order order;
        public ModifyCustomer modifyCustomer;

        public OrderDescription()
        {
            InitializeComponent();
            orderManager = new OrderManager();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            orderManager.AddOrderDescription(txtContent.Text, order);
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
