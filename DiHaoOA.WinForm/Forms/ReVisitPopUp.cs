using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DiHaoOA.Business.Manager;
using DiHaoOA.WinForm.Forms;
using DiHaoOA.DataContract;

namespace DiHaoOA.WinForm
{
    public partial class ReVisitPopUp : BaseForm
    {
        public delegate void GetRevisit();

        public event GetRevisit ReLoad;

        public Form parentForm;
        RevisitPopUpManager revisitPopUpManager;
        public int informationAssistantId;
        public int customerOrderId;
        public string designerId;
        public string type;

        public ReVisitPopUp()
        {
            InitializeComponent();
            revisitPopUpManager = new RevisitPopUpManager();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (txtContent.Text == "")
            {
                MessageBox.Show("内容不能为空");
                return;
            }
            this.Visible = false;
            parentForm.Enabled = true;
            SaveReVisitContent();
            MessageBox.Show("添加成功");
            this.ReLoad();
        }

        private void SaveReVisitContent()
        {
            if (type == VisitType.type_InformationAssistant)
            {
                revisitPopUpManager.SaveRevisit(txtContent.Text, DateTime.Now, informationAssistantId);
            }
            else if (type == VisitType.type_Customer)
            {
                revisitPopUpManager.SaveCustomerRevisit(txtContent.Text, DateTime.Now, customerOrderId);
            }
            else {
                revisitPopUpManager.SaveDesignerRevisit(txtContent.Text, DateTime.Now, customerOrderId);
            }
        }

        private void ReVisitPopUp_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentForm.Enabled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            parentForm.Enabled = true;
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            parentForm.Enabled = true;
        }

        private void lblExit_MouseHover(object sender, EventArgs e)
        {
            lblExit.ForeColor = Color.FromArgb(84,211,245);
        }

        private void lblExit_MouseLeave(object sender, EventArgs e)
        {
            lblExit.ForeColor = Color.FromArgb(250, 250, 250);
        }

        public void ClearContent()
        {
            txtContent.Clear();
        }
    }
}
