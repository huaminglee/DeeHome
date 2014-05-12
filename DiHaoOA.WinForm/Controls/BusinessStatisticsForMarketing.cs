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
    public partial class BusinessStatisticsForMarketing : BaseUserControl
    {
        EmployeeManager empManager;
        int totalRecords = 0;
        OrderManager orderManager;
        VisitContentForDesigner visitContentForDesigner;

        public BusinessStatisticsForMarketing()
        {
            InitializeComponent();
            empManager = new EmployeeManager();
            orderManager = new OrderManager();
        }

        public void LoadData()
        {
            OrderList.AutoGenerateColumns = false;
            OrderList.DataSource = empManager.GetSalesMan().Tables[0];
            totalRecords = empManager.GetAll().Tables[0].Rows.Count;
        }

        private void BusinessStatisticsForMarketing_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgMySuordinate_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            for (int i = 0; i < totalRecords; i++)
            {
                if (e.RowIndex == i)
                {
                    string employeeId = Convert.ToString(OrderList.Rows[e.RowIndex].Cells[0].Value);
                    if (e.ColumnIndex == 2)
                    {
                        e.Value = 0;
                    }
                    if (e.ColumnIndex == 3)
                    {
                        e.Value = orderManager.GetCurrentMonthCountByOrderStatusForSalesManager(employeeId, OrderStatus.OnChatting);
                    }
                    if (e.ColumnIndex == 4)
                    {
                        e.Value = orderManager.GetCurrentMonthCountByOrderStatusForSalesManager(employeeId, OrderStatus.Denied);
                    }
                    if (e.ColumnIndex == 5)
                    {
                        e.Value = orderManager.GetCurrentMonthCountByOrderStatusForSalesManager(employeeId, OrderStatus.NotSigned);
                    }
                    if (e.ColumnIndex == 6)
                    {
                        e.Value = orderManager.GetCurrentMonthCountByOrderStatusForSalesManager(employeeId, OrderStatus.Signed);
                    }
                    if (e.ColumnIndex == 7)
                    {
                        e.Value = orderManager.GetLastMonthToCurrentMonthCountByOrderStatus(employeeId,OrderStatus.OnChatting);
                    }
                }
            
            }
        }

        private void dgMySuordinate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 2)
                {
                    int orderId = Convert.ToInt32(OrderList.Rows[e.RowIndex].Cells[0].Value);
                    if (visitContentForDesigner == null)
                    {
                        visitContentForDesigner = new VisitContentForDesigner();
                        visitContentForDesigner.orderID = orderId;
                        visitContentForDesigner.Name = "ModifyCustomer";
                        visitContentForDesigner.ParentPanel = ParentPanel;
                        visitContentForDesigner.NavigationBar = NavigationBar;
                        visitContentForDesigner.employee = employee;
                        visitContentForDesigner.Dock = DockStyle.Fill;
                        ParentPanel.Controls.Add(visitContentForDesigner);
                    }
                    visitContentForDesigner.orderID = orderId;
                    visitContentForDesigner.Show();
                }
            }
        }
    }
}


