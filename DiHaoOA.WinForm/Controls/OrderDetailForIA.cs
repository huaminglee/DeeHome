using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DiHaoOA.DataContract.Entity;
using DiHaoOA.Business.Manager;
using DiHaoOA.Controls;

namespace DiHaoOA.WinForm.Controls
{
    public partial class OrderDetailForIA : BaseUserControl
    {
        public Order order;
        OrderManager orderManager;
        public ReVisitPopUp popUp;
        RevisitPopUpManager revisitManager;

        public OrderDetailForIA()
        {
            InitializeComponent();
            orderManager = new OrderManager();
            revisitManager = new RevisitPopUpManager();
        }

        public void LoadDetailInformation()
        {
            lblCompany.Text = order.Customers.CompanyName;
            lblEmail.Text = order.Customers.Email;
            lblRidePath.Text = order.Customers.RidePath;
            lblUsableArea.Text = order.Customers.UsableArea;
            lblDecorateAddress.Text = order.Customers.DecorationAddress;
            lblWorkPlace.Text = order.Customers.WorkPlace;
            lblCity.Text = order.Customers.City;
            lblOrderNumber.Text = order.OrderNumber.ToString();
            lblRecordDateTime.Text = order.RecordDate.ToLongDateString();
            lblImformationer.Text = order.Customers.InformationAssistants.InformationAssistantName;
            lblOrderStatus.Text = order.OrderStatus;
            lblEmployee.Text = order.Customers.Employees.Name;
            lblCustomerType.Text = order.Customers.CustomerType;
            lblProviderType.Text = order.Customers.ProviderType;
            lblDecorateDate.Text = order.Customers.AppointDateTime;
            labelDesinger.Text = order.Designer.Name;
            lblContactPerson.Text = order.Customers.ContactPerson;
            lblContactPerson2.Text = order.Customers.ContactPerson2;
            lblContactPerson3.Text = order.Customers.ContactPerson3;
            lblContactPerson2Number.Text = order.Customers.ContactPerson2Number;
            lblContactPerson3Number.Text = order.Customers.Contactperson3Number;
            lblContactPersonNumber.Text = order.Customers.ContactPersonNumber;
        }

        private void dataGridReVisit_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                e.Value = e.RowIndex + 1;//set serial number of the table rows.
            }
        }

        public void LoadReVisit()
        {
            DataSet ds = revisitManager.GetDesignerVisitAll(order.Designer.EmployeeId, order.OrderId);
            dataGridReVisit.AutoGenerateColumns = false;
            dataGridReVisit.DataSource = ds.Tables[0];
        }

        private void OrderDetailForIA_Load(object sender, EventArgs e)
        {
            LoadReVisit();
        }
    }
}
