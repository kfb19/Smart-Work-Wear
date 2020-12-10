namespace Coursework
{
    partial class frmAddNest
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
            this.btnAddNest = new System.Windows.Forms.Button();
            this.lblAddNest = new System.Windows.Forms.Label();
            this.txtWhatThreeWords = new System.Windows.Forms.TextBox();
            this.txtNestPostcode = new System.Windows.Forms.TextBox();
            this.lblWhatThreeWords = new System.Windows.Forms.Label();
            this.lblNestPostcode = new System.Windows.Forms.Label();
            this.lblAboutWhatThreeWords = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBack.Location = new System.Drawing.Point(42, 194);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(63, 32);
            this.btnBack.TabIndex = 63;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAddNest
            // 
            this.btnAddNest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAddNest.Location = new System.Drawing.Point(208, 161);
            this.btnAddNest.Name = "btnAddNest";
            this.btnAddNest.Size = new System.Drawing.Size(100, 65);
            this.btnAddNest.TabIndex = 60;
            this.btnAddNest.Text = "Add Nest";
            this.btnAddNest.UseVisualStyleBackColor = false;
            this.btnAddNest.Click += new System.EventHandler(this.btnAddNest_Click);
            // 
            // lblAddNest
            // 
            this.lblAddNest.AutoSize = true;
            this.lblAddNest.Font = new System.Drawing.Font("Rockwell", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddNest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblAddNest.Location = new System.Drawing.Point(125, 38);
            this.lblAddNest.Name = "lblAddNest";
            this.lblAddNest.Size = new System.Drawing.Size(223, 43);
            this.lblAddNest.TabIndex = 59;
            this.lblAddNest.Text = "Add a Nest: ";
            // 
            // txtWhatThreeWords
            // 
            this.txtWhatThreeWords.Location = new System.Drawing.Point(191, 123);
            this.txtWhatThreeWords.Name = "txtWhatThreeWords";
            this.txtWhatThreeWords.Size = new System.Drawing.Size(137, 20);
            this.txtWhatThreeWords.TabIndex = 55;
            // 
            // txtNestPostcode
            // 
            this.txtNestPostcode.Location = new System.Drawing.Point(191, 93);
            this.txtNestPostcode.Name = "txtNestPostcode";
            this.txtNestPostcode.Size = new System.Drawing.Size(137, 20);
            this.txtNestPostcode.TabIndex = 54;
            // 
            // lblWhatThreeWords
            // 
            this.lblWhatThreeWords.AutoSize = true;
            this.lblWhatThreeWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhatThreeWords.Location = new System.Drawing.Point(38, 123);
            this.lblWhatThreeWords.Name = "lblWhatThreeWords";
            this.lblWhatThreeWords.Size = new System.Drawing.Size(147, 20);
            this.lblWhatThreeWords.TabIndex = 48;
            this.lblWhatThreeWords.Text = "Nest What3Words: ";
            // 
            // lblNestPostcode
            // 
            this.lblNestPostcode.AutoSize = true;
            this.lblNestPostcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNestPostcode.Location = new System.Drawing.Point(64, 93);
            this.lblNestPostcode.Name = "lblNestPostcode";
            this.lblNestPostcode.Size = new System.Drawing.Size(121, 20);
            this.lblNestPostcode.TabIndex = 47;
            this.lblNestPostcode.Text = "Nest Postcode: ";
            // 
            // lblAboutWhatThreeWords
            // 
            this.lblAboutWhatThreeWords.AutoSize = true;
            this.lblAboutWhatThreeWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAboutWhatThreeWords.Location = new System.Drawing.Point(118, 239);
            this.lblAboutWhatThreeWords.Name = "lblAboutWhatThreeWords";
            this.lblAboutWhatThreeWords.Size = new System.Drawing.Size(269, 60);
            this.lblAboutWhatThreeWords.TabIndex = 64;
            this.lblAboutWhatThreeWords.Text = "The What3Words of the nest can be \r\nobtained using the What3Words\r\napp on any app" +
    " store. ";
            this.lblAboutWhatThreeWords.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmAddNest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(428, 312);
            this.Controls.Add(this.lblAboutWhatThreeWords);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAddNest);
            this.Controls.Add(this.lblAddNest);
            this.Controls.Add(this.txtWhatThreeWords);
            this.Controls.Add(this.txtNestPostcode);
            this.Controls.Add(this.lblWhatThreeWords);
            this.Controls.Add(this.lblNestPostcode);
            this.Name = "frmAddNest";
            this.Text = "Add a Nest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAddNest;
        private System.Windows.Forms.Label lblAddNest;
        private System.Windows.Forms.TextBox txtWhatThreeWords;
        private System.Windows.Forms.TextBox txtNestPostcode;
        private System.Windows.Forms.Label lblWhatThreeWords;
        private System.Windows.Forms.Label lblNestPostcode;
        private System.Windows.Forms.Label lblAboutWhatThreeWords;
    }
}