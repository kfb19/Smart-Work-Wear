namespace Coursework
{
    partial class frmCompaniesHomepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCompaniesHomepage));
            this.lblDate = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsViewEmployees = new System.Windows.Forms.ToolStripMenuItem();
            this.tsViewStatistics = new System.Windows.Forms.ToolStripMenuItem();
            this.tsAddEmployees = new System.Windows.Forms.ToolStripMenuItem();
            this.tsEditEmployees = new System.Windows.Forms.ToolStripMenuItem();
            this.tsChangeDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.tsAddNest = new System.Windows.Forms.ToolStripMenuItem();
            this.tsViewNests = new System.Windows.Forms.ToolStripMenuItem();
            this.tsDeleteUser = new System.Windows.Forms.ToolStripMenuItem();
            this.tsLogOut = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.lblLoggedInTime = new System.Windows.Forms.Label();
            this.lblOnlineTime = new System.Windows.Forms.Label();
            this.lblAboutThisPage = new System.Windows.Forms.Label();
            this.mcCalendar = new System.Windows.Forms.MonthCalendar();
            this.lblHelp = new System.Windows.Forms.Label();
            this.lblHelpInfo = new System.Windows.Forms.Label();
            this.lblToday = new System.Windows.Forms.Label();
            this.lblOnline = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Black;
            this.lblDate.Location = new System.Drawing.Point(1, 388);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(44, 20);
            this.lblDate.TabIndex = 7;
            this.lblDate.Text = "Date";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsViewEmployees,
            this.tsViewStatistics,
            this.tsAddEmployees,
            this.tsEditEmployees,
            this.tsDeleteUser,
            this.tsChangeDetails,
            this.tsAddNest,
            this.tsViewNests,
            this.tsLogOut});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(920, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsViewEmployees
            // 
            this.tsViewEmployees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tsViewEmployees.Name = "tsViewEmployees";
            this.tsViewEmployees.Size = new System.Drawing.Size(104, 20);
            this.tsViewEmployees.Text = "View Employees";
            this.tsViewEmployees.Click += new System.EventHandler(this.tsViewEmployees_Click);
            // 
            // tsViewStatistics
            // 
            this.tsViewStatistics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tsViewStatistics.Name = "tsViewStatistics";
            this.tsViewStatistics.Size = new System.Drawing.Size(93, 20);
            this.tsViewStatistics.Text = "View Statistics";
            this.tsViewStatistics.Click += new System.EventHandler(this.tsViewStatistics_Click);
            // 
            // tsAddEmployees
            // 
            this.tsAddEmployees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tsAddEmployees.Name = "tsAddEmployees";
            this.tsAddEmployees.Size = new System.Drawing.Size(115, 20);
            this.tsAddEmployees.Text = "Add an Employee ";
            this.tsAddEmployees.Click += new System.EventHandler(this.tsAddEmployees_Click);
            // 
            // tsEditEmployees
            // 
            this.tsEditEmployees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tsEditEmployees.Name = "tsEditEmployees";
            this.tsEditEmployees.Size = new System.Drawing.Size(102, 20);
            this.tsEditEmployees.Text = "Edit Employees ";
            this.tsEditEmployees.Click += new System.EventHandler(this.tsEditEmployees_Click);
            // 
            // tsChangeDetails
            // 
            this.tsChangeDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tsChangeDetails.Name = "tsChangeDetails";
            this.tsChangeDetails.Size = new System.Drawing.Size(156, 20);
            this.tsChangeDetails.Text = "Change Company Details ";
            this.tsChangeDetails.Click += new System.EventHandler(this.tsChangeDetails_Click);
            // 
            // tsAddNest
            // 
            this.tsAddNest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tsAddNest.Name = "tsAddNest";
            this.tsAddNest.Size = new System.Drawing.Size(77, 20);
            this.tsAddNest.Text = "Add a Nest";
            this.tsAddNest.Click += new System.EventHandler(this.tsAddNest_Click);
            // 
            // tsViewNests
            // 
            this.tsViewNests.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tsViewNests.Name = "tsViewNests";
            this.tsViewNests.Size = new System.Drawing.Size(76, 20);
            this.tsViewNests.Text = "View Nests";
            this.tsViewNests.Click += new System.EventHandler(this.tsViewNests_Click);
            // 
            // tsDeleteUser
            // 
            this.tsDeleteUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tsDeleteUser.Name = "tsDeleteUser";
            this.tsDeleteUser.Size = new System.Drawing.Size(123, 20);
            this.tsDeleteUser.Text = "Delete an Employee";
            this.tsDeleteUser.Click += new System.EventHandler(this.tsDeleteUser_Click);
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
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyName.ForeColor = System.Drawing.Color.Black;
            this.lblCompanyName.Location = new System.Drawing.Point(1, 25);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(221, 31);
            this.lblCompanyName.TabIndex = 8;
            this.lblCompanyName.Text = "Company Name";
            // 
            // lblLoggedInTime
            // 
            this.lblLoggedInTime.AutoSize = true;
            this.lblLoggedInTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoggedInTime.ForeColor = System.Drawing.Color.Black;
            this.lblLoggedInTime.Location = new System.Drawing.Point(1, 339);
            this.lblLoggedInTime.Name = "lblLoggedInTime";
            this.lblLoggedInTime.Size = new System.Drawing.Size(105, 20);
            this.lblLoggedInTime.TabIndex = 9;
            this.lblLoggedInTime.Text = "Logged in at: ";
            // 
            // lblOnlineTime
            // 
            this.lblOnlineTime.AutoSize = true;
            this.lblOnlineTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOnlineTime.ForeColor = System.Drawing.Color.Black;
            this.lblOnlineTime.Location = new System.Drawing.Point(121, 291);
            this.lblOnlineTime.Name = "lblOnlineTime";
            this.lblOnlineTime.Size = new System.Drawing.Size(18, 20);
            this.lblOnlineTime.TabIndex = 10;
            this.lblOnlineTime.Text = "0";
            // 
            // lblAboutThisPage
            // 
            this.lblAboutThisPage.AutoSize = true;
            this.lblAboutThisPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAboutThisPage.ForeColor = System.Drawing.Color.Black;
            this.lblAboutThisPage.Location = new System.Drawing.Point(1, 60);
            this.lblAboutThisPage.Name = "lblAboutThisPage";
            this.lblAboutThisPage.Size = new System.Drawing.Size(857, 40);
            this.lblAboutThisPage.TabIndex = 11;
            this.lblAboutThisPage.Text = "Welcome to your company homepage. From this page you can access details of your e" +
    "mployees, company statistics and \r\nthe details of your own company. ";
            // 
            // mcCalendar
            // 
            this.mcCalendar.Location = new System.Drawing.Point(631, 246);
            this.mcCalendar.Name = "mcCalendar";
            this.mcCalendar.TabIndex = 13;
            // 
            // lblHelp
            // 
            this.lblHelp.AutoSize = true;
            this.lblHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblHelp.ForeColor = System.Drawing.Color.Black;
            this.lblHelp.Location = new System.Drawing.Point(1, 108);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(63, 24);
            this.lblHelp.TabIndex = 14;
            this.lblHelp.Text = "HELP";
            // 
            // lblHelpInfo
            // 
            this.lblHelpInfo.AutoSize = true;
            this.lblHelpInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelpInfo.ForeColor = System.Drawing.Color.Black;
            this.lblHelpInfo.Location = new System.Drawing.Point(1, 137);
            this.lblHelpInfo.Name = "lblHelpInfo";
            this.lblHelpInfo.Size = new System.Drawing.Size(857, 100);
            this.lblHelpInfo.TabIndex = 15;
            this.lblHelpInfo.Text = resources.GetString("lblHelpInfo.Text");
            // 
            // lblToday
            // 
            this.lblToday.AutoSize = true;
            this.lblToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblToday.ForeColor = System.Drawing.Color.Black;
            this.lblToday.Location = new System.Drawing.Point(1, 246);
            this.lblToday.Name = "lblToday";
            this.lblToday.Size = new System.Drawing.Size(80, 24);
            this.lblToday.TabIndex = 16;
            this.lblToday.Text = "TODAY";
            // 
            // lblOnline
            // 
            this.lblOnline.AutoSize = true;
            this.lblOnline.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOnline.ForeColor = System.Drawing.Color.Black;
            this.lblOnline.Location = new System.Drawing.Point(1, 290);
            this.lblOnline.Name = "lblOnline";
            this.lblOnline.Size = new System.Drawing.Size(118, 20);
            this.lblOnline.TabIndex = 17;
            this.lblOnline.Text = "Minutes Online:";
            // 
            // timer2
            // 
            this.timer2.Interval = 60000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // frmCompaniesHomepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(920, 427);
            this.Controls.Add(this.lblOnline);
            this.Controls.Add(this.lblToday);
            this.Controls.Add(this.lblHelpInfo);
            this.Controls.Add(this.lblHelp);
            this.Controls.Add(this.mcCalendar);
            this.Controls.Add(this.lblAboutThisPage);
            this.Controls.Add(this.lblOnlineTime);
            this.Controls.Add(this.lblLoggedInTime);
            this.Controls.Add(this.lblCompanyName);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmCompaniesHomepage";
            this.Text = "Company Homepage";
            this.Load += new System.EventHandler(this.frmCompaniesHomepage_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsViewEmployees;
        private System.Windows.Forms.ToolStripMenuItem tsViewStatistics;
        private System.Windows.Forms.ToolStripMenuItem tsAddEmployees;
        private System.Windows.Forms.ToolStripMenuItem tsEditEmployees;
        private System.Windows.Forms.ToolStripMenuItem tsChangeDetails;
        private System.Windows.Forms.ToolStripMenuItem tsLogOut;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.Label lblLoggedInTime;
        private System.Windows.Forms.Label lblOnlineTime;
        private System.Windows.Forms.Label lblAboutThisPage;
        private System.Windows.Forms.MonthCalendar mcCalendar;
        private System.Windows.Forms.Label lblHelp;
        private System.Windows.Forms.Label lblHelpInfo;
        private System.Windows.Forms.Label lblToday;
        private System.Windows.Forms.Label lblOnline;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ToolStripMenuItem tsAddNest;
        private System.Windows.Forms.ToolStripMenuItem tsViewNests;
        private System.Windows.Forms.ToolStripMenuItem tsDeleteUser;
    }
}