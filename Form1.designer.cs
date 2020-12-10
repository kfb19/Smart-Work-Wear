namespace Coursework
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imgWPMpro = new System.Windows.Forms.PictureBox();
            this.lblSmartWorkWearTitle = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblAboutUs = new System.Windows.Forms.Label();
            this.lblContactUs = new System.Windows.Forms.Label();
            this.lblAboutUsInfo = new System.Windows.Forms.Label();
            this.lblContactInfo = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.imgWPMpro)).BeginInit();
            this.SuspendLayout();
            // 
            // imgWPMpro
            // 
            this.imgWPMpro.Image = ((System.Drawing.Image)(resources.GetObject("imgWPMpro.Image")));
            this.imgWPMpro.Location = new System.Drawing.Point(12, 12);
            this.imgWPMpro.Name = "imgWPMpro";
            this.imgWPMpro.Size = new System.Drawing.Size(194, 209);
            this.imgWPMpro.TabIndex = 0;
            this.imgWPMpro.TabStop = false;
            // 
            // lblSmartWorkWearTitle
            // 
            this.lblSmartWorkWearTitle.AutoSize = true;
            this.lblSmartWorkWearTitle.Font = new System.Drawing.Font("Rockwell", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSmartWorkWearTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblSmartWorkWearTitle.Location = new System.Drawing.Point(231, 12);
            this.lblSmartWorkWearTitle.Name = "lblSmartWorkWearTitle";
            this.lblSmartWorkWearTitle.Size = new System.Drawing.Size(323, 43);
            this.lblSmartWorkWearTitle.TabIndex = 1;
            this.lblSmartWorkWearTitle.Text = "Smart Work Wear";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLogin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.Location = new System.Drawing.Point(442, 244);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(130, 98);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblAboutUs
            // 
            this.lblAboutUs.AutoSize = true;
            this.lblAboutUs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAboutUs.Location = new System.Drawing.Point(235, 55);
            this.lblAboutUs.Name = "lblAboutUs";
            this.lblAboutUs.Size = new System.Drawing.Size(84, 20);
            this.lblAboutUs.TabIndex = 3;
            this.lblAboutUs.Text = "About Us";
            // 
            // lblContactUs
            // 
            this.lblContactUs.AutoSize = true;
            this.lblContactUs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactUs.Location = new System.Drawing.Point(12, 224);
            this.lblContactUs.Name = "lblContactUs";
            this.lblContactUs.Size = new System.Drawing.Size(99, 20);
            this.lblContactUs.TabIndex = 4;
            this.lblContactUs.Text = "Contact Us";
            // 
            // lblAboutUsInfo
            // 
            this.lblAboutUsInfo.AutoSize = true;
            this.lblAboutUsInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAboutUsInfo.Location = new System.Drawing.Point(236, 77);
            this.lblAboutUsInfo.Name = "lblAboutUsInfo";
            this.lblAboutUsInfo.Size = new System.Drawing.Size(336, 144);
            this.lblAboutUsInfo.TabIndex = 5;
            this.lblAboutUsInfo.Text = resources.GetString("lblAboutUsInfo.Text");
            // 
            // lblContactInfo
            // 
            this.lblContactInfo.AutoSize = true;
            this.lblContactInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactInfo.Location = new System.Drawing.Point(13, 244);
            this.lblContactInfo.Name = "lblContactInfo";
            this.lblContactInfo.Size = new System.Drawing.Size(244, 108);
            this.lblContactInfo.TabIndex = 6;
            this.lblContactInfo.Text = "Developers:\r\nKate: kate@xdu.cc \r\nNick: nick@xdu.cc \r\nTelephone Number: \r\n07772218" +
    "8236 \r\nEmail: smartworkwear@gmail.com ";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(591, 365);
            this.Controls.Add(this.lblContactInfo);
            this.Controls.Add(this.lblAboutUsInfo);
            this.Controls.Add(this.lblContactUs);
            this.Controls.Add(this.lblAboutUs);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblSmartWorkWearTitle);
            this.Controls.Add(this.imgWPMpro);
            this.Name = "Form1";
            this.Text = "Smart Work Wear Platform";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgWPMpro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgWPMpro;
        private System.Windows.Forms.Label lblSmartWorkWearTitle;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblAboutUs;
        private System.Windows.Forms.Label lblContactUs;
        private System.Windows.Forms.Label lblAboutUsInfo;
        private System.Windows.Forms.Label lblContactInfo;
        private System.Windows.Forms.Timer timer1;
    }
}

