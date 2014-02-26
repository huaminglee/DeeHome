namespace DiHaoOA.WinForm.Controls
{
    partial class AllocateDesignerGroup
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
            this.pMain = new System.Windows.Forms.Panel();
            this.lblSuccessMsg = new System.Windows.Forms.Label();
            this.cbDesinger = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.cbDesingerGroup = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pMain
            // 
            this.pMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(232)))), ((int)(((byte)(241)))));
            this.pMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pMain.Controls.Add(this.lblSuccessMsg);
            this.pMain.Controls.Add(this.cbDesinger);
            this.pMain.Controls.Add(this.label2);
            this.pMain.Controls.Add(this.btnConfirm);
            this.pMain.Controls.Add(this.panel1);
            this.pMain.Controls.Add(this.cbDesingerGroup);
            this.pMain.Controls.Add(this.label1);
            this.pMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pMain.Location = new System.Drawing.Point(0, 0);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(451, 301);
            this.pMain.TabIndex = 2;
            // 
            // lblSuccessMsg
            // 
            this.lblSuccessMsg.AutoSize = true;
            this.lblSuccessMsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(70)))));
            this.lblSuccessMsg.Location = new System.Drawing.Point(176, 191);
            this.lblSuccessMsg.Name = "lblSuccessMsg";
            this.lblSuccessMsg.Size = new System.Drawing.Size(53, 12);
            this.lblSuccessMsg.TabIndex = 11;
            this.lblSuccessMsg.Text = "分配成功";
            this.lblSuccessMsg.Visible = false;
            // 
            // cbDesinger
            // 
            this.cbDesinger.DisplayMember = "Name";
            this.cbDesinger.FormattingEnabled = true;
            this.cbDesinger.Items.AddRange(new object[] {
            "Name"});
            this.cbDesinger.Location = new System.Drawing.Point(189, 74);
            this.cbDesinger.Name = "cbDesinger";
            this.cbDesinger.Size = new System.Drawing.Size(121, 20);
            this.cbDesinger.TabIndex = 6;
            this.cbDesinger.ValueMember = "EmployeeId";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(102)))), ((int)(((byte)(124)))));
            this.label2.Location = new System.Drawing.Point(113, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "选择设计师:";
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(159)))), ((int)(((byte)(239)))));
            this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConfirm.Location = new System.Drawing.Point(115, 185);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(56, 25);
            this.btnConfirm.TabIndex = 4;
            this.btnConfirm.Text = "分配";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(232)))), ((int)(((byte)(241)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(449, 27);
            this.panel1.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(159)))), ((int)(((byte)(239)))));
            this.label4.Location = new System.Drawing.Point(1, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "分配设计师";
            // 
            // cbDesingerGroup
            // 
            this.cbDesingerGroup.DisplayMember = "GroupName";
            this.cbDesingerGroup.FormattingEnabled = true;
            this.cbDesingerGroup.Items.AddRange(new object[] {
            "Name"});
            this.cbDesingerGroup.Location = new System.Drawing.Point(189, 126);
            this.cbDesingerGroup.Name = "cbDesingerGroup";
            this.cbDesingerGroup.Size = new System.Drawing.Size(121, 20);
            this.cbDesingerGroup.TabIndex = 1;
            this.cbDesingerGroup.ValueMember = "GroupId";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(102)))), ((int)(((byte)(124)))));
            this.label1.Location = new System.Drawing.Point(113, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "选择主案部:";
            // 
            // AllocateDesignerGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pMain);
            this.Name = "AllocateDesignerGroup";
            this.Size = new System.Drawing.Size(451, 301);
            this.Load += new System.EventHandler(this.AllocateDesignerGroup_Load);
            this.pMain.ResumeLayout(false);
            this.pMain.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pMain;
        private System.Windows.Forms.ComboBox cbDesinger;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbDesingerGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSuccessMsg;
    }
}
