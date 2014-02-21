namespace DiHaoOA.WinForm.Controls
{
    partial class ApprovalList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pHeader = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pFooter = new System.Windows.Forms.Panel();
            this.pagingForCustomer = new DiHaoOA.WinForm.Controls.PagingControl();
            this.dgApprovalCustomer = new System.Windows.Forms.DataGridView();
            this.OrderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SerialNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RecordDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.decorateAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InformationAssistantName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DesignerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BAName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.city = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pHeader.SuspendLayout();
            this.pFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgApprovalCustomer)).BeginInit();
            this.SuspendLayout();
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
            this.pHeader.Size = new System.Drawing.Size(958, 35);
            this.pHeader.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(102)))), ((int)(((byte)(124)))));
            this.btnSearch.Location = new System.Drawing.Point(900, 8);
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
            this.txtSearch.Location = new System.Drawing.Point(750, 9);
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
            this.button1.Location = new System.Drawing.Point(2, 1);
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
            this.pFooter.Controls.Add(this.pagingForCustomer);
            this.pFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pFooter.Location = new System.Drawing.Point(0, 335);
            this.pFooter.Name = "pFooter";
            this.pFooter.Size = new System.Drawing.Size(958, 85);
            this.pFooter.TabIndex = 6;
            // 
            // pagingForCustomer
            // 
            this.pagingForCustomer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pagingForCustomer.Location = new System.Drawing.Point(0, 30);
            this.pagingForCustomer.Name = "pagingForCustomer";
            this.pagingForCustomer.Size = new System.Drawing.Size(958, 55);
            this.pagingForCustomer.TabIndex = 9;
            // 
            // dgApprovalCustomer
            // 
            this.dgApprovalCustomer.AllowUserToAddRows = false;
            this.dgApprovalCustomer.AllowUserToDeleteRows = false;
            this.dgApprovalCustomer.AllowUserToResizeColumns = false;
            this.dgApprovalCustomer.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(232)))), ((int)(((byte)(241)))));
            this.dgApprovalCustomer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgApprovalCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgApprovalCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgApprovalCustomer.BackgroundColor = System.Drawing.Color.White;
            this.dgApprovalCustomer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgApprovalCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgApprovalCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderId,
            this.SerialNumber,
            this.orderNumber,
            this.CompanyName,
            this.RecordDate,
            this.decorateAddress,
            this.InformationAssistantName,
            this.DesignerName,
            this.BAName,
            this.city});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(113)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgApprovalCustomer.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgApprovalCustomer.Location = new System.Drawing.Point(0, 35);
            this.dgApprovalCustomer.Name = "dgApprovalCustomer";
            this.dgApprovalCustomer.RowHeadersVisible = false;
            this.dgApprovalCustomer.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgApprovalCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgApprovalCustomer.Size = new System.Drawing.Size(958, 332);
            this.dgApprovalCustomer.TabIndex = 7;
            this.dgApprovalCustomer.VirtualMode = true;
            this.dgApprovalCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgApprovalCustomer_CellClick);
            this.dgApprovalCustomer.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgApprovalCustomer_CellMouseEnter);
            this.dgApprovalCustomer.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgApprovalCustomer_CellPainting);
            this.dgApprovalCustomer.CellValueNeeded += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.dgApprovalCustomer_CellValueNeeded);
            // 
            // OrderId
            // 
            this.OrderId.DataPropertyName = "OrderId";
            this.OrderId.HeaderText = "PrimarKey";
            this.OrderId.Name = "OrderId";
            this.OrderId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.OrderId.Visible = false;
            // 
            // SerialNumber
            // 
            this.SerialNumber.FillWeight = 43.42281F;
            this.SerialNumber.HeaderText = "序号";
            this.SerialNumber.Name = "SerialNumber";
            this.SerialNumber.ReadOnly = true;
            this.SerialNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // orderNumber
            // 
            this.orderNumber.DataPropertyName = "orderNumber1";
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red;
            this.orderNumber.DefaultCellStyle = dataGridViewCellStyle2;
            this.orderNumber.FillWeight = 86.69612F;
            this.orderNumber.HeaderText = "任务单号";
            this.orderNumber.Name = "orderNumber";
            this.orderNumber.ReadOnly = true;
            this.orderNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CompanyName
            // 
            this.CompanyName.DataPropertyName = "CompanyName";
            this.CompanyName.FillWeight = 86.69612F;
            this.CompanyName.HeaderText = "公司名称";
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.ReadOnly = true;
            this.CompanyName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // RecordDate
            // 
            this.RecordDate.DataPropertyName = "RecordDate";
            this.RecordDate.FillWeight = 111.8924F;
            this.RecordDate.HeaderText = "录入日期";
            this.RecordDate.Name = "RecordDate";
            this.RecordDate.ReadOnly = true;
            this.RecordDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // decorateAddress
            // 
            this.decorateAddress.DataPropertyName = "decorateAddress";
            this.decorateAddress.FillWeight = 302.1098F;
            this.decorateAddress.HeaderText = "装修地址";
            this.decorateAddress.Name = "decorateAddress";
            this.decorateAddress.ReadOnly = true;
            this.decorateAddress.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // InformationAssistantName
            // 
            this.InformationAssistantName.DataPropertyName = "InformationAssistantName";
            this.InformationAssistantName.FillWeight = 86.69612F;
            this.InformationAssistantName.HeaderText = "合作伙伴";
            this.InformationAssistantName.Name = "InformationAssistantName";
            this.InformationAssistantName.ReadOnly = true;
            this.InformationAssistantName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DesignerName
            // 
            this.DesignerName.DataPropertyName = "DesignerName";
            this.DesignerName.FillWeight = 86.69612F;
            this.DesignerName.HeaderText = "设计师";
            this.DesignerName.Name = "DesignerName";
            this.DesignerName.ReadOnly = true;
            this.DesignerName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // BAName
            // 
            this.BAName.DataPropertyName = "BAName";
            this.BAName.FillWeight = 101.5228F;
            this.BAName.HeaderText = "商务部";
            this.BAName.Name = "BAName";
            this.BAName.ReadOnly = true;
            this.BAName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // city
            // 
            this.city.DataPropertyName = "city";
            this.city.FillWeight = 61.81458F;
            this.city.HeaderText = "地区";
            this.city.Name = "city";
            this.city.ReadOnly = true;
            this.city.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ApprovalList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgApprovalCustomer);
            this.Controls.Add(this.pFooter);
            this.Controls.Add(this.pHeader);
            this.Name = "ApprovalList";
            this.Size = new System.Drawing.Size(958, 420);
            this.Load += new System.EventHandler(this.ApprovalList_Load);
            this.pHeader.ResumeLayout(false);
            this.pHeader.PerformLayout();
            this.pFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgApprovalCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pHeader;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pFooter;
        private PagingControl pagingForCustomer;
        private System.Windows.Forms.DataGridView dgApprovalCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SerialNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecordDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn decorateAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn InformationAssistantName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DesignerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BAName;
        private System.Windows.Forms.DataGridViewTextBoxColumn city;
    }
}
