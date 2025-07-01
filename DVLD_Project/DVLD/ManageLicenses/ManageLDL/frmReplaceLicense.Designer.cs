namespace DVLD
{
    partial class frmReplaceLicense
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
            this.rbDamaged = new System.Windows.Forms.RadioButton();
            this.rbLost = new System.Windows.Forms.RadioButton();
            this.labelReplaceFor = new System.Windows.Forms.Label();
            this.gbReplaceChoice = new System.Windows.Forms.GroupBox();
            this.labelLRAID = new System.Windows.Forms.Label();
            this.lbLRAID = new System.Windows.Forms.Label();
            this.gbAppInfo = new System.Windows.Forms.GroupBox();
            this.lbCreatedBy = new System.Windows.Forms.Label();
            this.labelCreatedBy = new System.Windows.Forms.Label();
            this.lbOldLicenseID = new System.Windows.Forms.Label();
            this.labelOldLicenseID = new System.Windows.Forms.Label();
            this.lbReplacedLicenseID = new System.Windows.Forms.Label();
            this.labelReplacedLicenseID = new System.Windows.Forms.Label();
            this.lbApplicationFees = new System.Windows.Forms.Label();
            this.labelApplicationFees = new System.Windows.Forms.Label();
            this.lbApplicationDate = new System.Windows.Forms.Label();
            this.labelApplicationDate = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnReplace = new System.Windows.Forms.Button();
            this.liShowLicensesHistory = new System.Windows.Forms.LinkLabel();
            this.liNewLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.labelHeader = new System.Windows.Forms.Label();
            this.ctrlLicenseCardFilter1 = new DVLD.ctrlLicenseCardFilter();
            this.gbReplaceChoice.SuspendLayout();
            this.gbAppInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbDamaged
            // 
            this.rbDamaged.AutoSize = true;
            this.rbDamaged.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDamaged.Location = new System.Drawing.Point(332, 12);
            this.rbDamaged.Name = "rbDamaged";
            this.rbDamaged.Size = new System.Drawing.Size(171, 24);
            this.rbDamaged.TabIndex = 1;
            this.rbDamaged.Text = "Damaged License";
            this.rbDamaged.UseVisualStyleBackColor = true;
            this.rbDamaged.CheckedChanged += new System.EventHandler(this.rbDamaged_CheckedChanged);
            // 
            // rbLost
            // 
            this.rbLost.AutoSize = true;
            this.rbLost.Checked = true;
            this.rbLost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLost.Location = new System.Drawing.Point(168, 12);
            this.rbLost.Name = "rbLost";
            this.rbLost.Size = new System.Drawing.Size(129, 24);
            this.rbLost.TabIndex = 2;
            this.rbLost.TabStop = true;
            this.rbLost.Text = "Lost License";
            this.rbLost.UseVisualStyleBackColor = true;
            this.rbLost.CheckedChanged += new System.EventHandler(this.rbLost_CheckedChanged);
            // 
            // labelReplaceFor
            // 
            this.labelReplaceFor.AutoSize = true;
            this.labelReplaceFor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReplaceFor.Location = new System.Drawing.Point(6, 14);
            this.labelReplaceFor.Name = "labelReplaceFor";
            this.labelReplaceFor.Size = new System.Drawing.Size(107, 20);
            this.labelReplaceFor.TabIndex = 3;
            this.labelReplaceFor.Text = "Replace for:";
            // 
            // gbReplaceChoice
            // 
            this.gbReplaceChoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gbReplaceChoice.Controls.Add(this.labelReplaceFor);
            this.gbReplaceChoice.Controls.Add(this.rbDamaged);
            this.gbReplaceChoice.Controls.Add(this.rbLost);
            this.gbReplaceChoice.Location = new System.Drawing.Point(134, 448);
            this.gbReplaceChoice.Name = "gbReplaceChoice";
            this.gbReplaceChoice.Size = new System.Drawing.Size(528, 48);
            this.gbReplaceChoice.TabIndex = 4;
            this.gbReplaceChoice.TabStop = false;
            // 
            // labelLRAID
            // 
            this.labelLRAID.AutoSize = true;
            this.labelLRAID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLRAID.Location = new System.Drawing.Point(7, 31);
            this.labelLRAID.Name = "labelLRAID";
            this.labelLRAID.Size = new System.Drawing.Size(135, 16);
            this.labelLRAID.TabIndex = 5;
            this.labelLRAID.Text = "L.R.Application ID:";
            // 
            // lbLRAID
            // 
            this.lbLRAID.AutoSize = true;
            this.lbLRAID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbLRAID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLRAID.Location = new System.Drawing.Point(148, 31);
            this.lbLRAID.Name = "lbLRAID";
            this.lbLRAID.Size = new System.Drawing.Size(49, 16);
            this.lbLRAID.TabIndex = 6;
            this.lbLRAID.Text = "[ ??? ]";
            // 
            // gbAppInfo
            // 
            this.gbAppInfo.Controls.Add(this.lbCreatedBy);
            this.gbAppInfo.Controls.Add(this.labelCreatedBy);
            this.gbAppInfo.Controls.Add(this.lbOldLicenseID);
            this.gbAppInfo.Controls.Add(this.labelOldLicenseID);
            this.gbAppInfo.Controls.Add(this.lbReplacedLicenseID);
            this.gbAppInfo.Controls.Add(this.labelReplacedLicenseID);
            this.gbAppInfo.Controls.Add(this.lbApplicationFees);
            this.gbAppInfo.Controls.Add(this.labelApplicationFees);
            this.gbAppInfo.Controls.Add(this.lbApplicationDate);
            this.gbAppInfo.Controls.Add(this.labelApplicationDate);
            this.gbAppInfo.Controls.Add(this.lbLRAID);
            this.gbAppInfo.Controls.Add(this.labelLRAID);
            this.gbAppInfo.Location = new System.Drawing.Point(12, 502);
            this.gbAppInfo.Name = "gbAppInfo";
            this.gbAppInfo.Size = new System.Drawing.Size(768, 135);
            this.gbAppInfo.TabIndex = 7;
            this.gbAppInfo.TabStop = false;
            this.gbAppInfo.Text = "License replacement application info:";
            // 
            // lbCreatedBy
            // 
            this.lbCreatedBy.AutoSize = true;
            this.lbCreatedBy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbCreatedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCreatedBy.Location = new System.Drawing.Point(522, 97);
            this.lbCreatedBy.Name = "lbCreatedBy";
            this.lbCreatedBy.Size = new System.Drawing.Size(49, 16);
            this.lbCreatedBy.TabIndex = 16;
            this.lbCreatedBy.Text = "[ ??? ]";
            // 
            // labelCreatedBy
            // 
            this.labelCreatedBy.AutoSize = true;
            this.labelCreatedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreatedBy.Location = new System.Drawing.Point(428, 97);
            this.labelCreatedBy.Name = "labelCreatedBy";
            this.labelCreatedBy.Size = new System.Drawing.Size(88, 16);
            this.labelCreatedBy.TabIndex = 15;
            this.labelCreatedBy.Text = "Created By:";
            // 
            // lbOldLicenseID
            // 
            this.lbOldLicenseID.AutoSize = true;
            this.lbOldLicenseID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbOldLicenseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOldLicenseID.Location = new System.Drawing.Point(522, 64);
            this.lbOldLicenseID.Name = "lbOldLicenseID";
            this.lbOldLicenseID.Size = new System.Drawing.Size(49, 16);
            this.lbOldLicenseID.TabIndex = 14;
            this.lbOldLicenseID.Text = "[ ??? ]";
            // 
            // labelOldLicenseID
            // 
            this.labelOldLicenseID.AutoSize = true;
            this.labelOldLicenseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOldLicenseID.Location = new System.Drawing.Point(404, 64);
            this.labelOldLicenseID.Name = "labelOldLicenseID";
            this.labelOldLicenseID.Size = new System.Drawing.Size(112, 16);
            this.labelOldLicenseID.TabIndex = 13;
            this.labelOldLicenseID.Text = "Old License ID:";
            // 
            // lbReplacedLicenseID
            // 
            this.lbReplacedLicenseID.AutoSize = true;
            this.lbReplacedLicenseID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbReplacedLicenseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReplacedLicenseID.Location = new System.Drawing.Point(522, 31);
            this.lbReplacedLicenseID.Name = "lbReplacedLicenseID";
            this.lbReplacedLicenseID.Size = new System.Drawing.Size(49, 16);
            this.lbReplacedLicenseID.TabIndex = 12;
            this.lbReplacedLicenseID.Text = "[ ??? ]";
            // 
            // labelReplacedLicenseID
            // 
            this.labelReplacedLicenseID.AutoSize = true;
            this.labelReplacedLicenseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReplacedLicenseID.Location = new System.Drawing.Point(360, 31);
            this.labelReplacedLicenseID.Name = "labelReplacedLicenseID";
            this.labelReplacedLicenseID.Size = new System.Drawing.Size(156, 16);
            this.labelReplacedLicenseID.TabIndex = 11;
            this.labelReplacedLicenseID.Text = "Replaced License ID:";
            // 
            // lbApplicationFees
            // 
            this.lbApplicationFees.AutoSize = true;
            this.lbApplicationFees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbApplicationFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApplicationFees.Location = new System.Drawing.Point(148, 97);
            this.lbApplicationFees.Name = "lbApplicationFees";
            this.lbApplicationFees.Size = new System.Drawing.Size(15, 16);
            this.lbApplicationFees.TabIndex = 10;
            this.lbApplicationFees.Text = "0";
            // 
            // labelApplicationFees
            // 
            this.labelApplicationFees.AutoSize = true;
            this.labelApplicationFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApplicationFees.Location = new System.Drawing.Point(7, 97);
            this.labelApplicationFees.Name = "labelApplicationFees";
            this.labelApplicationFees.Size = new System.Drawing.Size(128, 16);
            this.labelApplicationFees.TabIndex = 9;
            this.labelApplicationFees.Text = "Application Fees:";
            // 
            // lbApplicationDate
            // 
            this.lbApplicationDate.AutoSize = true;
            this.lbApplicationDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbApplicationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApplicationDate.Location = new System.Drawing.Point(148, 64);
            this.lbApplicationDate.Name = "lbApplicationDate";
            this.lbApplicationDate.Size = new System.Drawing.Size(49, 16);
            this.lbApplicationDate.TabIndex = 8;
            this.lbApplicationDate.Text = "[ ??? ]";
            // 
            // labelApplicationDate
            // 
            this.labelApplicationDate.AutoSize = true;
            this.labelApplicationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApplicationDate.Location = new System.Drawing.Point(7, 64);
            this.labelApplicationDate.Name = "labelApplicationDate";
            this.labelApplicationDate.Size = new System.Drawing.Size(126, 16);
            this.labelApplicationDate.TabIndex = 7;
            this.labelApplicationDate.Text = "Application Date:";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Teal;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(571, 643);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 43);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnReplace
            // 
            this.btnReplace.BackColor = System.Drawing.Color.Green;
            this.btnReplace.Enabled = false;
            this.btnReplace.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnReplace.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnReplace.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReplace.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReplace.ForeColor = System.Drawing.Color.White;
            this.btnReplace.Location = new System.Drawing.Point(680, 643);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(100, 43);
            this.btnReplace.TabIndex = 9;
            this.btnReplace.Text = "Replace";
            this.btnReplace.UseVisualStyleBackColor = false;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // liShowLicensesHistory
            // 
            this.liShowLicensesHistory.AutoSize = true;
            this.liShowLicensesHistory.Enabled = false;
            this.liShowLicensesHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.liShowLicensesHistory.Location = new System.Drawing.Point(18, 653);
            this.liShowLicensesHistory.Name = "liShowLicensesHistory";
            this.liShowLicensesHistory.Size = new System.Drawing.Size(169, 20);
            this.liShowLicensesHistory.TabIndex = 10;
            this.liShowLicensesHistory.TabStop = true;
            this.liShowLicensesHistory.Text = "Show Licenses History";
            this.liShowLicensesHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.liShowLicensesHistory_LinkClicked);
            // 
            // liNewLicenseInfo
            // 
            this.liNewLicenseInfo.AutoSize = true;
            this.liNewLicenseInfo.Enabled = false;
            this.liNewLicenseInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.liNewLicenseInfo.Location = new System.Drawing.Point(193, 653);
            this.liNewLicenseInfo.Name = "liNewLicenseInfo";
            this.liNewLicenseInfo.Size = new System.Drawing.Size(165, 20);
            this.liNewLicenseInfo.TabIndex = 11;
            this.liNewLicenseInfo.TabStop = true;
            this.liNewLicenseInfo.Text = "Show new license info";
            this.liNewLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.liNewLicenseInfo_LinkClicked);
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.ForeColor = System.Drawing.Color.Teal;
            this.labelHeader.Location = new System.Drawing.Point(53, 7);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(670, 44);
            this.labelHeader.TabIndex = 12;
            this.labelHeader.Text = "Replace License for lost or damaged";
            // 
            // ctrlLicenseCardFilter1
            // 
            this.ctrlLicenseCardFilter1.BackColor = System.Drawing.Color.White;
            this.ctrlLicenseCardFilter1.Location = new System.Drawing.Point(3, 54);
            this.ctrlLicenseCardFilter1.Name = "ctrlLicenseCardFilter1";
            this.ctrlLicenseCardFilter1.Size = new System.Drawing.Size(780, 388);
            this.ctrlLicenseCardFilter1.TabIndex = 0;
            this.ctrlLicenseCardFilter1.OnLicenseSelected += new System.Action<int>(this.ctrlLicenseCardFilter1_OnLicenseSelected);
            // 
            // frmReplaceLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 702);
            this.Controls.Add(this.labelHeader);
            this.Controls.Add(this.liNewLicenseInfo);
            this.Controls.Add(this.liShowLicensesHistory);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gbAppInfo);
            this.Controls.Add(this.gbReplaceChoice);
            this.Controls.Add(this.ctrlLicenseCardFilter1);
            this.Name = "frmReplaceLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReplaceLicense";
            this.Load += new System.EventHandler(this.frmReplaceLicense_Load);
            this.gbReplaceChoice.ResumeLayout(false);
            this.gbReplaceChoice.PerformLayout();
            this.gbAppInfo.ResumeLayout(false);
            this.gbAppInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlLicenseCardFilter ctrlLicenseCardFilter1;
        private System.Windows.Forms.RadioButton rbDamaged;
        private System.Windows.Forms.RadioButton rbLost;
        private System.Windows.Forms.Label labelReplaceFor;
        private System.Windows.Forms.GroupBox gbReplaceChoice;
        private System.Windows.Forms.Label labelLRAID;
        private System.Windows.Forms.Label lbLRAID;
        private System.Windows.Forms.GroupBox gbAppInfo;
        private System.Windows.Forms.Label lbCreatedBy;
        private System.Windows.Forms.Label labelCreatedBy;
        private System.Windows.Forms.Label lbOldLicenseID;
        private System.Windows.Forms.Label labelOldLicenseID;
        private System.Windows.Forms.Label lbReplacedLicenseID;
        private System.Windows.Forms.Label labelReplacedLicenseID;
        private System.Windows.Forms.Label lbApplicationFees;
        private System.Windows.Forms.Label labelApplicationFees;
        private System.Windows.Forms.Label lbApplicationDate;
        private System.Windows.Forms.Label labelApplicationDate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.LinkLabel liShowLicensesHistory;
        private System.Windows.Forms.LinkLabel liNewLicenseInfo;
        private System.Windows.Forms.Label labelHeader;
    }
}