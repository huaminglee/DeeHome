namespace DiHaoOA.WinForm.Forms
{
    partial class ModifyIA
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
            this.pMain = new System.Windows.Forms.Panel();
            this.ckYes = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.cbEmployee = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pMain
            // 
            this.pMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(232)))), ((int)(((byte)(241)))));
            this.pMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pMain.Controls.Add(this.ckYes);
            this.pMain.Controls.Add(this.label3);
            this.pMain.Controls.Add(this.label2);
            this.pMain.Controls.Add(this.btnConfirm);
            this.pMain.Controls.Add(this.panel1);
            this.pMain.Controls.Add(this.cbEmployee);
            this.pMain.Controls.Add(this.label1);
            this.pMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pMain.Location = new System.Drawing.Point(0, 0);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(414, 330);
            this.pMain.TabIndex = 0;
            // 
            // ckYes
            // 
            this.ckYes.AutoSize = true;
            this.ckYes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(102)))), ((int)(((byte)(124)))));
            this.ckYes.Location = new System.Drawing.Point(304, 136);
            this.ckYes.Name = "ckYes";
            this.ckYes.Size = new System.Drawing.Size(74, 17);
            this.ckYes.TabIndex = 7;
            this.ckYes.Text = "连带客户";
            this.ckYes.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(62, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(283, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "则正跟踪和被打回的客户可随信息员直接转到新业务";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(32, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(379, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "如果原业务没有离职，则只能修改信息员的隶属，如果原业务离职了，";
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(159)))), ((int)(((byte)(239)))));
            this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConfirm.Location = new System.Drawing.Point(178, 233);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(56, 27);
            this.btnConfirm.TabIndex = 4;
            this.btnConfirm.Text = "确定";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(160)))), ((int)(((byte)(245)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(412, 29);
            this.panel1.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "修改合作伙伴隶属";
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblExit.ForeColor = System.Drawing.Color.White;
            this.lblExit.Location = new System.Drawing.Point(396, 2);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(15, 13);
            this.lblExit.TabIndex = 1;
            this.lblExit.Text = "X";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            this.lblExit.MouseLeave += new System.EventHandler(this.lblExit_MouseLeave);
            this.lblExit.MouseHover += new System.EventHandler(this.lblExit_MouseHover);
            // 
            // cbEmployee
            // 
            this.cbEmployee.FormattingEnabled = true;
            this.cbEmployee.Items.AddRange(new object[] {
            "Name"});
            this.cbEmployee.Location = new System.Drawing.Point(177, 132);
            this.cbEmployee.Name = "cbEmployee";
            this.cbEmployee.Size = new System.Drawing.Size(121, 21);
            this.cbEmployee.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(102)))), ((int)(((byte)(124)))));
            this.label1.Location = new System.Drawing.Point(113, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "选择员工:";
            // 
            // ModifyIA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 330);
            this.Controls.Add(this.pMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModifyIA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModifyIA";
            this.Load += new System.EventHandler(this.ModifyIA_Load);
            this.pMain.ResumeLayout(false);
            this.pMain.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbEmployee;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox ckYes;

    }
}