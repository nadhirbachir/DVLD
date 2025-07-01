namespace DVLD
{
    partial class frmReleaseDetainedLicense
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
            this.labelHeader = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRelease = new System.Windows.Forms.Button();
            this.liReleasedLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.liShowLicensesHistory = new System.Windows.Forms.LinkLabel();
            this.gbDetainInfo = new System.Windows.Forms.GroupBox();
            this.lbAppID = new System.Windows.Forms.Label();
            this.labelAppID = new System.Windows.Forms.Label();
            this.lbTotalFees = new System.Windows.Forms.Label();
            this.labelTotalFees = new System.Windows.Forms.Label();
            this.lbApplicationFees = new System.Windows.Forms.Label();
            this.labelApplicationFees = new System.Windows.Forms.Label();
            this.lbFineFees = new System.Windows.Forms.Label();
            this.labelFineFees = new System.Windows.Forms.Label();
            this.lbCreatedBy = new System.Windows.Forms.Label();
            this.labelCreatedBy = new System.Windows.Forms.Label();
            this.lbLicenseID = new System.Windows.Forms.Label();
            this.labelLicenseID = new System.Windows.Forms.Label();
            this.lbDetainDate = new System.Windows.Forms.Label();
            this.labelDetainDate = new System.Windows.Forms.Label();
            this.lbDetainID = new System.Windows.Forms.Label();
            this.labelDetainID = new System.Windows.Forms.Label();
            this.ctrlLicenseCardFilter1 = new DVLD.ctrlLicenseCardFilter();
            this.gbDetainInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.ForeColor = System.Drawing.Color.Green;
            this.labelHeader.Location = new System.Drawing.Point(149, 9);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(479, 44);
            this.labelHeader.TabIndex = 22;
            this.labelHeader.Text = "Release Detained License";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Teal;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(555, 623);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(104, 39);
            this.btnClose.TabIndex = 21;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRelease
            // 
            this.btnRelease.BackColor = System.Drawing.Color.Green;
            this.btnRelease.Enabled = false;
            this.btnRelease.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnRelease.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnRelease.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRelease.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelease.ForeColor = System.Drawing.Color.White;
            this.btnRelease.Location = new System.Drawing.Point(665, 623);
            this.btnRelease.Name = "btnRelease";
            this.btnRelease.Size = new System.Drawing.Size(104, 39);
            this.btnRelease.TabIndex = 20;
            this.btnRelease.Text = "Release";
            this.btnRelease.UseVisualStyleBackColor = false;
            this.btnRelease.Click += new System.EventHandler(this.btnRelease_Click);
            // 
            // liReleasedLicenseInfo
            // 
            this.liReleasedLicenseInfo.AutoSize = true;
            this.liReleasedLicenseInfo.Enabled = false;
            this.liReleasedLicenseInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.liReleasedLicenseInfo.Location = new System.Drawing.Point(196, 631);
            this.liReleasedLicenseInfo.Name = "liReleasedLicenseInfo";
            this.liReleasedLicenseInfo.Size = new System.Drawing.Size(210, 20);
            this.liReleasedLicenseInfo.TabIndex = 19;
            this.liReleasedLicenseInfo.TabStop = true;
            this.liReleasedLicenseInfo.Text = "Show Released License info";
            this.liReleasedLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.liReleasedLicenseInfo_LinkClicked);
            // 
            // liShowLicensesHistory
            // 
            this.liShowLicensesHistory.AutoSize = true;
            this.liShowLicensesHistory.Enabled = false;
            this.liShowLicensesHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.liShowLicensesHistory.Location = new System.Drawing.Point(11, 631);
            this.liShowLicensesHistory.Name = "liShowLicensesHistory";
            this.liShowLicensesHistory.Size = new System.Drawing.Size(169, 20);
            this.liShowLicensesHistory.TabIndex = 18;
            this.liShowLicensesHistory.TabStop = true;
            this.liShowLicensesHistory.Text = "Show Licenses History";
            this.liShowLicensesHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.liShowLicensesHistory_LinkClicked);
            // 
            // gbDetainInfo
            // 
            this.gbDetainInfo.Controls.Add(this.lbAppID);
            this.gbDetainInfo.Controls.Add(this.labelAppID);
            this.gbDetainInfo.Controls.Add(this.lbTotalFees);
            this.gbDetainInfo.Controls.Add(this.labelTotalFees);
            this.gbDetainInfo.Controls.Add(this.lbApplicationFees);
            this.gbDetainInfo.Controls.Add(this.labelApplicationFees);
            this.gbDetainInfo.Controls.Add(this.lbFineFees);
            this.gbDetainInfo.Controls.Add(this.labelFineFees);
            this.gbDetainInfo.Controls.Add(this.lbCreatedBy);
            this.gbDetainInfo.Controls.Add(this.labelCreatedBy);
            this.gbDetainInfo.Controls.Add(this.lbLicenseID);
            this.gbDetainInfo.Controls.Add(this.labelLicenseID);
            this.gbDetainInfo.Controls.Add(this.lbDetainDate);
            this.gbDetainInfo.Controls.Add(this.labelDetainDate);
            this.gbDetainInfo.Controls.Add(this.lbDetainID);
            this.gbDetainInfo.Controls.Add(this.labelDetainID);
            this.gbDetainInfo.Location = new System.Drawing.Point(3, 459);
            this.gbDetainInfo.Name = "gbDetainInfo";
            this.gbDetainInfo.Size = new System.Drawing.Size(774, 158);
            this.gbDetainInfo.TabIndex = 17;
            this.gbDetainInfo.TabStop = false;
            this.gbDetainInfo.Text = "groupBox1";
            // 
            // lbAppID
            // 
            this.lbAppID.AutoSize = true;
            this.lbAppID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbAppID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAppID.Location = new System.Drawing.Point(424, 126);
            this.lbAppID.Name = "lbAppID";
            this.lbAppID.Size = new System.Drawing.Size(49, 16);
            this.lbAppID.TabIndex = 16;
            this.lbAppID.Text = "[ ??? ]";
            // 
            // labelAppID
            // 
            this.labelAppID.AutoSize = true;
            this.labelAppID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAppID.Location = new System.Drawing.Point(356, 126);
            this.labelAppID.Name = "labelAppID";
            this.labelAppID.Size = new System.Drawing.Size(62, 16);
            this.labelAppID.TabIndex = 15;
            this.labelAppID.Text = "App. ID:";
            // 
            // lbTotalFees
            // 
            this.lbTotalFees.AutoSize = true;
            this.lbTotalFees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbTotalFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalFees.Location = new System.Drawing.Point(107, 126);
            this.lbTotalFees.Name = "lbTotalFees";
            this.lbTotalFees.Size = new System.Drawing.Size(49, 16);
            this.lbTotalFees.TabIndex = 14;
            this.lbTotalFees.Text = "[ ??? ]";
            // 
            // labelTotalFees
            // 
            this.labelTotalFees.AutoSize = true;
            this.labelTotalFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalFees.Location = new System.Drawing.Point(9, 126);
            this.labelTotalFees.Name = "labelTotalFees";
            this.labelTotalFees.Size = new System.Drawing.Size(86, 16);
            this.labelTotalFees.TabIndex = 13;
            this.labelTotalFees.Text = "Total Fees:";
            // 
            // lbApplicationFees
            // 
            this.lbApplicationFees.AutoSize = true;
            this.lbApplicationFees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbApplicationFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApplicationFees.Location = new System.Drawing.Point(424, 96);
            this.lbApplicationFees.Name = "lbApplicationFees";
            this.lbApplicationFees.Size = new System.Drawing.Size(15, 16);
            this.lbApplicationFees.TabIndex = 12;
            this.lbApplicationFees.Text = "0";
            // 
            // labelApplicationFees
            // 
            this.labelApplicationFees.AutoSize = true;
            this.labelApplicationFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApplicationFees.Location = new System.Drawing.Point(290, 96);
            this.labelApplicationFees.Name = "labelApplicationFees";
            this.labelApplicationFees.Size = new System.Drawing.Size(128, 16);
            this.labelApplicationFees.TabIndex = 11;
            this.labelApplicationFees.Text = "Application Fees:";
            // 
            // lbFineFees
            // 
            this.lbFineFees.AutoSize = true;
            this.lbFineFees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbFineFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFineFees.Location = new System.Drawing.Point(107, 96);
            this.lbFineFees.Name = "lbFineFees";
            this.lbFineFees.Size = new System.Drawing.Size(15, 16);
            this.lbFineFees.TabIndex = 10;
            this.lbFineFees.Text = "0";
            // 
            // labelFineFees
            // 
            this.labelFineFees.AutoSize = true;
            this.labelFineFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFineFees.Location = new System.Drawing.Point(8, 96);
            this.labelFineFees.Name = "labelFineFees";
            this.labelFineFees.Size = new System.Drawing.Size(80, 16);
            this.labelFineFees.TabIndex = 9;
            this.labelFineFees.Text = "Fine Fees:";
            // 
            // lbCreatedBy
            // 
            this.lbCreatedBy.AutoSize = true;
            this.lbCreatedBy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbCreatedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCreatedBy.Location = new System.Drawing.Point(424, 66);
            this.lbCreatedBy.Name = "lbCreatedBy";
            this.lbCreatedBy.Size = new System.Drawing.Size(49, 16);
            this.lbCreatedBy.TabIndex = 8;
            this.lbCreatedBy.Text = "[ ??? ]";
            // 
            // labelCreatedBy
            // 
            this.labelCreatedBy.AutoSize = true;
            this.labelCreatedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreatedBy.Location = new System.Drawing.Point(330, 66);
            this.labelCreatedBy.Name = "labelCreatedBy";
            this.labelCreatedBy.Size = new System.Drawing.Size(88, 16);
            this.labelCreatedBy.TabIndex = 7;
            this.labelCreatedBy.Text = "Created By:";
            // 
            // lbLicenseID
            // 
            this.lbLicenseID.AutoSize = true;
            this.lbLicenseID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbLicenseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLicenseID.Location = new System.Drawing.Point(424, 36);
            this.lbLicenseID.Name = "lbLicenseID";
            this.lbLicenseID.Size = new System.Drawing.Size(49, 16);
            this.lbLicenseID.TabIndex = 6;
            this.lbLicenseID.Text = "[ ??? ]";
            // 
            // labelLicenseID
            // 
            this.labelLicenseID.AutoSize = true;
            this.labelLicenseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLicenseID.Location = new System.Drawing.Point(334, 36);
            this.labelLicenseID.Name = "labelLicenseID";
            this.labelLicenseID.Size = new System.Drawing.Size(84, 16);
            this.labelLicenseID.TabIndex = 5;
            this.labelLicenseID.Text = "License ID:";
            this.labelLicenseID.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbDetainDate
            // 
            this.lbDetainDate.AutoSize = true;
            this.lbDetainDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbDetainDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDetainDate.Location = new System.Drawing.Point(107, 66);
            this.lbDetainDate.Name = "lbDetainDate";
            this.lbDetainDate.Size = new System.Drawing.Size(49, 16);
            this.lbDetainDate.TabIndex = 4;
            this.lbDetainDate.Text = "[ ??? ]";
            // 
            // labelDetainDate
            // 
            this.labelDetainDate.AutoSize = true;
            this.labelDetainDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDetainDate.Location = new System.Drawing.Point(8, 66);
            this.labelDetainDate.Name = "labelDetainDate";
            this.labelDetainDate.Size = new System.Drawing.Size(93, 16);
            this.labelDetainDate.TabIndex = 3;
            this.labelDetainDate.Text = "Detain Date:";
            // 
            // lbDetainID
            // 
            this.lbDetainID.AutoSize = true;
            this.lbDetainID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbDetainID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDetainID.Location = new System.Drawing.Point(107, 36);
            this.lbDetainID.Name = "lbDetainID";
            this.lbDetainID.Size = new System.Drawing.Size(49, 16);
            this.lbDetainID.TabIndex = 2;
            this.lbDetainID.Text = "[ ??? ]";
            // 
            // labelDetainID
            // 
            this.labelDetainID.AutoSize = true;
            this.labelDetainID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDetainID.Location = new System.Drawing.Point(8, 36);
            this.labelDetainID.Name = "labelDetainID";
            this.labelDetainID.Size = new System.Drawing.Size(75, 16);
            this.labelDetainID.TabIndex = 1;
            this.labelDetainID.Text = "Detain ID:";
            // 
            // ctrlLicenseCardFilter1
            // 
            this.ctrlLicenseCardFilter1.BackColor = System.Drawing.Color.White;
            this.ctrlLicenseCardFilter1.Location = new System.Drawing.Point(0, 62);
            this.ctrlLicenseCardFilter1.Name = "ctrlLicenseCardFilter1";
            this.ctrlLicenseCardFilter1.Size = new System.Drawing.Size(780, 388);
            this.ctrlLicenseCardFilter1.TabIndex = 16;
            this.ctrlLicenseCardFilter1.OnLicenseSelected += new System.Action<int>(this.ctrlLicenseCardFilter1_OnLicenseSelected);
            // 
            // frmReleaseDetainedLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(781, 675);
            this.Controls.Add(this.labelHeader);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRelease);
            this.Controls.Add(this.liReleasedLicenseInfo);
            this.Controls.Add(this.liShowLicensesHistory);
            this.Controls.Add(this.gbDetainInfo);
            this.Controls.Add(this.ctrlLicenseCardFilter1);
            this.MaximumSize = new System.Drawing.Size(797, 714);
            this.MinimumSize = new System.Drawing.Size(797, 714);
            this.Name = "frmReleaseDetainedLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReleaseDetainedLicense";
            this.gbDetainInfo.ResumeLayout(false);
            this.gbDetainInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRelease;
        private System.Windows.Forms.LinkLabel liReleasedLicenseInfo;
        private System.Windows.Forms.LinkLabel liShowLicensesHistory;
        private System.Windows.Forms.GroupBox gbDetainInfo;
        private System.Windows.Forms.Label labelFineFees;
        private System.Windows.Forms.Label lbCreatedBy;
        private System.Windows.Forms.Label labelCreatedBy;
        private System.Windows.Forms.Label lbLicenseID;
        private System.Windows.Forms.Label labelLicenseID;
        private System.Windows.Forms.Label lbDetainDate;
        private System.Windows.Forms.Label labelDetainDate;
        private System.Windows.Forms.Label lbDetainID;
        private System.Windows.Forms.Label labelDetainID;
        private ctrlLicenseCardFilter ctrlLicenseCardFilter1;
        private System.Windows.Forms.Label lbFineFees;
        private System.Windows.Forms.Label lbAppID;
        private System.Windows.Forms.Label labelAppID;
        private System.Windows.Forms.Label lbTotalFees;
        private System.Windows.Forms.Label labelTotalFees;
        private System.Windows.Forms.Label lbApplicationFees;
        private System.Windows.Forms.Label labelApplicationFees;
    }
}