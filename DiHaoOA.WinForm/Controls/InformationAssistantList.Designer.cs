namespace DiHaoOA.WinForm.Controls
{
    partial class InformationAssistantList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_Main = new System.Windows.Forms.Panel();
            this.pHeader = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pFooter = new System.Windows.Forms.Panel();
            this.pagingForIA = new DiHaoOA.WinForm.Controls.PagingControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ckSelectAll = new System.Windows.Forms.CheckBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pTop = new System.Windows.Forms.Panel();
            this.dgIAList = new System.Windows.Forms.DataGridView();
            this.gridColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsSelected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.SerialNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IAName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Employee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_Main.SuspendLayout();
            this.pHeader.SuspendLayout();
            this.pFooter.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgIAList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Main
            // 
            this.panel_Main.Controls.Add(this.pHeader);
            this.panel_Main.Controls.Add(this.pFooter);
            this.panel_Main.Controls.Add(this.pTop);
            this.panel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Main.Location = new System.Drawing.Point(0, 0);
            this.panel_Main.Name = "panel_Main";
            this.panel_Main.Size = new System.Drawing.Size(945, 562);
            this.panel_Main.TabIndex = 1;
            // 
            // pHeader
            // 
            this.pHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(232)))), ((int)(((byte)(241)))));
            this.pHeader.Controls.Add(this.btnSearch);
            this.pHeader.Controls.Add(this.txtSearch);
            this.pHeader.Controls.Add(this.button1);
            this.pHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pHeader.Location = new System.Drawing.Point(0, 0);
            this.pHeader.Margin = new System.Windows.Forms.Padding(2);
            this.pHeader.Name = "pHeader";
            this.pHeader.Size = new System.Drawing.Size(945, 35);
            this.pHeader.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(102)))), ((int)(((byte)(124)))));
            this.btnSearch.Location = new System.Drawing.Point(887, 8);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(55, 24);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "搜索";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Location = new System.Drawing.Point(737, 9);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(150, 22);
            this.txtSearch.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(102)))), ((int)(((byte)(124)))));
            this.button1.Location = new System.Drawing.Point(0, 1);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "全部列表";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pFooter
            // 
            this.pFooter.BackColor = System.Drawing.Color.White;
            this.pFooter.Controls.Add(this.pagingForIA);
            this.pFooter.Controls.Add(this.panel1);
            this.pFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pFooter.Location = new System.Drawing.Point(0, 471);
            this.pFooter.Name = "pFooter";
            this.pFooter.Size = new System.Drawing.Size(945, 91);
            this.pFooter.TabIndex = 2;
            // 
            // pagingForIA
            // 
            this.pagingForIA.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pagingForIA.Location = new System.Drawing.Point(0, 32);
            this.pagingForIA.Name = "pagingForIA";
            this.pagingForIA.Size = new System.Drawing.Size(945, 59);
            this.pagingForIA.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ckSelectAll);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnModify);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(945, 26);
            this.panel1.TabIndex = 0;
            // 
            // ckSelectAll
            // 
            this.ckSelectAll.AutoSize = true;
            this.ckSelectAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ckSelectAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(102)))), ((int)(((byte)(124)))));
            this.ckSelectAll.Location = new System.Drawing.Point(18, 5);
            this.ckSelectAll.Name = "ckSelectAll";
            this.ckSelectAll.Size = new System.Drawing.Size(48, 17);
            this.ckSelectAll.TabIndex = 9;
            this.ckSelectAll.Text = "全选";
            this.ckSelectAll.UseVisualStyleBackColor = true;
            this.ckSelectAll.CheckedChanged += new System.EventHandler(this.ckSelectAll_CheckedChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(102)))), ((int)(((byte)(124)))));
            this.btnDelete.Location = new System.Drawing.Point(250, 2);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(48, 22);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnModify
            // 
            this.btnModify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btnModify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModify.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(102)))), ((int)(((byte)(124)))));
            this.btnModify.Location = new System.Drawing.Point(198, 2);
            this.btnModify.Margin = new System.Windows.Forms.Padding(2);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(48, 22);
            this.btnModify.TabIndex = 7;
            this.btnModify.Text = "修改";
            this.btnModify.UseVisualStyleBackColor = false;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(102)))), ((int)(((byte)(124)))));
            this.label2.Location = new System.Drawing.Point(79, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "修改选中信息员隶属";
            // 
            // pTop
            // 
            this.pTop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pTop.BackColor = System.Drawing.Color.White;
            this.pTop.Controls.Add(this.dgIAList);
            this.pTop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(113)))), ((int)(((byte)(133)))));
            this.pTop.Location = new System.Drawing.Point(0, 36);
            this.pTop.Name = "pTop";
            this.pTop.Size = new System.Drawing.Size(945, 437);
            this.pTop.TabIndex = 1;
            // 
            // dgIAList
            // 
            this.dgIAList.AllowUserToAddRows = false;
            this.dgIAList.AllowUserToDeleteRows = false;
            this.dgIAList.AllowUserToResizeColumns = false;
            this.dgIAList.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(232)))), ((int)(((byte)(241)))));
            this.dgIAList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgIAList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgIAList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgIAList.BackgroundColor = System.Drawing.Color.White;
            this.dgIAList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgIAList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgIAList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gridColumnName,
            this.IsSelected,
            this.SerialNumber,
            this.IAName,
            this.Phone,
            this.Type,
            this.Company,
            this.City,
            this.Level,
            this.Employee});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(113)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgIAList.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgIAList.Location = new System.Drawing.Point(0, 0);
            this.dgIAList.Name = "dgIAList";
            this.dgIAList.RowHeadersVisible = false;
            this.dgIAList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgIAList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgIAList.Size = new System.Drawing.Size(945, 437);
            this.dgIAList.TabIndex = 0;
            this.dgIAList.VirtualMode = true;
            this.dgIAList.CellValueNeeded += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.dgDeletedIAList_CellValueNeeded);
            // 
            // gridColumnName
            // 
            this.gridColumnName.DataPropertyName = "gridColumnIndex";
            this.gridColumnName.HeaderText = "PrimarKey";
            this.gridColumnName.Name = "gridColumnName";
            this.gridColumnName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.gridColumnName.Visible = false;
            // 
            // IsSelected
            // 
            this.IsSelected.DataPropertyName = "IsSelected";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle5.NullValue = false;
            this.IsSelected.DefaultCellStyle = dataGridViewCellStyle5;
            this.IsSelected.FalseValue = "False";
            this.IsSelected.FillWeight = 37.90776F;
            this.IsSelected.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.IsSelected.HeaderText = "";
            this.IsSelected.Name = "IsSelected";
            this.IsSelected.TrueValue = "True";
            // 
            // SerialNumber
            // 
            this.SerialNumber.FillWeight = 52.70721F;
            this.SerialNumber.HeaderText = "序号";
            this.SerialNumber.Name = "SerialNumber";
            this.SerialNumber.ReadOnly = true;
            this.SerialNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // IAName
            // 
            this.IAName.DataPropertyName = "gridColumnInformationAssistant";
            this.IAName.FillWeight = 101.2679F;
            this.IAName.HeaderText = "姓名";
            this.IAName.Name = "IAName";
            this.IAName.ReadOnly = true;
            this.IAName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "IaPhoneNumber";
            this.Phone.HeaderText = "电话";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            // 
            // Type
            // 
            this.Type.DataPropertyName = "gridColumnType";
            this.Type.FillWeight = 101.2679F;
            this.Type.HeaderText = "性质";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Company
            // 
            this.Company.DataPropertyName = "gridColumnCompany";
            this.Company.FillWeight = 203.0457F;
            this.Company.HeaderText = "工作单位";
            this.Company.Name = "Company";
            this.Company.ReadOnly = true;
            this.Company.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // City
            // 
            this.City.DataPropertyName = "gridColumnCity";
            this.City.FillWeight = 101.2679F;
            this.City.HeaderText = "地区";
            this.City.Name = "City";
            this.City.ReadOnly = true;
            this.City.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Level
            // 
            this.Level.DataPropertyName = "gridColumnLevel";
            this.Level.FillWeight = 101.2679F;
            this.Level.HeaderText = "级别";
            this.Level.Name = "Level";
            this.Level.ReadOnly = true;
            this.Level.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Employee
            // 
            this.Employee.DataPropertyName = "EmployeeName";
            this.Employee.FillWeight = 101.2679F;
            this.Employee.HeaderText = "商务部";
            this.Employee.Name = "Employee";
            this.Employee.ReadOnly = true;
            this.Employee.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // InformationAssistantList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_Main);
            this.Name = "InformationAssistantList";
            this.Size = new System.Drawing.Size(945, 562);
            this.Load += new System.EventHandler(this.DeletedInformationAssistant_Load);
            this.panel_Main.ResumeLayout(false);
            this.pHeader.ResumeLayout(false);
            this.pHeader.PerformLayout();
            this.pFooter.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgIAList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Main;
        private System.Windows.Forms.Panel pHeader;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pFooter;
        private System.Windows.Forms.Panel pTop;
        private System.Windows.Forms.DataGridView dgIAList;
        private System.Windows.Forms.Panel panel1;
        private PagingControl pagingForIA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.CheckBox ckSelectAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridColumnName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsSelected;
        private System.Windows.Forms.DataGridViewTextBoxColumn SerialNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn IAName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Company;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn Level;
        private System.Windows.Forms.DataGridViewTextBoxColumn Employee;
    }
}
