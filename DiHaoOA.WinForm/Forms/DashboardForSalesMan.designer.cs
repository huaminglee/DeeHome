namespace DiHaoOA
{
    partial class DashboardForSalesMan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForSalesMan));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panelcontent = new System.Windows.Forms.Panel();
            this.pMainContent = new System.Windows.Forms.Panel();
            this.pNavBar = new System.Windows.Forms.Panel();
            this.navBarForSalesMan = new DiHaoOA.Controls.NavBar();
            this.panelfooter = new System.Windows.Forms.Panel();
            this.lblDateTime2 = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelHeaderHeader = new System.Windows.Forms.Panel();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblReturn = new System.Windows.Forms.Label();
            this.userInfo = new DiHaoOA.WinForm.Controls.UserInfo();
            this.panelcontent.SuspendLayout();
            this.pNavBar.SuspendLayout();
            this.panelfooter.SuspendLayout();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelHeaderHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // panelcontent
            // 
            this.panelcontent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelcontent.Controls.Add(this.pMainContent);
            this.panelcontent.Controls.Add(this.pNavBar);
            this.panelcontent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelcontent.Location = new System.Drawing.Point(0, 80);
            this.panelcontent.Name = "panelcontent";
            this.panelcontent.Size = new System.Drawing.Size(924, 602);
            this.panelcontent.TabIndex = 2;
            // 
            // pMainContent
            // 
            this.pMainContent.BackColor = System.Drawing.Color.White;
            this.pMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pMainContent.Location = new System.Drawing.Point(129, 0);
            this.pMainContent.Name = "pMainContent";
            this.pMainContent.Size = new System.Drawing.Size(791, 598);
            this.pMainContent.TabIndex = 2;
            // 
            // pNavBar
            // 
            this.pNavBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.pNavBar.Controls.Add(this.navBarForSalesMan);
            this.pNavBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pNavBar.Location = new System.Drawing.Point(0, 0);
            this.pNavBar.Name = "pNavBar";
            this.pNavBar.Size = new System.Drawing.Size(129, 598);
            this.pNavBar.TabIndex = 1;
            // 
            // navBarForSalesMan
            // 
            this.navBarForSalesMan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(232)))), ((int)(((byte)(241)))));
            this.navBarForSalesMan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navBarForSalesMan.Location = new System.Drawing.Point(0, 0);
            this.navBarForSalesMan.Margin = new System.Windows.Forms.Padding(2);
            this.navBarForSalesMan.MenuItems = ((System.Collections.ArrayList)(resources.GetObject("navBarForSalesMan.MenuItems")));
            this.navBarForSalesMan.Name = "navBarForSalesMan";
            this.navBarForSalesMan.Size = new System.Drawing.Size(129, 598);
            this.navBarForSalesMan.TabIndex = 1;
            // 
            // panelfooter
            // 
            this.panelfooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(144)))), ((int)(((byte)(206)))));
            this.panelfooter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelfooter.Controls.Add(this.lblDateTime2);
            this.panelfooter.Controls.Add(this.lblDateTime);
            this.panelfooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelfooter.Location = new System.Drawing.Point(0, 682);
            this.panelfooter.Name = "panelfooter";
            this.panelfooter.Size = new System.Drawing.Size(924, 31);
            this.panelfooter.TabIndex = 1;
            // 
            // lblDateTime2
            // 
            this.lblDateTime2.AutoSize = true;
            this.lblDateTime2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDateTime2.ForeColor = System.Drawing.Color.White;
            this.lblDateTime2.Location = new System.Drawing.Point(0, 7);
            this.lblDateTime2.Name = "lblDateTime2";
            this.lblDateTime2.Size = new System.Drawing.Size(25, 13);
            this.lblDateTime2.TabIndex = 1;
            this.lblDateTime2.Text = "sss";
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDateTime.ForeColor = System.Drawing.Color.White;
            this.lblDateTime.Location = new System.Drawing.Point(0, 7);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(25, 13);
            this.lblDateTime.TabIndex = 0;
            this.lblDateTime.Text = "sss";
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(232)))), ((int)(((byte)(241)))));
            this.panelHeader.Controls.Add(this.pictureBox1);
            this.panelHeader.Controls.Add(this.panelHeaderHeader);
            this.panelHeader.Controls.Add(this.userInfo);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(924, 80);
            this.panelHeader.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(131, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // panelHeaderHeader
            // 
            this.panelHeaderHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(144)))), ((int)(((byte)(206)))));
            this.panelHeaderHeader.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelHeaderHeader.Controls.Add(this.btnReturn);
            this.panelHeaderHeader.Controls.Add(this.lblReturn);
            this.panelHeaderHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeaderHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeaderHeader.Name = "panelHeaderHeader";
            this.panelHeaderHeader.Size = new System.Drawing.Size(924, 27);
            this.panelHeaderHeader.TabIndex = 3;
            // 
            // btnReturn
            // 
            this.btnReturn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btnReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnReturn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(102)))), ((int)(((byte)(124)))));
            this.btnReturn.Location = new System.Drawing.Point(823, 0);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(95, 24);
            this.btnReturn.TabIndex = 4;
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
            this.lblReturn.Location = new System.Drawing.Point(841, 7);
            this.lblReturn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReturn.Name = "lblReturn";
            this.lblReturn.Size = new System.Drawing.Size(79, 13);
            this.lblReturn.TabIndex = 0;
            this.lblReturn.Text = "返回登录界面";
            this.lblReturn.Visible = false;
            this.lblReturn.Click += new System.EventHandler(this.lblReturn_Click);
            // 
            // userInfo
            // 
            this.userInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userInfo.Location = new System.Drawing.Point(709, 29);
            this.userInfo.Margin = new System.Windows.Forms.Padding(2);
            this.userInfo.Name = "userInfo";
            this.userInfo.Size = new System.Drawing.Size(213, 48);
            this.userInfo.TabIndex = 2;
            // 
            // DashboardForSalesMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 713);
            this.Controls.Add(this.panelcontent);
            this.Controls.Add(this.panelfooter);
            this.Controls.Add(this.panelHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DashboardForSalesMan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OA企业办公系统";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DashboardForSalesMan_FormClosed);
            this.Load += new System.EventHandler(this.DashboardForSalesMan_Load);
            this.Resize += new System.EventHandler(this.DashboardForSalesMan_Resize);
            this.panelcontent.ResumeLayout(false);
            this.pNavBar.ResumeLayout(false);
            this.panelfooter.ResumeLayout(false);
            this.panelfooter.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelHeaderHeader.ResumeLayout(false);
            this.panelHeaderHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelfooter;
        private System.Windows.Forms.Panel panelcontent;
        private System.Windows.Forms.Panel pMainContent;
        private System.Windows.Forms.Panel pNavBar;
        private Controls.NavBar navBarForSalesMan;
        private WinForm.Controls.UserInfo userInfo;
        private System.Windows.Forms.Panel panelHeaderHeader;
        private System.Windows.Forms.Label lblReturn;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblDateTime2;

    }
}