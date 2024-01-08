namespace DataBrokerCleaning
{
    partial class ShowDetailsForm
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
            this.lblCompnayName = new System.Windows.Forms.Label();
            this.imgCompanyLogo = new System.Windows.Forms.PictureBox();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCompanyLogo)).BeginInit();
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
            // lblCompnayName
            // 
            this.lblCompnayName.AutoSize = true;
            this.lblCompnayName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompnayName.Location = new System.Drawing.Point(4, 9);
            this.lblCompnayName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCompnayName.Name = "lblCompnayName";
            this.lblCompnayName.Size = new System.Drawing.Size(166, 25);
            this.lblCompnayName.TabIndex = 5;
            this.lblCompnayName.Text = "Company Name";
            // 
            // imgCompanyLogo
            // 
            this.imgCompanyLogo.Location = new System.Drawing.Point(587, 12);
            this.imgCompanyLogo.Name = "imgCompanyLogo";
            this.imgCompanyLogo.Size = new System.Drawing.Size(195, 85);
            this.imgCompanyLogo.TabIndex = 6;
            this.imgCompanyLogo.TabStop = false;
            // 
            // ShowDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1474, 513);
            this.Controls.Add(this.panelTop);
            this.Name = "ShowDetailsForm";
            this.Text = "ShowDetailsForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ShowDetailsForm_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCompanyLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblCompnayName;
        private System.Windows.Forms.PictureBox imgCompanyLogo;
    }
}