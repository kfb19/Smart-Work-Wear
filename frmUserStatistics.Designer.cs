namespace Coursework
{
    partial class frmUserStatistics
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserStatistics));
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnBack = new System.Windows.Forms.Button();
            this.cmbGarmentStatuses = new System.Windows.Forms.ComboBox();
            this.lblChooseDate = new System.Windows.Forms.Label();
            this.lblMildEvents = new System.Windows.Forms.Label();
            this.lblYourStats = new System.Windows.Forms.Label();
            this.lblUploadData = new System.Windows.Forms.Label();
            this.lblCriticalEvents = new System.Windows.Forms.Label();
            this.lblTotalEvents = new System.Windows.Forms.Label();
            this.btnPrintGraph = new System.Windows.Forms.Button();
            this.lblLowestAngle = new System.Windows.Forms.Label();
            this.lblHighestAngle = new System.Windows.Forms.Label();
            this.lblCriticalEventNo = new System.Windows.Forms.Label();
            this.lblLowestAngleNo = new System.Windows.Forms.Label();
            this.lblHighestAngleNo = new System.Windows.Forms.Label();
            this.lblTotalEventNo = new System.Windows.Forms.Label();
            this.lblMildEventNo = new System.Windows.Forms.Label();
            this.lblAverageAngleNo = new System.Windows.Forms.Label();
            this.lblAverageAngle = new System.Windows.Forms.Label();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(452, 65);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chart1.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))))};
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(300, 300);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBack.Location = new System.Drawing.Point(689, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(63, 32);
            this.btnBack.TabIndex = 50;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // cmbGarmentStatuses
            // 
            this.cmbGarmentStatuses.FormattingEnabled = true;
            this.cmbGarmentStatuses.Location = new System.Drawing.Point(475, 38);
            this.cmbGarmentStatuses.Name = "cmbGarmentStatuses";
            this.cmbGarmentStatuses.Size = new System.Drawing.Size(188, 21);
            this.cmbGarmentStatuses.TabIndex = 73;
            this.cmbGarmentStatuses.SelectedIndexChanged += new System.EventHandler(this.cmbGarmentStatuses_SelectedIndexChanged);
            // 
            // lblChooseDate
            // 
            this.lblChooseDate.AutoSize = true;
            this.lblChooseDate.Location = new System.Drawing.Point(499, 15);
            this.lblChooseDate.Name = "lblChooseDate";
            this.lblChooseDate.Size = new System.Drawing.Size(136, 13);
            this.lblChooseDate.TabIndex = 74;
            this.lblChooseDate.Text = "Choose Date to View Data:";
            // 
            // lblMildEvents
            // 
            this.lblMildEvents.AutoSize = true;
            this.lblMildEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblMildEvents.ForeColor = System.Drawing.Color.Black;
            this.lblMildEvents.Location = new System.Drawing.Point(14, 68);
            this.lblMildEvents.Name = "lblMildEvents";
            this.lblMildEvents.Size = new System.Drawing.Size(228, 24);
            this.lblMildEvents.TabIndex = 75;
            this.lblMildEvents.Text = "Number of Mild Events:";
            // 
            // lblYourStats
            // 
            this.lblYourStats.AutoSize = true;
            this.lblYourStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYourStats.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblYourStats.Location = new System.Drawing.Point(14, 10);
            this.lblYourStats.Name = "lblYourStats";
            this.lblYourStats.Size = new System.Drawing.Size(204, 31);
            this.lblYourStats.TabIndex = 76;
            this.lblYourStats.Text = "Your Statistics";
            // 
            // lblUploadData
            // 
            this.lblUploadData.AutoSize = true;
            this.lblUploadData.Location = new System.Drawing.Point(14, 46);
            this.lblUploadData.Name = "lblUploadData";
            this.lblUploadData.Size = new System.Drawing.Size(379, 13);
            this.lblUploadData.TabIndex = 77;
            this.lblUploadData.Text = "If you have not recently uploaded your data, please do so as soon as possible. ";
            // 
            // lblCriticalEvents
            // 
            this.lblCriticalEvents.AutoSize = true;
            this.lblCriticalEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblCriticalEvents.ForeColor = System.Drawing.Color.Black;
            this.lblCriticalEvents.Location = new System.Drawing.Point(14, 98);
            this.lblCriticalEvents.Name = "lblCriticalEvents";
            this.lblCriticalEvents.Size = new System.Drawing.Size(252, 24);
            this.lblCriticalEvents.TabIndex = 78;
            this.lblCriticalEvents.Text = "Number of Critical Events:";
            // 
            // lblTotalEvents
            // 
            this.lblTotalEvents.AutoSize = true;
            this.lblTotalEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTotalEvents.ForeColor = System.Drawing.Color.Black;
            this.lblTotalEvents.Location = new System.Drawing.Point(14, 128);
            this.lblTotalEvents.Name = "lblTotalEvents";
            this.lblTotalEvents.Size = new System.Drawing.Size(235, 24);
            this.lblTotalEvents.TabIndex = 79;
            this.lblTotalEvents.Text = "Total Number of Events:";
            // 
            // btnPrintGraph
            // 
            this.btnPrintGraph.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPrintGraph.Location = new System.Drawing.Point(47, 258);
            this.btnPrintGraph.Name = "btnPrintGraph";
            this.btnPrintGraph.Size = new System.Drawing.Size(171, 103);
            this.btnPrintGraph.TabIndex = 80;
            this.btnPrintGraph.Text = "Print Analysis Report";
            this.btnPrintGraph.UseVisualStyleBackColor = false;
            this.btnPrintGraph.Click += new System.EventHandler(this.btnPrintGraph_Click);
            // 
            // lblLowestAngle
            // 
            this.lblLowestAngle.AutoSize = true;
            this.lblLowestAngle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblLowestAngle.ForeColor = System.Drawing.Color.Black;
            this.lblLowestAngle.Location = new System.Drawing.Point(14, 188);
            this.lblLowestAngle.Name = "lblLowestAngle";
            this.lblLowestAngle.Size = new System.Drawing.Size(240, 24);
            this.lblLowestAngle.TabIndex = 82;
            this.lblLowestAngle.Text = "Lowest Angle Recorded:";
            // 
            // lblHighestAngle
            // 
            this.lblHighestAngle.AutoSize = true;
            this.lblHighestAngle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblHighestAngle.ForeColor = System.Drawing.Color.Black;
            this.lblHighestAngle.Location = new System.Drawing.Point(14, 158);
            this.lblHighestAngle.Name = "lblHighestAngle";
            this.lblHighestAngle.Size = new System.Drawing.Size(246, 24);
            this.lblHighestAngle.TabIndex = 83;
            this.lblHighestAngle.Text = "Highest Angle Recorded:";
            // 
            // lblCriticalEventNo
            // 
            this.lblCriticalEventNo.AutoSize = true;
            this.lblCriticalEventNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblCriticalEventNo.ForeColor = System.Drawing.Color.Black;
            this.lblCriticalEventNo.Location = new System.Drawing.Point(266, 98);
            this.lblCriticalEventNo.Name = "lblCriticalEventNo";
            this.lblCriticalEventNo.Size = new System.Drawing.Size(21, 24);
            this.lblCriticalEventNo.TabIndex = 85;
            this.lblCriticalEventNo.Text = "0";
            // 
            // lblLowestAngleNo
            // 
            this.lblLowestAngleNo.AutoSize = true;
            this.lblLowestAngleNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblLowestAngleNo.ForeColor = System.Drawing.Color.Black;
            this.lblLowestAngleNo.Location = new System.Drawing.Point(255, 188);
            this.lblLowestAngleNo.Name = "lblLowestAngleNo";
            this.lblLowestAngleNo.Size = new System.Drawing.Size(21, 24);
            this.lblLowestAngleNo.TabIndex = 87;
            this.lblLowestAngleNo.Text = "0";
            // 
            // lblHighestAngleNo
            // 
            this.lblHighestAngleNo.AutoSize = true;
            this.lblHighestAngleNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblHighestAngleNo.ForeColor = System.Drawing.Color.Black;
            this.lblHighestAngleNo.Location = new System.Drawing.Point(266, 158);
            this.lblHighestAngleNo.Name = "lblHighestAngleNo";
            this.lblHighestAngleNo.Size = new System.Drawing.Size(21, 24);
            this.lblHighestAngleNo.TabIndex = 88;
            this.lblHighestAngleNo.Text = "0";
            // 
            // lblTotalEventNo
            // 
            this.lblTotalEventNo.AutoSize = true;
            this.lblTotalEventNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTotalEventNo.ForeColor = System.Drawing.Color.Black;
            this.lblTotalEventNo.Location = new System.Drawing.Point(255, 128);
            this.lblTotalEventNo.Name = "lblTotalEventNo";
            this.lblTotalEventNo.Size = new System.Drawing.Size(21, 24);
            this.lblTotalEventNo.TabIndex = 89;
            this.lblTotalEventNo.Text = "0";
            // 
            // lblMildEventNo
            // 
            this.lblMildEventNo.AutoSize = true;
            this.lblMildEventNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblMildEventNo.ForeColor = System.Drawing.Color.Black;
            this.lblMildEventNo.Location = new System.Drawing.Point(248, 68);
            this.lblMildEventNo.Name = "lblMildEventNo";
            this.lblMildEventNo.Size = new System.Drawing.Size(21, 24);
            this.lblMildEventNo.TabIndex = 90;
            this.lblMildEventNo.Text = "0";
            // 
            // lblAverageAngleNo
            // 
            this.lblAverageAngleNo.AutoSize = true;
            this.lblAverageAngleNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblAverageAngleNo.ForeColor = System.Drawing.Color.Black;
            this.lblAverageAngleNo.Location = new System.Drawing.Point(266, 218);
            this.lblAverageAngleNo.Name = "lblAverageAngleNo";
            this.lblAverageAngleNo.Size = new System.Drawing.Size(21, 24);
            this.lblAverageAngleNo.TabIndex = 92;
            this.lblAverageAngleNo.Text = "0";
            // 
            // lblAverageAngle
            // 
            this.lblAverageAngle.AutoSize = true;
            this.lblAverageAngle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblAverageAngle.ForeColor = System.Drawing.Color.Black;
            this.lblAverageAngle.Location = new System.Drawing.Point(14, 218);
            this.lblAverageAngle.Name = "lblAverageAngle";
            this.lblAverageAngle.Size = new System.Drawing.Size(253, 24);
            this.lblAverageAngle.TabIndex = 91;
            this.lblAverageAngle.Text = "Average Angle Recorded:";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // frmUserStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(764, 377);
            this.Controls.Add(this.lblAverageAngleNo);
            this.Controls.Add(this.lblAverageAngle);
            this.Controls.Add(this.lblMildEventNo);
            this.Controls.Add(this.lblTotalEventNo);
            this.Controls.Add(this.lblHighestAngleNo);
            this.Controls.Add(this.lblLowestAngleNo);
            this.Controls.Add(this.lblCriticalEventNo);
            this.Controls.Add(this.lblHighestAngle);
            this.Controls.Add(this.lblLowestAngle);
            this.Controls.Add(this.btnPrintGraph);
            this.Controls.Add(this.lblTotalEvents);
            this.Controls.Add(this.lblCriticalEvents);
            this.Controls.Add(this.lblUploadData);
            this.Controls.Add(this.lblYourStats);
            this.Controls.Add(this.lblMildEvents);
            this.Controls.Add(this.lblChooseDate);
            this.Controls.Add(this.cmbGarmentStatuses);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.chart1);
            this.Name = "frmUserStatistics";
            this.Text = "frmUserStatistics";
            this.Load += new System.EventHandler(this.frmUserStatistics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox cmbGarmentStatuses;
        private System.Windows.Forms.Label lblChooseDate;
        private System.Windows.Forms.Label lblMildEvents;
        private System.Windows.Forms.Label lblYourStats;
        private System.Windows.Forms.Label lblUploadData;
        private System.Windows.Forms.Label lblCriticalEvents;
        private System.Windows.Forms.Label lblTotalEvents;
        private System.Windows.Forms.Button btnPrintGraph;
        private System.Windows.Forms.Label lblLowestAngle;
        private System.Windows.Forms.Label lblHighestAngle;
        private System.Windows.Forms.Label lblCriticalEventNo;
        private System.Windows.Forms.Label lblLowestAngleNo;
        private System.Windows.Forms.Label lblHighestAngleNo;
        private System.Windows.Forms.Label lblTotalEventNo;
        private System.Windows.Forms.Label lblMildEventNo;
        private System.Windows.Forms.Label lblAverageAngleNo;
        private System.Windows.Forms.Label lblAverageAngle;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}