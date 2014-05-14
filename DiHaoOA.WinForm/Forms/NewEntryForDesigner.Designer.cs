namespace DiHaoOA.WinForm.Forms
{
    partial class NewEntryForDesigner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewEntryForDesigner));
            this.panel1 = new System.Windows.Forms.Panel();
            this.picEditPwd = new System.Windows.Forms.PictureBox();
            this.picHome = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblMsg = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEditPwd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(851, 434);
            this.panel1.TabIndex = 0;
            // 
            // picEditPwd
            // 
            this.picEditPwd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picEditPwd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picEditPwd.Enabled = false;
            this.picEditPwd.Image = ((System.Drawing.Image)(resources.GetObject("picEditPwd.Image")));
            this.picEditPwd.Location = new System.Drawing.Point(157, 44);
            this.picEditPwd.Margin = new System.Windows.Forms.Padding(2);
            this.picEditPwd.Name = "picEditPwd";
            this.picEditPwd.Size = new System.Drawing.Size(105, 105);
            this.picEditPwd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picEditPwd.TabIndex = 3;
            this.picEditPwd.TabStop = false;
            this.picEditPwd.Visible = false;
            this.picEditPwd.WaitOnLoad = true;
            this.picEditPwd.Click += new System.EventHandler(this.picEditPwd_Click);
            // 
            // picHome
            // 
            this.picHome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picHome.Enabled = false;
            this.picHome.Image = ((System.Drawing.Image)(resources.GetObject("picHome.Image")));
            this.picHome.Location = new System.Drawing.Point(48, 31);
            this.picHome.Margin = new System.Windows.Forms.Padding(2);
            this.picHome.Name = "picHome";
            this.picHome.Size = new System.Drawing.Size(105, 105);
            this.picHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picHome.TabIndex = 2;
            this.picHome.TabStop = false;
            this.picHome.Visible = false;
            this.picHome.WaitOnLoad = true;
            this.picHome.Click += new System.EventHandler(this.picHome_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.lblMsg);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnLogin);
            this.panel2.Controls.Add(this.txtPassword);
            this.panel2.Controls.Add(this.txtUserName);
            this.panel2.Controls.Add(this.lblPassword);
            this.panel2.Controls.Add(this.lblUserName);
            this.panel2.Location = new System.Drawing.Point(296, 136);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(298, 174);
            this.panel2.TabIndex = 0;
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(75)))), ((int)(((byte)(57)))));
            this.lblMsg.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblMsg.Location = new System.Drawing.Point(99, 133);
            this.lblMsg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(107, 12);
            this.lblMsg.TabIndex = 7;
            this.lblMsg.Text = "*用户名或密码错误";
            this.lblMsg.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(167)))), ((int)(((byte)(205)))));
            this.label1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(106)))), ((int)(((byte)(123)))));
            this.label1.Location = new System.Drawing.Point(15, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "帝豪OA办公系统";
            // 
            // btnLogin
            // 
            this.btnLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogin.BackgroundImage")));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(106)))), ((int)(((byte)(123)))));
            this.btnLogin.Location = new System.Drawing.Point(19, 128);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "登陆";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.AcceptsTab = true;
            this.txtPassword.Location = new System.Drawing.Point(82, 85);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(150, 21);
            this.txtPassword.TabIndex = 5;
            // 
            // txtUserName
            // 
            this.txtUserName.AcceptsTab = true;
            this.txtUserName.Location = new System.Drawing.Point(82, 47);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(2);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(150, 21);
            this.txtUserName.TabIndex = 4;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(167)))), ((int)(((byte)(205)))));
            this.lblPassword.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(106)))), ((int)(((byte)(123)))));
            this.lblPassword.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPassword.Location = new System.Drawing.Point(17, 88);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(52, 12);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "密  码:";
            // 
            // lblUserName
            // 
            this.lblUserName.AccessibleName = "";
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(167)))), ((int)(((byte)(205)))));
            this.lblUserName.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(106)))), ((int)(((byte)(123)))));
            this.lblUserName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblUserName.Location = new System.Drawing.Point(17, 50);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(51, 12);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "用户名:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(178)))), ((int)(((byte)(221)))));
            this.panel3.Controls.Add(this.picHome);
            this.panel3.Controls.Add(this.picEditPwd);
            this.panel3.Location = new System.Drawing.Point(296, 149);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(301, 151);
            this.panel3.TabIndex = 4;
            this.panel3.Visible = false;
            // 
            // NewEntryForDesigner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(851, 434);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "NewEntryForDesigner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OA企业办公系统";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picEditPwd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.PictureBox picHome;
        private System.Windows.Forms.PictureBox picEditPwd;
        private System.Windows.Forms.Panel panel3;
    }
}