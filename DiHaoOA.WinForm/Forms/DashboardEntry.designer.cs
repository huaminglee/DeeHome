namespace DiHaoOA
{
    partial class DashboardEntry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardEntry));
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.MainContent = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblMsg = new System.Windows.Forms.Label();
            this.picPeople = new System.Windows.Forms.PictureBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.picEditPwd = new System.Windows.Forms.PictureBox();
            this.picHome = new System.Windows.Forms.PictureBox();
            this.panelFoot = new System.Windows.Forms.Panel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.pUserInfor = new System.Windows.Forms.Panel();
            this.userInfo = new DiHaoOA.WinForm.Controls.UserInfo();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.panelContent.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.MainContent.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPeople)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEditPwd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.pUserInfor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(178)))), ((int)(((byte)(221)))));
            this.panelContent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelContent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelContent.Controls.Add(this.panelMenu);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelContent.Location = new System.Drawing.Point(0, 62);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1008, 465);
            this.panelContent.TabIndex = 2;
            this.panelContent.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContent_Paint);
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.MainContent);
            this.panelMenu.Controls.Add(this.picEditPwd);
            this.panelMenu.Controls.Add(this.picHome);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1004, 461);
            this.panelMenu.TabIndex = 3;
            // 
            // MainContent
            // 
            this.MainContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(246)))), ((int)(((byte)(245)))));
            this.MainContent.Controls.Add(this.panel2);
            this.MainContent.Location = new System.Drawing.Point(265, 113);
            this.MainContent.Margin = new System.Windows.Forms.Padding(2);
            this.MainContent.Name = "MainContent";
            this.MainContent.Size = new System.Drawing.Size(308, 189);
            this.MainContent.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lblMsg);
            this.panel2.Controls.Add(this.picPeople);
            this.panel2.Controls.Add(this.btnLogin);
            this.panel2.Controls.Add(this.lblPassword);
            this.panel2.Controls.Add(this.lblUserName);
            this.panel2.Controls.Add(this.txtPassword);
            this.panel2.Controls.Add(this.txtUserName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(308, 189);
            this.panel2.TabIndex = 0;
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(75)))), ((int)(((byte)(57)))));
            this.lblMsg.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblMsg.Location = new System.Drawing.Point(90, 13);
            this.lblMsg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(107, 12);
            this.lblMsg.TabIndex = 5;
            this.lblMsg.Text = "*用户名或密码错误";
            this.lblMsg.Visible = false;
            // 
            // picPeople
            // 
            this.picPeople.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picPeople.Image = ((System.Drawing.Image)(resources.GetObject("picPeople.Image")));
            this.picPeople.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.picPeople.Location = new System.Drawing.Point(209, 46);
            this.picPeople.Margin = new System.Windows.Forms.Padding(2);
            this.picPeople.Name = "picPeople";
            this.picPeople.Size = new System.Drawing.Size(100, 106);
            this.picPeople.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picPeople.TabIndex = 4;
            this.picPeople.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(150)))), ((int)(((byte)(14)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnLogin.Location = new System.Drawing.Point(28, 135);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(56, 27);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "登录";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.ForeColor = System.Drawing.Color.Gray;
            this.lblPassword.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPassword.Location = new System.Drawing.Point(25, 74);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(35, 12);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "密码:";
            // 
            // lblUserName
            // 
            this.lblUserName.AccessibleName = "";
            this.lblUserName.AutoSize = true;
            this.lblUserName.ForeColor = System.Drawing.Color.Gray;
            this.lblUserName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblUserName.Location = new System.Drawing.Point(25, 31);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(47, 12);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "用户名:";
            // 
            // txtPassword
            // 
            this.txtPassword.AcceptsTab = true;
            this.txtPassword.Location = new System.Drawing.Point(50, 90);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(150, 21);
            this.txtPassword.TabIndex = 1;
            // 
            // txtUserName
            // 
            this.txtUserName.AcceptsTab = true;
            this.txtUserName.Location = new System.Drawing.Point(50, 46);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(2);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(150, 21);
            this.txtUserName.TabIndex = 0;
            // 
            // picEditPwd
            // 
            this.picEditPwd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picEditPwd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picEditPwd.Enabled = false;
            this.picEditPwd.Image = ((System.Drawing.Image)(resources.GetObject("picEditPwd.Image")));
            this.picEditPwd.Location = new System.Drawing.Point(445, 141);
            this.picEditPwd.Margin = new System.Windows.Forms.Padding(2);
            this.picEditPwd.Name = "picEditPwd";
            this.picEditPwd.Size = new System.Drawing.Size(105, 105);
            this.picEditPwd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picEditPwd.TabIndex = 2;
            this.picEditPwd.TabStop = false;
            this.picEditPwd.Click += new System.EventHandler(this.picEditPwd_Click);
            // 
            // picHome
            // 
            this.picHome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picHome.Enabled = false;
            this.picHome.Image = ((System.Drawing.Image)(resources.GetObject("picHome.Image")));
            this.picHome.Location = new System.Drawing.Point(336, 132);
            this.picHome.Margin = new System.Windows.Forms.Padding(2);
            this.picHome.Name = "picHome";
            this.picHome.Size = new System.Drawing.Size(105, 105);
            this.picHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picHome.TabIndex = 1;
            this.picHome.TabStop = false;
            this.picHome.Click += new System.EventHandler(this.picHome_Click);
            // 
            // panelFoot
            // 
            this.panelFoot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(144)))), ((int)(((byte)(206)))));
            this.panelFoot.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelFoot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFoot.Location = new System.Drawing.Point(0, 527);
            this.panelFoot.Name = "panelFoot";
            this.panelFoot.Size = new System.Drawing.Size(904, 26);
            this.panelFoot.TabIndex = 1;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(144)))), ((int)(((byte)(206)))));
            this.panelHeader.Controls.Add(this.pUserInfor);
            this.panelHeader.Controls.Add(this.picLogo);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(904, 62);
            this.panelHeader.TabIndex = 0;
            // 
            // pUserInfor
            // 
            this.pUserInfor.Controls.Add(this.userInfo);
            this.pUserInfor.Dock = System.Windows.Forms.DockStyle.Right;
            this.pUserInfor.Location = new System.Drawing.Point(639, 0);
            this.pUserInfor.Margin = new System.Windows.Forms.Padding(2);
            this.pUserInfor.Name = "pUserInfor";
            this.pUserInfor.Size = new System.Drawing.Size(265, 62);
            this.pUserInfor.TabIndex = 3;
            // 
            // userInfo
            // 
            this.userInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.userInfo.ForeColor = System.Drawing.SystemColors.Control;
            this.userInfo.Location = new System.Drawing.Point(51, 0);
            this.userInfo.Margin = new System.Windows.Forms.Padding(2);
            this.userInfo.Name = "userInfo";
            this.userInfo.Size = new System.Drawing.Size(214, 62);
            this.userInfo.TabIndex = 0;
            // 
            // picLogo
            // 
            this.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(0, 0);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(100, 69);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // DashboardEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(904, 553);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelFoot);
            this.Controls.Add(this.panelHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "DashboardEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OA企业办公系统";
            this.Activated += new System.EventHandler(this.DashboardEntry_Activated);
            this.Load += new System.EventHandler(this.DashboardEntry_Load);
            this.Resize += new System.EventHandler(this.DashboardEntry_Resize);
            this.panelContent.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.MainContent.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPeople)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEditPwd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.pUserInfor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelFoot;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel pUserInfor;
        private WinForm.Controls.UserInfo userInfo;
        private System.Windows.Forms.PictureBox picHome;
        private System.Windows.Forms.PictureBox picEditPwd;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel MainContent;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.PictureBox picPeople;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;

    }
}