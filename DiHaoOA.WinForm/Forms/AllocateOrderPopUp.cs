using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DiHaoOA.DataContract.Entity;
using DiHaoOA.Business;
using DiHaoOA.Business.Manager;

namespace DiHaoOA.WinForm.Forms
{
    public partial class AllocateOrderPopUp : BaseForm
    {
        public Order order;
        EmployeeManager empManager;
        OrderManager orderManager;

        public AllocateOrderPopUp()
        {
            InitializeComponent();
            empManager = new EmployeeManager();
            orderManager = new OrderManager();
        }

        private void AllocateOrderPopUp_Load(object sender, EventArgs e)
        {
            cbDesignerGroup.DataSource = empManager.GetEmployeeGroup().Tables[0];
            //cbDesinger.DataSource = empManager.GetDesignerByGroupId();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void cbDesignerGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbDesinger.Text = "";
            int groudId = Convert.ToInt32(cbDesignerGroup.SelectedValue);
            cbDesinger.DataSource = empManager.GetDesignerByGroupId(groudId).Tables[0];
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string designerId = Convert.ToString(cbDesinger.SelectedValue);
            orderManager.AllocateOrderToDesigner(designerId, order.OrderId);
            this.Hide();
            MessageBox.Show("分配订单成功");
        }
    }
}
