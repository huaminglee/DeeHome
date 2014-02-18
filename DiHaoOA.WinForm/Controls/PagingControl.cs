using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace DiHaoOA.WinForm.Controls
{
    public partial class PagingControl : UserControl
    {
        public delegate void LoadData(int _index, int _pageSize);

        public event LoadData OnDataLoad;

        public int pageIndex = 1;
        public int pageSize = 30;
        public int TotalRecords;
        public int totalPage;

        public PagingControl()
        {
            InitializeComponent();
        }

        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            this.OnDataLoad(1, pageSize);
        }

        private void btnPrevPage_Click(object sender, EventArgs e)
        {
            this.OnDataLoad(--pageIndex, pageSize);
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            this.OnDataLoad(++pageIndex, pageSize);
        }

        private void btnLastPage_Click(object sender, EventArgs e)
        {
            this.OnDataLoad(totalPage, pageSize);
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
                    this.OnDataLoad(goForwardPage, pageSize);
                }
            }
        }

        public void SetDefaultData()
        {
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
                //MessageBox.Show("木有找到符合条件的结果-,-");
            }
            else
            {
                lblCurrentRecord.Text = "当前是" + pageIndex + "/" + totalPage + "页";
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

    }
}
