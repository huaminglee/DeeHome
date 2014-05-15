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

namespace DiHaoOA.WinForm.Controls
{
    public partial class VisitContentForDesigner : BaseUserControl
    {
        public int orderID;
        DisplayVisitContentManager displayVisitContentManager;

        public VisitContentForDesigner()
        {
            InitializeComponent();
            displayVisitContentManager = new DisplayVisitContentManager();
        }

        private void VisitContentForDesigner_Load(object sender, EventArgs e)
        {
            dgVisitContent.AutoGenerateColumns = false;
            pgDiaplayVisitContent.OnDataLoad += new PagingControl.LoadData(GetDataSource);
        }

        public void LoadData()
        {
            GetDataSource(pgDiaplayVisitContent.pageIndex, pgDiaplayVisitContent.pageSize);
        }

        private void GetDataSource(int pageIndex, int pageSize)
        {
            DataSet ds = displayVisitContentManager.GetDesignerVisitContent(orderID, pageIndex, pageSize);
            int totalRecords = displayVisitContentManager.GetTotalRecordsForDesignerVisit(orderID);
            pgDiaplayVisitContent.TotalRecords = totalRecords;
            pgDiaplayVisitContent.pageIndex = pageIndex;
            pgDiaplayVisitContent.SetDefaultData();
            dgVisitContent.DataSource = ds.Tables[0];
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

        }
    }
}
