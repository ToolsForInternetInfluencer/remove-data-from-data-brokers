namespace DataBrokerCleaning
{
    partial class CompanyIntroForm
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.imgCompanyLogo = new System.Windows.Forms.PictureBox();
            this.lblCompnayName = new System.Windows.Forms.Label();
            this.panelData = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBackToLoad = new System.Windows.Forms.Button();
            this.btnContactDetails = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCompanyType = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCompanyFounded = new System.Windows.Forms.Label();
            this.lblCompanyLegalName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCompanyDescription = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCompanyLogo)).BeginInit();
            this.panelData.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.imgCompanyLogo);
            this.panelTop.Controls.Add(this.lblCompnayName);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1474, 100);
            this.panelTop.TabIndex = 0;
            // 
            // imgCompanyLogo
            // 
            this.imgCompanyLogo.Location = new System.Drawing.Point(706, 0);
            this.imgCompanyLogo.Name = "imgCompanyLogo";
            this.imgCompanyLogo.Size = new System.Drawing.Size(195, 97);
            this.imgCompanyLogo.TabIndex = 6;
            this.imgCompanyLogo.TabStop = false;
            // 
            // lblCompnayName
            // 
            this.lblCompnayName.AutoSize = true;
            this.lblCompnayName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompnayName.Location = new System.Drawing.Point(524, 36);
            this.lblCompnayName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCompnayName.Name = "lblCompnayName";
            this.lblCompnayName.Size = new System.Drawing.Size(166, 25);
            this.lblCompnayName.TabIndex = 5;
            this.lblCompnayName.Text = "Company Name";
            // 
            // panelData
            // 
            this.panelData.Controls.Add(this.panel1);
            this.panelData.Controls.Add(this.tableLayoutPanel1);
            this.panelData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelData.Location = new System.Drawing.Point(0, 100);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(1474, 413);
            this.panelData.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnBackToLoad);
            this.panel1.Controls.Add(this.btnContactDetails);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 313);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1474, 100);
            this.panel1.TabIndex = 1;
            // 
            // btnBackToLoad
            // 
            this.btnBackToLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToLoad.Location = new System.Drawing.Point(4, 4);
            this.btnBackToLoad.Margin = new System.Windows.Forms.Padding(4);
            this.btnBackToLoad.Name = "btnBackToLoad";
            this.btnBackToLoad.Size = new System.Drawing.Size(561, 42);
            this.btnBackToLoad.TabIndex = 11;
            this.btnBackToLoad.Text = "Back To Load Page";
            this.btnBackToLoad.UseVisualStyleBackColor = true;
            this.btnBackToLoad.Click += new System.EventHandler(this.btnBackToLoad_Click);
            // 
            // btnContactDetails
            // 
            this.btnContactDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContactDetails.Location = new System.Drawing.Point(909, 0);
            this.btnContactDetails.Margin = new System.Windows.Forms.Padding(4);
            this.btnContactDetails.Name = "btnContactDetails";
            this.btnContactDetails.Size = new System.Drawing.Size(561, 42);
            this.btnContactDetails.TabIndex = 10;
            this.btnContactDetails.Text = "Check Contact Details";
            this.btnContactDetails.UseVisualStyleBackColor = true;
            this.btnContactDetails.Click += new System.EventHandler(this.btnContactDetails_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblCompanyType, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblCompanyFounded, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblCompanyLegalName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblCompanyDescription, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.32039F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.67961F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 136F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1474, 413);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 273);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Company Type";
            // 
            // lblCompanyType
            // 
            this.lblCompanyType.AutoSize = true;
            this.lblCompanyType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyType.Location = new System.Drawing.Point(742, 273);
            this.lblCompanyType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCompanyType.Name = "lblCompanyType";
            this.lblCompanyType.Size = new System.Drawing.Size(159, 25);
            this.lblCompanyType.TabIndex = 13;
            this.lblCompanyType.Text = "Company Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 166);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Company Year Birth";
            // 
            // lblCompanyFounded
            // 
            this.lblCompanyFounded.AutoSize = true;
            this.lblCompanyFounded.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyFounded.Location = new System.Drawing.Point(742, 166);
            this.lblCompanyFounded.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCompanyFounded.Name = "lblCompanyFounded";
            this.lblCompanyFounded.Size = new System.Drawing.Size(205, 25);
            this.lblCompanyFounded.TabIndex = 11;
            this.lblCompanyFounded.Text = "Company Year Birth";
            // 
            // lblCompanyLegalName
            // 
            this.lblCompanyLegalName.AutoSize = true;
            this.lblCompanyLegalName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyLegalName.Location = new System.Drawing.Point(742, 3);
            this.lblCompanyLegalName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCompanyLegalName.Name = "lblCompanyLegalName";
            this.lblCompanyLegalName.Size = new System.Drawing.Size(225, 25);
            this.lblCompanyLegalName.TabIndex = 10;
            this.lblCompanyLegalName.Text = "Company Legal Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Company Legal Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Company Decription";
            // 
            // lblCompanyDescription
            // 
            this.lblCompanyDescription.AutoSize = true;
            this.lblCompanyDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyDescription.Location = new System.Drawing.Point(742, 68);
            this.lblCompanyDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCompanyDescription.Name = "lblCompanyDescription";
            this.lblCompanyDescription.Size = new System.Drawing.Size(207, 25);
            this.lblCompanyDescription.TabIndex = 8;
            this.lblCompanyDescription.Text = "Company Decription";
            // 
            // CompanyIntroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1474, 513);
            this.Controls.Add(this.panelData);
            this.Controls.Add(this.panelTop);
            this.Name = "CompanyIntroForm";
            this.Text = "ShowDetailsForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ShowDetailsForm_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCompanyLogo)).EndInit();
            this.panelData.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblCompnayName;
        private System.Windows.Forms.PictureBox imgCompanyLogo;
        private System.Windows.Forms.Panel panelData;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCompanyDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCompanyLegalName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCompanyFounded;
        private System.Windows.Forms.Label lblCompanyType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBackToLoad;
        private System.Windows.Forms.Button btnContactDetails;
    }
}