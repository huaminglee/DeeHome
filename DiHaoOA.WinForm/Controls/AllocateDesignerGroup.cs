using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DiHaoOA.Controls;
using DiHaoOA.Business;

namespace DiHaoOA.WinForm.Controls
{
    public partial class AllocateDesignerGroup : BaseUserControl
    {
        EmployeeManager empManager;

        public AllocateDesignerGroup()
        {
            InitializeComponent();
            empManager = new EmployeeManager();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            int groupId = Convert.ToInt32(cbDesingerGroup.SelectedValue);
            string designerId = Convert.ToString(cbDesinger.SelectedValue);
            empManager.AllocateDesignerToGroup(designerId, groupId);
            lblSuccessMsg.Visible = true;
        }

        private void AllocateDesignerGroup_Load(object sender, EventArgs e)
        {
            cbDesingerGroup.DataSource = empManager.GetEmployeeGroup().Tables[0];
            cbDesinger.DataSource = empManager.GetDesigner().Tables[0];
        }

        public void ClearContent()
        {
            lblSuccessMsg.Visible = false;
        }
    }
}
