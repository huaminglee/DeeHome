﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DiHaoOA.Controls;
using DiHaoOA.Business.Manager;

namespace DiHaoOA.WinForm.Controls
{
    public partial class ApprovalList : BaseUserControl
    {
        CustomerManager customerManager;
        OrderManager orderManager;
        OrderDetail orderDetail;
        DataSet datas;

        public string procedureName = string.Empty;

        public ApprovalList()
        {
            InitializeComponent();
            customerManager = new CustomerManager();
            orderManager = new OrderManager();
        }

        private void ApprovalList_Load(object sender, EventArgs e)
        {
            dgApprovalCustomer.AutoGenerateColumns = false;
            pagingForCustomer.OnDataLoad += new DiHaoOA.WinForm.Controls.PagingControl.LoadData(GetDataSource);
        }

        public void ReLoadData()
        {
            GetDataSource(pagingForCustomer.pageIndex, pagingForCustomer.pageSize);
        }

        private void GetDataSource(int _index, int _pageSize)
        {
            DataSet ds = customerManager.GetSubmittedCustomer(_index, _pageSize, txtSearch.Text.Replace(" ", ""), procedureName);
            datas = ds;
            int totalRecords = customerManager.GetTotalRecords(_index, _pageSize, txtSearch.Text.Replace(" ", ""), procedureName);
            pagingForCustomer.TotalRecords = totalRecords;
            pagingForCustomer.pageIndex = _index;
            pagingForCustomer.SetDefaultData();
            dgApprovalCustomer.DataSource = ds.Tables[0];
        }

        private void dgApprovalCustomer_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                e.Value = (pagingForCustomer.pageIndex - 1) * pagingForCustomer.pageSize + e.RowIndex + 1;//set serial number of the table rows.
            }
        }

        public void ClearSearchText()
        {
            txtSearch.Clear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            GetDataSource(pagingForCustomer.pageIndex, pagingForCustomer.pageSize);
        }

        private void dgApprovalCustomer_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            DataGridViewRow dgr = dgApprovalCustomer.Rows[e.RowIndex];
            //dgr.Cells["TaskNumber"].Value.ToString().Split(' ')[1]
            if (e.ColumnIndex == 2)
            {
                string orderNumber = datas.Tables[0].Rows[e.RowIndex][e.ColumnIndex + 1].ToString();
                string status = datas.Tables[0].Rows[e.RowIndex][e.ColumnIndex + 2].ToString();
                Rectangle newRect = new Rectangle(e.CellBounds.X + 5, e.CellBounds.Y + 3, e.CellBounds.Width - 15,
                    e.CellBounds.Height - 10);
                using (Brush gridBrush = new SolidBrush(dgApprovalCustomer.GridColor), backColorBrush = new SolidBrush(e.CellStyle.BackColor))
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

        private void dgApprovalCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 2)
                {
                    int orderId = Convert.ToInt32(dgApprovalCustomer.Rows[e.RowIndex].Cells[0].Value);
                    if (ParentPanel != null)
                    {
                        foreach (Control control in ParentPanel.Controls)
                        {
                            if (control is ApprovalList)
                            {
                                control.Visible = false;
                            }
                        }
                        LoadOrderDetail(orderId);
                    }
                }
            }
        }

        private void LoadOrderDetail(int orderId)
        {
            if (!ParentPanel.Contains(orderDetail))
            {
                orderDetail = new OrderDetail();
                orderDetail.Name = "ModifyCustomer";
                orderDetail.ParentPanel = ParentPanel;
                orderDetail.NavigationBar = NavigationBar;
                orderDetail.employee = employee;
                orderDetail.Dock = DockStyle.Fill;
                ParentPanel.Controls.Add(orderDetail);
            }
            orderDetail.order = orderManager.GetOrderById(orderId);
            orderDetail.Show();
            orderDetail.ClearContent();
            orderDetail.employee = employee;
            orderDetail.LoadDetailInformation(orderId);
        }

        private void dgApprovalCustomer_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                dgApprovalCustomer.Cursor = Cursors.Hand;
            }
            else
            {
                dgApprovalCustomer.Cursor = Cursors.Arrow;
            }
        }


       
    }
}
