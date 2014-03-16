namespace DiHaoOA.WinForm
{
    partial class DashboardForSalesManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForSalesManager));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panelContent = new System.Windows.Forms.Panel();
            this.pMainContent = new System.Windows.Forms.Panel();
            this.pApproval = new System.Windows.Forms.Panel();
            this.lblApproval = new System.Windows.Forms.Label();
            this.panelNav = new System.Windows.Forms.Panel();
            this.navBarForSalesManager = new DiHaoOA.Controls.NavBar();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.lblDateTime2 = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblReturn = new System.Windows.Forms.Label();
            this.userInfo = new DiHaoOA.WinForm.Controls.UserInfo();
            this.picLog = new System.Windows.Forms.PictureBox();
            this.panelContent.SuspendLayout();
            this.pMainContent.SuspendLayout();
            this.pApproval.SuspendLayout();
            this.panelNav.SuspendLayout();
            this.panelFooter.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLog)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.White;
            this.panelContent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelContent.Controls.Add(this.pMainContent);
            this.panelContent.Controls.Add(this.panelNav);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 75);
            this.panelContent.Margin = new System.Windows.Forms.Padding(2);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1008, 554);
            this.panelContent.TabIndex = 4;
            // 
            // pMainContent
            // 
            this.pMainContent.Controls.Add(this.pApproval);
            this.pMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pMainContent.Location = new System.Drawing.Point(129, 0);
            this.pMainContent.Margin = new System.Windows.Forms.Padding(2);
            this.pMainContent.Name = "pMainContent";
            this.pMainContent.Size = new System.Drawing.Size(875, 550);
            this.pMainContent.TabIndex = 4;
            // 
            // pApproval
            // 
            this.pApproval.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pApproval.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(68)))), ((int)(((byte)(0)))));
            this.pApproval.Controls.Add(this.lblApproval);
            this.pApproval.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pApproval.Location = new System.Drawing.Point(675, 530);
            this.pApproval.Name = "pApproval";
            this.pApproval.Size = new System.Drawing.Size(200, 24);
            this.pApproval.TabIndex = 0;
            this.pApproval.Visible = false;
            // 
            // lblApproval
            // 
            this.lblApproval.AutoSize = true;
            this.lblApproval.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblApproval.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(12)))), ((int)(((byte)(1)))));
            this.lblApproval.Location = new System.Drawing.Point(57, 5);
            this.lblApproval.Name = "lblApproval";
            this.lblApproval.Size = new System.Drawing.Size(105, 13);
            this.lblApproval.TabIndex = 0;
            this.lblApproval.Text = "你有1条审批信息";
            this.lblApproval.Click += new System.EventHandler(this.lblApproval_Click);
            // 
            // panelNav
            // 
            this.panelNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.panelNav.Controls.Add(this.navBarForSalesManager);
            this.panelNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNav.Location = new System.Drawing.Point(0, 0);
            this.panelNav.Margin = new System.Windows.Forms.Padding(2);
            this.panelNav.Name = "panelNav";
            this.panelNav.Size = new System.Drawing.Size(129, 550);
            this.panelNav.TabIndex = 3;
            // 
            // navBarForSalesManager
            // 
            this.navBarForSalesManager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(232)))), ((int)(((byte)(241)))));
            this.navBarForSalesManager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navBarForSalesManager.Location = new System.Drawing.Point(0, 0);
            this.navBarForSalesManager.Margin = new System.Windows.Forms.Padding(2);
            this.navBarForSalesManager.MenuItems = ((System.Collections.ArrayList)(resources.GetObject("navBarForSalesManager.MenuItems")));
            this.navBarForSalesManager.Name = "navBarForSalesManager";
            this.navBarForSalesManager.Size = new System.Drawing.Size(129, 550);
            this.navBarForSalesManager.TabIndex = 0;
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(144)))), ((int)(((byte)(206)))));
            this.panelFooter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelFooter.Controls.Add(this.lblDateTime2);
            this.panelFooter.Controls.Add(this.lblDateTime);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 629);
            this.panelFooter.Margin = new System.Windows.Forms.Padding(2);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(1008, 29);
            this.panelFooter.TabIndex = 2;
            // 
            // lblDateTime2
            // 
            this.lblDateTime2.AutoSize = true;
            this.lblDateTime2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDateTime2.ForeColor = System.Drawing.Color.White;
            this.lblDateTime2.Location = new System.Drawing.Point(0, 6);
            this.lblDateTime2.Name = "lblDateTime2";
            this.lblDateTime2.Size = new System.Drawing.Size(25, 13);
            this.lblDateTime2.TabIndex = 2;
            this.lblDateTime2.Text = "sss";
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDateTime.ForeColor = System.Drawing.Color.White;
            this.lblDateTime.Location = new System.Drawing.Point(0, 6);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(0, 13);
            this.lblDateTime.TabIndex = 1;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(232)))), ((int)(((byte)(241)))));
            this.panelHeader.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelHeader.Controls.Add(this.panel1);
            this.panelHeader.Controls.Add(this.userInfo);
            this.panelHeader.Controls.Add(this.picLog);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(2);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1008, 75);
            this.panelHeader.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(144)))), ((int)(((byte)(206)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnReturn);
            this.panel1.Controls.Add(this.lblReturn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1004, 29);
            this.panel1.TabIndex = 4;
            // 
            // btnReturn
            // 
            this.btnReturn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btnReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnReturn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(102)))), ((int)(((byte)(124)))));
            this.btnReturn.Location = new System.Drawing.Point(903, 2);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(95, 22);
            this.btnReturn.TabIndex = 5;
            this.btnReturn.Text = "返回登录界面";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblReturn
            // 
            this.lblReturn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblReturn.AutoSize = true;
            this.lblReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblReturn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblReturn.Location = new System.Drawing.Point(920, 5);
            this.lblReturn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReturn.Name = "lblReturn";
            this.lblReturn.Size = new System.Drawing.Size(77, 12);
            this.lblReturn.TabIndex = 1;
            this.lblReturn.Text = "返回登录界面";
            this.lblReturn.Click += new System.EventHandler(this.lblReturn_Click);
            // 
            // userInfo
            // 
            this.userInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.userInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userInfo.Location = new System.Drawing.Point(790, 30);
            this.userInfo.Margin = new System.Windows.Forms.Padding(2);
            this.userInfo.Name = "userInfo";
            this.userInfo.Size = new System.Drawing.Size(211, 39);
            this.userInfo.TabIndex = 1;
            this.userInfo.Load += new System.EventHandler(this.userInfo_Load);
            // 
            // picLog
            // 
            this.picLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picLog.Image = ((System.Drawing.Image)(resources.GetObject("picLog.Image")));
            this.picLog.Location = new System.Drawing.Point(129, 25);
            this.picLog.Margin = new System.Windows.Forms.Padding(2);
            this.picLog.Name = "picLog";
            this.picLog.Size = new System.Drawing.Size(190, 52);
            this.picLog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picLog.TabIndex = 0;
            this.picLog.TabStop = false;
            // 
            // DashboardForSalesManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 658);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panelHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DashboardForSalesManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OA办公系统";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DashboardForSalesManager_FormClosed);
            this.Load += new System.EventHandler(this.DashboardForSalesManager_Load);
            this.Resize += new System.EventHandler(this.DashboardForSalesManager_Resize);
            this.panelContent.ResumeLayout(false);
            this.pMainContent.ResumeLayout(false);
            this.pApproval.ResumeLayout(false);
            this.pApproval.PerformLayout();
            this.panelNav.ResumeLayout(false);
            this.panelFooter.ResumeLayout(false);
            this.panelFooter.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private Controls.UserInfo userInfo;
        private System.Windows.Forms.PictureBox picLog;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Panel panelNav;
        private System.Windows.Forms.Panel panelContent;
        private DiHaoOA.Controls.NavBar navBarForSalesManager;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pMainContent;
        private System.Windows.Forms.Label lblReturn;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblDateTime2;
        private System.Windows.Forms.Panel pApproval;
        private System.Windows.Forms.Label lblApproval;
    }
}