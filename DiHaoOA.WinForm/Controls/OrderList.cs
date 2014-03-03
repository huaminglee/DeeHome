using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DiHaoOA.Business.Manager;
using DiHaoOA.Controls;
using DiHaoOA.DataContract.Entity;
using DiHaoOA.DataContract;

namespace DiHaoOA.WinForm.Controls
{
    public partial class OrderList : BaseUserControl
    {
        public string orderStatus = string.Empty;
        DataSet datas;
        CustomerManager customerManager;
        OrderManager orderManager;
        OrderDetail orderDetails;
        OrderDetailForIA orderDetailsForIA;
        public string role = string.Empty;

        public OrderList()
        {
            InitializeComponent();
            customerManager = new CustomerManager();
            orderManager = new OrderManager();
        }

        private void GetDataSource(int _index, int _pageSize)
        {
            DataSet ds = null;
            int totalRecords = 0;
            if (role == Roles.Designer)
            {
                ds = orderManager.GetOrderByOrderStatus(_index, _pageSize, txtSearch.Text.Replace(" ", ""), orderStatus, employee.EmployeeId, "dbo.pro_GetOrderByOrderStatus");
                totalRecords = orderManager.GetTotalRecords(_index, _pageSize, txtSearch.Text.Replace(" ", ""), orderStatus, employee.EmployeeId, "dbo.pro_GetOrderByOrderStatus");
            }
            else
            {
                ds = orderManager.GetOrderByOrderStatus(_index, _pageSize, txtSearch.Text.Replace(" ", ""), orderStatus, employee.EmployeeId, "dbo.pro_GetOrderByOrderStatusForIA");
                totalRecords = orderManager.GetTotalRecords(_index, _pageSize, txtSearch.Text.Replace(" ", ""), orderStatus, employee.EmployeeId, "dbo.pro_GetOrderByOrderStatusForIA");
            }
            datas = ds;
            pagingForCustomer.TotalRecords = totalRecords;
            pagingForCustomer.pageIndex = _index;
            pagingForCustomer.SetDefaultData();
            dgOrderList.DataSource = ds.Tables[0];
        }

        public void ClearSearchText()
        {
            txtSearch.Clear();
        }

        public void ReLoadData()
        {
            GetDataSource(pagingForCustomer.pageIndex, pagingForCustomer.pageSize);
        }

        private void OrderList_Load(object sender, EventArgs e)
        {
            dgOrderList.AutoGenerateColumns = false;
            pagingForCustomer.OnDataLoad += new DiHaoOA.WinForm.Controls.PagingControl.LoadData(GetDataSource);
        }

        private void dgOrderList_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                e.Value = (pagingForCustomer.pageIndex - 1) * pagingForCustomer.pageSize + e.RowIndex + 1;//set serial number of the table rows.
            }
        }

        private void dgOrderList_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            DataGridViewRow dgr = dgOrderList.Rows[e.RowIndex];
            if (e.ColumnIndex == 2)
            {
                string orderNumber = datas.Tables[0].Rows[e.RowIndex][e.ColumnIndex + 1].ToString();
                string status = datas.Tables[0].Rows[e.RowIndex][e.ColumnIndex + 2].ToString();
                Rectangle newRect = new Rectangle(e.CellBounds.X + 5, e.CellBounds.Y + 3, e.CellBounds.Width - 15,
                    e.CellBounds.Height - 10);
                using (Brush gridBrush = new SolidBrush(dgOrderList.GridColor), backColorBrush = new SolidBrush(e.CellStyle.BackColor))
                {
                    using (Pen gridLinePen = new Pen(gridBrush, 2))
                    {
                        // Erase the cell.
                        e.Graphics.FillRectangle(backColorBrush, e.CellBounds);

                        //划线
                        Point p1 = new Point(e.CellBounds.Left + e.CellBounds.Width, e.CellBounds.Top);
                        Point p2 = new Point(e.CellBounds.Left + e.CellBounds.Width, e.CellBounds.Top + e.CellBounds.Height);
                        Point p3 = new Point(e.CellBounds.Left, e.CellBounds.Top + e.CellBounds.Height);
                        Point[] ps = new Point[] { p1, p2, p3 };
                        //Point[] ps = new Point[] { p1, p2 };
                        e.Graphics.DrawLines(gridLinePen, ps);

                        //画多边形
                        //e.Graphics.DrawRectangle(Pens.White, newRect);
                        //e.Graphics.FillRectangle(Brushes.White, newRect);
                        //画字符串
                        e.Graphics.DrawString(orderNumber, e.CellStyle.Font, Brushes.Black,
                            e.CellBounds.Left + 5, e.CellBounds.Top + 5, StringFormat.GenericDefault);
                        e.Graphics.DrawString(status, e.CellStyle.Font, Brushes.Red,
                           e.CellBounds.Left + 40, e.CellBounds.Top + 5, StringFormat.GenericDefault);
                        e.Handled = true;
                    }
                }
            }
        }

        private void dgOrderList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 2)
                {
                    int orderId = Convert.ToInt32(dgOrderList.Rows[e.RowIndex].Cells[0].Value);
                    if (ParentPanel != null)
                    {
                        foreach (Control control in ParentPanel.Controls)
                        {
                            control.Visible = false;
                        }
                        if (role == Roles.Designer)
                        {
                            LoadOrderDetail(orderId);
                        }
                        else
                        {
                            LoadOrderDetailForIA(orderId);
                        }
                        
                    }
                }
            }
        }

        private void LoadOrderDetailForIA(int orderId)
        {
            Order order = orderManager.GetOrderById(orderId);
            if (!ParentPanel.Contains(orderDetailsForIA))
            {
                orderDetailsForIA = new OrderDetailForIA();
                orderDetailsForIA.Name = "OrderDetailForIA";
                orderDetailsForIA.ParentPanel = ParentPanel;
                orderDetailsForIA.NavigationBar = NavigationBar;
                orderDetailsForIA.employee = employee;
                orderDetailsForIA.Dock = DockStyle.Fill;
                orderDetailsForIA.order = order;
                ParentPanel.Controls.Add(orderDetailsForIA);
            }
            orderDetailsForIA.order = order;
            orderDetailsForIA.Show();
            orderDetailsForIA.employee = employee;
            orderDetailsForIA.LoadDetailInformation();
            orderDetailsForIA.LoadReVisit();
        }

        private void LoadOrderDetail(int orderId)
        {
            Order order = orderManager.GetOrderById(orderId);
            if (!ParentPanel.Contains(orderDetails))
            {
                orderDetails = new OrderDetail();
                orderDetails.Name = "OrderDetailForDesigner";
                orderDetails.ParentPanel = ParentPanel;
                orderDetails.NavigationBar = NavigationBar;
                orderDetails.employee = employee;
                orderDetails.Dock = DockStyle.Fill;
                orderDetails.order = order;
                ParentPanel.Controls.Add(orderDetails);
            }
            orderDetails.order = order;
            orderDetails.Show();
            orderDetails.ClearContent();
            orderDetails.employee = employee;
            orderDetails.LoadDetailInformation();
        }

        private void dgOrderList_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                dgOrderList.Cursor = Cursors.Hand;
            }
            else
            {
                dgOrderList.Cursor = Cursors.Arrow;
            }
        }
    }
}
