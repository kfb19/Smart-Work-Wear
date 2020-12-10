namespace Coursework
{
    partial class frmUserDetails
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
            this.btnUserStatistics = new System.Windows.Forms.Button();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblHouseNo = new System.Windows.Forms.Label();
            this.lblPostcode = new System.Windows.Forms.Label();
            this.lblNest = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblUserSurname = new System.Windows.Forms.Label();
            this.lblUserHouse = new System.Windows.Forms.Label();
            this.lblUserPostcode = new System.Windows.Forms.Label();
            this.lblUserNest = new System.Windows.Forms.Label();
            this.lblUserDOB = new System.Windows.Forms.Label();
            this.lblUserFirstName = new System.Windows.Forms.Label();
            this.lblUserEmail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBack.Location = new System.Drawing.Point(622, 9);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(63, 32);
            this.btnBack.TabIndex = 52;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnUserStatistics
            // 
            this.btnUserStatistics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnUserStatistics.Location = new System.Drawing.Point(585, 196);
            this.btnUserStatistics.Name = "btnUserStatistics";
            this.btnUserStatistics.Size = new System.Drawing.Size(100, 65);
            this.btnUserStatistics.TabIndex = 50;
            this.btnUserStatistics.Text = "View User Statistics";
            this.btnUserStatistics.UseVisualStyleBackColor = false;
            this.btnUserStatistics.Click += new System.EventHandler(this.btnUserStatistics_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.Black;
            this.lblUserName.Location = new System.Drawing.Point(8, 9);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(301, 33);
            this.lblUserName.TabIndex = 48;
            this.lblUserName.Text = "Employee Selected: ";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.Location = new System.Drawing.Point(10, 114);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(91, 20);
            this.lblSurname.TabIndex = 59;
            this.lblSurname.Text = "Surname: ";
            // 
            // lblHouseNo
            // 
            this.lblHouseNo.AutoSize = true;
            this.lblHouseNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHouseNo.Location = new System.Drawing.Point(10, 174);
            this.lblHouseNo.Name = "lblHouseNo";
            this.lblHouseNo.Size = new System.Drawing.Size(189, 20);
            this.lblHouseNo.TabIndex = 58;
            this.lblHouseNo.Text = "House Name/Number: ";
            // 
            // lblPostcode
            // 
            this.lblPostcode.AutoSize = true;
            this.lblPostcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostcode.Location = new System.Drawing.Point(10, 204);
            this.lblPostcode.Name = "lblPostcode";
            this.lblPostcode.Size = new System.Drawing.Size(94, 20);
            this.lblPostcode.TabIndex = 57;
            this.lblPostcode.Text = "Postcode: ";
            // 
            // lblNest
            // 
            this.lblNest.AutoSize = true;
            this.lblNest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNest.Location = new System.Drawing.Point(10, 234);
            this.lblNest.Name = "lblNest";
            this.lblNest.Size = new System.Drawing.Size(80, 20);
            this.lblNest.TabIndex = 56;
            this.lblNest.Text = "Nest ID: ";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.Location = new System.Drawing.Point(10, 144);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(125, 20);
            this.lblDOB.TabIndex = 55;
            this.lblDOB.Text = "Date Of Birth: ";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(10, 84);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(106, 20);
            this.lblFirstName.TabIndex = 54;
            this.lblFirstName.Text = "First Name: ";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(10, 54);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(63, 20);
            this.lblEmail.TabIndex = 53;
            this.lblEmail.Text = "Email: ";
            // 
            // lblUserSurname
            // 
            this.lblUserSurname.AutoSize = true;
            this.lblUserSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserSurname.Location = new System.Drawing.Point(98, 114);
            this.lblUserSurname.Name = "lblUserSurname";
            this.lblUserSurname.Size = new System.Drawing.Size(21, 20);
            this.lblUserSurname.TabIndex = 66;
            this.lblUserSurname.Text = "...";
            // 
            // lblUserHouse
            // 
            this.lblUserHouse.AutoSize = true;
            this.lblUserHouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserHouse.Location = new System.Drawing.Point(186, 174);
            this.lblUserHouse.Name = "lblUserHouse";
            this.lblUserHouse.Size = new System.Drawing.Size(21, 20);
            this.lblUserHouse.TabIndex = 65;
            this.lblUserHouse.Text = "...";
            // 
            // lblUserPostcode
            // 
            this.lblUserPostcode.AutoSize = true;
            this.lblUserPostcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserPostcode.Location = new System.Drawing.Point(100, 204);
            this.lblUserPostcode.Name = "lblUserPostcode";
            this.lblUserPostcode.Size = new System.Drawing.Size(21, 20);
            this.lblUserPostcode.TabIndex = 64;
            this.lblUserPostcode.Text = "...";
            // 
            // lblUserNest
            // 
            this.lblUserNest.AutoSize = true;
            this.lblUserNest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserNest.Location = new System.Drawing.Point(87, 234);
            this.lblUserNest.Name = "lblUserNest";
            this.lblUserNest.Size = new System.Drawing.Size(21, 20);
            this.lblUserNest.TabIndex = 63;
            this.lblUserNest.Text = "...";
            // 
            // lblUserDOB
            // 
            this.lblUserDOB.AutoSize = true;
            this.lblUserDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserDOB.Location = new System.Drawing.Point(126, 144);
            this.lblUserDOB.Name = "lblUserDOB";
            this.lblUserDOB.Size = new System.Drawing.Size(21, 20);
            this.lblUserDOB.TabIndex = 62;
            this.lblUserDOB.Text = "...";
            // 
            // lblUserFirstName
            // 
            this.lblUserFirstName.AutoSize = true;
            this.lblUserFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserFirstName.Location = new System.Drawing.Point(110, 84);
            this.lblUserFirstName.Name = "lblUserFirstName";
            this.lblUserFirstName.Size = new System.Drawing.Size(21, 20);
            this.lblUserFirstName.TabIndex = 61;
            this.lblUserFirstName.Text = "...";
            // 
            // lblUserEmail
            // 
            this.lblUserEmail.AutoSize = true;
            this.lblUserEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserEmail.Location = new System.Drawing.Point(64, 54);
            this.lblUserEmail.Name = "lblUserEmail";
            this.lblUserEmail.Size = new System.Drawing.Size(21, 20);
            this.lblUserEmail.TabIndex = 60;
            this.lblUserEmail.Text = "...";
            // 
            // frmUserDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(697, 273);
            this.Controls.Add(this.lblUserSurname);
            this.Controls.Add(this.lblUserHouse);
            this.Controls.Add(this.lblUserPostcode);
            this.Controls.Add(this.lblUserNest);
            this.Controls.Add(this.lblUserDOB);
            this.Controls.Add(this.lblUserFirstName);
            this.Controls.Add(this.lblUserEmail);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblHouseNo);
            this.Controls.Add(this.lblPostcode);
            this.Controls.Add(this.lblNest);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnUserStatistics);
            this.Controls.Add(this.lblUserName);
            this.Name = "frmUserDetails";
            this.Text = "Employee Details";
            this.Load += new System.EventHandler(this.frmUserDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnUserStatistics;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblHouseNo;
        private System.Windows.Forms.Label lblPostcode;
        private System.Windows.Forms.Label lblNest;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblUserSurname;
        private System.Windows.Forms.Label lblUserHouse;
        private System.Windows.Forms.Label lblUserPostcode;
        private System.Windows.Forms.Label lblUserNest;
        private System.Windows.Forms.Label lblUserDOB;
        private System.Windows.Forms.Label lblUserFirstName;
        private System.Windows.Forms.Label lblUserEmail;
    }
}