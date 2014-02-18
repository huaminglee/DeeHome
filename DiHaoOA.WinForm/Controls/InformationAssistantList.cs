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
    public partial class InformationAssistantList : BaseUserControl
    {
        InformationAssistantManager iAManager;
        ModifyIA modifyIA;
        public string procedureName = string.Empty;

        public InformationAssistantList()
        {
            InitializeComponent();
            iAManager = new InformationAssistantManager();
        }

        private void DeletedInformationAssistant_Load(object sender, EventArgs e)
        {
            dgIAList.AutoGenerateColumns = false;
            pagingForIA.OnDataLoad += new PagingControl.LoadData(GetDataSource);
        }

        private void GetDataSource(int pageIndex, int pageSize)
        {
            DataSet ds = iAManager.GetInformationAssistant(pageIndex, pageSize, txtSearch.Text.Replace(" ", ""), procedureName);
            int totalRecords = iAManager.GetTotalRecords(pageIndex, pageSize, txtSearch.Text.Replace(" ", ""), procedureName);
            pagingForIA.TotalRecords = totalRecords;
            pagingForIA.pageIndex = pageIndex;
            pagingForIA.SetDefaultData();
            dgIAList.DataSource = ds.Tables[0];
        }

        private void dgDeletedIAList_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                e.Value = (pagingForIA.pageIndex - 1) * pagingForIA.pageSize + e.RowIndex + 1;//set serial number of the table rows.
            }
        }

        public void ClearSearchText()
        {
            txtSearch.Clear();
            pagingForIA.pageIndex = 1;
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (IsInormationAssistantSelected())
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
            else
            {
                MessageBox.Show("请选择信息员-.-");
            }

        }

        private List<int> GetSelectedIA()
        {
            List<int> ids = new List<int>();
            for (int i = 0, len = dgIAList.Rows.Count; i < len; i++)
            {
                if (dgIAList.Rows[i].Cells[1].EditedFormattedValue.ToString().ToLower() == "true")
                {
                    ids.Add(Convert.ToInt32(dgIAList.Rows[i].Cells[0].EditedFormattedValue));
                }
            }
            return ids;
        }

        public void ReloadData()
        {
            GetDataSource(pagingForIA.pageIndex, pagingForIA.pageSize);
            ckSelectAll.Checked = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (IsInormationAssistantSelected())
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
                    GetDataSource(pagingForIA.pageIndex, pagingForIA.pageSize);//reload datagridview
                }
            }
            else
            {
                MessageBox.Show("请选择信息员-.-");
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

        private bool IsInormationAssistantSelected()
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            GetDataSource(pagingForIA.pageIndex, pagingForIA.pageSize);
        }

        private void ckSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0, len = dgIAList.Rows.Count; i < len; i++)
            {
                dgIAList.Rows[i].Cells[1].Value = ckSelectAll.Checked;
            }

        }
    }
}
