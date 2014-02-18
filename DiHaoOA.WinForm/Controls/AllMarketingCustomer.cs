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
using DiHaoOA.WinForm.Forms;

namespace DiHaoOA.WinForm.Controls
{
    public partial class AllMarketingCustomer : BaseUserControl
    {
        AllMarketingCustomerManager allMarketingCustomerManager;
        ModifyAllMarketingCustomer modifyAllMarketingCustomer;
        CustomerManager customerManager;
        DataSet datas;
        public string procedureName = string.Empty;

        public AllMarketingCustomer()
        {
            InitializeComponent();
            allMarketingCustomerManager = new AllMarketingCustomerManager();
            customerManager = new CustomerManager();
        }

        private void AllMarketingCustomer_Load(object sender, EventArgs e)
        {
            dgAllMarketingCustomer.AutoGenerateColumns = false;
            pagingForCustomer.OnDataLoad += new DiHaoOA.WinForm.Controls.PagingControl.LoadData(GetDataSource);
            //GetDataSource(1, 20);
        }

        private void GetDataSource(int _index, int _pageSize)
        {
            DataSet ds = customerManager.GetCustomerList(_index, _pageSize, txtSearch.Text.Replace(" ", ""), procedureName);
            datas = ds;
            int totalRecords = customerManager.GetTotalRecords(_index, _pageSize, txtSearch.Text.Replace(" ", ""), procedureName);
            pagingForCustomer.TotalRecords = totalRecords;
            pagingForCustomer.pageIndex = _index;
            pagingForCustomer.SetDefaultData();
            dgAllMarketingCustomer.DataSource = ds.Tables[0];
        }

        private void dgAllMarketingCustomer_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            if (e.ColumnIndex == 2)
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
            GetDataSource(pagingForCustomer.pageIndex,pagingForCustomer.pageSize);
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (IsCustomerSelected())
            {
                if (modifyAllMarketingCustomer == null)
                {
                    modifyAllMarketingCustomer = new ModifyAllMarketingCustomer();
                    modifyAllMarketingCustomer.parentForm = this.ParentForm;
                }
                this.ParentForm.Enabled = false;
                modifyAllMarketingCustomer.CustomerId = GetSelectedIA();
                modifyAllMarketingCustomer.ReLoad += new DiHaoOA.WinForm.Forms.ModifyAllMarketingCustomer.AllMarketingCustomerReload(ReloadData);
                modifyAllMarketingCustomer.Show();
            }
            else
            {
                MessageBox.Show("请选择客户-.-");
            }
           
        }

        private List<int> GetSelectedIA()
        {
            List<int> ids = new List<int>();
            for (int i = 0, len = dgAllMarketingCustomer.Rows.Count; i < len; i++)
            {
                if (dgAllMarketingCustomer.Rows[i].Cells[1].EditedFormattedValue.ToString().ToLower() == "true")
                {
                    ids.Add(Convert.ToInt32(dgAllMarketingCustomer.Rows[i].Cells[0].EditedFormattedValue));
                }
            }
            return ids;
        }

        private bool IsCustomerSelected()
        {
            if (GetSelectedIA().Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void HideDeleteButton()
        {
            btnDelete.Visible = false;
        }

        public void ShowDeleteButton()
        {
            btnDelete.Visible = true;
        }

        public void ReloadData()
        {
            GetDataSource(pagingForCustomer.pageIndex, pagingForCustomer.pageSize);
            ckSelectAll.Checked = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (IsCustomerSelected())
            {
                MessageBoxButtons messButton = MessageBoxButtons.OKCancel;
                DialogResult dr = MessageBox.Show("确定要删除么?", "确定", messButton);
                if (dr == DialogResult.OK)
                {
                    List<int> deletingIA = GetSelectedIA();
                    foreach (int id in deletingIA)
                    {
                        customerManager.Delete(id);//delete selected information assistant
                    }
                    GetDataSource(pagingForCustomer.pageIndex, pagingForCustomer.pageSize);//reload datagridview
                }
            }
            else
            {
                MessageBox.Show("请选择客户-.-");
            }
           
        }

        private void dgAllMarketingCustomer_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            DataGridViewRow dgr = dgAllMarketingCustomer.Rows[e.RowIndex];
            //dgr.Cells["TaskNumber"].Value.ToString().Split(' ')[1]
            if (e.ColumnIndex == 3)
            {
                string orderNumber = datas.Tables[0].Rows[e.RowIndex][e.ColumnIndex + 1].ToString();
                string status = datas.Tables[0].Rows[e.RowIndex][e.ColumnIndex + 2].ToString();
                Rectangle newRect = new Rectangle(e.CellBounds.X + 5, e.CellBounds.Y + 3, e.CellBounds.Width - 15,
                    e.CellBounds.Height - 10);
                using (Brush gridBrush = new SolidBrush(dgAllMarketingCustomer.GridColor), backColorBrush = new SolidBrush(e.CellStyle.BackColor))
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

        private void ckSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0, len = dgAllMarketingCustomer.Rows.Count; i < len; i++)
            {
                dgAllMarketingCustomer.Rows[i].Cells[1].Value = ckSelectAll.Checked;
            }
        }
    }
}
