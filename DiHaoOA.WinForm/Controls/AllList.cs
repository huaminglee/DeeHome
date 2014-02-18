using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using DiHaoOA.Business;
using System.Text.RegularExpressions;
using DiHaoOA.DataContract.Entity;
using DiHaoOA.WinForm;
using DiHaoOA.Business.Manager;

namespace DiHaoOA.Controls
{
    public partial class AllList : BaseUserControl
    {
        AllListManager allListManager;
        EditMessengerManager editMessengerManager;
        AddInformationAssistant addInformationAssistant;
        EditMessenger editMessenger;

        public int pageIndex;
        const int pageSize = 30;
        int TotalRecords;
        int totalPage;
        public string _eventCode;
        DataSet dataSet;

        public AllList()
        {
            InitializeComponent();
            allListManager = new AllListManager();
            editMessengerManager = new EditMessengerManager();
        }

        public void LoadDataGrid(int index, string eventCode, string searchInput)
        {
            _eventCode = eventCode;
            gridAllList.AutoGenerateColumns = false;
            pageIndex = index;
            TotalRecords = allListManager.GetTotalRows(_eventCode, searchInput, employee.EmployeeId);
            if (TotalRecords % pageSize == 0)
            {
                totalPage = TotalRecords / pageSize;
            }
            else
            {
                totalPage = TotalRecords / pageSize + 1;
            }
            lblRecord.Text = "共" + TotalRecords + "条记录";
            if (totalPage == 0)
            {
                lblCurrentRecord.Text = "当前是" + 0 + "/" + 0 + "页";
            }
            else
            {
                lblCurrentRecord.Text = "当前是" + pageIndex + "/" + totalPage + "页";
            }
            DataSet ds = allListManager.GetAllList(pageIndex, pageSize, _eventCode, searchInput, employee.EmployeeId);
            dataSet = ds;
            gridAllList.DataSource = ds.Tables[0];
            if (totalPage == 1 || totalPage == 0)
            {
                btnPrevPage.Enabled = false;
                btnNextPage.Enabled = false;
            }
            else
            {
                if (pageIndex <= 1)
                {
                    btnPrevPage.Enabled = false;
                    btnNextPage.Enabled = true;
                }
                else if (pageIndex >= totalPage)
                {
                    btnPrevPage.Enabled = true;
                    btnNextPage.Enabled = false;
                }
                else
                {
                    btnPrevPage.Enabled = true;
                    btnNextPage.Enabled = true;
                }
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ParentPanel != null)
            {
                foreach (Control control in ParentPanel.Controls)
                {
                    control.Visible = false;
                }
                if (!ParentPanel.Controls.Contains(addInformationAssistant))
                {
                    addInformationAssistant = new AddInformationAssistant();
                    ParentPanel.Controls.Add(addInformationAssistant);
                }
                addInformationAssistant.ClearControlContent();//clear the contents of all te text box;
                addInformationAssistant.employee = employee;
                addInformationAssistant.allList = this;
                addInformationAssistant.ParentPanel = this.ParentPanel;
                addInformationAssistant.Show();
            }
        }

        private void LoadEditMessenger(InformationAssistant informationAssistant)
        {
            if (!ParentPanel.Controls.Contains(editMessenger))
            {
                editMessenger = new EditMessenger();
                editMessenger.Name = "EditMessenger";
                editMessenger.ParentPanel = ParentPanel;
                editMessenger.NavigationBar = NavigationBar;
                editMessenger.Dock = DockStyle.Fill;
                
            }
            editMessenger.employee = employee;
            editMessenger._informationAssistant = informationAssistant;
            editMessenger.allList = this;
            ParentPanel.Controls.Add(editMessenger);
            editMessenger.Show();
            editMessenger.ClearControlContent();
            editMessenger.LoadDetailInformation(informationAssistant.InformationAssistantId);
            editMessenger.LoadReVisit();
        }

        private void gridAllList_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                e.Value = (pageIndex - 1) * pageSize + e.RowIndex + 1;//set serial number of the table rows.
            }
            if (e.ColumnIndex == 9)
            {
                if (dataSet.Tables[0].Rows.Count > 0)
                {
                    e.Value = dataSet.Tables[0].Rows[e.RowIndex][e.ColumnIndex + 1] + "小时";
                }

            }
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            LoadDataGrid(++pageIndex, _eventCode, txtSearch.Text.Trim());
        }

        private void btnPrevPage_Click(object sender, EventArgs e)
        {
            LoadDataGrid(--pageIndex, _eventCode, txtSearch.Text.Trim());
        }

        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            LoadDataGrid(1, _eventCode, txtSearch.Text.Trim());
        }

        private void btnLastPage_Click(object sender, EventArgs e)
        {
            LoadDataGrid(totalPage, _eventCode, txtSearch.Text.Trim());
        }

        private void btnGoForward_Click(object sender, EventArgs e)
        {
            string reg = @"^\d+$";
            if (!Regex.IsMatch(txtPage.Text, reg))
            {
                MessageBox.Show("请输入数字");
            }
            else
            {
                int goForwardPage = Convert.ToInt32(txtPage.Text);
                if (goForwardPage <= 0 || goForwardPage > totalPage)
                {
                    MessageBox.Show("页数必须在1到" + totalPage + "之间");
                }
                else
                {
                    LoadDataGrid(goForwardPage, _eventCode, txtSearch.Text.Trim());
                }
            }

        }

        /// <summary>
        /// get a new list by your input
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSeniorSearch_Click(object sender, EventArgs e)
        {
            LoadDataGrid(pageIndex, _eventCode, txtSearch.Text.Trim());
        }

        /// <summary>
        /// when select a child menu. reset the search textbox
        /// </summary>
        public void ClearSearchContent()
        {
            txtSearch.Clear();
        }

        private void gridAllList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)//can't click the header
            {
                int informationAssistantId = Convert.ToInt32(gridAllList.Rows[e.RowIndex].Cells[0].Value);
                InformationAssistant informationAssistant = editMessengerManager.GetInformationAssistantById(informationAssistantId);
                if (e.ColumnIndex == 2)//Display EditMessenger Only when click the name column,
                {
                    if (ParentPanel != null)
                    {
                        foreach (Control control in ParentPanel.Controls)
                        {
                            control.Visible = false;
                        }
                        if (this.Name == DiHaoUserControl.AllList)
                        {
                            LoadEditMessenger(informationAssistant);
                        }
                    }
                }
            }
        }

        private void AllList_Load(object sender, EventArgs e)
        {

        }

    }
}
