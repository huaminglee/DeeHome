using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DiHaoOA.DataContract.Entity;
using System.Drawing;
using log4net;
using DiHaoOA.Controls;

namespace DiHaoOA.WinForm.Forms
{
    public interface IAddFormStrategy
    {
        void AddForm(BaseForm form);


        void Test();
    }

    public class BaseForm : Form
    {
        public Employee employee { get; set; }
        public Login login;
        public DashboardEntry dashboardEntry;
        private bool _Moving = false;
        private Point _Offset;
        protected static readonly ILog logger = LogManager.GetLogger("DiHaoLogging");
        

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // BaseForm
            // 
            this.ClientSize = new System.Drawing.Size(1006, 723);
            this.Name = "BaseForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BaseForm_FormClosed);
            this.ResumeLayout(false);

        }

        protected void AdjustWindowHeightBasedOnResolution()
        {
            Rectangle screenRect = screenRect = Screen.GetWorkingArea(this);
            int screenHeight = screenRect.Height;

            if (this.Height > screenHeight)
            {
                this.Height = screenHeight - 20;
            }

            this.Location = new Point((screenRect.Width - this.Width) / 2, (screenRect.Height - this.Height) / 2);
        }

        protected string GetDateInfor()
        {
            DateTime nextYear = DateTime.Parse(DateTime.Now.ToString("yyyy-01-01")).AddYears(1).AddDays(-1).AddHours(24); 
            DateTime dt = DateTime.Now;
            DateTime start = new DateTime(dt.Year, dt.Month, 1);  //月初日期
            DateTime end = start.AddMonths(1).AddDays(-1);  //月底日期
            string result = "距离月底还有" + (end - dt).Days + "天零" + (end - dt).Hours + ":" + 
                (end - dt).Minutes +":" +(end-dt).Seconds+"小时                       " +
                            "距元旦还有" + (nextYear - dt).Days + "天零" + (nextYear - dt).Hours + ":" +
                (nextYear - dt).Minutes + ":" + (nextYear - dt).Seconds + "小时";
            return result;
        }

        private void BaseForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


    }
}
