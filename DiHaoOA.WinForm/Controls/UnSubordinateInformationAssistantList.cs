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

namespace DiHaoOA.WinForm.Controls
{
    public partial class UnSubordinateInformationAssistantList : BaseUserControl
    {
        UnSubordinateMessengerListManager unSubOrdinateMessengerManager;

        EditUnSubordinateIA editUnsubOrdinateIA;
        public int pageIndex;
        const int pageSize = 10;
        int TotalRecords;
        int totalPage;
        string _eventCode;

        public UnSubordinateInformationAssistantList()
        {
            InitializeComponent();
            unSubOrdinateMessengerManager = new UnSubordinateMessengerListManager();
        }


        public void LoadData(int pageIndex)
        {
            this.pageIndex = pageIndex;
            dgUnSubordinate.DataSource = unSubOrdinateMessengerManager.GetAll(pageIndex, pageSize).Tables[0];
            dgUnSubordinate.AutoGenerateColumns = false;
        }

        private void dgUnSubordinate_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                e.Value = (pageIndex - 1) * pageSize + e.RowIndex + 1;//set serial number of the table rows.
            }
        }

        private void dgUnSubordinate_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 2)
                {
                    int informationAssistantId = Convert.ToInt32(dgUnSubordinate.Rows[e.RowIndex].Cells[1].Value);
                    InformationAssistant informationAssistant = unSubOrdinateMessengerManager.GetInformationAssistantById(informationAssistantId);
                    if (ParentPanel != null)
                    {
                        foreach (Control control in ParentPanel.Controls)
                        {
                            if (control is UnSubordinateInformationAssistantList)
                            {
                                control.Visible = false;
                            }
                        }
                        LoadEditUnSubordinateIA(informationAssistant);
                    }
                }
               
            }
        }

        private void LoadEditUnSubordinateIA(InformationAssistant informationAssistant)
        {
            if (!ParentPanel.Controls.Contains(editUnsubOrdinateIA))
            {
                editUnsubOrdinateIA = new EditUnSubordinateIA();
                editUnsubOrdinateIA.ParentPanel = this.ParentPanel;
                editUnsubOrdinateIA.NavigationBar = this.NavigationBar;
                editUnsubOrdinateIA.employee = this.employee;
                editUnsubOrdinateIA._informationAssistant = informationAssistant;
                ParentPanel.Controls.Add(editUnsubOrdinateIA);
            }
            else {
                editUnsubOrdinateIA.Show();
                editUnsubOrdinateIA.ClearContent();
            }
        }
    }
}
