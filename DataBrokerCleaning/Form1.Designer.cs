namespace DataBrokerCleaning
{
    partial class Form1
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
            this.dataBrokerDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataBrokerDatabaseDataSet = new DataBrokerCleaning.DataBrokerDatabaseDataSet();
            this.dataBrokerDetailsTableAdapter = new DataBrokerCleaning.DataBrokerDatabaseDataSetTableAdapters.DataBrokerDetailsTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDomain = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewData = new System.Windows.Forms.DataGridView();
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
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataBrokerDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBrokerDatabaseDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).BeginInit();
            this.SuspendLayout();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Domain";
            // 
            // txtDomain
            // 
            this.txtDomain.Location = new System.Drawing.Point(88, 36);
            this.txtDomain.Name = "txtDomain";
            this.txtDomain.Size = new System.Drawing.Size(140, 20);
            this.txtDomain.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(266, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Company Name";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(430, 38);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(140, 20);
            this.txtCompanyName.TabIndex = 5;
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address.Location = new System.Drawing.Point(632, 38);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(75, 20);
            this.Address.TabIndex = 6;
            this.Address.Text = "Address";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(817, 40);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(140, 20);
            this.txtAddress.TabIndex = 7;
            // 
            // Search
            // 
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(1011, 29);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(90, 34);
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
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1398, 100);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewData);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1398, 266);
            this.panel2.TabIndex = 10;
            // 
            // dataGridViewData
            // 
            this.dataGridViewData.AllowUserToOrderColumns = true;
            this.dataGridViewData.AutoGenerateColumns = false;
            this.dataGridViewData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewData.ColumnHeadersHeight = 29;
            this.dataGridViewData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataGridViewData.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewData.Name = "dataGridViewData";
            this.dataGridViewData.RowHeadersWidth = 51;
            this.dataGridViewData.RowTemplate.Height = 24;
            this.dataGridViewData.Size = new System.Drawing.Size(1398, 266);
            this.dataGridViewData.TabIndex = 1;
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
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(1131, 29);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 34);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1398, 366);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataBrokerDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBrokerDatabaseDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridViewData;
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
        private System.Windows.Forms.Button btnClear;
    }
}

