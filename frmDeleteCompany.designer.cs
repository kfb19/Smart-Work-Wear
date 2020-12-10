namespace Coursework
{
    partial class frmDeleteCompany
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
            this.btnBack = new System.Windows.Forms.Button();
            this.lblCompanyView = new System.Windows.Forms.Label();
            this.flpCompanies = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBack.Location = new System.Drawing.Point(851, 6);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(63, 32);
            this.btnBack.TabIndex = 49;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblCompanyView
            // 
            this.lblCompanyView.AutoSize = true;
            this.lblCompanyView.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyView.ForeColor = System.Drawing.Color.Black;
            this.lblCompanyView.Location = new System.Drawing.Point(12, 6);
            this.lblCompanyView.Name = "lblCompanyView";
            this.lblCompanyView.Size = new System.Drawing.Size(431, 33);
            this.lblCompanyView.TabIndex = 48;
            this.lblCompanyView.Text = "Choose a Company to Delete:";
            // 
            // flpCompanies
            // 
            this.flpCompanies.Location = new System.Drawing.Point(12, 45);
            this.flpCompanies.Name = "flpCompanies";
            this.flpCompanies.Size = new System.Drawing.Size(902, 560);
            this.flpCompanies.TabIndex = 47;
            // 
            // frmDeleteCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 619);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblCompanyView);
            this.Controls.Add(this.flpCompanies);
            this.Name = "frmDeleteCompany";
            this.Text = "Delete a Company ";
            this.Load += new System.EventHandler(this.frmDeleteCompany_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblCompanyView;
        private System.Windows.Forms.FlowLayoutPanel flpCompanies;
    }
}