using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DiHaoOA.Controls;
using DiHaoOA.DataContract.Entity;
using DiHaoOA.DataContract;
using DiHaoOA.Business.Manager;

namespace DiHaoOA.WinForm.Controls
{
    public partial class OrderDetail : BaseUserControl
    {
        public Order order;
        OrderManager orderManager;
        public ReVisitPopUp popUp;
        RevisitPopUpManager revisitManager;

        public OrderDetail()
        {
            InitializeComponent();
            orderManager = new OrderManager();
            revisitManager = new RevisitPopUpManager();
        }


        public void ClearContent()
        {
            lblMsg.Visible = false;
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

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string orderStatus = string.Empty;
            if (rbSubmittedNotAllowed.Checked)
            {
                orderStatus = OrderStatus.SubmittedNotAllowed;
            }
            if (rbSubmittedNotSign.Checked)
            {
                orderStatus = OrderStatus.SubmittedNotSigned;
            }
            if (rbSubmittedSigned.Checked)
            {
                orderStatus = OrderStatus.SubmittedSigned;
            }
            orderManager.UpdateOrderStatus(order.OrderId, orderStatus);
            lblMsg.Text = "*订单状态修改成功，当前订单状态为"+orderStatus;
            lblMsg.Visible = true;
        }

        private void btnAddVisit_Click(object sender, EventArgs e)
        {
            if (popUp == null)
            {
                popUp = new ReVisitPopUp();
                popUp.parentForm = this.ParentForm;
                popUp.employee = employee;
                popUp.type = VisitType.type_Desinger;
                popUp.ReLoad += new DiHaoOA.WinForm.ReVisitPopUp.GetRevisit(LoadReVisit);
                this.ParentForm.Enabled = false;
                popUp.Show();
            }
            else
            {
                this.ParentForm.Enabled = false;
                popUp.Show();
            }
            popUp.customerOrderId = order.OrderId;
            
            popUp.ClearContent();
        }

        public void LoadReVisit()
        {
            DataSet ds = revisitManager.GetDesignerVisitAll(employee.EmployeeId,order.OrderId);
            dataGridReVisit.AutoGenerateColumns = false;
            dataGridReVisit.DataSource = ds.Tables[0];
        }

        private void OrderDetail_Load(object sender, EventArgs e)
        {
            LoadReVisit();
        }

        
    }
}
