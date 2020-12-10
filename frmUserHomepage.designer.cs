namespace Coursework
{
    partial class frmUserHomepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserHomepage));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsChangeDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.tsViewStatistics = new System.Windows.Forms.ToolStripMenuItem();
            this.tsAddGarment = new System.Windows.Forms.ToolStripMenuItem();
            this.tsHelpAndSupport = new System.Windows.Forms.ToolStripMenuItem();
            this.tsLogOut = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblOnline = new System.Windows.Forms.Label();
            this.lblToday = new System.Windows.Forms.Label();
            this.lblHelpInfo = new System.Windows.Forms.Label();
            this.lblHelp = new System.Windows.Forms.Label();
            this.mcCalendar = new System.Windows.Forms.MonthCalendar();
            this.lblAboutThisPage = new System.Windows.Forms.Label();
            this.lblOnlineTime = new System.Windows.Forms.Label();
            this.lblLoggedInTime = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsChangeDetails,
            this.tsViewStatistics,
            this.tsAddGarment,
            this.tsHelpAndSupport,
            this.tsLogOut});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(542, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsChangeDetails
            // 
            this.tsChangeDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tsChangeDetails.Name = "tsChangeDetails";
            this.tsChangeDetails.Size = new System.Drawing.Size(101, 20);
            this.tsChangeDetails.Text = "Change Details ";
            this.tsChangeDetails.Click += new System.EventHandler(this.tsChangeDetails_Click);
            // 
            // tsViewStatistics
            // 
            this.tsViewStatistics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tsViewStatistics.Name = "tsViewStatistics";
            this.tsViewStatistics.Size = new System.Drawing.Size(96, 20);
            this.tsViewStatistics.Text = "View Statistics ";
            this.tsViewStatistics.Click += new System.EventHandler(this.tsViewStatistics_Click);
            // 
            // tsAddGarment
            // 
            this.tsAddGarment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tsAddGarment.Name = "tsAddGarment";
            this.tsAddGarment.Size = new System.Drawing.Size(152, 20);
            this.tsAddGarment.Text = "Add or Delete a Garment ";
            this.tsAddGarment.Click += new System.EventHandler(this.tsAddGarment_Click);
            // 
            // tsHelpAndSupport
            // 
            this.tsHelpAndSupport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tsHelpAndSupport.Name = "tsHelpAndSupport";
            this.tsHelpAndSupport.Size = new System.Drawing.Size(115, 20);
            this.tsHelpAndSupport.Text = "Help and Support ";
            this.tsHelpAndSupport.Click += new System.EventHandler(this.tsHelpAndSupport_Click);
            // 
            // tsLogOut
            // 
            this.tsLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tsLogOut.Name = "tsLogOut";
            this.tsLogOut.Size = new System.Drawing.Size(62, 20);
            this.tsLogOut.Text = "Log Out";
            this.tsLogOut.Click += new System.EventHandler(this.tsLogOut_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblOnline
            // 
            this.lblOnline.AutoSize = true;
            this.lblOnline.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOnline.ForeColor = System.Drawing.Color.Black;
            this.lblOnline.Location = new System.Drawing.Point(1, 370);
            this.lblOnline.Name = "lblOnline";
            this.lblOnline.Size = new System.Drawing.Size(118, 20);
            this.lblOnline.TabIndex = 37;
            this.lblOnline.Text = "Minutes Online:";
            // 
            // lblToday
            // 
            this.lblToday.AutoSize = true;
            this.lblToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblToday.ForeColor = System.Drawing.Color.Black;
            this.lblToday.Location = new System.Drawing.Point(1, 326);
            this.lblToday.Name = "lblToday";
            this.lblToday.Size = new System.Drawing.Size(80, 24);
            this.lblToday.TabIndex = 36;
            this.lblToday.Text = "TODAY";
            // 
            // lblHelpInfo
            // 
            this.lblHelpInfo.AutoSize = true;
            this.lblHelpInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelpInfo.ForeColor = System.Drawing.Color.Black;
            this.lblHelpInfo.Location = new System.Drawing.Point(1, 138);
            this.lblHelpInfo.Name = "lblHelpInfo";
            this.lblHelpInfo.Size = new System.Drawing.Size(515, 160);
            this.lblHelpInfo.TabIndex = 35;
            this.lblHelpInfo.Text = resources.GetString("lblHelpInfo.Text");
            // 
            // lblHelp
            // 
            this.lblHelp.AutoSize = true;
            this.lblHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblHelp.ForeColor = System.Drawing.Color.Black;
            this.lblHelp.Location = new System.Drawing.Point(1, 109);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(63, 24);
            this.lblHelp.TabIndex = 34;
            this.lblHelp.Text = "HELP";
            // 
            // mcCalendar
            // 
            this.mcCalendar.Location = new System.Drawing.Point(289, 325);
            this.mcCalendar.Name = "mcCalendar";
            this.mcCalendar.TabIndex = 33;
            // 
            // lblAboutThisPage
            // 
            this.lblAboutThisPage.AutoSize = true;
            this.lblAboutThisPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAboutThisPage.ForeColor = System.Drawing.Color.Black;
            this.lblAboutThisPage.Location = new System.Drawing.Point(1, 61);
            this.lblAboutThisPage.Name = "lblAboutThisPage";
            this.lblAboutThisPage.Size = new System.Drawing.Size(472, 40);
            this.lblAboutThisPage.TabIndex = 32;
            this.lblAboutThisPage.Text = "Welcome to your homepage. From this page you can access your \r\npersonal details a" +
    "nd view your daily statistics. ";
            // 
            // lblOnlineTime
            // 
            this.lblOnlineTime.AutoSize = true;
            this.lblOnlineTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOnlineTime.ForeColor = System.Drawing.Color.Black;
            this.lblOnlineTime.Location = new System.Drawing.Point(121, 370);
            this.lblOnlineTime.Name = "lblOnlineTime";
            this.lblOnlineTime.Size = new System.Drawing.Size(18, 20);
            this.lblOnlineTime.TabIndex = 31;
            this.lblOnlineTime.Text = "0";
            // 
            // lblLoggedInTime
            // 
            this.lblLoggedInTime.AutoSize = true;
            this.lblLoggedInTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoggedInTime.ForeColor = System.Drawing.Color.Black;
            this.lblLoggedInTime.Location = new System.Drawing.Point(1, 419);
            this.lblLoggedInTime.Name = "lblLoggedInTime";
            this.lblLoggedInTime.Size = new System.Drawing.Size(105, 20);
            this.lblLoggedInTime.TabIndex = 30;
            this.lblLoggedInTime.Text = "Logged in at: ";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.Black;
            this.lblUserName.Location = new System.Drawing.Point(1, 26);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(51, 31);
            this.lblUserName.TabIndex = 29;
            this.lblUserName.Text = "Hi!";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Black;
            this.lblDate.Location = new System.Drawing.Point(1, 468);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(44, 20);
            this.lblDate.TabIndex = 28;
            this.lblDate.Text = "Date";
            // 
            // timer2
            // 
            this.timer2.Interval = 60000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // frmUserHomepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(542, 505);
            this.Controls.Add(this.lblOnline);
            this.Controls.Add(this.lblToday);
            this.Controls.Add(this.lblHelpInfo);
            this.Controls.Add(this.lblHelp);
            this.Controls.Add(this.mcCalendar);
            this.Controls.Add(this.lblAboutThisPage);
            this.Controls.Add(this.lblOnlineTime);
            this.Controls.Add(this.lblLoggedInTime);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmUserHomepage";
            this.Text = "User Homepage";
            this.Load += new System.EventHandler(this.frmUserHomepage_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsChangeDetails;
        private System.Windows.Forms.ToolStripMenuItem tsViewStatistics;
        private System.Windows.Forms.ToolStripMenuItem tsAddGarment;
        private System.Windows.Forms.ToolStripMenuItem tsHelpAndSupport;
        private System.Windows.Forms.ToolStripMenuItem tsLogOut;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblOnline;
        private System.Windows.Forms.Label lblToday;
        private System.Windows.Forms.Label lblHelpInfo;
        private System.Windows.Forms.Label lblHelp;
        private System.Windows.Forms.MonthCalendar mcCalendar;
        private System.Windows.Forms.Label lblAboutThisPage;
        private System.Windows.Forms.Label lblOnlineTime;
        private System.Windows.Forms.Label lblLoggedInTime;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Timer timer2;
    }
}