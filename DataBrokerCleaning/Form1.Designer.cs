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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataBrokerDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataBrokerDatabaseDataSet = new DataBrokerCleaning.DataBrokerDatabaseDataSet();
            this.dataBrokerDetailsTableAdapter = new DataBrokerCleaning.DataBrokerDatabaseDataSetTableAdapters.DataBrokerDetailsTableAdapter();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBrokerDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBrokerDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataGridView1.DataSource = this.dataBrokerDetailsBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(800, 450);
            this.dataGridView1.TabIndex = 0;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBrokerDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBrokerDatabaseDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataBrokerDatabaseDataSet dataBrokerDatabaseDataSet;
        private System.Windows.Forms.BindingSource dataBrokerDetailsBindingSource;
        private DataBrokerDatabaseDataSetTableAdapters.DataBrokerDetailsTableAdapter dataBrokerDetailsTableAdapter;
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

