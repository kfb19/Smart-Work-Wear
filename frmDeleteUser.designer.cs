namespace Coursework
{
    partial class frmDeleteUser
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
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.flpEmployees = new System.Windows.Forms.FlowLayoutPanel();
            this.lblChooseEmployee = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBack.Location = new System.Drawing.Point(840, 14);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(63, 32);
            this.btnBack.TabIndex = 49;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyName.ForeColor = System.Drawing.Color.Black;
            this.lblCompanyName.Location = new System.Drawing.Point(12, 6);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(147, 33);
            this.lblCompanyName.TabIndex = 48;
            this.lblCompanyName.Text = "Company";
            // 
            // flpEmployees
            // 
            this.flpEmployees.Location = new System.Drawing.Point(12, 59);
            this.flpEmployees.Name = "flpEmployees";
            this.flpEmployees.Size = new System.Drawing.Size(902, 504);
            this.flpEmployees.TabIndex = 47;
            // 
            // lblChooseEmployee
            // 
            this.lblChooseEmployee.AutoSize = true;
            this.lblChooseEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChooseEmployee.ForeColor = System.Drawing.Color.Black;
            this.lblChooseEmployee.Location = new System.Drawing.Point(15, 40);
            this.lblChooseEmployee.Name = "lblChooseEmployee";
            this.lblChooseEmployee.Size = new System.Drawing.Size(223, 16);
            this.lblChooseEmployee.TabIndex = 50;
            this.lblChooseEmployee.Text = "Choose an Employee to Delete";
            // 
            // frmDeleteUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 575);
            this.Controls.Add(this.lblChooseEmployee);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblCompanyName);
            this.Controls.Add(this.flpEmployees);
            this.Name = "frmDeleteUser";
            this.Text = "Delete a User ";
            this.Load += new System.EventHandler(this.frmDeleteUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.FlowLayoutPanel flpEmployees;
        private System.Windows.Forms.Label lblChooseEmployee;
    }
}