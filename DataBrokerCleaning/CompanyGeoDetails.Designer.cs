namespace DataBrokerCleaning
{
    partial class CompanyGeoDetails
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
            this.imgCompanyLogo = new System.Windows.Forms.PictureBox();
            this.lblCompnayName = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.imgCompanyLogo)).BeginInit();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
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
            // panelTop
            // 
            this.panelTop.Controls.Add(this.imgCompanyLogo);
            this.panelTop.Controls.Add(this.lblCompnayName);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1768, 100);
            this.panelTop.TabIndex = 1;
            // 
            // CompanyGeoDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1768, 576);
            this.Controls.Add(this.panelTop);
            this.Name = "CompanyGeoDetails";
            this.Text = "CompanyGeoDetails";
            this.Load += new System.EventHandler(this.CompanyGeoDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgCompanyLogo)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgCompanyLogo;
        private System.Windows.Forms.Label lblCompnayName;
        private System.Windows.Forms.Panel panelTop;
    }
}