namespace DataBrokerCleaning
{
    partial class CompanyIntroData
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDomain = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnShowDetail = new System.Windows.Forms.Button();
            this.dataGridViewData = new System.Windows.Forms.DataGridView();
            this.dataBrokerDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataBrokerDatabaseDataSet = new DataBrokerCleaning.DataBrokerDatabaseDataSet();
            this.dataBrokerDetailsTableAdapter = new DataBrokerCleaning.DataBrokerDatabaseDataSetTableAdapters.DataBrokerDetailsTableAdapter();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.domainDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumbersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyDomainDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyFoundedYearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyLogoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyTickerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBrokerDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBrokerDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Domain";
            // 
            // txtDomain
            // 
            this.txtDomain.Location = new System.Drawing.Point(117, 44);
            this.txtDomain.Margin = new System.Windows.Forms.Padding(4);
            this.txtDomain.Name = "txtDomain";
            this.txtDomain.Size = new System.Drawing.Size(185, 22);
            this.txtDomain.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(355, 44);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Company Name";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(573, 47);
            this.txtCompanyName.Margin = new System.Windows.Forms.Padding(4);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(185, 22);
            this.txtCompanyName.TabIndex = 5;
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address.Location = new System.Drawing.Point(843, 47);
            this.Address.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(92, 25);
            this.Address.TabIndex = 6;
            this.Address.Text = "Address";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(1089, 49);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(185, 22);
            this.txtAddress.TabIndex = 7;
            // 
            // Search
            // 
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(1348, 36);
            this.Search.Margin = new System.Windows.Forms.Padding(4);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(120, 42);
            this.Search.TabIndex = 8;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.Address);
            this.panel1.Controls.Add(this.Search);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.txtDomain);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtCompanyName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1864, 123);
            this.panel1.TabIndex = 9;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(1508, 36);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 42);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.dataGridViewData);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 123);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1864, 327);
            this.panel2.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnShowDetail);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 279);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1864, 48);
            this.panel3.TabIndex = 2;
            // 
            // btnShowDetail
            // 
            this.btnShowDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowDetail.Location = new System.Drawing.Point(573, 6);
            this.btnShowDetail.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowDetail.Name = "btnShowDetail";
            this.btnShowDetail.Size = new System.Drawing.Size(561, 42);
            this.btnShowDetail.TabIndex = 9;
            this.btnShowDetail.Text = "Check Detail Of Selected Row from Grid";
            this.btnShowDetail.UseVisualStyleBackColor = true;
            this.btnShowDetail.Click += new System.EventHandler(this.btnShowDetail_Click);
            // 
            // dataGridViewData
            // 
            this.dataGridViewData.AllowUserToOrderColumns = true;
            this.dataGridViewData.AutoGenerateColumns = false;
            this.dataGridViewData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewData.ColumnHeadersHeight = 29;
            this.dataGridViewData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.domainDataGridViewTextBoxColumn,
            this.emailsDataGridViewTextBoxColumn,
            this.companyNameDataGridViewTextBoxColumn,
            this.phoneNumbersDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.companyDomainDataGridViewTextBoxColumn,
            this.companyFoundedYearDataGridViewTextBoxColumn,
            this.companyLogoDataGridViewTextBoxColumn,
            this.companyTypeDataGridViewTextBoxColumn,
            this.companyTickerDataGridViewTextBoxColumn});
            this.dataGridViewData.DataSource = this.dataBrokerDetailsBindingSource;
            this.dataGridViewData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewData.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewData.Name = "dataGridViewData";
            this.dataGridViewData.RowHeadersWidth = 51;
            this.dataGridViewData.RowTemplate.Height = 24;
            this.dataGridViewData.Size = new System.Drawing.Size(1864, 327);
            this.dataGridViewData.TabIndex = 1;
            // 
            // dataBrokerDetailsBindingSource
            // 
            this.dataBrokerDetailsBindingSource.DataMember = "DataBrokerDetails";
            this.dataBrokerDetailsBindingSource.DataSource = this.dataBrokerDatabaseDataSet;
            // 
            // dataBrokerDatabaseDataSet
            // 
            this.dataBrokerDatabaseDataSet.DataSetName = "DataBrokerDatabaseDataSet";
            this.dataBrokerDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataBrokerDetailsTableAdapter
            // 
            this.dataBrokerDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // domainDataGridViewTextBoxColumn
            // 
            this.domainDataGridViewTextBoxColumn.DataPropertyName = "Domain";
            this.domainDataGridViewTextBoxColumn.HeaderText = "Domain";
            this.domainDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.domainDataGridViewTextBoxColumn.Name = "domainDataGridViewTextBoxColumn";
            // 
            // emailsDataGridViewTextBoxColumn
            // 
            this.emailsDataGridViewTextBoxColumn.DataPropertyName = "Emails";
            this.emailsDataGridViewTextBoxColumn.HeaderText = "Emails";
            this.emailsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailsDataGridViewTextBoxColumn.Name = "emailsDataGridViewTextBoxColumn";
            // 
            // companyNameDataGridViewTextBoxColumn
            // 
            this.companyNameDataGridViewTextBoxColumn.DataPropertyName = "Company Name";
            this.companyNameDataGridViewTextBoxColumn.HeaderText = "Company Name";
            this.companyNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.companyNameDataGridViewTextBoxColumn.Name = "companyNameDataGridViewTextBoxColumn";
            // 
            // phoneNumbersDataGridViewTextBoxColumn
            // 
            this.phoneNumbersDataGridViewTextBoxColumn.DataPropertyName = "Phone Numbers";
            this.phoneNumbersDataGridViewTextBoxColumn.HeaderText = "Phone Numbers";
            this.phoneNumbersDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneNumbersDataGridViewTextBoxColumn.Name = "phoneNumbersDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // companyDomainDataGridViewTextBoxColumn
            // 
            this.companyDomainDataGridViewTextBoxColumn.DataPropertyName = "Company Domain";
            this.companyDomainDataGridViewTextBoxColumn.HeaderText = "Company Domain";
            this.companyDomainDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.companyDomainDataGridViewTextBoxColumn.Name = "companyDomainDataGridViewTextBoxColumn";
            // 
            // companyFoundedYearDataGridViewTextBoxColumn
            // 
            this.companyFoundedYearDataGridViewTextBoxColumn.DataPropertyName = "Company Founded Year";
            this.companyFoundedYearDataGridViewTextBoxColumn.HeaderText = "Company Founded Year";
            this.companyFoundedYearDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.companyFoundedYearDataGridViewTextBoxColumn.Name = "companyFoundedYearDataGridViewTextBoxColumn";
            // 
            // companyLogoDataGridViewTextBoxColumn
            // 
            this.companyLogoDataGridViewTextBoxColumn.DataPropertyName = "Company Logo";
            this.companyLogoDataGridViewTextBoxColumn.HeaderText = "Company Logo";
            this.companyLogoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.companyLogoDataGridViewTextBoxColumn.Name = "companyLogoDataGridViewTextBoxColumn";
            // 
            // companyTypeDataGridViewTextBoxColumn
            // 
            this.companyTypeDataGridViewTextBoxColumn.DataPropertyName = "Company Type";
            this.companyTypeDataGridViewTextBoxColumn.HeaderText = "Company Type";
            this.companyTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.companyTypeDataGridViewTextBoxColumn.Name = "companyTypeDataGridViewTextBoxColumn";
            // 
            // companyTickerDataGridViewTextBoxColumn
            // 
            this.companyTickerDataGridViewTextBoxColumn.DataPropertyName = "Company Ticker";
            this.companyTickerDataGridViewTextBoxColumn.HeaderText = "Company Ticker";
            this.companyTickerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.companyTickerDataGridViewTextBoxColumn.Name = "companyTickerDataGridViewTextBoxColumn";
            // 
            // LoadGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1864, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LoadGrid";
            this.Text = "Entery Search Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBrokerDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBrokerDatabaseDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DataBrokerDatabaseDataSet dataBrokerDatabaseDataSet;
        private System.Windows.Forms.BindingSource dataBrokerDetailsBindingSource;
        private DataBrokerDatabaseDataSetTableAdapters.DataBrokerDetailsTableAdapter dataBrokerDetailsTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDomain;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dataGridViewData;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnShowDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn domainDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumbersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyDomainDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyFoundedYearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyLogoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyTickerDataGridViewTextBoxColumn;
    }
}

