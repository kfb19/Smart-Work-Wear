namespace Coursework
{
    partial class frmEditUserDetails
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
            this.nudNestID = new System.Windows.Forms.NumericUpDown();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.lblEditDetails = new System.Windows.Forms.Label();
            this.txtPostcode = new System.Windows.Forms.TextBox();
            this.txtHouseNo = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblHouseNo = new System.Windows.Forms.Label();
            this.lblPostcode = new System.Windows.Forms.Label();
            this.lblNest = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblOldPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudNestID)).BeginInit();
            this.SuspendLayout();
            // 
            // nudNestID
            // 
            this.nudNestID.ForeColor = System.Drawing.Color.Black;
            this.nudNestID.Location = new System.Drawing.Point(188, 265);
            this.nudNestID.Name = "nudNestID";
            this.nudNestID.Size = new System.Drawing.Size(137, 20);
            this.nudNestID.TabIndex = 43;
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(188, 174);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(137, 20);
            this.dtpDOB.TabIndex = 42;
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSaveChanges.Location = new System.Drawing.Point(188, 330);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(100, 65);
            this.btnSaveChanges.TabIndex = 41;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // lblEditDetails
            // 
            this.lblEditDetails.AutoSize = true;
            this.lblEditDetails.Font = new System.Drawing.Font("Rockwell", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblEditDetails.Location = new System.Drawing.Point(121, 22);
            this.lblEditDetails.Name = "lblEditDetails";
            this.lblEditDetails.Size = new System.Drawing.Size(226, 43);
            this.lblEditDetails.TabIndex = 40;
            this.lblEditDetails.Text = "Edit Details:";
            // 
            // txtPostcode
            // 
            this.txtPostcode.Location = new System.Drawing.Point(188, 235);
            this.txtPostcode.Name = "txtPostcode";
            this.txtPostcode.Size = new System.Drawing.Size(137, 20);
            this.txtPostcode.TabIndex = 39;
            // 
            // txtHouseNo
            // 
            this.txtHouseNo.Location = new System.Drawing.Point(188, 205);
            this.txtHouseNo.Name = "txtHouseNo";
            this.txtHouseNo.Size = new System.Drawing.Size(137, 20);
            this.txtHouseNo.TabIndex = 38;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(188, 145);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(137, 20);
            this.txtSurname.TabIndex = 37;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(188, 115);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(137, 20);
            this.txtFirstName.TabIndex = 36;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.Location = new System.Drawing.Point(100, 145);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(82, 20);
            this.lblSurname.TabIndex = 34;
            this.lblSurname.Text = "Surname: ";
            // 
            // lblHouseNo
            // 
            this.lblHouseNo.AutoSize = true;
            this.lblHouseNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHouseNo.Location = new System.Drawing.Point(12, 205);
            this.lblHouseNo.Name = "lblHouseNo";
            this.lblHouseNo.Size = new System.Drawing.Size(170, 20);
            this.lblHouseNo.TabIndex = 33;
            this.lblHouseNo.Text = "House Name/Number: ";
            // 
            // lblPostcode
            // 
            this.lblPostcode.AutoSize = true;
            this.lblPostcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostcode.Location = new System.Drawing.Point(98, 235);
            this.lblPostcode.Name = "lblPostcode";
            this.lblPostcode.Size = new System.Drawing.Size(84, 20);
            this.lblPostcode.TabIndex = 32;
            this.lblPostcode.Text = "Postcode: ";
            // 
            // lblNest
            // 
            this.lblNest.AutoSize = true;
            this.lblNest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNest.Location = new System.Drawing.Point(111, 265);
            this.lblNest.Name = "lblNest";
            this.lblNest.Size = new System.Drawing.Size(71, 20);
            this.lblNest.TabIndex = 31;
            this.lblNest.Text = "Nest ID: ";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.Location = new System.Drawing.Point(72, 175);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(110, 20);
            this.lblDOB.TabIndex = 30;
            this.lblDOB.Text = "Date Of Birth: ";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(88, 115);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(94, 20);
            this.lblFirstName.TabIndex = 29;
            this.lblFirstName.Text = "First Name: ";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(126, 85);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(56, 20);
            this.lblEmail.TabIndex = 28;
            this.lblEmail.Text = "Email: ";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(188, 85);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(137, 20);
            this.txtEmail.TabIndex = 44;
            // 
            // lblOldPassword
            // 
            this.lblOldPassword.AutoSize = true;
            this.lblOldPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldPassword.Location = new System.Drawing.Point(98, 295);
            this.lblOldPassword.Name = "lblOldPassword";
            this.lblOldPassword.Size = new System.Drawing.Size(86, 20);
            this.lblOldPassword.TabIndex = 45;
            this.lblOldPassword.Text = "Password: ";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(188, 295);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(137, 20);
            this.txtPassword.TabIndex = 46;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBack.Location = new System.Drawing.Point(12, 363);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(63, 32);
            this.btnBack.TabIndex = 47;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmEditUserDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(409, 411);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblOldPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.nudNestID);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.lblEditDetails);
            this.Controls.Add(this.txtPostcode);
            this.Controls.Add(this.txtHouseNo);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblHouseNo);
            this.Controls.Add(this.lblPostcode);
            this.Controls.Add(this.lblNest);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblEmail);
            this.Name = "frmEditUserDetails";
            this.Text = "Edit Details ";
            this.Load += new System.EventHandler(this.frmEditUserDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudNestID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown nudNestID;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Label lblEditDetails;
        private System.Windows.Forms.TextBox txtPostcode;
        private System.Windows.Forms.TextBox txtHouseNo;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblHouseNo;
        private System.Windows.Forms.Label lblPostcode;
        private System.Windows.Forms.Label lblNest;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblOldPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnBack;
    }
}