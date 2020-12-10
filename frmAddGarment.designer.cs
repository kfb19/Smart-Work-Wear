namespace Coursework
{
    partial class frmAddGarment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddGarment));
            this.pbTrousers = new System.Windows.Forms.PictureBox();
            this.lblMasterMAC = new System.Windows.Forms.Label();
            this.lblRL = new System.Windows.Forms.Label();
            this.lblLL = new System.Windows.Forms.Label();
            this.lblLU = new System.Windows.Forms.Label();
            this.lblRU = new System.Windows.Forms.Label();
            this.lblView = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblAddGarment = new System.Windows.Forms.Label();
            this.txtLLMAC = new System.Windows.Forms.TextBox();
            this.txtRLMAC = new System.Windows.Forms.TextBox();
            this.txtRUMAC = new System.Windows.Forms.TextBox();
            this.txtMasterMAC = new System.Windows.Forms.TextBox();
            this.lblRightLower = new System.Windows.Forms.Label();
            this.lblLeftLower = new System.Windows.Forms.Label();
            this.lblTypeOfGarment = new System.Windows.Forms.Label();
            this.lblRightUpper = new System.Windows.Forms.Label();
            this.lblMasterMACEnter = new System.Windows.Forms.Label();
            this.lblDeleteGarment = new System.Windows.Forms.Label();
            this.lblLeftUpper = new System.Windows.Forms.Label();
            this.txtLUMAC = new System.Windows.Forms.TextBox();
            this.dudGarmentType = new System.Windows.Forms.DomainUpDown();
            this.btnAddGarment = new System.Windows.Forms.Button();
            this.flpExistingGarments = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pbTrousers)).BeginInit();
            this.SuspendLayout();
            // 
            // pbTrousers
            // 
            this.pbTrousers.Image = ((System.Drawing.Image)(resources.GetObject("pbTrousers.Image")));
            this.pbTrousers.Location = new System.Drawing.Point(359, 55);
            this.pbTrousers.Name = "pbTrousers";
            this.pbTrousers.Size = new System.Drawing.Size(183, 211);
            this.pbTrousers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTrousers.TabIndex = 0;
            this.pbTrousers.TabStop = false;
            // 
            // lblMasterMAC
            // 
            this.lblMasterMAC.AutoSize = true;
            this.lblMasterMAC.BackColor = System.Drawing.Color.Transparent;
            this.lblMasterMAC.Location = new System.Drawing.Point(426, 55);
            this.lblMasterMAC.Name = "lblMasterMAC";
            this.lblMasterMAC.Size = new System.Drawing.Size(52, 13);
            this.lblMasterMAC.TabIndex = 1;
            this.lblMasterMAC.Text = "MASTER";
            // 
            // lblRL
            // 
            this.lblRL.AutoSize = true;
            this.lblRL.BackColor = System.Drawing.Color.Transparent;
            this.lblRL.Location = new System.Drawing.Point(375, 189);
            this.lblRL.Name = "lblRL";
            this.lblRL.Size = new System.Drawing.Size(21, 13);
            this.lblRL.TabIndex = 2;
            this.lblRL.Text = "RL";
            // 
            // lblLL
            // 
            this.lblLL.AutoSize = true;
            this.lblLL.BackColor = System.Drawing.Color.Transparent;
            this.lblLL.Location = new System.Drawing.Point(511, 189);
            this.lblLL.Name = "lblLL";
            this.lblLL.Size = new System.Drawing.Size(19, 13);
            this.lblLL.TabIndex = 3;
            this.lblLL.Text = "LL";
            // 
            // lblLU
            // 
            this.lblLU.AutoSize = true;
            this.lblLU.BackColor = System.Drawing.Color.Transparent;
            this.lblLU.Location = new System.Drawing.Point(511, 135);
            this.lblLU.Name = "lblLU";
            this.lblLU.Size = new System.Drawing.Size(21, 13);
            this.lblLU.TabIndex = 4;
            this.lblLU.Text = "LU";
            // 
            // lblRU
            // 
            this.lblRU.AutoSize = true;
            this.lblRU.BackColor = System.Drawing.Color.Transparent;
            this.lblRU.Location = new System.Drawing.Point(373, 135);
            this.lblRU.Name = "lblRU";
            this.lblRU.Size = new System.Drawing.Size(23, 13);
            this.lblRU.TabIndex = 5;
            this.lblRU.Text = "RU";
            // 
            // lblView
            // 
            this.lblView.AutoSize = true;
            this.lblView.BackColor = System.Drawing.Color.Transparent;
            this.lblView.Location = new System.Drawing.Point(372, 251);
            this.lblView.Name = "lblView";
            this.lblView.Size = new System.Drawing.Size(163, 13);
            this.lblView.TabIndex = 6;
            this.lblView.Text = "With the front facing towards you";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBack.Location = new System.Drawing.Point(489, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(63, 32);
            this.btnBack.TabIndex = 63;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblAddGarment
            // 
            this.lblAddGarment.AutoSize = true;
            this.lblAddGarment.Font = new System.Drawing.Font("Rockwell", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddGarment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblAddGarment.Location = new System.Drawing.Point(45, 12);
            this.lblAddGarment.Name = "lblAddGarment";
            this.lblAddGarment.Size = new System.Drawing.Size(300, 43);
            this.lblAddGarment.TabIndex = 59;
            this.lblAddGarment.Text = "Add a Garment: ";
            // 
            // txtLLMAC
            // 
            this.txtLLMAC.Location = new System.Drawing.Point(188, 186);
            this.txtLLMAC.Name = "txtLLMAC";
            this.txtLLMAC.Size = new System.Drawing.Size(137, 20);
            this.txtLLMAC.TabIndex = 57;
            // 
            // txtRLMAC
            // 
            this.txtRLMAC.Location = new System.Drawing.Point(188, 126);
            this.txtRLMAC.Name = "txtRLMAC";
            this.txtRLMAC.Size = new System.Drawing.Size(137, 20);
            this.txtRLMAC.TabIndex = 56;
            // 
            // txtRUMAC
            // 
            this.txtRUMAC.Location = new System.Drawing.Point(188, 96);
            this.txtRUMAC.Name = "txtRUMAC";
            this.txtRUMAC.Size = new System.Drawing.Size(137, 20);
            this.txtRUMAC.TabIndex = 55;
            // 
            // txtMasterMAC
            // 
            this.txtMasterMAC.Location = new System.Drawing.Point(188, 66);
            this.txtMasterMAC.Name = "txtMasterMAC";
            this.txtMasterMAC.Size = new System.Drawing.Size(137, 20);
            this.txtMasterMAC.TabIndex = 54;
            // 
            // lblRightLower
            // 
            this.lblRightLower.AutoSize = true;
            this.lblRightLower.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRightLower.Location = new System.Drawing.Point(39, 126);
            this.lblRightLower.Name = "lblRightLower";
            this.lblRightLower.Size = new System.Drawing.Size(137, 20);
            this.lblRightLower.TabIndex = 53;
            this.lblRightLower.Text = "Right Lower MAC:";
            // 
            // lblLeftLower
            // 
            this.lblLeftLower.AutoSize = true;
            this.lblLeftLower.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeftLower.Location = new System.Drawing.Point(49, 186);
            this.lblLeftLower.Name = "lblLeftLower";
            this.lblLeftLower.Size = new System.Drawing.Size(127, 20);
            this.lblLeftLower.TabIndex = 52;
            this.lblLeftLower.Text = "Left Lower MAC:";
            // 
            // lblTypeOfGarment
            // 
            this.lblTypeOfGarment.AutoSize = true;
            this.lblTypeOfGarment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeOfGarment.Location = new System.Drawing.Point(58, 216);
            this.lblTypeOfGarment.Name = "lblTypeOfGarment";
            this.lblTypeOfGarment.Size = new System.Drawing.Size(118, 20);
            this.lblTypeOfGarment.TabIndex = 51;
            this.lblTypeOfGarment.Text = "Garment Type: ";
            // 
            // lblRightUpper
            // 
            this.lblRightUpper.AutoSize = true;
            this.lblRightUpper.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRightUpper.Location = new System.Drawing.Point(38, 96);
            this.lblRightUpper.Name = "lblRightUpper";
            this.lblRightUpper.Size = new System.Drawing.Size(138, 20);
            this.lblRightUpper.TabIndex = 48;
            this.lblRightUpper.Text = "Right Upper MAC:";
            // 
            // lblMasterMACEnter
            // 
            this.lblMasterMACEnter.AutoSize = true;
            this.lblMasterMACEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMasterMACEnter.Location = new System.Drawing.Point(12, 66);
            this.lblMasterMACEnter.Name = "lblMasterMACEnter";
            this.lblMasterMACEnter.Size = new System.Drawing.Size(164, 20);
            this.lblMasterMACEnter.TabIndex = 47;
            this.lblMasterMACEnter.Text = "Master MAC Address:";
            // 
            // lblDeleteGarment
            // 
            this.lblDeleteGarment.AutoSize = true;
            this.lblDeleteGarment.Font = new System.Drawing.Font("Rockwell", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteGarment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblDeleteGarment.Location = new System.Drawing.Point(25, 318);
            this.lblDeleteGarment.Name = "lblDeleteGarment";
            this.lblDeleteGarment.Size = new System.Drawing.Size(342, 43);
            this.lblDeleteGarment.TabIndex = 64;
            this.lblDeleteGarment.Text = "Delete a Garment: ";
            // 
            // lblLeftUpper
            // 
            this.lblLeftUpper.AutoSize = true;
            this.lblLeftUpper.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeftUpper.Location = new System.Drawing.Point(48, 156);
            this.lblLeftUpper.Name = "lblLeftUpper";
            this.lblLeftUpper.Size = new System.Drawing.Size(128, 20);
            this.lblLeftUpper.TabIndex = 49;
            this.lblLeftUpper.Text = "Left Upper MAC:";
            // 
            // txtLUMAC
            // 
            this.txtLUMAC.Location = new System.Drawing.Point(188, 156);
            this.txtLUMAC.Name = "txtLUMAC";
            this.txtLUMAC.Size = new System.Drawing.Size(137, 20);
            this.txtLUMAC.TabIndex = 65;
            // 
            // dudGarmentType
            // 
            this.dudGarmentType.Items.Add("Trousers");
            this.dudGarmentType.Items.Add("Shirt");
            this.dudGarmentType.Items.Add("Jacket");
            this.dudGarmentType.Location = new System.Drawing.Point(188, 216);
            this.dudGarmentType.Name = "dudGarmentType";
            this.dudGarmentType.Size = new System.Drawing.Size(137, 20);
            this.dudGarmentType.TabIndex = 66;
            this.dudGarmentType.Text = "Choose a Garment...";
            // 
            // btnAddGarment
            // 
            this.btnAddGarment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAddGarment.Location = new System.Drawing.Point(133, 261);
            this.btnAddGarment.Name = "btnAddGarment";
            this.btnAddGarment.Size = new System.Drawing.Size(88, 43);
            this.btnAddGarment.TabIndex = 67;
            this.btnAddGarment.Text = "Add Garment";
            this.btnAddGarment.UseVisualStyleBackColor = false;
            this.btnAddGarment.Click += new System.EventHandler(this.btnAddGarment_Click);
            // 
            // flpExistingGarments
            // 
            this.flpExistingGarments.Location = new System.Drawing.Point(21, 364);
            this.flpExistingGarments.Name = "flpExistingGarments";
            this.flpExistingGarments.Size = new System.Drawing.Size(521, 219);
            this.flpExistingGarments.TabIndex = 68;
            // 
            // frmAddGarment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(564, 595);
            this.Controls.Add(this.flpExistingGarments);
            this.Controls.Add(this.btnAddGarment);
            this.Controls.Add(this.dudGarmentType);
            this.Controls.Add(this.txtLUMAC);
            this.Controls.Add(this.lblDeleteGarment);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblAddGarment);
            this.Controls.Add(this.txtLLMAC);
            this.Controls.Add(this.txtRLMAC);
            this.Controls.Add(this.txtRUMAC);
            this.Controls.Add(this.txtMasterMAC);
            this.Controls.Add(this.lblRightLower);
            this.Controls.Add(this.lblLeftLower);
            this.Controls.Add(this.lblTypeOfGarment);
            this.Controls.Add(this.lblLeftUpper);
            this.Controls.Add(this.lblRightUpper);
            this.Controls.Add(this.lblMasterMACEnter);
            this.Controls.Add(this.lblView);
            this.Controls.Add(this.lblRU);
            this.Controls.Add(this.lblLU);
            this.Controls.Add(this.lblLL);
            this.Controls.Add(this.lblRL);
            this.Controls.Add(this.lblMasterMAC);
            this.Controls.Add(this.pbTrousers);
            this.Name = "frmAddGarment";
            this.Text = "Add a Garment";
            this.Load += new System.EventHandler(this.frmAddGarment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbTrousers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbTrousers;
        private System.Windows.Forms.Label lblMasterMAC;
        private System.Windows.Forms.Label lblRL;
        private System.Windows.Forms.Label lblLL;
        private System.Windows.Forms.Label lblLU;
        private System.Windows.Forms.Label lblRU;
        private System.Windows.Forms.Label lblView;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblAddGarment;
        private System.Windows.Forms.TextBox txtLLMAC;
        private System.Windows.Forms.TextBox txtRLMAC;
        private System.Windows.Forms.TextBox txtRUMAC;
        private System.Windows.Forms.TextBox txtMasterMAC;
        private System.Windows.Forms.Label lblRightLower;
        private System.Windows.Forms.Label lblLeftLower;
        private System.Windows.Forms.Label lblTypeOfGarment;
        private System.Windows.Forms.Label lblRightUpper;
        private System.Windows.Forms.Label lblMasterMACEnter;
        private System.Windows.Forms.Label lblDeleteGarment;
        private System.Windows.Forms.Label lblLeftUpper;
        private System.Windows.Forms.TextBox txtLUMAC;
        private System.Windows.Forms.DomainUpDown dudGarmentType;
        private System.Windows.Forms.Button btnAddGarment;
        private System.Windows.Forms.FlowLayoutPanel flpExistingGarments;
    }
}