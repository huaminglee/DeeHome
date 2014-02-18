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
using System.Text.RegularExpressions;
using DiHaoOA.DataContract.Entity;

namespace DiHaoOA.WinForm.Controls
{
    public partial class CustomerTrace : BaseUserControl
    {
        CustomerTraceManager customerTraceManager;
        ModifyCustomer modifyCustomer;
        public InformationAssistant _informationAssistant;

        public int pageIndex;
        const int pageSize = 30;
        int TotalRecords;
        int totalPage;
        string _eventCode;
        DataSet datas;


        public CustomerTrace()
        {
            InitializeComponent();
            customerTraceManager = new CustomerTraceManager();
        }

        public void LoadDataGrid(int index, string eventCode, string searchInput)
        {
            _eventCode = eventCode;
            orderGrid.AutoGenerateColumns = false;
            pageIndex = index;
            TotalRecords = customerTraceManager.GetTotalRecords(eventCode, searchInput, employee.EmployeeId);
            if (TotalRecords % pageSize == 0)
            {
                totalPage = TotalRecords / pageSize;
            }
            else
            {
                totalPage = TotalRecords / pageSize + 1;
            }
            if (totalPage == 0)
            {
                lblCurrentRecords.Text = "当前是" + 0 + "/" + 0 + "页";
            }
            else
            {
                lblCurrentRecords.Text = "当前是" + pageIndex + "/" + totalPage + "页";
            }
            lblTotalRecords.Text = "共" + TotalRecords + "条记录";
            DataSet ds = customerTraceManager.GetAllOrders(pageIndex, pageSize, eventCode, searchInput, employee.EmployeeId);
            datas = ds;
            orderGrid.DataSource = ds.Tables[0];
            if (orderGrid.Rows.Count == 0)
            {
                //MessageBox.Show("木有找到符合条件的结果=.=");
            }
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

        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            LoadDataGrid(1, _eventCode, txtSearch.Text.Replace(" ", ""));
        }

        private void btnPrevPage_Click(object sender, EventArgs e)
        {
            LoadDataGrid(--pageIndex, _eventCode, txtSearch.Text.Replace(" ", ""));
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            LoadDataGrid(++pageIndex, _eventCode, txtSearch.Text.Replace(" ", ""));
        }

        private void btnEndPage_Click(object sender, EventArgs e)
        {
            LoadDataGrid(totalPage, _eventCode, txtSearch.Text.Replace(" ", ""));
        }

        private void btnGoforword_Click(object sender, EventArgs e)
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
                    LoadDataGrid(goForwardPage, _eventCode, txtSearch.Text.Replace(" ", ""));
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadDataGrid(pageIndex, _eventCode, txtSearch.Text.Replace(" ", ""));
        }

        public void ClearSearchContent()
        {
            txtSearch.Clear();
        }

        private void orderGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex >= 0)
            //{
            //    if (e.ColumnIndex == 2)
            //    {
            //        int orderId = Convert.ToInt32(orderGrid.Rows[e.RowIndex].Cells[0].Value);
            //        if (ParentPanel != null)
            //        {
            //            foreach (Control control in ParentPanel.Controls)
            //            {
            //                if (control is CustomerTrace)
            //                {
            //                    control.Visible = false;
            //                }
            //            }
            //            LoadModifyCustomer(orderId);
            //        }
            //    }
            //}

        }

        private void LoadModifyCustomer(int orderId)
        {
             _informationAssistant = customerTraceManager.GetInformationAssistantByOrderId(orderId);
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
            modifyCustomer.Show();
            modifyCustomer.ClareContent();
            modifyCustomer._informationAssistant = _informationAssistant;
            modifyCustomer._customerOrderId = orderId;
            modifyCustomer.employee = employee;
            modifyCustomer.LoadDetailInformation(orderId);
            modifyCustomer.LoadReVisit();
        }

        private void orderGrid_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                e.Value = (pageIndex - 1) * pageSize + e.RowIndex + 1;//set serial number of the table rows.
            }
            if (e.ColumnIndex == 2)
            {
                if (datas.Tables[0].Rows.Count > 0)
                {
                    //e.Value = datas.Tables[0].Rows[e.RowIndex][e.ColumnIndex + 1] + " " +
                    //datas.Tables[0].Rows[e.RowIndex][e.ColumnIndex + 2];
                }
            }
            if (e.ColumnIndex == 4)
            {
                if (datas.Tables[0].Rows.Count > 0)
                {
                    e.Value = Convert.ToDateTime(datas.Tables[0].Rows[e.RowIndex][e.ColumnIndex + 2]).ToLongDateString();
                }
            }
        }

        private void orderGrid_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

            if (e.RowIndex < 0)
                return;
            DataGridViewRow dgr = orderGrid.Rows[e.RowIndex];
            //dgr.Cells["TaskNumber"].Value.ToString().Split(' ')[1]
            if (e.ColumnIndex == 2)
            {
                string status = datas.Tables[0].Rows[e.RowIndex][e.ColumnIndex + 2].ToString();
                string orderNumber = datas.Tables[0].Rows[e.RowIndex][e.ColumnIndex + 1].ToString();
                Rectangle newRect = new Rectangle(e.CellBounds.X + 5, e.CellBounds.Y +3, e.CellBounds.Width-15,
                    e.CellBounds.Height-10);
                using (Brush gridBrush = new SolidBrush(orderGrid.GridColor), backColorBrush = new SolidBrush(e.CellStyle.BackColor))
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
                           e.CellBounds.Left + 50, e.CellBounds.Top + 5, StringFormat.GenericDefault);
                        e.Handled = true;
                    }
                }
            }
        }

        private void orderGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 2)
                {
                    int orderId = Convert.ToInt32(orderGrid.Rows[e.RowIndex].Cells[0].Value);
                    if (ParentPanel != null)
                    {
                        foreach (Control control in ParentPanel.Controls)
                        {
                            if (control is CustomerTrace)
                            {
                                control.Visible = false;
                            }
                        }
                        LoadModifyCustomer(orderId);
                    }
                }
            }
        }

        private void orderGrid_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                orderGrid.Cursor = Cursors.Hand;
            }
            else {
                orderGrid.Cursor = Cursors.Arrow;
            }
        }
    }
}
