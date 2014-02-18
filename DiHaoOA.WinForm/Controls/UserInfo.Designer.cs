namespace DiHaoOA.WinForm.Controls
{
    partial class UserInfo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.btnSeniorSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(102)))), ((int)(((byte)(124)))));
            this.label1.Location = new System.Drawing.Point(2, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "登录用户:";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(102)))), ((int)(((byte)(124)))));
            this.lblUserName.Location = new System.Drawing.Point(69, 22);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(0, 13);
            this.lblUserName.TabIndex = 1;
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(102)))), ((int)(((byte)(124)))));
            this.lblExit.Location = new System.Drawing.Point(143, 22);
            this.lblExit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(33, 13);
            this.lblExit.TabIndex = 2;
            this.lblExit.Text = "退出";
            this.lblExit.Visible = false;
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // btnSeniorSearch
            // 
            this.btnSeniorSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btnSeniorSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeniorSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSeniorSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(102)))), ((int)(((byte)(124)))));
            this.btnSeniorSearch.Location = new System.Drawing.Point(158, 16);
            this.btnSeniorSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSeniorSearch.Name = "btnSeniorSearch";
            this.btnSeniorSearch.Size = new System.Drawing.Size(50, 24);
            this.btnSeniorSearch.TabIndex = 3;
            this.btnSeniorSearch.Text = "退出";
            this.btnSeniorSearch.UseVisualStyleBackColor = false;
            this.btnSeniorSearch.Click += new System.EventHandler(this.btnSeniorSearch_Click);
            // 
            // UserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSeniorSearch);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserInfo";
            this.Size = new System.Drawing.Size(210, 64);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Button btnSeniorSearch;
    }
}
