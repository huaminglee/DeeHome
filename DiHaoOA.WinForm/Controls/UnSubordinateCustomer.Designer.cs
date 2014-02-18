namespace DiHaoOA.WinForm.Controls
{
    partial class UnSubordinateCustomer
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
            this.pMainContent = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgUnSubordinateCustomer = new System.Windows.Forms.DataGridView();
            this.CompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactPerson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DecoreateAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pMainContent.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUnSubordinateCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // pMainContent
            // 
            this.pMainContent.Controls.Add(this.tabControl1);
            this.pMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pMainContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(113)))), ((int)(((byte)(133)))));
            this.pMainContent.Location = new System.Drawing.Point(0, 0);
            this.pMainContent.Margin = new System.Windows.Forms.Padding(2);
            this.pMainContent.Name = "pMainContent";
            this.pMainContent.Size = new System.Drawing.Size(907, 318);
            this.pMainContent.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(907, 318);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgUnSubordinateCustomer);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(102)))), ((int)(((byte)(124)))));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(899, 292);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "未隶属客户列表";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgUnSubordinateCustomer
            // 
            this.dgUnSubordinateCustomer.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(232)))), ((int)(((byte)(241)))));
            this.dgUnSubordinateCustomer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgUnSubordinateCustomer.BackgroundColor = System.Drawing.Color.White;
            this.dgUnSubordinateCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUnSubordinateCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CompanyName,
            this.ContactPerson,
            this.ContactPhoneNumber,
            this.City,
            this.Email,
            this.DecoreateAddress,
            this.CustomerType});
            this.dgUnSubordinateCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgUnSubordinateCustomer.Location = new System.Drawing.Point(2, 2);
            this.dgUnSubordinateCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.dgUnSubordinateCustomer.Name = "dgUnSubordinateCustomer";
            this.dgUnSubordinateCustomer.RowTemplate.Height = 24;
            this.dgUnSubordinateCustomer.Size = new System.Drawing.Size(895, 288);
            this.dgUnSubordinateCustomer.TabIndex = 0;
            // 
            // CompanyName
            // 
            this.CompanyName.DataPropertyName = "CompanyName";
            this.CompanyName.HeaderText = "公司名称";
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.ReadOnly = true;
            // 
            // ContactPerson
            // 
            this.ContactPerson.DataPropertyName = "ContactPerson";
            this.ContactPerson.HeaderText = "联系人";
            this.ContactPerson.Name = "ContactPerson";
            this.ContactPerson.ReadOnly = true;
            // 
            // ContactPhoneNumber
            // 
            this.ContactPhoneNumber.DataPropertyName = "ContactPersonNumber";
            this.ContactPhoneNumber.HeaderText = "联系电话";
            this.ContactPhoneNumber.Name = "ContactPhoneNumber";
            this.ContactPhoneNumber.ReadOnly = true;
            // 
            // City
            // 
            this.City.DataPropertyName = "City";
            this.City.HeaderText = "地区";
            this.City.Name = "City";
            this.City.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "电子邮箱";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 150;
            // 
            // DecoreateAddress
            // 
            this.DecoreateAddress.DataPropertyName = "DecorationAddress";
            this.DecoreateAddress.HeaderText = "装修地址";
            this.DecoreateAddress.Name = "DecoreateAddress";
            this.DecoreateAddress.ReadOnly = true;
            this.DecoreateAddress.Width = 200;
            // 
            // CustomerType
            // 
            this.CustomerType.DataPropertyName = "CustomerType";
            this.CustomerType.HeaderText = "客户类型";
            this.CustomerType.Name = "CustomerType";
            this.CustomerType.ReadOnly = true;
            // 
            // UnSubordinateCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.pMainContent);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UnSubordinateCustomer";
            this.Size = new System.Drawing.Size(907, 318);
            this.pMainContent.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgUnSubordinateCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pMainContent;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgUnSubordinateCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactPerson;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactPhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn DecoreateAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerType;
    }
}
