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
using DiHaoOA.DataContract;

namespace DiHaoOA.WinForm.Controls
{
    public partial class MyDesigner : BaseUserControl
    {
        EmployeeManager empManager;
        OrderManager orderManager;
        int totalRecords = 0;

        public MyDesigner()
        {
            InitializeComponent();
            empManager = new EmployeeManager();
            orderManager = new OrderManager();
        }

        public void LoadData()
        {
            dgMyDesigner.AutoGenerateColumns = false;
            dgMyDesigner.DataSource = empManager.GetDesigner().Tables[0];
            totalRecords = empManager.GetAll().Tables[0].Rows.Count;
        }

        private void dgMyDesigner_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            for (int i = 0; i < totalRecords; i++)
            {
                if (e.RowIndex == i)
                {
                    string employeeId = Convert.ToString(dgMyDesigner.Rows[e.RowIndex].Cells[0].Value);
                    if (e.ColumnIndex == 1)
                    {
                        e.Value = empManager.GetGroupNameByEmployeeId(employeeId);
                    }
                    if (e.ColumnIndex == 2)
                    {
                        e.Value = empManager.GetEmployeeById(employeeId).Name;
                    }
                    if (e.ColumnIndex == 3)
                    {
                        e.Value = orderManager.GetCurrentMonthCountByOrderStatus(employeeId, OrderStatus.OnChatting);
                    }
                    if (e.ColumnIndex == 4)
                    {
                        e.Value = orderManager.GetCurrentMonthCountByOrderStatus(employeeId, OrderStatus.Signed);
                    }
                    if (e.ColumnIndex == 5)
                    {
                        e.Value = orderManager.GetCurrentMonthCountByOrderStatus(employeeId, OrderStatus.NotSigned);
                    }
                    if (e.ColumnIndex == 6)
                    {
                        e.Value = orderManager.GetCurrentMonthCountByOrderStatus(employeeId, OrderStatus.Denied);
                    }
                }
            }
        }

    }
}
