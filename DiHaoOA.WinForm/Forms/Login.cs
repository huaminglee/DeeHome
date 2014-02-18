using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Xml.Linq;
using DiHaoOA.Controls;
using DiHaoOA.Business;
using DiHaoOA.Security;
using log4net;
using DiHaoOA.DataContract.Entity;
using DiHaoOA.WinForm.Forms;
using System.Drawing.Drawing2D;

namespace DiHaoOA
{
    public partial class Login : BaseForm
    {
        readonly Size designSize = new Size(1024, 768);
        EmployeeManager empManager;
        RolesManager roleManager;
        DashboardEntry dashboard;
        
        private bool _Moving = false;
        private Point _Offset;

        public Login()
        {
            InitializeComponent();
            this.AcceptButton = btnLogin;
            empManager = new EmployeeManager();
            roleManager = new RolesManager();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AdjustWindowHeightBasedOnResolution();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            employee = empManager.GetEmployeeById(txtUserName.Text);
            if (!empManager.ValidateEmployee(txtUserName.Text, txtPassword.Text) ||
                txtPassword.Text == "" || txtUserName.Text == "")
            {
                lblMsg.Visible = true;
            }
            else
            {
                this.Hide();
                if (dashboard == null)
                {
                    dashboard = new DashboardEntry();
                }
                dashboard.login = this;
                dashboard.SetUserInfor(employee.Name);
                dashboard.employee = employee;
                dashboard.Show();
            }

        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pExit_MouseHover(object sender, EventArgs e)
        {
            pExit.BackColor = Color.FromArgb(199, 59, 59);
        }

        private void pExit_MouseLeave(object sender, EventArgs e)
        {
            pExit.BackColor = Color.FromArgb(55, 144, 206);
        }

        private void lblExit_MouseHover(object sender, EventArgs e)
        {
            pExit.BackColor = Color.FromArgb(199, 59, 59);
        }

        private void lblExit_MouseLeave(object sender, EventArgs e)
        {
            pExit.BackColor = Color.FromArgb(55, 144, 206);
        }

        private void Login_Resize(object sender, EventArgs e)
        {
            this.Height = 408;
            this.Width = 614;
            this.picLogo.Width = 93;
            this.picLogo.Height = 63;
            picPeople.Width = 100;
            picPeople.Height = 106;
            this.pHeader.Height = 70;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.picPeople.Location = new Point(this.panel2.Width - picPeople.Width - 1, this.panel2.Height - picPeople.Height - 1);
            this.picLogo.Location = new Point(this.pHeader.Location.X - 1, this.pHeader.Location.Y );
            this.pHeader.Height = 70;
            GetDateInfor();
        }


        private void pHeader_MouseDown(object sender, MouseEventArgs e)
        {
            _Moving = true;
            _Offset = new Point(e.X, e.Y);
        }

        private void pHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (_Moving)
            {
                Point newlocation = this.Location;
                newlocation.X += e.X - _Offset.X;
                newlocation.Y += e.Y - _Offset.Y;
                this.Location = newlocation;
            }
        }

        private void pHeader_MouseUp(object sender, MouseEventArgs e)
        {
            if (_Moving)
            {
                _Moving = false;
            }
        }

        public void ClearContent()
        {
            txtPassword.Clear();
            lblMsg.Visible = false;
        }
    }
}
