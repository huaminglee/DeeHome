using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DiHaoOA.Business.Manager;
using System.Text.RegularExpressions;
using DiHaoOA.Controls;
using DiHaoOA.WinForm.Forms;

namespace DiHaoOA.WinForm.Controls
{
    public partial class AllListForMarketing : BaseUserControl
    {
        public int pageIndex;
        const int pageSize = 20;
        int TotalRecords;
        int totalPage;
        DataSet dataSet;
        AllListForMarketingManager allListForMarketManager;
        InformationAssistantManager iAManager;
        ModifyIA modifyIA;

        public AllListForMarketing()
        {
            InitializeComponent();
            allListForMarketManager = new AllListForMarketingManager();
            iAManager = new InformationAssistantManager();
        }

        public void LoadData(int index)
        {
            dgAllListForManager.AutoGenerateColumns = false;
            pageIndex = index;
            TotalRecords = allListForMarketManager.GetTotalRows(txtSearch.Text.Replace(" ", ""));
            if (TotalRecords % pageSize == 0)
            {
                totalPage = TotalRecords / pageSize;
            }
            else
            {
                totalPage = TotalRecords / pageSize + 1;
            }
            lblRecord.Text = "共" + TotalRecords + "条记录";
            lblCurrentRecord.Text = "当前是" + pageIndex + "/" + totalPage + "页";
            DataSet ds = allListForMarketManager.GetAllList(pageIndex, pageSize, txtSearch.Text.Replace(" ", ""));
            dataSet = ds;
            dgAllListForManager.DataSource = ds.Tables[0];
            if (dgAllListForManager.Rows.Count == 0)
            {
                MessageBox.Show("木有找到符合条件的结果-,-");
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

        private void AllListForManager_Load(object sender, EventArgs e)
        {
            
        }

        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            LoadData(1);
        }

        private void btnPrevPage_Click(object sender, EventArgs e)
        {
            LoadData(--pageIndex);
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            LoadData(++pageIndex);
        }

        private void btnLastPage_Click(object sender, EventArgs e)
        {
            LoadData(totalPage);
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
                    LoadData(goForwardPage);
                }
            }
        }

        private void dgAllListForManager_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                e.Value = (pageIndex - 1) * pageSize + e.RowIndex + 1;//set serial number of the table rows.
            }
            if (e.ColumnIndex == 1)
            {
                
            }
            
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (modifyIA == null)
            {
                modifyIA = new ModifyIA();
                modifyIA.parentForm = this.ParentForm;
            }
            this.ParentForm.Enabled = false;
            modifyIA.informationAssistantId = GetSelectedIA();
            modifyIA.ReLoad += new DiHaoOA.WinForm.Forms.ModifyIA.AllListForMarketingReload(ReloadData);
            modifyIA.Show();
            
        }

        private List<int> GetSelectedIA()
        {
            List<int> ids = new List<int>();
            for (int i = 0, len = dgAllListForManager.Rows.Count; i < len; i++)
            {
                if (dgAllListForManager.Rows[i].Cells[1].EditedFormattedValue.ToString().ToLower() == "true")
                {
                    ids.Add(Convert.ToInt32(dgAllListForManager.Rows[i].Cells[0].EditedFormattedValue));
                }
            }
            return ids;
        }

        private void ReloadData()
        {
            LoadData(pageIndex);
        }

        private void dgAllListForManager_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (this.dgAllListForManager.IsCurrentCellDirty)
            {
                this.dgAllListForManager.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadData(pageIndex);
        }

        public void ClearSearchText()
        {
            txtSearch.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MessageBoxButtons messButton = MessageBoxButtons.OKCancel;
            DialogResult dr = MessageBox.Show("确定要删除么?", "确定", messButton);
            if (dr == DialogResult.OK)
            {
                List<int> deletingIA = GetSelectedIA();
                foreach (int id in deletingIA)
                {
                    iAManager.Delete(id);//delete selected information assistant
                }
                LoadData(pageIndex);//reload datagridview
            }
            


        }

       

        

       
    }
}
