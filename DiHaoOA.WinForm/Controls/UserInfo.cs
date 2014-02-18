using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DiHaoOA.WinForm.Controls
{
    public partial class UserInfo : UserControl
    {
        public UserInfo()
        {
            InitializeComponent();
        }

       
        public void SetUserInfor(string userName)
        {
            lblUserName.Text = userName;
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void SetForeColor() 
        {
            //lblUserName.Font  = new Fon
            lblUserName.ForeColor = Color.FromArgb(255, 255, 255);
            label1.ForeColor = Color.FromArgb(255, 255, 255);
            lblExit.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void btnSeniorSearch_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
