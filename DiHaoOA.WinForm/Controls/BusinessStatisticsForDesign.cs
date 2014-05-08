using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DiHaoOA.Business;
using DiHaoOA.Business.Manager;
using DiHaoOA.DataContract;
using DiHaoOA.Controls;

namespace DiHaoOA.WinForm.Controls
{
    public partial class BusinessStatisticsForDesign : BaseUserControl
    {
        EmployeeManager empManager;
        int totalRecords = 0;
        OrderManager orderManager;

        public BusinessStatisticsForDesign()
        {
            InitializeComponent();
            empManager = new EmployeeManager();
            orderManager = new OrderManager();
        }

        public void LoadData()
        {
            dgMySuordinate.AutoGenerateColumns = false;
            dgMySuordinate.DataSource = empManager.GetDesigner().Tables[0];
            totalRecords = empManager.GetAll().Tables[0].Rows.Count;
        }

        private void BusinessStatisticsForDesign_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgMySuordinate_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            for (int i = 0; i < totalRecords; i++)
            {
                if (e.RowIndex == i)
                {
                    string employeeId = Convert.ToString(dgMySuordinate.Rows[e.RowIndex].Cells[0].Value);
                    if (e.ColumnIndex == 2)
                    {
                        e.Value = orderManager.GetCurrentMonthCountByOrderStatusForSalesManager(employeeId, OrderStatus.OnChatting);
                    }
                    if (e.ColumnIndex == 3)
                    {
                        e.Value = orderManager.GetCurrentMonthCountByOrderStatusForSalesManager(employeeId, OrderStatus.Signed);
                    }
                    if (e.ColumnIndex == 4)
                    {
                        e.Value = orderManager.GetCurrentMonthCountByOrderStatusForSalesManager(employeeId, OrderStatus.NotSigned);
                    }
                    if (e.ColumnIndex == 5)
                    {
                        e.Value = orderManager.GetCurrentMonthCountByOrderStatusForSalesManager(employeeId, OrderStatus.Denied);
                    }
                    if (e.ColumnIndex == 6)
                    {
                        e.Value = orderManager.GetLastMonthToCurrentMonthCountByOrderStatus(employeeId, OrderStatus.OnChatting);
                    }
                }
            }
        }
    }
}
