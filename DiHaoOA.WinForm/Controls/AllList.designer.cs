namespace DiHaoOA.Controls
{
    partial class AllList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.allListMainpanel = new System.Windows.Forms.Panel();
            this.pFooter = new System.Windows.Forms.Panel();
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
            this.pContent = new System.Windows.Forms.Panel();
            this.gridAllList = new System.Windows.Forms.DataGridView();
            this.PrimaryKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serialNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridColumnName = new System.Windows.Forms.DataGridViewLinkColumn();
            this.gridColumnPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridColumnType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridColumnCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridColumnCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridColumnLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridColumnInformationAssistant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridColumnleftRevisitTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pHeader = new System.Windows.Forms.Panel();
            this.pHeaderRight = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSeniorSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pHeaderLeft = new System.Windows.Forms.Panel();
            this.btnAllList = new System.Windows.Forms.Button();
            this.allListMainpanel.SuspendLayout();
            this.pFooter.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAllList)).BeginInit();
            this.pHeader.SuspendLayout();
            this.pHeaderRight.SuspendLayout();
            this.pHeaderLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // allListMainpanel
            // 
            this.allListMainpanel.BackColor = System.Drawing.Color.White;
            this.allListMainpanel.Controls.Add(this.pFooter);
            this.allListMainpanel.Controls.Add(this.pContent);
            this.allListMainpanel.Controls.Add(this.pHeader);
            this.allListMainpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.allListMainpanel.Location = new System.Drawing.Point(0, 0);
            this.allListMainpanel.Margin = new System.Windows.Forms.Padding(2);
            this.allListMainpanel.Name = "allListMainpanel";
            this.allListMainpanel.Size = new System.Drawing.Size(1045, 384);
            this.allListMainpanel.TabIndex = 6;
            // 
            // pFooter
            // 
            this.pFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(232)))), ((int)(((byte)(241)))));
            this.pFooter.Controls.Add(this.panel2);
            this.pFooter.Controls.Add(this.panel1);
            this.pFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pFooter.Location = new System.Drawing.Point(0, 326);
            this.pFooter.Margin = new System.Windows.Forms.Padding(2);
            this.pFooter.Name = "pFooter";
            this.pFooter.Size = new System.Drawing.Size(1045, 58);
            this.pFooter.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblCurrentRecord);
            this.panel2.Controls.Add(this.lblRecord);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(232, 58);
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
            this.lblCurrentRecord.Text = "当前是1/1页";
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
            this.lblRecord.Text = "共1条记录";
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
            this.panel1.Location = new System.Drawing.Point(678, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(367, 58);
            this.panel1.TabIndex = 6;
            // 
            // btnGoForward
            // 
            this.btnGoForward.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btnGoForward.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGoForward.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(102)))), ((int)(((byte)(124)))));
            this.btnGoForward.Location = new System.Drawing.Point(320, 10);
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
            this.txtPage.Location = new System.Drawing.Point(273, 12);
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
            this.label1.Location = new System.Drawing.Point(238, 17);
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
            this.btnPrevPage.Location = new System.Drawing.Point(74, 12);
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
            this.btnNextPage.Location = new System.Drawing.Point(136, 12);
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
            this.btnLastPage.Location = new System.Drawing.Point(193, 12);
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
            this.btnFirstPage.Location = new System.Drawing.Point(22, 12);
            this.btnFirstPage.Margin = new System.Windows.Forms.Padding(2);
            this.btnFirstPage.Name = "btnFirstPage";
            this.btnFirstPage.Size = new System.Drawing.Size(48, 22);
            this.btnFirstPage.TabIndex = 5;
            this.btnFirstPage.Text = "首页";
            this.btnFirstPage.UseVisualStyleBackColor = false;
            this.btnFirstPage.Click += new System.EventHandler(this.btnFirstPage_Click);
            // 
            // pContent
            // 
            this.pContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pContent.Controls.Add(this.gridAllList);
            this.pContent.Location = new System.Drawing.Point(0, 35);
            this.pContent.Margin = new System.Windows.Forms.Padding(2);
            this.pContent.Name = "pContent";
            this.pContent.Size = new System.Drawing.Size(1045, 287);
            this.pContent.TabIndex = 1;
            // 
            // gridAllList
            // 
            this.gridAllList.AllowUserToAddRows = false;
            this.gridAllList.AllowUserToDeleteRows = false;
            this.gridAllList.AllowUserToResizeColumns = false;
            this.gridAllList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(232)))), ((int)(((byte)(241)))));
            this.gridAllList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridAllList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridAllList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridAllList.BackgroundColor = System.Drawing.Color.White;
            this.gridAllList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridAllList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridAllList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PrimaryKey,
            this.serialNumber,
            this.gridColumnName,
            this.gridColumnPhone,
            this.gridColumnType,
            this.gridColumnCompany,
            this.gridColumnCity,
            this.gridColumnLevel,
            this.gridColumnInformationAssistant,
            this.gridColumnleftRevisitTime});
            this.gridAllList.Location = new System.Drawing.Point(0, 0);
            this.gridAllList.Margin = new System.Windows.Forms.Padding(2);
            this.gridAllList.MultiSelect = false;
            this.gridAllList.Name = "gridAllList";
            this.gridAllList.RowHeadersVisible = false;
            this.gridAllList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridAllList.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.gridAllList.RowTemplate.Height = 24;
            this.gridAllList.Size = new System.Drawing.Size(1045, 287);
            this.gridAllList.TabIndex = 3;
            this.gridAllList.VirtualMode = true;
            this.gridAllList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridAllList_CellContentClick);
            this.gridAllList.CellValueNeeded += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.gridAllList_CellValueNeeded);
            // 
            // PrimaryKey
            // 
            this.PrimaryKey.DataPropertyName = "gridColumnIndex";
            this.PrimaryKey.HeaderText = "allListPrimaryKey";
            this.PrimaryKey.Name = "PrimaryKey";
            this.PrimaryKey.ReadOnly = true;
            this.PrimaryKey.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PrimaryKey.Visible = false;
            // 
            // serialNumber
            // 
            this.serialNumber.DataPropertyName = "serialNumber";
            this.serialNumber.FillWeight = 38.67954F;
            this.serialNumber.HeaderText = "序号";
            this.serialNumber.Name = "serialNumber";
            this.serialNumber.ReadOnly = true;
            this.serialNumber.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.serialNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // gridColumnName
            // 
            this.gridColumnName.DataPropertyName = "gridColumnName";
            this.gridColumnName.FillWeight = 90.41344F;
            this.gridColumnName.HeaderText = "姓名";
            this.gridColumnName.Name = "gridColumnName";
            this.gridColumnName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // gridColumnPhone
            // 
            this.gridColumnPhone.DataPropertyName = "gridColumnPhone";
            this.gridColumnPhone.FillWeight = 90.41344F;
            this.gridColumnPhone.HeaderText = "电话";
            this.gridColumnPhone.Name = "gridColumnPhone";
            this.gridColumnPhone.ReadOnly = true;
            this.gridColumnPhone.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gridColumnPhone.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // gridColumnType
            // 
            this.gridColumnType.DataPropertyName = "gridColumnType";
            this.gridColumnType.FillWeight = 90.41344F;
            this.gridColumnType.HeaderText = "性质";
            this.gridColumnType.Name = "gridColumnType";
            this.gridColumnType.ReadOnly = true;
            this.gridColumnType.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gridColumnType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // gridColumnCompany
            // 
            this.gridColumnCompany.DataPropertyName = "gridColumnCompany";
            this.gridColumnCompany.FillWeight = 228.4264F;
            this.gridColumnCompany.HeaderText = "工作单位";
            this.gridColumnCompany.Name = "gridColumnCompany";
            this.gridColumnCompany.ReadOnly = true;
            this.gridColumnCompany.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gridColumnCompany.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // gridColumnCity
            // 
            this.gridColumnCity.DataPropertyName = "gridColumnCity";
            this.gridColumnCity.FillWeight = 90.41344F;
            this.gridColumnCity.HeaderText = "地区";
            this.gridColumnCity.Name = "gridColumnCity";
            this.gridColumnCity.ReadOnly = true;
            this.gridColumnCity.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gridColumnCity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // gridColumnLevel
            // 
            this.gridColumnLevel.DataPropertyName = "gridColumnLevel";
            this.gridColumnLevel.FillWeight = 90.41344F;
            this.gridColumnLevel.HeaderText = "级别";
            this.gridColumnLevel.Name = "gridColumnLevel";
            this.gridColumnLevel.ReadOnly = true;
            this.gridColumnLevel.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gridColumnLevel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // gridColumnInformationAssistant
            // 
            this.gridColumnInformationAssistant.DataPropertyName = "EmployeeName";
            this.gridColumnInformationAssistant.FillWeight = 90.41344F;
            this.gridColumnInformationAssistant.HeaderText = "商务部";
            this.gridColumnInformationAssistant.Name = "gridColumnInformationAssistant";
            this.gridColumnInformationAssistant.ReadOnly = true;
            this.gridColumnInformationAssistant.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gridColumnInformationAssistant.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // gridColumnleftRevisitTime
            // 
            this.gridColumnleftRevisitTime.FillWeight = 90.41344F;
            this.gridColumnleftRevisitTime.HeaderText = "剩余回访时间";
            this.gridColumnleftRevisitTime.Name = "gridColumnleftRevisitTime";
            this.gridColumnleftRevisitTime.ReadOnly = true;
            this.gridColumnleftRevisitTime.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gridColumnleftRevisitTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // pHeader
            // 
            this.pHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(232)))), ((int)(((byte)(241)))));
            this.pHeader.Controls.Add(this.pHeaderRight);
            this.pHeader.Controls.Add(this.pHeaderLeft);
            this.pHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pHeader.Location = new System.Drawing.Point(0, 0);
            this.pHeader.Margin = new System.Windows.Forms.Padding(2);
            this.pHeader.Name = "pHeader";
            this.pHeader.Size = new System.Drawing.Size(1045, 35);
            this.pHeader.TabIndex = 0;
            // 
            // pHeaderRight
            // 
            this.pHeaderRight.Controls.Add(this.btnAdd);
            this.pHeaderRight.Controls.Add(this.btnSeniorSearch);
            this.pHeaderRight.Controls.Add(this.txtSearch);
            this.pHeaderRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pHeaderRight.Location = new System.Drawing.Point(752, 0);
            this.pHeaderRight.Margin = new System.Windows.Forms.Padding(2);
            this.pHeaderRight.Name = "pHeaderRight";
            this.pHeaderRight.Size = new System.Drawing.Size(293, 35);
            this.pHeaderRight.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(102)))), ((int)(((byte)(124)))));
            this.btnAdd.Location = new System.Drawing.Point(235, 5);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(55, 24);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSeniorSearch
            // 
            this.btnSeniorSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btnSeniorSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeniorSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSeniorSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(102)))), ((int)(((byte)(124)))));
            this.btnSeniorSearch.Location = new System.Drawing.Point(173, 5);
            this.btnSeniorSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSeniorSearch.Name = "btnSeniorSearch";
            this.btnSeniorSearch.Size = new System.Drawing.Size(55, 24);
            this.btnSeniorSearch.TabIndex = 2;
            this.btnSeniorSearch.Text = "搜索";
            this.btnSeniorSearch.UseVisualStyleBackColor = false;
            this.btnSeniorSearch.Click += new System.EventHandler(this.btnSeniorSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Location = new System.Drawing.Point(35, 6);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(138, 22);
            this.txtSearch.TabIndex = 1;
            // 
            // pHeaderLeft
            // 
            this.pHeaderLeft.Controls.Add(this.btnAllList);
            this.pHeaderLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pHeaderLeft.Location = new System.Drawing.Point(0, 0);
            this.pHeaderLeft.Margin = new System.Windows.Forms.Padding(2);
            this.pHeaderLeft.Name = "pHeaderLeft";
            this.pHeaderLeft.Size = new System.Drawing.Size(150, 35);
            this.pHeaderLeft.TabIndex = 3;
            // 
            // btnAllList
            // 
            this.btnAllList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btnAllList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAllList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(102)))), ((int)(((byte)(124)))));
            this.btnAllList.Location = new System.Drawing.Point(0, 1);
            this.btnAllList.Margin = new System.Windows.Forms.Padding(2);
            this.btnAllList.Name = "btnAllList";
            this.btnAllList.Size = new System.Drawing.Size(84, 30);
            this.btnAllList.TabIndex = 0;
            this.btnAllList.Text = "全部列表";
            this.btnAllList.UseVisualStyleBackColor = false;
            // 
            // AllList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.allListMainpanel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(113)))), ((int)(((byte)(133)))));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AllList";
            this.Size = new System.Drawing.Size(1045, 384);
            this.Load += new System.EventHandler(this.AllList_Load);
            this.allListMainpanel.ResumeLayout(false);
            this.pFooter.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridAllList)).EndInit();
            this.pHeader.ResumeLayout(false);
            this.pHeaderRight.ResumeLayout(false);
            this.pHeaderRight.PerformLayout();
            this.pHeaderLeft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAllList;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSeniorSearch;
        private System.Windows.Forms.DataGridView gridAllList;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel allListMainpanel;
        private System.Windows.Forms.Panel pHeader;
        private System.Windows.Forms.Panel pContent;
        private System.Windows.Forms.Panel pFooter;
        private System.Windows.Forms.Label lblRecord;
        private System.Windows.Forms.Button btnNextPage;
        private System.Windows.Forms.Label lblCurrentRecord;
        private System.Windows.Forms.Button btnPrevPage;
        private System.Windows.Forms.Button btnFirstPage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLastPage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPage;
        private System.Windows.Forms.Button btnGoForward;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pHeaderLeft;
        private System.Windows.Forms.Panel pHeaderRight;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrimaryKey;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialNumber;
        private System.Windows.Forms.DataGridViewLinkColumn gridColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridColumnPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridColumnType;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridColumnCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridColumnCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridColumnLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridColumnInformationAssistant;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridColumnleftRevisitTime;

    }
}
