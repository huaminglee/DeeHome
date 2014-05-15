namespace DiHaoOA.WinForm.Controls
{
    partial class VisitContentForDesigner
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pgDiaplayVisitContent = new DiHaoOA.WinForm.Controls.PagingControl();
            this.btnReturn = new System.Windows.Forms.Button();
            this.dgVisitContent = new System.Windows.Forms.DataGridView();
            this.序号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.回访内容 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.回访时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVisitContent)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pgDiaplayVisitContent);
            this.panel1.Controls.Add(this.btnReturn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 239);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(768, 76);
            this.panel1.TabIndex = 3;
            // 
            // pgDiaplayVisitContent
            // 
            this.pgDiaplayVisitContent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pgDiaplayVisitContent.Location = new System.Drawing.Point(0, 33);
            this.pgDiaplayVisitContent.Name = "pgDiaplayVisitContent";
            this.pgDiaplayVisitContent.Size = new System.Drawing.Size(768, 43);
            this.pgDiaplayVisitContent.TabIndex = 4;
            // 
            // btnReturn
            // 
            this.btnReturn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btnReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnReturn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(102)))), ((int)(((byte)(124)))));
            this.btnReturn.Location = new System.Drawing.Point(700, 6);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(66, 22);
            this.btnReturn.TabIndex = 3;
            this.btnReturn.Text = "返回";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Visible = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // dgVisitContent
            // 
            this.dgVisitContent.AllowUserToAddRows = false;
            this.dgVisitContent.AllowUserToDeleteRows = false;
            this.dgVisitContent.AllowUserToResizeColumns = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(232)))), ((int)(((byte)(241)))));
            this.dgVisitContent.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgVisitContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgVisitContent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgVisitContent.BackgroundColor = System.Drawing.Color.White;
            this.dgVisitContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgVisitContent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgVisitContent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVisitContent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.序号,
            this.回访内容,
            this.回访时间});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(113)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgVisitContent.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgVisitContent.Location = new System.Drawing.Point(0, 0);
            this.dgVisitContent.Name = "dgVisitContent";
            this.dgVisitContent.RowHeadersVisible = false;
            this.dgVisitContent.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgVisitContent.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgVisitContent.Size = new System.Drawing.Size(768, 240);
            this.dgVisitContent.TabIndex = 4;
            this.dgVisitContent.VirtualMode = true;
            this.dgVisitContent.CellValueNeeded += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.dgVisitContent_CellValueNeeded);
            // 
            // 序号
            // 
            this.序号.DataPropertyName = "SerialNumber";
            this.序号.FillWeight = 22.84264F;
            this.序号.HeaderText = "序号";
            this.序号.Name = "序号";
            this.序号.ReadOnly = true;
            this.序号.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.序号.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // 回访内容
            // 
            this.回访内容.DataPropertyName = "RevisitContent";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.回访内容.DefaultCellStyle = dataGridViewCellStyle8;
            this.回访内容.FillWeight = 237.7222F;
            this.回访内容.HeaderText = "回访内容";
            this.回访内容.Name = "回访内容";
            this.回访内容.ReadOnly = true;
            this.回访内容.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.回访内容.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // 回访时间
            // 
            this.回访时间.DataPropertyName = "RevisitTime";
            this.回访时间.FillWeight = 39.4351F;
            this.回访时间.HeaderText = "回访时间";
            this.回访时间.Name = "回访时间";
            this.回访时间.ReadOnly = true;
            this.回访时间.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.回访时间.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // VisitContentForDesigner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgVisitContent);
            this.Controls.Add(this.panel1);
            this.Name = "VisitContentForDesigner";
            this.Size = new System.Drawing.Size(768, 315);
            this.Load += new System.EventHandler(this.VisitContentForDesigner_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgVisitContent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private PagingControl pgDiaplayVisitContent;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.DataGridView dgVisitContent;
        private System.Windows.Forms.DataGridViewTextBoxColumn 序号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 回访内容;
        private System.Windows.Forms.DataGridViewTextBoxColumn 回访时间;
    }
}
