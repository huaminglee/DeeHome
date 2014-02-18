namespace DiHaoOA.WinForm.Controls
{
    partial class MySubordinate
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgMySuordinate = new System.Windows.Forms.DataGridView();
            this.gridColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SerialNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VisitCount = new System.Windows.Forms.DataGridViewLinkColumn();
            this.IACount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Employee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoSign = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoPermission = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMySuordinate)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dgMySuordinate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1044, 456);
            this.panel1.TabIndex = 6;
            // 
            // dgMySuordinate
            // 
            this.dgMySuordinate.AllowUserToAddRows = false;
            this.dgMySuordinate.AllowUserToDeleteRows = false;
            this.dgMySuordinate.AllowUserToResizeColumns = false;
            this.dgMySuordinate.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(232)))), ((int)(((byte)(241)))));
            this.dgMySuordinate.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgMySuordinate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgMySuordinate.BackgroundColor = System.Drawing.Color.White;
            this.dgMySuordinate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgMySuordinate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMySuordinate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gridColumnName,
            this.SerialNumber,
            this.EmployeeName,
            this.VisitCount,
            this.IACount,
            this.CustomerCount,
            this.Level,
            this.Employee,
            this.NoSign,
            this.NoPermission});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(113)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgMySuordinate.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgMySuordinate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgMySuordinate.Location = new System.Drawing.Point(0, 0);
            this.dgMySuordinate.Name = "dgMySuordinate";
            this.dgMySuordinate.RowHeadersVisible = false;
            this.dgMySuordinate.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgMySuordinate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgMySuordinate.Size = new System.Drawing.Size(1044, 456);
            this.dgMySuordinate.TabIndex = 1;
            this.dgMySuordinate.VirtualMode = true;
            this.dgMySuordinate.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMySuordinate_CellContentClick);
            this.dgMySuordinate.CellValueNeeded += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.dgIAList_CellValueNeeded);
            // 
            // gridColumnName
            // 
            this.gridColumnName.DataPropertyName = "EmployeeId";
            this.gridColumnName.HeaderText = "PrimarKey";
            this.gridColumnName.Name = "gridColumnName";
            this.gridColumnName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.gridColumnName.Visible = false;
            // 
            // SerialNumber
            // 
            this.SerialNumber.FillWeight = 49.81301F;
            this.SerialNumber.HeaderText = "序号";
            this.SerialNumber.Name = "SerialNumber";
            this.SerialNumber.ReadOnly = true;
            this.SerialNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // EmployeeName
            // 
            this.EmployeeName.DataPropertyName = "Name";
            this.EmployeeName.FillWeight = 95.70717F;
            this.EmployeeName.HeaderText = "姓名";
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.ReadOnly = true;
            this.EmployeeName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // VisitCount
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.VisitCount.DefaultCellStyle = dataGridViewCellStyle2;
            this.VisitCount.FillWeight = 95.70717F;
            this.VisitCount.HeaderText = "当日访问量";
            this.VisitCount.Name = "VisitCount";
            this.VisitCount.ReadOnly = true;
            this.VisitCount.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // IACount
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.IACount.DefaultCellStyle = dataGridViewCellStyle3;
            this.IACount.FillWeight = 197.1154F;
            this.IACount.HeaderText = "当日合作伙伴录入量";
            this.IACount.Name = "IACount";
            this.IACount.ReadOnly = true;
            this.IACount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CustomerCount
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CustomerCount.DefaultCellStyle = dataGridViewCellStyle4;
            this.CustomerCount.FillWeight = 95.70717F;
            this.CustomerCount.HeaderText = "当日客户录入量";
            this.CustomerCount.Name = "CustomerCount";
            this.CustomerCount.ReadOnly = true;
            this.CustomerCount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Level
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Level.DefaultCellStyle = dataGridViewCellStyle5;
            this.Level.FillWeight = 95.70717F;
            this.Level.HeaderText = "当月在谈";
            this.Level.Name = "Level";
            this.Level.ReadOnly = true;
            this.Level.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Employee
            // 
            this.Employee.DataPropertyName = "EmployeeName";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Employee.DefaultCellStyle = dataGridViewCellStyle6;
            this.Employee.FillWeight = 95.70717F;
            this.Employee.HeaderText = "当月已签";
            this.Employee.Name = "Employee";
            this.Employee.ReadOnly = true;
            this.Employee.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // NoSign
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.NoSign.DefaultCellStyle = dataGridViewCellStyle7;
            this.NoSign.FillWeight = 122.6646F;
            this.NoSign.HeaderText = "当月未签";
            this.NoSign.Name = "NoSign";
            this.NoSign.ReadOnly = true;
            // 
            // NoPermission
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.NoPermission.DefaultCellStyle = dataGridViewCellStyle8;
            this.NoPermission.FillWeight = 122.6646F;
            this.NoPermission.HeaderText = "当月不准";
            this.NoPermission.Name = "NoPermission";
            this.NoPermission.ReadOnly = true;
            // 
            // MySubordinate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "MySubordinate";
            this.Size = new System.Drawing.Size(1044, 456);
            this.Load += new System.EventHandler(this.MySubordinate_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgMySuordinate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgMySuordinate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SerialNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeName;
        private System.Windows.Forms.DataGridViewLinkColumn VisitCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn IACount;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Level;
        private System.Windows.Forms.DataGridViewTextBoxColumn Employee;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoSign;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoPermission;
    }
}
