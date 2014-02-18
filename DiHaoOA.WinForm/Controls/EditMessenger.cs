using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DiHaoOA.Controls;
using DiHaoOA.Business.Manager;
using DiHaoOA.DataContract.Entity;
using DiHaoOA.WinForm;
using DiHaoOA.WinForm.Common;
using DiHaoOA.DataContract;
using DiHaoOA.WinForm.Controls;

namespace DiHaoOA
{
    public partial class EditMessenger : BaseUserControl
    {
        EditMessengerManager editMessenger;
        CustomerTraceManager customerTraceManager;
        RevisitPopUpManager revisitManager;
        public AllList allList;
        ReVisitPopUp popUp;
        AddCustomer addCustomer;
        ModifyCustomer modifyCustomer;
        public InformationAssistant _informationAssistant;
        DataSet datas;

        public EditMessenger()
        {
            InitializeComponent();
            editMessenger = new EditMessengerManager();
            revisitManager = new RevisitPopUpManager();
        }


        public void LoadDetailInformation(int informationAssistantId)
        {
            InformationAssistant informationAssistant = editMessenger.GetInformationAssistantById(informationAssistantId);
            _informationAssistant = informationAssistant;
            txtMessengerName.Text = informationAssistant.InformationAssistantName;
            txtPhone.Text = informationAssistant.PhoneNumber;
            txtCompany.Text = informationAssistant.Company;
            txtAddress.Text = informationAssistant.Address;
            txtHandSet.Text = informationAssistant.HandSet;
            cbCity.Text = informationAssistant.City;
            if (informationAssistant.IsVisit)
            {
                rbVisitYes.Checked = true;
            }
            else
            {
                rbVisitNo.Checked = true;
            }
            lblLevel.Text = informationAssistant.InformationLevel;
            lblLeftRevisitDays.Text = informationAssistant.ReVisitTime;
            dgInformList.AutoGenerateColumns = false;
            dgInformList.DataSource = editMessenger.GetInformList(_informationAssistant.InformationAssistantId).Tables[0];
            dgTracingInformList.AutoGenerateColumns = false;
            dgTracingInformList.DataSource = editMessenger.GetTraceingInformList(_informationAssistant.InformationAssistantId).Tables[0];
        }

        private void btnSaveCustomer_Click(object sender, EventArgs e)
        {
            if (ParentPanel != null)
            {
                foreach (Control control in ParentPanel.Controls)
                {
                    control.Visible = false;
                }
                if (!ParentPanel.Controls.Contains(addCustomer))
                {
                    addCustomer = new AddCustomer();
                    addCustomer.ParentPanel = ParentPanel;
                    addCustomer.Name = "AddCustomer";
                    addCustomer.NavigationBar = NavigationBar;
                    addCustomer.Menu = "CustomerTrace";
                    addCustomer.ChildMenu = "正跟踪";
                }
                addCustomer.employee = employee;
                addCustomer.informationAssistant = _informationAssistant;
                addCustomer.employee = this.employee;
                ParentPanel.Controls.Add(addCustomer);
                addCustomer.ClearContent();
                addCustomer.Show();


            }
        }

        private void btnReturenAllList_Click(object sender, EventArgs e)
        {
            this.Hide();
            allList.LoadDataGrid(allList.pageIndex, allList._eventCode, SearchInput.NoContent);
            allList.Show();
            
        }

        private void btnReVisit_Click(object sender, EventArgs e)
        {
            if (popUp == null)
            {
                popUp = new ReVisitPopUp();
                popUp.parentForm = this.ParentForm;
                popUp.employee = employee;
                popUp.ReLoad += new DiHaoOA.WinForm.ReVisitPopUp.GetRevisit(LoadReVisit);
                popUp.type = VisitType.type_InformationAssistant;
                this.ParentForm.Enabled = false;
                popUp.Show();
            }
            else
            {
                this.ParentForm.Enabled = false;
                popUp.Show();
            }
            popUp.informationAssistantId = _informationAssistant.InformationAssistantId;
            popUp.ClearContent();

        }

