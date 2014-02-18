namespace DiHaoOA.WinForm.Controls
{
    partial class CustomerTrace
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pContent = new System.Windows.Forms.Panel();
            this.pfooter = new System.Windows.Forms.Panel();
            this.pFooterRight = new System.Windows.Forms.Panel();
            this.txtPage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.btnGoforword = new System.Windows.Forms.Button();
            this.btnPrevPage = new System.Windows.Forms.Button();
            this.btnEndPage = new System.Windows.Forms.Button();
            this.btnFirstPage = new System.Windows.Forms.Button();
            this.pFooterLeft = new System.Windows.Forms.Panel();
            this.lblCurrentRecords = new System.Windows.Forms.Label();
            this.lblTotalRecords = new System.Windows.Forms.Label();
            this.orderGrid = new System.Windows.Forms.DataGridView();
            this.OrderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SerialNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaskNumber = new System.Windows.Forms.DataGridViewLinkColumn();
            this.CompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RecordDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DecorateAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InformationAssistant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Designer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalesMan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.District = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pHeader = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pContent.SuspendLayout();
            this.pfooter.SuspendLayout();
            this.pFooterRight.SuspendLayout();
            this.pFooterLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderGrid)).BeginInit();
            this.pHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pContent
            // 
            this.pContent.BackColor = System.Drawing.Color.White;
            this.pContent.Controls.Add(this.pfooter);
            this.pContent.Controls.Add(this.orderGrid);
            this.pContent.Controls.Add(this.pHeader);
            this.pContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(113)))), ((int)(((byte)(133)))));
            this.pContent.Location = new System.Drawing.Point(0, 0);
            this.pContent.Margin = new System.Windows.Forms.Padding(2);
            this.pContent.Name = "pContent";
            this.pContent.Size = new System.Drawing.Size(1045, 500);
            this.pContent.TabIndex = 0;
            // 
            // pfooter
            // 
            this.pfooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(232)))), ((int)(((byte)(241)))));
            this.pfooter.Controls.Add(this.pFooterRight);
            this.pfooter.Controls.Add(this.pFooterLeft);
            this.pfooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pfooter.Location = new System.Drawing.Point(0, 440);
            this.pfooter.Margin = new System.Windows.Forms.Padding(2);
            this.pfooter.Name = "pfooter";
            this.pfooter.Size = new System.Drawing.Size(1045, 60);
            this.pfooter.TabIndex = 2;
            // 
            // pFooterRight
            // 
            this.pFooterRight.Controls.Add(this.txtPage);
            this.pFooterRight.Controls.Add(this.label1);
            this.pFooterRight.Controls.Add(this.btnNextPage);
            this.pFooterRight.Controls.Add(this.btnGoforword);
            this.pFooterRight.Controls.Add(this.btnPrevPage);
            this.pFooterRight.Controls.Add(this.btnEndPage);
            this.pFooterRight.Controls.Add(this.btnFirstPage);
            this.pFooterRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pFooterRight.Location = new System.Drawing.Point(663, 0);
            this.pFooterRight.Margin = new System.Windows.Forms.Padding(2);
            this.pFooterRight.Name = "pFooterRight";
            this.pFooterRight.Size = new System.Drawing.Size(382, 60);
            this.pFooterRight.TabIndex = 1;
            // 
            // txtPage
            // 
            this.txtPage.Location = new System.Drawing.Point(293, 17);
            this.txtPage.Margin = new System.Windows.Forms.Padding(2);
            this.txtPage.Multiline = true;
            this.txtPage.Name = "txtPage";
            this.txtPage.Size = new System.Drawing.Size(32, 20);
            this.txtPage.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(102)))), ((int)(((byte)(124)))));
            this.label1.Location = new System.Drawing.Point(258, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "转到";
            // 
            // btnNextPage
            // 
            this.btnNextPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNextPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(102)))), ((int)(((byte)(124)))));
            this.btnNextPage.Location = new System.Drawing.Point(143, 17);
            this.btnNextPage.Margin = new System.Windows.Forms.Padding(2);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(55, 22);
            this.btnNextPage.TabIndex = 0;
            this.btnNextPage.Text = "下一页";
            this.btnNextPage.UseVisualStyleBackColor = true;
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // btnGoforword
            // 
            this.btnGoforword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGoforword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(102)))), ((int)(((byte)(124)))));
            this.btnGoforword.Location = new System.Drawing.Point(333, 17);
            this.btnGoforword.Margin = new System.Windows.Forms.Padding(2);
            this.btnGoforword.Name = "btnGoforword";
            this.btnGoforword.Size = new System.Drawing.Size(46, 22);
            this.btnGoforword.TabIndex = 0;
            this.btnGoforword.Text = "跳转";
            this.btnGoforword.UseVisualStyleBackColor = true;
            this.btnGoforword.Click += new System.EventHandler(this.btnGoforword_Click);
            // 
            // btnPrevPage
            // 
            this.btnPrevPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrevPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(102)))), ((int)(((byte)(124)))));
            this.btnPrevPage.Location = new System.Drawing.Point(78, 17);
            this.btnPrevPage.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrevPage.Name = "btnPrevPage";
            this.btnPrevPage.Size = new System.Drawing.Size(61, 22);
            this.btnPrevPage.TabIndex = 0;
            this.btnPrevPage.Text = "上一页";
            this.btnPrevPage.UseVisualStyleBackColor = true;
            this.btnPrevPage.Click += new System.EventHandler(this.btnPrevPage_Click);
            // 
            // btnEndPage
            // 
            this.btnEndPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEndPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(102)))), ((int)(((byte)(124)))));
            this.btnEndPage.Location = new System.Drawing.Point(202, 17);
            this.btnEndPage.Margin = new System.Windows.Forms.Padding(2);
            this.btnEndPage.Name = "btnEndPage";
            this.btnEndPage.Size = new System.Drawing.Size(52, 22);
            this.btnEndPage.TabIndex = 0;
            this.btnEndPage.Text = "尾页";
            this.btnEndPage.UseVisualStyleBackColor = true;
            this.btnEndPage.Click += new System.EventHandler(this.btnEndPage_Click);
            // 
            // btnFirstPage
            // 
            this.btnFirstPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFirstPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(102)))), ((int)(((byte)(124)))));
            this.btnFirstPage.Location = new System.Drawing.Point(25, 17);
            this.btnFirstPage.Margin = new System.Windows.Forms.Padding(2);
            this.btnFirstPage.Name = "btnFirstPage";
            this.btnFirstPage.Size = new System.Drawing.Size(49, 22);
            this.btnFirstPage.TabIndex = 0;
            this.btnFirstPage.Text = "首页";
            this.btnFirstPage.UseVisualStyleBackColor = true;
            this.btnFirstPage.Click += new System.EventHandler(this.btnFirstPage_Click);
            // 
            // pFooterLeft
            // 
            this.pFooterLeft.Controls.Add(this.lblCurrentRecords);
            this.pFooterLeft.Controls.Add(this.lblTotalRecords);
            this.pFooterLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pFooterLeft.Location = new System.Drawing.Point(0, 0);
            this.pFooterLeft.Margin = new System.Windows.Forms.Padding(2);
            this.pFooterLeft.Name = "pFooterLeft";
            this.pFooterLeft.Size = new System.Drawing.Size(256, 60);
            this.pFooterLeft.TabIndex = 0;
            // 
            // lblCurrentRecords
            // 
            this.lblCurrentRecords.AutoSize = true;
            this.lblCurrentRecords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(102)))), ((int)(((byte)(124)))));
            this.lblCurrentRecords.Location = new System.Drawing.Point(177, 24);
            this.lblCurrentRecords.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurrentRecords.Name = "lblCurrentRecords";
            this.lblCurrentRecords.Size = new System.Drawing.Size(72, 13);
            this.lblCurrentRecords.TabIndex = 0;
            this.lblCurrentRecords.Text = "当前是1/1页";
            // 
            // lblTotalRecords
            // 
            this.lblTotalRecords.AutoSize = true;
            this.lblTotalRecords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(102)))), ((int)(((byte)(124)))));
            this.lblTotalRecords.Location = new System.Drawing.Point(10, 24);
            this.lblTotalRecords.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalRecords.Name = "lblTotalRecords";
            this.lblTotalRecords.Size = new System.Drawing.Size(61, 13);
            this.lblTotalRecords.TabIndex = 0;
            this.lblTotalRecords.Text = "共1条记录";
            // 
            // orderGrid
            // 
            this.orderGrid.AllowUserToAddRows = false;
            this.orderGrid.AllowUserToDeleteRows = false;
            this.orderGrid.AllowUserToResizeColumns = false;
            this.orderGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(232)))), ((int)(((byte)(241)))));
            this.orderGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.orderGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.orderGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.orderGrid.BackgroundColor = System.Drawing.Color.White;
            this.orderGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.orderGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderId,
            this.SerialNumber,
            this.TaskNumber,
            this.CompanyName,
            this.RecordDate,
            this.DecorateAddress,
            this.InformationAssistant,
            this.Designer,
            this.SalesMan,
            this.District});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(113)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.orderGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.orderGrid.Location = new System.Drawing.Point(0, 35);
            this.orderGrid.Margin = new System.Windows.Forms.Padding(2);
            this.orderGrid.Name = "orderGrid";
            this.orderGrid.RowHeadersVisible = false;
            this.orderGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.orderGrid.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.orderGrid.RowTemplate.Height = 24;
            this.orderGrid.Size = new System.Drawing.Size(1045, 401);
            this.orderGrid.TabIndex = 1;
            this.orderGrid.VirtualMode = true;
            this.orderGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.orderGrid_CellClick);
            this.orderGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.orderGrid_CellContentClick);
            this.orderGrid.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.orderGrid_CellMouseEnter);
            this.orderGrid.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.orderGrid_CellPainting);
            this.orderGrid.CellValueNeeded += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.orderGrid_CellValueNeeded);
            // 
            // OrderId
            // 
            this.OrderId.DataPropertyName = "OrderId";
            this.OrderId.HeaderText = "OrderPrimaryKey";
            this.OrderId.Name = "OrderId";
            this.OrderId.ReadOnly = true;
            this.OrderId.Visible = false;
            // 
            // SerialNumber
            // 
            this.SerialNumber.FillWeight = 37.75307F;
            this.SerialNumber.HeaderText = "序号";
            this.SerialNumber.Name = "SerialNumber";
            this.SerialNumber.ReadOnly = true;
            this.SerialNumber.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.SerialNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TaskNumber
            // 
            this.TaskNumber.DataPropertyName = "orderNumber1";
            this.TaskNumber.FillWeight = 88.2478F;
            this.TaskNumber.HeaderText = "任务单号";
            this.TaskNumber.Name = "TaskNumber";
            this.TaskNumber.ReadOnly = true;
            this.TaskNumber.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // CompanyName
            // 
            this.CompanyName.DataPropertyName = "CompanyName";
            this.CompanyName.FillWeight = 88.2478F;
            this.CompanyName.HeaderText = "公司名称";
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.ReadOnly = true;
            this.CompanyName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CompanyName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // RecordDate
            // 
            this.RecordDate.DataPropertyName = "RecordDate";
            this.RecordDate.FillWeight = 88.2478F;
            this.RecordDate.HeaderText = "录入日期";
            this.RecordDate.Name = "RecordDate";
            this.RecordDate.ReadOnly = true;
            this.RecordDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.RecordDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DecorateAddress
            // 
            this.DecorateAddress.DataPropertyName = "decorateAddress";
            this.DecorateAddress.FillWeight = 287.0748F;
            this.DecorateAddress.HeaderText = "装修地址";
            this.DecorateAddress.Name = "DecorateAddress";
            this.DecorateAddress.ReadOnly = true;
            this.DecorateAddress.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DecorateAddress.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // InformationAssistant
            // 
            this.InformationAssistant.DataPropertyName = "informationAssistantName";
            this.InformationAssistant.FillWeight = 88.2478F;
            this.InformationAssistant.HeaderText = "合作伙伴";
            this.InformationAssistant.Name = "InformationAssistant";
            this.InformationAssistant.ReadOnly = true;
            this.InformationAssistant.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.InformationAssistant.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Designer
            // 
            this.Designer.DataPropertyName = "Designer";
            this.Designer.FillWeight = 88.2478F;
            this.Designer.HeaderText = "设计师";
            this.Designer.Name = "Designer";
            this.Designer.ReadOnly = true;
            this.Designer.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Designer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // SalesMan
            // 
            this.SalesMan.DataPropertyName = "BAName";
            this.SalesMan.FillWeight = 88.2478F;
            this.SalesMan.HeaderText = "商务部";
            this.SalesMan.Name = "SalesMan";
            this.SalesMan.ReadOnly = true;
            this.SalesMan.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.SalesMan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // District
            // 
            this.District.DataPropertyName = "city";
            this.District.FillWeight = 45.68528F;
            this.District.HeaderText = "地区";
            this.District.Name = "District";
            this.District.ReadOnly = true;
            this.District.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.District.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            this.pHeader.Size = new System.Drawing.Size(1045, 35);
            this.pHeader.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(102)))), ((int)(((byte)(124)))));
            this.btnSearch.Location = new System.Drawing.Point(988, 8);
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
            this.txtSearch.Location = new System.Drawing.Point(838, 9);
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
            // CustomerTrace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pContent);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CustomerTrace";
            this.Size = new System.Drawing.Size(1045, 500);
            this.pContent.ResumeLayout(false);
            this.pfooter.ResumeLayout(false);
            this.pFooterRight.ResumeLayout(false);
            this.pFooterRight.PerformLayout();
            this.pFooterLeft.ResumeLayout(false);
            this.pFooterLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderGrid)).EndInit();
            this.pHeader.ResumeLayout(false);
            this.pHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pContent;
        private System.Windows.Forms.Panel pHeader;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView orderGrid;
        private System.Windows.Forms.Panel pfooter;
        private System.Windows.Forms.Panel pFooterLeft;
        private System.Windows.Forms.Panel pFooterRight;
        private System.Windows.Forms.Label lblTotalRecords;
        private System.Windows.Forms.Label lblCurrentRecords;
        private System.Windows.Forms.Button btnFirstPage;
        private System.Windows.Forms.Button btnPrevPage;
        private System.Windows.Forms.Button btnNextPage;
        private System.Windows.Forms.Button btnEndPage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPage;
        private System.Windows.Forms.Button btnGoforword;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SerialNumber;
        private System.Windows.Forms.DataGridViewLinkColumn TaskNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecordDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DecorateAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn InformationAssistant;
        private System.Windows.Forms.DataGridViewTextBoxColumn Designer;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesMan;
        private System.Windows.Forms.DataGridViewTextBoxColumn District;
    }
}
