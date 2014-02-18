using System;
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
    public partial class DisplayVisitContent : BaseUserControl
    {
        public string employeeId;
        DisplayVisitContentManager displayVisitContentManager;
        public MySubordinate mySubordinate;
       

        public DisplayVisitContent()
        {
            InitializeComponent();
            displayVisitContentManager = new DisplayVisitContentManager();
        }

        private void DisplayVisitContent_Load(object sender, EventArgs e)
        {
            dgVisitContent.AutoGenerateColumns = false;
            pgDiaplayVisitContent.OnDataLoad += new PagingControl.LoadData(GetDataSource);
        }

        private void GetDataSource(int pageIndex, int pageSize)
        {
            DataSet ds = displayVisitContentManager.GetVisitContent(employeeId,pageIndex,pageSize);
            int totalRecords = displayVisitContentManager.GetTotalRecords(employeeId, pageIndex, pageSize);
            pgDiaplayVisitContent.TotalRecords = totalRecords;
            pgDiaplayVisitContent.pageIndex = pageIndex;
            pgDiaplayVisitContent.SetDefaultData();
            dgVisitContent.DataSource = ds.Tables[0];
        }

        public void LoadData()
        {
            GetDataSource(pgDiaplayVisitContent.pageIndex, pgDiaplayVisitContent.pageSize);
        }

        private void dgVisitContent_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                e.Value = e.RowIndex + 1;//set serial number of the table rows.
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            mySubordinate.Show();
        }
    }
}
