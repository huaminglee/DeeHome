namespace DiHaoOA.WinForm.Controls
{
    partial class AllListForMarketing
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_Main = new System.Windows.Forms.Panel();
            this.pHeader = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pFooter = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGoForward = new System.Windows.Forms.Button();
            this.txtPage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrevPage = new System.Windows.Forms.Button();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.btnLastPage = new System.Windows.Forms.Button();
            this.btnFirstPage = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCurrentRecord = new System.Windows.Forms.Label();
            this.lblRecord = new System.Windows.Forms.Label();
            this.pTop = new System.Windows.Forms.Panel();
            this.dgAllListForManager = new System.Windows.Forms.DataGridView();
            this.gridColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsSelected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.SerialNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IAName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Employee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_Main.SuspendLayout();
            this.pHeader.SuspendLayout();
            this.pFooter.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAllListForManager)).BeginInit();
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
            this.panel_Main.TabIndex = 0;
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
            this.button1.Location = new System.Drawing.Point(0, 2);
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
            this.pFooter.Controls.Add(this.panel1);
            this.pFooter.Controls.Add(this.panel2);
            this.pFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pFooter.Location = new System.Drawing.Point(0, 471);
            this.pFooter.Name = "pFooter";
            this.pFooter.Size = new System.Drawing.Size(945, 91);
            this.pFooter.TabIndex = 2;
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
            this.panel1.Location = new System.Drawing.Point(578, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(367, 91);
            this.panel1.TabIndex = 9;
            // 
            // btnGoForward
            // 
            this.btnGoForward.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btnGoForward.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGoForward.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(102)))), ((int)(((byte)(124)))));
            this.btnGoForward.Location = new System.Drawing.Point(320, 56);
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
            this.txtPage.Location = new System.Drawing.Point(277, 56);
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
            this.label1.Location = new System.Drawing.Point(242, 61);
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
            this.btnPrevPage.Location = new System.Drawing.Point(74, 56);
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
            this.btnNextPage.Location = new System.Drawing.Point(131, 56);
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
            this.btnLastPage.Location = new System.Drawing.Point(188, 56);
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
            this.btnFirstPage.Location = new System.Drawing.Point(22, 56);
            this.btnFirstPage.Margin = new System.Windows.Forms.Padding(2);
            this.btnFirstPage.Name = "btnFirstPage";
            this.btnFirstPage.Size = new System.Drawing.Size(48, 22);
            this.btnFirstPage.TabIndex = 5;
            this.btnFirstPage.Text = "首页";
            this.btnFirstPage.UseVisualStyleBackColor = false;
            this.btnFirstPage.Click += new System.EventHandler(this.btnFirstPage_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnModify);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lblCurrentRecord);
            this.panel2.Controls.Add(this.lblRecord);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(295, 91);
            this.panel2.TabIndex = 8;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(102)))), ((int)(((byte)(124)))));
            this.btnDelete.Location = new System.Drawing.Point(183, 14);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(48, 22);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnModify
            // 
            this.btnModify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btnModify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModify.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(102)))), ((int)(((byte)(124)))));
            this.btnModify.Location = new System.Drawing.Point(131, 14);
            this.btnModify.Margin = new System.Windows.Forms.Padding(2);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(48, 22);
            this.btnModify.TabIndex = 6;
            this.btnModify.Text = "修改";
            this.btnModify.UseVisualStyleBackColor = false;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(102)))), ((int)(((byte)(124)))));
            this.label2.Location = new System.Drawing.Point(12, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "修改选中信息员隶属";
            // 
            // lblCurrentRecord
            // 
            this.lblCurrentRecord.AutoSize = true;
            this.lblCurrentRecord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(102)))), ((int)(((byte)(124)))));
            this.lblCurrentRecord.Location = new System.Drawing.Point(128, 65);
            this.lblCurrentRecord.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurrentRecord.Name = "lblCurrentRecord";
            this.lblCurrentRecord.Size = new System.Drawing.Size(72, 13);
            this.lblCurrentRecord.TabIndex = 4;
            this.lblCurrentRecord.Text = "当前是1/1页";
            // 
            // lblRecord
            // 
            this.lblRecord.AutoSize = true;
            this.lblRecord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(102)))), ((int)(((byte)(124)))));
            this.lblRecord.Location = new System.Drawing.Point(12, 65);
            this.lblRecord.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(61, 13);
            this.lblRecord.TabIndex = 4;
            this.lblRecord.Text = "共1条记录";
            // 
            // pTop
            // 
            this.pTop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pTop.BackColor = System.Drawing.Color.White;
            this.pTop.Controls.Add(this.dgAllListForManager);
            this.pTop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(113)))), ((int)(((byte)(133)))));
            this.pTop.Location = new System.Drawing.Point(0, 36);
            this.pTop.Name = "pTop";
            this.pTop.Size = new System.Drawing.Size(945, 444);
            this.pTop.TabIndex = 1;
            // 
            // dgAllListForManager
            // 
            this.dgAllListForManager.AllowUserToAddRows = false;
            this.dgAllListForManager.AllowUserToDeleteRows = false;
            this.dgAllListForManager.AllowUserToResizeColumns = false;
            this.dgAllListForManager.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(232)))), ((int)(((byte)(241)))));
            this.dgAllListForManager.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgAllListForManager.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgAllListForManager.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgAllListForManager.BackgroundColor = System.Drawing.Color.White;
            this.dgAllListForManager.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgAllListForManager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAllListForManager.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gridColumnName,
            this.IsSelected,
            this.SerialNumber,
            this.IAName,
            this.Type,
            this.Company,
            this.City,
            this.Level,
            this.Employee});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(113)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgAllListForManager.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgAllListForManager.Location = new System.Drawing.Point(0, 0);
            this.dgAllListForManager.Name = "dgAllListForManager";
            this.dgAllListForManager.RowHeadersVisible = false;
            this.dgAllListForManager.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgAllListForManager.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgAllListForManager.Size = new System.Drawing.Size(945, 444);
            this.dgAllListForManager.TabIndex = 0;
            this.dgAllListForManager.VirtualMode = true;
            this.dgAllListForManager.CellValueNeeded += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.dgAllListForManager_CellValueNeeded);
            this.dgAllListForManager.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgAllListForManager_CurrentCellDirtyStateChanged);
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
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle11.NullValue = false;
            this.IsSelected.DefaultCellStyle = dataGridViewCellStyle11;
            this.IsSelected.FalseValue = "False";
            this.IsSelected.FillWeight = 29.20666F;
            this.IsSelected.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.IsSelected.HeaderText = "";
            this.IsSelected.Name = "IsSelected";
            this.IsSelected.TrueValue = "True";
            // 
            // SerialNumber
            // 
            this.SerialNumber.FillWeight = 40.60914F;
            this.SerialNumber.HeaderText = "序号";
            this.SerialNumber.Name = "SerialNumber";
            this.SerialNumber.ReadOnly = true;
            this.SerialNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // IAName
            // 
            this.IAName.DataPropertyName = "gridColumnInformationAssistant";
            this.IAName.FillWeight = 78.0235F;
            this.IAName.HeaderText = "姓名";
            this.IAName.Name = "IAName";
            this.IAName.ReadOnly = true;
            this.IAName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Type
            // 
            this.Type.DataPropertyName = "gridColumnType";
            this.Type.FillWeight = 78.0235F;
            this.Type.HeaderText = "性质";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Company
            // 
            this.Company.DataPropertyName = "gridColumnCompany";
            this.Company.FillWeight = 340.0667F;
            this.Company.HeaderText = "工作单位";
            this.Company.Name = "Company";
            this.Company.ReadOnly = true;
            this.Company.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // City
            // 
            this.City.DataPropertyName = "gridColumnCity";
            this.City.FillWeight = 78.0235F;
            this.City.HeaderText = "地区";
            this.City.Name = "City";
            this.City.ReadOnly = true;
            this.City.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Level
            // 
            this.Level.DataPropertyName = "gridColumnLevel";
            this.Level.FillWeight = 78.0235F;
            this.Level.HeaderText = "级别";
            this.Level.Name = "Level";
            this.Level.ReadOnly = true;
            this.Level.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Employee
            // 
            this.Employee.DataPropertyName = "EmployeeName";
            this.Employee.FillWeight = 78.0235F;
            this.Employee.HeaderText = "商务部";
            this.Employee.Name = "Employee";
            this.Employee.ReadOnly = true;
            this.Employee.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // AllListForMarketing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_Main);
            this.Name = "AllListForMarketing";
            this.Size = new System.Drawing.Size(945, 562);
            this.Load += new System.EventHandler(this.AllListForManager_Load);
            this.panel_Main.ResumeLayout(false);
            this.pHeader.ResumeLayout(false);
            this.pHeader.PerformLayout();
            this.pFooter.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgAllListForManager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Main;
        private System.Windows.Forms.Panel pTop;
        private System.Windows.Forms.Panel pFooter;
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
        private System.Windows.Forms.DataGridView dgAllListForManager;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Panel pHeader;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridColumnName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsSelected;
        private System.Windows.Forms.DataGridViewTextBoxColumn SerialNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn IAName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Company;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn Level;
        private System.Windows.Forms.DataGridViewTextBoxColumn Employee;
    }
}
