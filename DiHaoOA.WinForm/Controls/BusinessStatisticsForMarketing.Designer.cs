namespace DiHaoOA.WinForm.Controls
{
    partial class BusinessStatisticsForMarketing
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.OrderList = new System.Windows.Forms.DataGridView();
            this.gridColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nnn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VisitCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IACount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Employee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.OrderList);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(915, 451);
            this.panel1.TabIndex = 7;
            // 
            // OrderList
            // 
            this.OrderList.AllowUserToAddRows = false;
            this.OrderList.AllowUserToDeleteRows = false;
            this.OrderList.AllowUserToResizeColumns = false;
            this.OrderList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(232)))), ((int)(((byte)(241)))));
            this.OrderList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.OrderList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OrderList.BackgroundColor = System.Drawing.Color.White;
            this.OrderList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gridColumnName,
            this.EmployeeName,
            this.nnn,
            this.VisitCount,
            this.IACount,
            this.CustomerCount,
            this.Level,
            this.Employee});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(113)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.OrderList.DefaultCellStyle = dataGridViewCellStyle7;
            this.OrderList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrderList.Location = new System.Drawing.Point(0, 0);
            this.OrderList.Name = "OrderList";
            this.OrderList.RowHeadersVisible = false;
            this.OrderList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.OrderList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.OrderList.Size = new System.Drawing.Size(915, 451);
            this.OrderList.TabIndex = 1;
            this.OrderList.VirtualMode = true;
            this.OrderList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMySuordinate_CellContentClick);
            this.OrderList.CellValueNeeded += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.dgMySuordinate_CellValueNeeded);
            // 
            // gridColumnName
            // 
            this.gridColumnName.DataPropertyName = "EmployeeId";
            this.gridColumnName.HeaderText = "PrimarKey";
            this.gridColumnName.Name = "gridColumnName";
            this.gridColumnName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.gridColumnName.Visible = false;
            // 
            // EmployeeName
            // 
            this.EmployeeName.DataPropertyName = "Name";
            this.EmployeeName.FillWeight = 49.81301F;
            this.EmployeeName.HeaderText = "商务部";
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.ReadOnly = true;
            this.EmployeeName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // nnn
            // 
            this.nnn.FillWeight = 95.70717F;
            this.nnn.HeaderText = "当月量房";
            this.nnn.Name = "nnn";
            this.nnn.ReadOnly = true;
            this.nnn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // VisitCount
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.VisitCount.DefaultCellStyle = dataGridViewCellStyle2;
            this.VisitCount.FillWeight = 95.70717F;
            this.VisitCount.HeaderText = "当月在谈";
            this.VisitCount.Name = "VisitCount";
            this.VisitCount.ReadOnly = true;
            this.VisitCount.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.VisitCount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // IACount
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.IACount.DefaultCellStyle = dataGridViewCellStyle3;
            this.IACount.FillWeight = 197.1154F;
            this.IACount.HeaderText = "当月不准";
            this.IACount.Name = "IACount";
            this.IACount.ReadOnly = true;
            this.IACount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CustomerCount
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CustomerCount.DefaultCellStyle = dataGridViewCellStyle4;
            this.CustomerCount.FillWeight = 95.70717F;
            this.CustomerCount.HeaderText = "当月未签";
            this.CustomerCount.Name = "CustomerCount";
            this.CustomerCount.ReadOnly = true;
            this.CustomerCount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Level
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Level.DefaultCellStyle = dataGridViewCellStyle5;
            this.Level.FillWeight = 95.70717F;
            this.Level.HeaderText = "当月已签";
            this.Level.Name = "Level";
            this.Level.ReadOnly = true;
            this.Level.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Employee
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Employee.DefaultCellStyle = dataGridViewCellStyle6;
            this.Employee.FillWeight = 95.70717F;
            this.Employee.HeaderText = "上月累计本月在谈";
            this.Employee.Name = "Employee";
            this.Employee.ReadOnly = true;
            this.Employee.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // BusinessStatisticsForMarketing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "BusinessStatisticsForMarketing";
            this.Size = new System.Drawing.Size(915, 451);
            this.Load += new System.EventHandler(this.BusinessStatisticsForMarketing_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OrderList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView OrderList;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn nnn;
        private System.Windows.Forms.DataGridViewTextBoxColumn VisitCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn IACount;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Level;
        private System.Windows.Forms.DataGridViewTextBoxColumn Employee;
    }
}
