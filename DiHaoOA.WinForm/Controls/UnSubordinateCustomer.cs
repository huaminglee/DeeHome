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
    public partial class UnSubordinateCustomer : BaseUserControl
    {
        UnSubordinateCustomerManager unsubordinateManager;
        public UnSubordinateCustomer()
        {
            InitializeComponent();
            unsubordinateManager = new UnSubordinateCustomerManager();
        }

       
        public void LoadGridData()
        {
            dgUnSubordinateCustomer.DataSource = unsubordinateManager.GetAll().Tables[0];
            dgUnSubordinateCustomer.AutoGenerateColumns = false;
        }


    }
}
