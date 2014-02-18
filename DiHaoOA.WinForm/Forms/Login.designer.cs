namespace DiHaoOA
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.MainContent = new System.Windows.Forms.Panel();
            this.pHeader = new System.Windows.Forms.Panel();
            this.pExit = new System.Windows.Forms.Panel();
            this.lblExit = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblMsg = new System.Windows.Forms.Label();
            this.picPeople = new System.Windows.Forms.PictureBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.MainContent.SuspendLayout();
            this.pHeader.SuspendLayout();
            this.pExit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // MainContent
            // 
            this.MainContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(178)))), ((int)(((byte)(221)))));
            this.MainContent.Controls.Add(this.pHeader);
            this.MainContent.Controls.Add(this.panel2);
            resources.ApplyResources(this.MainContent, "MainContent");
            this.MainContent.Name = "MainContent";
            // 
            // pHeader
            // 
            this.pHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(144)))), ((int)(((byte)(206)))));
            this.pHeader.Controls.Add(this.pExit);
            this.pHeader.Controls.Add(this.picLogo);
            resources.ApplyResources(this.pHeader, "pHeader");
            this.pHeader.Name = "pHeader";
            this.pHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pHeader_MouseDown);
            this.pHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pHeader_MouseMove);
            this.pHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pHeader_MouseUp);
            // 
            // pExit
            // 
            resources.ApplyResources(this.pExit, "pExit");
            this.pExit.Controls.Add(this.lblExit);
            this.pExit.Name = "pExit";
            this.pExit.MouseLeave += new System.EventHandler(this.pExit_MouseLeave);
            this.pExit.MouseHover += new System.EventHandler(this.pExit_MouseHover);
            // 
            // lblExit
            // 
            resources.ApplyResources(this.lblExit, "lblExit");
            this.lblExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblExit.ForeColor = System.Drawing.Color.White;
            this.lblExit.Name = "lblExit";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            this.lblExit.MouseLeave += new System.EventHandler(this.lblExit_MouseLeave);
            this.lblExit.MouseHover += new System.EventHandler(this.lblExit_MouseHover);
            // 
            // picLogo
            // 
            resources.ApplyResources(this.picLogo, "picLogo");
            this.picLogo.Name = "picLogo";
            this.picLogo.TabStop = false;
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.panel2.Controls.Add(this.lblMsg);
            this.panel2.Controls.Add(this.picPeople);
            this.panel2.Controls.Add(this.btnLogin);
            this.panel2.Controls.Add(this.lblPassword);
            this.panel2.Controls.Add(this.lblUserName);
            this.panel2.Controls.Add(this.txtPassword);
            this.panel2.Controls.Add(this.txtUserName);
            this.panel2.Name = "panel2";
            // 
            // lblMsg
            // 
            resources.ApplyResources(this.lblMsg, "lblMsg");
            this.lblMsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(75)))), ((int)(((byte)(57)))));
            this.lblMsg.Name = "lblMsg";
            // 
            // picPeople
            // 
            resources.ApplyResources(this.picPeople, "picPeople");
            this.picPeople.Name = "picPeople";
            this.picPeople.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(150)))), ((int)(((byte)(14)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnLogin, "btnLogin");
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblPassword
            // 
            resources.ApplyResources(this.lblPassword, "lblPassword");
            this.lblPassword.ForeColor = System.Drawing.Color.Gray;
            this.lblPassword.Name = "lblPassword";
            // 
            // lblUserName
            // 
            resources.ApplyResources(this.lblUserName, "lblUserName");
            this.lblUserName.ForeColor = System.Drawing.Color.Gray;
            this.lblUserName.Name = "lblUserName";
            // 
            // txtPassword
            // 
            this.txtPassword.AcceptsTab = true;
            resources.ApplyResources(this.txtPassword, "txtPassword");
            this.txtPassword.Name = "txtPassword";
            // 
            // txtUserName
            // 
            this.txtUserName.AcceptsTab = true;
            resources.ApplyResources(this.txtUserName, "txtUserName");
            this.txtUserName.Name = "txtUserName";
            // 
            // Login
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MainContent);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.Login_Load);
            this.Resize += new System.EventHandler(this.Login_Resize);
            this.MainContent.ResumeLayout(false);
            this.pHeader.ResumeLayout(false);
            this.pHeader.PerformLayout();
            this.pExit.ResumeLayout(false);
            this.pExit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPeople)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picPeople;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Panel pHeader;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel MainContent;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Panel pExit;

    }
}

