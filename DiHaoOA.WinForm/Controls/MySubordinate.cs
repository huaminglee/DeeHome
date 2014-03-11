using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DiHaoOA.Business;
using DiHaoOA.Controls;
using DiHaoOA.Business.Manager;

namespace DiHaoOA.WinForm.Controls
{
    public partial class MySubordinate : BaseUserControl
    {
        EmployeeManager empManager;
        MySubordinateManager mySubordinateManager;
        DisplayVisitContent displayVisitContent;
        int totalRecords = 0;

        public MySubordinate()
        {
            InitializeComponent();
            empManager = new EmployeeManager();
            mySubordinateManager = new MySubordinateManager();
        }

        private void dgIAList_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            for (int i = 0; i < totalRecords; i++)
            {
                if (e.RowIndex == i)
                {
                    string employeeId = Convert.ToString(dgMySuordinate.Rows[e.RowIndex].Cells[0].Value);
                    if (e.ColumnIndex == 1)
                    {
                        e.Value = i + 1;
                    }
                    if (e.ColumnIndex == 3)
                    {
                        e.Value = mySubordinateManager.GetVisitCount(employeeId);
                    }
                    if (e.ColumnIndex == 4)
                    {
                        e.Value = mySubordinateManager.GetInformationAssistantCount(employeeId);
                    }
                    if (e.ColumnIndex == 5)
                    {
                        e.Value = mySubordinateManager.GetCustomerCount(employeeId);
                    }
                    if (e.ColumnIndex == 6)
                    {
                        e.Value = 0;
                    }
                    if (e.ColumnIndex == 7)
                    {
                        e.Value = 0;
                    }
                    if (e.ColumnIndex == 8)
                    {
                        e.Value = 0;
                    }
                    if (e.ColumnIndex == 9)
                    {
                        e.Value = 0;
                    }
                }
            }
        }

        private void MySubordinate_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            dgMySuordinate.AutoGenerateColumns = false;
            dgMySuordinate.DataSource = empManager.GetAll().Tables[0];
            totalRecords = empManager.GetAll().Tables[0].Rows.Count;
        }

        private void dgMySuordinate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                if (e.ColumnIndex == 3)
                {
                    if (Convert.ToInt32(dgMySuordinate.Rows[e.RowIndex].Cells[3].Value) > 0)
                    {
                        if (ParentPanel != null)
                        {
                            foreach (Control control in ParentPanel.Controls)
                            {
                                control.Visible = false;
                            }
                        }
                        string employeeId = Convert.ToString(dgMySuordinate.Rows[e.RowIndex].Cells[0].Value);
                        LoadDisplayVisitContent(employeeId);
                    }
                    else
                    {
                        MessageBox.Show("该员工今天没有回访记录~.~");
                    }
                }
            }
        }

        private void LoadDisplayVisitContent(string employeeId)
        {
            if (!ParentPanel.Controls.Contains(displayVisitContent))
            {
                displayVisitContent = new DisplayVisitContent();
                displayVisitContent.Name = DiHaoUserControl.DisplayVisitContent;
                displayVisitContent.ParentPanel = ParentPanel;
                displayVisitContent.NavigationBar = NavigationBar;
                displayVisitContent.Dock = DockStyle.Fill;
                displayVisitContent.employeeId = employeeId;
                displayVisitContent.mySubordinate = this;
                ParentPanel.Controls.Add(displayVisitContent);
            }
            displayVisitContent.employee = employee;
            displayVisitContent.LoadData();
            displayVisitContent.employeeId = employeeId;
            displayVisitContent.Show();
            displayVisitContent.LoadData();
        }
    }
}
