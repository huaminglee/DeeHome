namespace DiHaoOA.WinForm.Controls
{
    partial class PagingControl
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
            this.pContent = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCurrentRecord = new System.Windows.Forms.Label();
            this.lblRecord = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGoForward = new System.Windows.Forms.Button();
            this.txtPage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrevPage = new System.Windows.Forms.Button();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.btnLastPage = new System.Windows.Forms.Button();
            this.btnFirstPage = new System.Windows.Forms.Button();
            this.pContent.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pContent
            // 
            this.pContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(232)))), ((int)(((byte)(241)))));
            this.pContent.Controls.Add(this.panel2);
            this.pContent.Controls.Add(this.panel1);
            this.pContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pContent.Location = new System.Drawing.Point(0, 0);
            this.pContent.Margin = new System.Windows.Forms.Padding(2);
            this.pContent.Name = "pContent";
            this.pContent.Size = new System.Drawing.Size(783, 55);
            this.pContent.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblCurrentRecord);
            this.panel2.Controls.Add(this.lblRecord);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(232, 55);
            this.panel2.TabIndex = 7;
            // 
            // lblCurrentRecord
            // 
            this.lblCurrentRecord.AutoSize = true;
            this.lblCurrentRecord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(102)))), ((int)(((byte)(124)))));
            this.lblCurrentRecord.Location = new System.Drawing.Point(124, 15);
            this.lblCurrentRecord.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurrentRecord.Name = "lblCurrentRecord";
            this.lblCurrentRecord.Size = new System.Drawing.Size(72, 13);
            this.lblCurrentRecord.TabIndex = 4;
            this.lblCurrentRecord.Text = "当前是0/0页";
            // 
            // lblRecord
            // 
            this.lblRecord.AutoSize = true;
            this.lblRecord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(102)))), ((int)(((byte)(124)))));
            this.lblRecord.Location = new System.Drawing.Point(14, 15);
            this.lblRecord.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(61, 13);
            this.lblRecord.TabIndex = 4;
            this.lblRecord.Text = "共0条记录";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnGoForward);
            this.panel1.Controls.Add(this.txtPage);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnPrevPage);
            this.panel1.Controls.Add(this.btnNextPage);
            this.panel1.Controls.Add(this.btnLastPage);
            this.panel1.Controls.Add(this.btnFirstPage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(416, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(367, 55);
            this.panel1.TabIndex = 6;
            // 
            // btnGoForward
            // 
            this.btnGoForward.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btnGoForward.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGoForward.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(102)))), ((int)(((byte)(124)))));
            this.btnGoForward.Location = new System.Drawing.Point(320, 12);
            this.btnGoForward.Margin = new System.Windows.Forms.Padding(2);
            this.btnGoForward.Name = "btnGoForward";
            this.btnGoForward.Size = new System.Drawing.Size(43, 22);
            this.btnGoForward.TabIndex = 8;
            this.btnGoForward.Text = "跳转";
            this.btnGoForward.UseVisualStyleBackColor = false;
            this.btnGoForward.Click += new System.EventHandler(this.btnGoForward_Click);
            // 
            // txtPage
            // 
            this.txtPage.Location = new System.Drawing.Point(277, 12);
            this.txtPage.Margin = new System.Windows.Forms.Padding(2);
            this.txtPage.Multiline = true;
            this.txtPage.Name = "txtPage";
            this.txtPage.Size = new System.Drawing.Size(39, 22);
            this.txtPage.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(102)))), ((int)(((byte)(124)))));
            this.label1.Location = new System.Drawing.Point(242, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "转到";
            // 
            // btnPrevPage
            // 
            this.btnPrevPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btnPrevPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrevPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(102)))), ((int)(((byte)(124)))));
            this.btnPrevPage.Location = new System.Drawing.Point(75, 12);
            this.btnPrevPage.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrevPage.Name = "btnPrevPage";
            this.btnPrevPage.Size = new System.Drawing.Size(53, 22);
            this.btnPrevPage.TabIndex = 5;
            this.btnPrevPage.Text = "上一页";
            this.btnPrevPage.UseVisualStyleBackColor = false;
            this.btnPrevPage.Click += new System.EventHandler(this.btnPrevPage_Click);
            // 
            // btnNextPage
            // 
            this.btnNextPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btnNextPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNextPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(102)))), ((int)(((byte)(124)))));
            this.btnNextPage.Location = new System.Drawing.Point(139, 12);
            this.btnNextPage.Margin = new System.Windows.Forms.Padding(2);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(53, 22);
            this.btnNextPage.TabIndex = 5;
            this.btnNextPage.Text = "下一页";
            this.btnNextPage.UseVisualStyleBackColor = false;
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // btnLastPage
            // 
            this.btnLastPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btnLastPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLastPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(102)))), ((int)(((byte)(124)))));
            this.btnLastPage.Location = new System.Drawing.Point(196, 12);
            this.btnLastPage.Margin = new System.Windows.Forms.Padding(2);
            this.btnLastPage.Name = "btnLastPage";
            this.btnLastPage.Size = new System.Drawing.Size(41, 22);
            this.btnLastPage.TabIndex = 5;
            this.btnLastPage.Text = "尾页";
            this.btnLastPage.UseVisualStyleBackColor = false;
            this.btnLastPage.Click += new System.EventHandler(this.btnLastPage_Click);
            // 
            // btnFirstPage
            // 
            this.btnFirstPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btnFirstPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFirstPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(102)))), ((int)(((byte)(124)))));
            this.btnFirstPage.Location = new System.Drawing.Point(23, 12);
            this.btnFirstPage.Margin = new System.Windows.Forms.Padding(2);
            this.btnFirstPage.Name = "btnFirstPage";
            this.btnFirstPage.Size = new System.Drawing.Size(48, 22);
            this.btnFirstPage.TabIndex = 5;
            this.btnFirstPage.Text = "首页";
            this.btnFirstPage.UseVisualStyleBackColor = false;
            this.btnFirstPage.Click += new System.EventHandler(this.btnFirstPage_Click);
            // 
            // PagingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pContent);
            this.Name = "PagingControl";
            this.Size = new System.Drawing.Size(783, 55);
            this.pContent.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pContent;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblCurrentRecord;
        private System.Windows.Forms.Label lblRecord;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGoForward;
        private System.Windows.Forms.TextBox txtPage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrevPage;
        private System.Windows.Forms.Button btnNextPage;
        private System.Windows.Forms.Button btnLastPage;
        private System.Windows.Forms.Button btnFirstPage;
    }
}