        public void LoadReVisit()
        {
            DataSet ds = revisitManager.GetAll(_informationAssistant.InformationAssistantId);
            dataGridReVisit.AutoGenerateColumns = false;
            dataGridReVisit.DataSource = ds.Tables[0];
        }

        private void dataGridReVisit_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                e.Value = e.RowIndex + 1;//set serial number of the table rows.
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (IsValidateInput())
            {
                InformationAssistant messenger = new InformationAssistant();
                messenger.InformationAssistantId = _informationAssistant.InformationAssistantId;
                messenger.InformationAssistantName = txtMessengerName.Text;
                messenger.PhoneNumber = txtPhone.Text;
                if (rbTypeInterMedia.Checked)
                {
                    messenger.Type = "中介";
                }
                else
                {
                    messenger.Type = "售楼";
                }
                if (rbVisitNo.Checked)
                {
                    messenger.IsVisit = false;
                }
                else
                {
                    messenger.IsVisit = true;
                }
                messenger.HandSet = txtHandSet.Text;
                messenger.Company = txtCompany.Text;
                messenger.Address = txtAddress.Text;
                editMessenger.UpdateMessenger(messenger);
                lblSuccessMsg.Text = "编辑成功";
                lblSuccessMsg.Visible = true;
            }
            else
            {
                lblSuccessMsg.Visible = false;
            }

        }


        private bool IsValidateInput()
        {
            return true;
        }

        public void ClearControlContent()
        {
            lblSuccessMsg.Visible = false;
        }

        private void btnFirstPage_Click(object sender, EventArgs e)
        {

        }

        private void EditMessenger_Load(object sender, EventArgs e)
        {
            dgInformList.AutoGenerateColumns = false;
            dgInformList.DataSource = editMessenger.GetInformList(_informationAssistant.InformationAssistantId).Tables[0];
            datas = editMessenger.GetInformList(_informationAssistant.InformationAssistantId);
        }

        private void dgInformList_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                if (datas.Tables[0].Rows.Count > 0)
                {
                    e.Value = Convert.ToDateTime(datas.Tables[0].Rows[e.RowIndex][e.ColumnIndex + 2]).ToLongDateString();
                }
            }
        }

        private void dgInformList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 2)
                {
                    int orderId = Convert.ToInt32(dgInformList.Rows[e.RowIndex].Cells[0].Value);
                    string childMenu = Convert.ToString(dgInformList.Rows[e.RowIndex].Cells[2].Value).Split(' ')[1];
                    if (ParentPanel != null)
                    {
                        foreach (Control control in ParentPanel.Controls)
                        {
                            if (control is EditMessenger)
                            {
                                control.Visible = false;
                            }
                        }
                        LoadModifyCustomer(orderId);
                        NavigationBar.ChangeNavItem("CustomerTrace", childMenu);
                    }
                }
            }
        }

        private void LoadModifyCustomer(int orderId)
        {
            if (_informationAssistant == null)
            {
                _informationAssistant = customerTraceManager.GetInformationAssistantByOrderId(orderId);
            }
            if (!ParentPanel.Contains(modifyCustomer))
            {
                modifyCustomer = new ModifyCustomer();
                modifyCustomer.Name = "ModifyCustomer";
                modifyCustomer.ParentPanel = ParentPanel;
                modifyCustomer.NavigationBar = NavigationBar;
                modifyCustomer.employee = employee;
                modifyCustomer.Dock = DockStyle.Fill;
                modifyCustomer._informationAssistant = _informationAssistant;
                ParentPanel.Controls.Add(modifyCustomer);
            }
            else
            {
                modifyCustomer.Show();
                modifyCustomer.ClareContent();
            }
            modifyCustomer.LoadDetailInformation(orderId);
            modifyCustomer._informationAssistant = _informationAssistant;
            modifyCustomer._customerOrderId = orderId;
            modifyCustomer.LoadReVisit();
        }

    }
}
