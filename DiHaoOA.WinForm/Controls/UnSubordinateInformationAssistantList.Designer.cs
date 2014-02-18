namespace DiHaoOA.WinForm.Controls
{
    partial class UnSubordinateInformationAssistantList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pContent = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgUnSubordinate = new System.Windows.Forms.DataGridView();
            this.PrimaryKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SerialNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InformationAssistantName = new System.Windows.Forms.DataGridViewLinkColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.District = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pfooter = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGoForward = new System.Windows.Forms.Button();
            this.txtPage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrevPage = new System.Windows.Forms.Button();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.btnLastPage = new System.Windows.Forms.Button();
            this.btnFirstPage = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCurrentRecord = new System.Windows.Forms.Label();
            this.lblRecord = new System.Windows.Forms.Label();
            this.pContent.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUnSubordinate)).BeginInit();
            this.pfooter.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pContent
            // 
            this.pContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.pContent.Controls.Add(this.tabControl1);
            this.pContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(113)))), ((int)(((byte)(133)))));
            this.pContent.Location = new System.Drawing.Point(0, 0);
            this.pContent.Margin = new System.Windows.Forms.Padding(2);
            this.pContent.Name = "pContent";
            this.pContent.Size = new System.Drawing.Size(759, 456);
            this.pContent.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(759, 456);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.pfooter);
            this.tabPage1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(113)))), ((int)(((byte)(133)))));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(751, 430);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "未隶属信息员列表";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgUnSubordinate);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel3.Location = new System.Drawing.Point(2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(747, 354);
            this.panel3.TabIndex = 2;
            // 
            // dgUnSubordinate
            // 
            this.dgUnSubordinate.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(232)))), ((int)(((byte)(241)))));
            this.dgUnSubordinate.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgUnSubordinate.BackgroundColor = System.Drawing.Color.White;
            this.dgUnSubordinate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUnSubordinate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PrimaryKey,
            this.SerialNumber,
            this.InformationAssistantName,
            this.PhoneNumber,
            this.Type,
            this.Company,
            this.District,
            this.Level});
            this.dgUnSubordinate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgUnSubordinate.Location = new System.Drawing.Point(0, 0);
            this.dgUnSubordinate.Margin = new System.Windows.Forms.Padding(2);
            this.dgUnSubordinate.Name = "dgUnSubordinate";
            this.dgUnSubordinate.RowTemplate.Height = 24;
            this.dgUnSubordinate.Size = new System.Drawing.Size(747, 354);
            this.dgUnSubordinate.TabIndex = 0;
            this.dgUnSubordinate.VirtualMode = true;
            this.dgUnSubordinate.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgUnSubordinate_CellClick);
            this.dgUnSubordinate.CellValueNeeded += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.dgUnSubordinate_CellValueNeeded);
            // 
            // PrimaryKey
            // 
            this.PrimaryKey.DataPropertyName = "gridColumnInformationAssistantId";
            this.PrimaryKey.HeaderText = "PrimaryKey";
            this.PrimaryKey.Name = "PrimaryKey";
            this.PrimaryKey.ReadOnly = true;
            this.PrimaryKey.Visible = false;
            // 
            // SerialNumber
            // 
            this.SerialNumber.HeaderText = "序号";
            this.SerialNumber.Name = "SerialNumber";
            this.SerialNumber.ReadOnly = true;
            this.SerialNumber.Width = 60;
            // 
            // InformationAssistantName
            // 
            this.InformationAssistantName.DataPropertyName = "gridColumnName";
            this.InformationAssistantName.HeaderText = "姓名";
            this.InformationAssistantName.Name = "InformationAssistantName";
            this.InformationAssistantName.ReadOnly = true;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.DataPropertyName = "gridColumnPhone";
            this.PhoneNumber.HeaderText = "电话号码";
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.ReadOnly = true;
            this.PhoneNumber.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PhoneNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Type
            // 
            this.Type.DataPropertyName = "gridColumnType";
            this.Type.HeaderText = "性质";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Type.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Company
            // 
            this.Company.DataPropertyName = "gridColumnCompany";
            this.Company.HeaderText = "工作单位";
            this.Company.Name = "Company";
            this.Company.ReadOnly = true;
            this.Company.Width = 140;
            // 
            // District
            // 
            this.District.DataPropertyName = "gridColumnCity";
            this.District.HeaderText = "工作地区";
            this.District.Name = "District";
            this.District.ReadOnly = true;
            // 
            // Level
            // 
            this.Level.DataPropertyName = "gridColumnLevel";
            this.Level.HeaderText = "级别";
            this.Level.Name = "Level";
            this.Level.ReadOnly = true;
            // 
            // pfooter
            // 
            this.pfooter.Controls.Add(this.panel1);
            this.pfooter.Controls.Add(this.panel2);
            this.pfooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pfooter.Location = new System.Drawing.Point(2, 361);
            this.pfooter.Margin = new System.Windows.Forms.Padding(2);
            this.pfooter.Name = "pfooter";
            this.pfooter.Size = new System.Drawing.Size(747, 67);
            this.pfooter.TabIndex = 1;
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
            this.panel1.Location = new System.Drawing.Point(333, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(414, 67);
            this.panel1.TabIndex = 9;
            // 
            // btnGoForward
            // 
            this.btnGoForward.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btnGoForward.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGoForward.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnGoForward.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(102)))), ((int)(((byte)(124)))));
            this.btnGoForward.Location = new System.Drawing.Point(346, 11);
            this.btnGoForward.Margin = new System.Windows.Forms.Padding(2);
            this.btnGoForward.Name = "btnGoForward";
            this.btnGoForward.Size = new System.Drawing.Size(49, 23);
            this.btnGoForward.TabIndex = 8;
            this.btnGoForward.Text = "跳转";
            this.btnGoForward.UseVisualStyleBackColor = false;
            this.btnGoForward.Visible = false;
            // 
            // txtPage
            // 
            this.txtPage.Location = new System.Drawing.Point(315, 13);
            this.txtPage.Margin = new System.Windows.Forms.Padding(2);
            this.txtPage.Name = "txtPage";
            this.txtPage.Size = new System.Drawing.Size(27, 20);
            this.txtPage.TabIndex = 7;
            this.txtPage.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(102)))), ((int)(((byte)(124)))));
            this.label1.Location = new System.Drawing.Point(278, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "转到";
            this.label1.Visible = false;
            // 
            // btnPrevPage
            // 
            this.btnPrevPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btnPrevPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrevPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPrevPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(102)))), ((int)(((byte)(124)))));
            this.btnPrevPage.Location = new System.Drawing.Point(76, 12);
            this.btnPrevPage.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrevPage.Name = "btnPrevPage";
            this.btnPrevPage.Size = new System.Drawing.Size(72, 24);
            this.btnPrevPage.TabIndex = 5;
            this.btnPrevPage.Text = "上一页";
            this.btnPrevPage.UseVisualStyleBackColor = false;
            this.btnPrevPage.Visible = false;
            // 
            // btnNextPage
            // 
            this.btnNextPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btnNextPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNextPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnNextPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(102)))), ((int)(((byte)(124)))));
            this.btnNextPage.Location = new System.Drawing.Point(152, 13);
            this.btnNextPage.Margin = new System.Windows.Forms.Padding(2);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(62, 21);
            this.btnNextPage.TabIndex = 5;
            this.btnNextPage.Text = "下一页";
            this.btnNextPage.UseVisualStyleBackColor = false;
            this.btnNextPage.Visible = false;
            // 
            // btnLastPage
            // 
            this.btnLastPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btnLastPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLastPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLastPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(102)))), ((int)(((byte)(124)))));
            this.btnLastPage.Location = new System.Drawing.Point(218, 13);
            this.btnLastPage.Margin = new System.Windows.Forms.Padding(2);
            this.btnLastPage.Name = "btnLastPage";
            this.btnLastPage.Size = new System.Drawing.Size(56, 21);
            this.btnLastPage.TabIndex = 5;
            this.btnLastPage.Text = "尾页";
            this.btnLastPage.UseVisualStyleBackColor = false;
            this.btnLastPage.Visible = false;
            // 
            // btnFirstPage
            // 
            this.btnFirstPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btnFirstPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFirstPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnFirstPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(102)))), ((int)(((byte)(124)))));
            this.btnFirstPage.Location = new System.Drawing.Point(11, 13);
            this.btnFirstPage.Margin = new System.Windows.Forms.Padding(2);
            this.btnFirstPage.Name = "btnFirstPage";
            this.btnFirstPage.Size = new System.Drawing.Size(61, 22);
            this.btnFirstPage.TabIndex = 5;
            this.btnFirstPage.Text = "首页";
            this.btnFirstPage.UseVisualStyleBackColor = false;
            this.btnFirstPage.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblCurrentRecord);
            this.panel2.Controls.Add(this.lblRecord);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(207, 67);
            this.panel2.TabIndex = 8;
            // 
            // lblCurrentRecord
            // 
            this.lblCurrentRecord.AutoSize = true;
            this.lblCurrentRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCurrentRecord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(102)))), ((int)(((byte)(124)))));
            this.lblCurrentRecord.Location = new System.Drawing.Point(124, 15);
            this.lblCurrentRecord.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurrentRecord.Name = "lblCurrentRecord";
            this.lblCurrentRecord.Size = new System.Drawing.Size(72, 13);
            this.lblCurrentRecord.TabIndex = 4;
            this.lblCurrentRecord.Text = "当前是1/1页";
            this.lblCurrentRecord.Visible = false;
            // 
            // lblRecord
            // 
            this.lblRecord.AutoSize = true;
            this.lblRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblRecord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(102)))), ((int)(((byte)(124)))));
            this.lblRecord.Location = new System.Drawing.Point(14, 15);
            this.lblRecord.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(61, 13);
            this.lblRecord.TabIndex = 4;
            this.lblRecord.Text = "共1条记录";
            this.lblRecord.Visible = false;
            // 
            // UnSubordinateInformationAssistantList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pContent);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UnSubordinateInformationAssistantList";
            this.Size = new System.Drawing.Size(759, 456);
            this.pContent.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgUnSubordinate)).EndInit();
            this.pfooter.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pContent;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel pfooter;
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
        private System.Windows.Forms.DataGridView dgUnSubordinate;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrimaryKey;
        private System.Windows.Forms.DataGridViewTextBoxColumn SerialNumber;
        private System.Windows.Forms.DataGridViewLinkColumn InformationAssistantName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Company;
        private System.Windows.Forms.DataGridViewTextBoxColumn District;
        private System.Windows.Forms.DataGridViewTextBoxColumn Level;
    }
}
