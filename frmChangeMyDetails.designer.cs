namespace Coursework
{
    partial class frmChangeMyDetails
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
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblOldPassword = new System.Windows.Forms.Label();
            this.nudNestID = new System.Windows.Forms.NumericUpDown();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.lblAddEmployee = new System.Windows.Forms.Label();
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
            this.lblNote = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudNestID)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(193, 259);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(137, 20);
            this.txtPassword.TabIndex = 64;
            // 
            // lblOldPassword
            // 
            this.lblOldPassword.AutoSize = true;
            this.lblOldPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldPassword.Location = new System.Drawing.Point(103, 259);
            this.lblOldPassword.Name = "lblOldPassword";
            this.lblOldPassword.Size = new System.Drawing.Size(86, 20);
            this.lblOldPassword.TabIndex = 63;
            this.lblOldPassword.Text = "Password: ";
            // 
            // nudNestID
            // 
            this.nudNestID.ForeColor = System.Drawing.Color.Black;
            this.nudNestID.Location = new System.Drawing.Point(193, 229);
            this.nudNestID.Name = "nudNestID";
            this.nudNestID.Size = new System.Drawing.Size(137, 20);
            this.nudNestID.TabIndex = 61;
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(193, 138);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(137, 20);
            this.dtpDOB.TabIndex = 60;
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSaveChanges.Location = new System.Drawing.Point(193, 294);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(100, 65);
            this.btnSaveChanges.TabIndex = 59;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // lblAddEmployee
            // 
            this.lblAddEmployee.AutoSize = true;
            this.lblAddEmployee.Font = new System.Drawing.Font("Rockwell", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblAddEmployee.Location = new System.Drawing.Point(125, 25);
            this.lblAddEmployee.Name = "lblAddEmployee";
            this.lblAddEmployee.Size = new System.Drawing.Size(226, 43);
            this.lblAddEmployee.TabIndex = 58;
            this.lblAddEmployee.Text = "Edit Details:";
            // 
            // txtPostcode
            // 
            this.txtPostcode.Location = new System.Drawing.Point(193, 199);
            this.txtPostcode.Name = "txtPostcode";
            this.txtPostcode.Size = new System.Drawing.Size(137, 20);
            this.txtPostcode.TabIndex = 57;
            // 
            // txtHouseNo
            // 
            this.txtHouseNo.Location = new System.Drawing.Point(193, 169);
            this.txtHouseNo.Name = "txtHouseNo";
            this.txtHouseNo.Size = new System.Drawing.Size(137, 20);
            this.txtHouseNo.TabIndex = 56;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(193, 109);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(137, 20);
            this.txtSurname.TabIndex = 55;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(193, 79);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(137, 20);
            this.txtFirstName.TabIndex = 54;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.Location = new System.Drawing.Point(105, 109);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(82, 20);
            this.lblSurname.TabIndex = 53;
            this.lblSurname.Text = "Surname: ";
            // 
            // lblHouseNo
            // 
            this.lblHouseNo.AutoSize = true;
            this.lblHouseNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHouseNo.Location = new System.Drawing.Point(17, 169);
            this.lblHouseNo.Name = "lblHouseNo";
            this.lblHouseNo.Size = new System.Drawing.Size(170, 20);
            this.lblHouseNo.TabIndex = 52;
            this.lblHouseNo.Text = "House Name/Number: ";
            // 
            // lblPostcode
            // 
            this.lblPostcode.AutoSize = true;
            this.lblPostcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostcode.Location = new System.Drawing.Point(103, 199);
            this.lblPostcode.Name = "lblPostcode";
            this.lblPostcode.Size = new System.Drawing.Size(84, 20);
            this.lblPostcode.TabIndex = 51;
            this.lblPostcode.Text = "Postcode: ";
            // 
            // lblNest
            // 
            this.lblNest.AutoSize = true;
            this.lblNest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNest.Location = new System.Drawing.Point(116, 229);
            this.lblNest.Name = "lblNest";
            this.lblNest.Size = new System.Drawing.Size(71, 20);
            this.lblNest.TabIndex = 50;
            this.lblNest.Text = "Nest ID: ";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.Location = new System.Drawing.Point(77, 139);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(110, 20);
            this.lblDOB.TabIndex = 49;
            this.lblDOB.Text = "Date Of Birth: ";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(93, 79);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(94, 20);
            this.lblFirstName.TabIndex = 48;
            this.lblFirstName.Text = "First Name: ";
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.Location = new System.Drawing.Point(23, 376);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(402, 40);
            this.lblNote.TabIndex = 65;
            this.lblNote.Text = "If you have changed your email address, please let your \r\ncompany know and they c" +
    "an change it for you. ";
            this.lblNote.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(63, 32);
            this.btnBack.TabIndex = 66;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmChangeMyDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(437, 446);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblOldPassword);
            this.Controls.Add(this.nudNestID);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.lblAddEmployee);
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
            this.Name = "frmChangeMyDetails";
            this.Text = "Update your Profile ";
            this.Load += new System.EventHandler(this.frmChangeMyDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudNestID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblOldPassword;
        private System.Windows.Forms.NumericUpDown nudNestID;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Label lblAddEmployee;
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
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Button btnBack;
    }
}