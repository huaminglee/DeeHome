using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DiHaoOA.Business;
using DiHaoOA.Business.Manager;

namespace DiHaoOA.WinForm.Forms
{
    public partial class ModifyIA : BaseForm
    {
        EmployeeManager employeeManager;
        public List<int> informationAssistantId;
        EditUnSubordinateIAManager editUnsubordinateIAManager;
        InformationAssistantManager iaManager;
        public Form parentForm;

        public delegate void AllListForMarketingReload();

        public event AllListForMarketingReload ReLoad;

        public ModifyIA()
        {
            InitializeComponent();
            employeeManager = new EmployeeManager();
            editUnsubordinateIAManager = new EditUnSubordinateIAManager();
            iaManager = new InformationAssistantManager();
        }

        private void ModifyIA_Load(object sender, EventArgs e)
        {
            cbEmployee.DataSource = employeeManager.GetAll().Tables[0];
            cbEmployee.DisplayMember = "Name";
            cbEmployee.ValueMember = "EmployeeId";
        }

        private void lblExit_MouseHover(object sender, EventArgs e)
        {
            lblExit.ForeColor = Color.FromArgb(84, 211, 245);
        }

        private void lblExit_MouseLeave(object sender, EventArgs e)
        {
            lblExit.ForeColor = Color.FromArgb(250, 250, 250);
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            parentForm.Enabled = true;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string employeeId = cbEmployee.SelectedValue.ToString();
            foreach (int id in informationAssistantId)
            {
                if (!iaManager.IsEmployeeActive(id)|| ckYes.Checked)//如果员工离职或者经理要转客户
                {
                    editUnsubordinateIAManager.TransferCustomer(employeeId, id);
                }
                if(iaManager.IsEmployeeActive(id)){
                    //iaManager.SetUnSunordinate(id);//员工没离职则当前信息员的客户为未隶属
                }
                editUnsubordinateIAManager.TransferInformationAssistant(employeeId, id);
            }
            this.Hide();
            parentForm.Enabled = true;
            MessageBox.Show("转信息员成功");
            this.ReLoad();
        }

    }
}
