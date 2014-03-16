namespace DiHaoOA.WinForm.Controls
{
    partial class MyDesigner
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgMyDesigner = new System.Windows.Forms.DataGridView();
            this.gridColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SerialNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DesignerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Employee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoSign = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoPermission = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMyDesigner)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dgMyDesigner);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(533, 308);
            this.panel1.TabIndex = 7;
            // 
            // dgMyDesigner
            // 
            this.dgMyDesigner.AllowUserToAddRows = false;
            this.dgMyDesigner.AllowUserToDeleteRows = false;
            this.dgMyDesigner.AllowUserToResizeColumns = false;
            this.dgMyDesigner.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(232)))), ((int)(((byte)(241)))));
            this.dgMyDesigner.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgMyDesigner.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgMyDesigner.BackgroundColor = System.Drawing.Color.White;
            this.dgMyDesigner.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgMyDesigner.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMyDesigner.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gridColumnName,
            this.SerialNumber,
            this.DesignerName,
            this.Level,
            this.Employee,
            this.NoSign,
            this.NoPermission});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(113)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgMyDesigner.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgMyDesigner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgMyDesigner.Location = new System.Drawing.Point(0, 0);
            this.dgMyDesigner.Name = "dgMyDesigner";
            this.dgMyDesigner.RowHeadersVisible = false;
            this.dgMyDesigner.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgMyDesigner.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgMyDesigner.Size = new System.Drawing.Size(533, 308);
            this.dgMyDesigner.TabIndex = 1;
            this.dgMyDesigner.VirtualMode = true;
            this.dgMyDesigner.CellValueNeeded += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.dgMyDesigner_CellValueNeeded);
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
            this.SerialNumber.HeaderText = "主案部";
            this.SerialNumber.Name = "SerialNumber";
            this.SerialNumber.ReadOnly = true;
            this.SerialNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DesignerName
            // 
            this.DesignerName.DataPropertyName = "DesignerName";
            this.DesignerName.HeaderText = "姓名";
            this.DesignerName.Name = "DesignerName";
            this.DesignerName.ReadOnly = true;
            // 
            // Level
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Level.DefaultCellStyle = dataGridViewCellStyle2;
            this.Level.FillWeight = 95.70717F;
            this.Level.HeaderText = "当月在谈";
            this.Level.Name = "Level";
            this.Level.ReadOnly = true;
            this.Level.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Employee
            // 
            this.Employee.DataPropertyName = "EmployeeName";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Employee.DefaultCellStyle = dataGridViewCellStyle3;
            this.Employee.FillWeight = 95.70717F;
            this.Employee.HeaderText = "当月已签";
            this.Employee.Name = "Employee";
            this.Employee.ReadOnly = true;
            this.Employee.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // NoSign
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.NoSign.DefaultCellStyle = dataGridViewCellStyle4;
            this.NoSign.FillWeight = 122.6646F;
            this.NoSign.HeaderText = "当月未签";
            this.NoSign.Name = "NoSign";
            this.NoSign.ReadOnly = true;
            // 
            // NoPermission
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.NoPermission.DefaultCellStyle = dataGridViewCellStyle5;
            this.NoPermission.FillWeight = 122.6646F;
            this.NoPermission.HeaderText = "当月不准";
            this.NoPermission.Name = "NoPermission";
            this.NoPermission.ReadOnly = true;
            // 
            // MyDesigner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "MyDesigner";
            this.Size = new System.Drawing.Size(533, 308);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgMyDesigner)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgMyDesigner;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SerialNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn DesignerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Level;
        private System.Windows.Forms.DataGridViewTextBoxColumn Employee;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoSign;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoPermission;
    }
}
