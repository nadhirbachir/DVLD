namespace DVLD
{
    partial class frmRenewDrivingLicense
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
            this.ctrlLicenseCardFilter1 = new DVLD.ctrlLicenseCardFilter();
            this.labelRenewDrivingLicense = new System.Windows.Forms.Label();
            this.liShowDrivingLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.btnRenew = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbNotes = new System.Windows.Forms.TextBox();
            this.labelNotes = new System.Windows.Forms.Label();
            this.lbTotalFees = new System.Windows.Forms.Label();
            this.labelTotalFees = new System.Windows.Forms.Label();
            this.lbCreatedBy = new System.Windows.Forms.Label();
            this.labelCreatedBy = new System.Windows.Forms.Label();
            this.lbLicenseFees = new System.Windows.Forms.Label();
            this.labelLicenseFees = new System.Windows.Forms.Label();
            this.lbApplicationFees = new System.Windows.Forms.Label();
            this.labelApplicationFees = new System.Windows.Forms.Label();
            this.lbExpirationDate = new System.Windows.Forms.Label();
            this.labelExpirationDate = new System.Windows.Forms.Label();
            this.lbOldLicenseID = new System.Windows.Forms.Label();
            this.labelOldLicenseID = new System.Windows.Forms.Label();
            this.lbRenewedLicenseID = new System.Windows.Forms.Label();
            this.labelRenewedLicenseID = new System.Windows.Forms.Label();
            this.lbIssueDate = new System.Windows.Forms.Label();
            this.labelIssueDate = new System.Windows.Forms.Label();
            this.lbApplicationDate = new System.Windows.Forms.Label();
            this.labelApplicationDate = new System.Windows.Forms.Label();
            this.lbRLAID = new System.Windows.Forms.Label();
            this.labelRLDID = new System.Windows.Forms.Label();
            this.liShowNewLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrlLicenseCardFilter1
            // 
            this.ctrlLicenseCardFilter1.BackColor = System.Drawing.Color.White;
            this.ctrlLicenseCardFilter1.Location = new System.Drawing.Point(3, 55);
            this.ctrlLicenseCardFilter1.Name = "ctrlLicenseCardFilter1";
            this.ctrlLicenseCardFilter1.Size = new System.Drawing.Size(780, 388);
            this.ctrlLicenseCardFilter1.TabIndex = 0;
            this.ctrlLicenseCardFilter1.OnLicenseSelected += new System.Action<int>(this.ctrlLicenseCardFilter1_OnLicenseSelected);
            // 
            // labelRenewDrivingLicense
            // 
            this.labelRenewDrivingLicense.AutoSize = true;
            this.labelRenewDrivingLicense.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRenewDrivingLicense.ForeColor = System.Drawing.Color.Teal;
            this.labelRenewDrivingLicense.Location = new System.Drawing.Point(178, 9);
            this.labelRenewDrivingLicense.Name = "labelRenewDrivingLicense";
            this.labelRenewDrivingLicense.Size = new System.Drawing.Size(411, 44);
            this.labelRenewDrivingLicense.TabIndex = 1;
            this.labelRenewDrivingLicense.Text = "Renew driving license";
            // 
            // liShowDrivingLicenseInfo
            // 
            this.liShowDrivingLicenseInfo.AutoSize = true;
            this.liShowDrivingLicenseInfo.Enabled = false;
            this.liShowDrivingLicenseInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.liShowDrivingLicenseInfo.Location = new System.Drawing.Point(12, 695);
            this.liShowDrivingLicenseInfo.Name = "liShowDrivingLicenseInfo";
            this.liShowDrivingLicenseInfo.Size = new System.Drawing.Size(181, 20);
            this.liShowDrivingLicenseInfo.TabIndex = 2;
            this.liShowDrivingLicenseInfo.TabStop = true;
            this.liShowDrivingLicenseInfo.Text = "Show driving license info";
            this.liShowDrivingLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.liShowDrivingLicenseInfo_LinkClicked);
            // 
            // btnRenew
            // 
            this.btnRenew.BackColor = System.Drawing.Color.Green;
            this.btnRenew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnRenew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnRenew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRenew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRenew.ForeColor = System.Drawing.Color.White;
            this.btnRenew.Location = new System.Drawing.Point(679, 682);
            this.btnRenew.Name = "btnRenew";
            this.btnRenew.Size = new System.Drawing.Size(101, 48);
            this.btnRenew.TabIndex = 3;
            this.btnRenew.Text = "Renew";
            this.btnRenew.UseVisualStyleBackColor = false;
            this.btnRenew.Click += new System.EventHandler(this.btnRenew_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Teal;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(572, 682);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(101, 48);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbNotes);
            this.groupBox1.Controls.Add(this.labelNotes);
            this.groupBox1.Controls.Add(this.lbTotalFees);
            this.groupBox1.Controls.Add(this.labelTotalFees);
            this.groupBox1.Controls.Add(this.lbCreatedBy);
            this.groupBox1.Controls.Add(this.labelCreatedBy);
            this.groupBox1.Controls.Add(this.lbLicenseFees);
            this.groupBox1.Controls.Add(this.labelLicenseFees);
            this.groupBox1.Controls.Add(this.lbApplicationFees);
            this.groupBox1.Controls.Add(this.labelApplicationFees);
            this.groupBox1.Controls.Add(this.lbExpirationDate);
            this.groupBox1.Controls.Add(this.labelExpirationDate);
            this.groupBox1.Controls.Add(this.lbOldLicenseID);
            this.groupBox1.Controls.Add(this.labelOldLicenseID);
            this.groupBox1.Controls.Add(this.lbRenewedLicenseID);
            this.groupBox1.Controls.Add(this.labelRenewedLicenseID);
            this.groupBox1.Controls.Add(this.lbIssueDate);
            this.groupBox1.Controls.Add(this.labelIssueDate);
            this.groupBox1.Controls.Add(this.lbApplicationDate);
            this.groupBox1.Controls.Add(this.labelApplicationDate);
            this.groupBox1.Controls.Add(this.lbRLAID);
            this.groupBox1.Controls.Add(this.labelRLDID);
            this.groupBox1.Location = new System.Drawing.Point(6, 449);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(774, 227);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // tbNotes
            // 
            this.tbNotes.Location = new System.Drawing.Point(144, 173);
            this.tbNotes.Multiline = true;
            this.tbNotes.Name = "tbNotes";
            this.tbNotes.Size = new System.Drawing.Size(507, 45);
            this.tbNotes.TabIndex = 21;
            // 
            // labelNotes
            // 
            this.labelNotes.AutoSize = true;
            this.labelNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNotes.Location = new System.Drawing.Point(7, 174);
            this.labelNotes.Name = "labelNotes";
            this.labelNotes.Size = new System.Drawing.Size(52, 16);
            this.labelNotes.TabIndex = 20;
            this.labelNotes.Text = "Notes:";
            // 
            // lbTotalFees
            // 
            this.lbTotalFees.AutoSize = true;
            this.lbTotalFees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbTotalFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalFees.Location = new System.Drawing.Point(528, 145);
            this.lbTotalFees.Name = "lbTotalFees";
            this.lbTotalFees.Size = new System.Drawing.Size(49, 16);
            this.lbTotalFees.TabIndex = 19;
            this.lbTotalFees.Text = "[ ??? ]";
            // 
            // labelTotalFees
            // 
            this.labelTotalFees.AutoSize = true;
            this.labelTotalFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalFees.Location = new System.Drawing.Point(369, 145);
            this.labelTotalFees.Name = "labelTotalFees";
            this.labelTotalFees.Size = new System.Drawing.Size(86, 16);
            this.labelTotalFees.TabIndex = 18;
            this.labelTotalFees.Text = "Total Fees:";
            // 
            // lbCreatedBy
            // 
            this.lbCreatedBy.AutoSize = true;
            this.lbCreatedBy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbCreatedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCreatedBy.Location = new System.Drawing.Point(528, 116);
            this.lbCreatedBy.Name = "lbCreatedBy";
            this.lbCreatedBy.Size = new System.Drawing.Size(49, 16);
            this.lbCreatedBy.TabIndex = 17;
            this.lbCreatedBy.Text = "[ ??? ]";
            // 
            // labelCreatedBy
            // 
            this.labelCreatedBy.AutoSize = true;
            this.labelCreatedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreatedBy.Location = new System.Drawing.Point(369, 116);
            this.labelCreatedBy.Name = "labelCreatedBy";
            this.labelCreatedBy.Size = new System.Drawing.Size(88, 16);
            this.labelCreatedBy.TabIndex = 16;
            this.labelCreatedBy.Text = "Created By:";
            // 
            // lbLicenseFees
            // 
            this.lbLicenseFees.AutoSize = true;
            this.lbLicenseFees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbLicenseFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLicenseFees.Location = new System.Drawing.Point(141, 145);
            this.lbLicenseFees.Name = "lbLicenseFees";
            this.lbLicenseFees.Size = new System.Drawing.Size(15, 16);
            this.lbLicenseFees.TabIndex = 15;
            this.lbLicenseFees.Text = "0";
            // 
            // labelLicenseFees
            // 
            this.labelLicenseFees.AutoSize = true;
            this.labelLicenseFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLicenseFees.Location = new System.Drawing.Point(7, 145);
            this.labelLicenseFees.Name = "labelLicenseFees";
            this.labelLicenseFees.Size = new System.Drawing.Size(104, 16);
            this.labelLicenseFees.TabIndex = 14;
            this.labelLicenseFees.Text = "License Fees:";
            // 
            // lbApplicationFees
            // 
            this.lbApplicationFees.AutoSize = true;
            this.lbApplicationFees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbApplicationFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApplicationFees.Location = new System.Drawing.Point(141, 116);
            this.lbApplicationFees.Name = "lbApplicationFees";
            this.lbApplicationFees.Size = new System.Drawing.Size(49, 16);
            this.lbApplicationFees.TabIndex = 13;
            this.lbApplicationFees.Text = "[ ??? ]";
            // 
            // labelApplicationFees
            // 
            this.labelApplicationFees.AutoSize = true;
            this.labelApplicationFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApplicationFees.Location = new System.Drawing.Point(7, 116);
            this.labelApplicationFees.Name = "labelApplicationFees";
            this.labelApplicationFees.Size = new System.Drawing.Size(128, 16);
            this.labelApplicationFees.TabIndex = 12;
            this.labelApplicationFees.Text = "Application Fees:";
            // 
            // lbExpirationDate
            // 
            this.lbExpirationDate.AutoSize = true;
            this.lbExpirationDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbExpirationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExpirationDate.Location = new System.Drawing.Point(528, 87);
            this.lbExpirationDate.Name = "lbExpirationDate";
            this.lbExpirationDate.Size = new System.Drawing.Size(49, 16);
            this.lbExpirationDate.TabIndex = 11;
            this.lbExpirationDate.Text = "[ ??? ]";
            // 
            // labelExpirationDate
            // 
            this.labelExpirationDate.AutoSize = true;
            this.labelExpirationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExpirationDate.Location = new System.Drawing.Point(369, 87);
            this.labelExpirationDate.Name = "labelExpirationDate";
            this.labelExpirationDate.Size = new System.Drawing.Size(117, 16);
            this.labelExpirationDate.TabIndex = 10;
            this.labelExpirationDate.Text = "Expiration Date:";
            // 
            // lbOldLicenseID
            // 
            this.lbOldLicenseID.AutoSize = true;
            this.lbOldLicenseID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbOldLicenseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOldLicenseID.Location = new System.Drawing.Point(528, 58);
            this.lbOldLicenseID.Name = "lbOldLicenseID";
            this.lbOldLicenseID.Size = new System.Drawing.Size(49, 16);
            this.lbOldLicenseID.TabIndex = 9;
            this.lbOldLicenseID.Text = "[ ??? ]";
            // 
            // labelOldLicenseID
            // 
            this.labelOldLicenseID.AutoSize = true;
            this.labelOldLicenseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOldLicenseID.Location = new System.Drawing.Point(369, 58);
            this.labelOldLicenseID.Name = "labelOldLicenseID";
            this.labelOldLicenseID.Size = new System.Drawing.Size(112, 16);
            this.labelOldLicenseID.TabIndex = 8;
            this.labelOldLicenseID.Text = "Old License ID:";
            // 
            // lbRenewedLicenseID
            // 
            this.lbRenewedLicenseID.AutoSize = true;
            this.lbRenewedLicenseID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbRenewedLicenseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRenewedLicenseID.Location = new System.Drawing.Point(528, 29);
            this.lbRenewedLicenseID.Name = "lbRenewedLicenseID";
            this.lbRenewedLicenseID.Size = new System.Drawing.Size(49, 16);
            this.lbRenewedLicenseID.TabIndex = 7;
            this.lbRenewedLicenseID.Text = "[ ??? ]";
            // 
            // labelRenewedLicenseID
            // 
            this.labelRenewedLicenseID.AutoSize = true;
            this.labelRenewedLicenseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRenewedLicenseID.Location = new System.Drawing.Point(369, 29);
            this.labelRenewedLicenseID.Name = "labelRenewedLicenseID";
            this.labelRenewedLicenseID.Size = new System.Drawing.Size(153, 16);
            this.labelRenewedLicenseID.TabIndex = 6;
            this.labelRenewedLicenseID.Text = "Renewed License ID:";
            // 
            // lbIssueDate
            // 
            this.lbIssueDate.AutoSize = true;
            this.lbIssueDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbIssueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIssueDate.Location = new System.Drawing.Point(141, 87);
            this.lbIssueDate.Name = "lbIssueDate";
            this.lbIssueDate.Size = new System.Drawing.Size(49, 16);
            this.lbIssueDate.TabIndex = 5;
            this.lbIssueDate.Text = "[ ??? ]";
            // 
            // labelIssueDate
            // 
            this.labelIssueDate.AutoSize = true;
            this.labelIssueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIssueDate.Location = new System.Drawing.Point(7, 87);
            this.labelIssueDate.Name = "labelIssueDate";
            this.labelIssueDate.Size = new System.Drawing.Size(85, 16);
            this.labelIssueDate.TabIndex = 4;
            this.labelIssueDate.Text = "Issue Date:";
            // 
            // lbApplicationDate
            // 
            this.lbApplicationDate.AutoSize = true;
            this.lbApplicationDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbApplicationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApplicationDate.Location = new System.Drawing.Point(141, 58);
            this.lbApplicationDate.Name = "lbApplicationDate";
            this.lbApplicationDate.Size = new System.Drawing.Size(49, 16);
            this.lbApplicationDate.TabIndex = 3;
            this.lbApplicationDate.Text = "[ ??? ]";
            // 
            // labelApplicationDate
            // 
            this.labelApplicationDate.AutoSize = true;
            this.labelApplicationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApplicationDate.Location = new System.Drawing.Point(7, 58);
            this.labelApplicationDate.Name = "labelApplicationDate";
            this.labelApplicationDate.Size = new System.Drawing.Size(126, 16);
            this.labelApplicationDate.TabIndex = 2;
            this.labelApplicationDate.Text = "Application Date:";
            // 
            // lbRLAID
            // 
            this.lbRLAID.AutoSize = true;
            this.lbRLAID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbRLAID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRLAID.Location = new System.Drawing.Point(141, 29);
            this.lbRLAID.Name = "lbRLAID";
            this.lbRLAID.Size = new System.Drawing.Size(49, 16);
            this.lbRLAID.TabIndex = 1;
            this.lbRLAID.Text = "[ ??? ]";
            // 
            // labelRLDID
            // 
            this.labelRLDID.AutoSize = true;
            this.labelRLDID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRLDID.Location = new System.Drawing.Point(7, 29);
            this.labelRLDID.Name = "labelRLDID";
            this.labelRLDID.Size = new System.Drawing.Size(67, 16);
            this.labelRLDID.TabIndex = 0;
            this.labelRLDID.Text = "R.L.A ID:";
            // 
            // liShowNewLicenseInfo
            // 
            this.liShowNewLicenseInfo.AutoSize = true;
            this.liShowNewLicenseInfo.Enabled = false;
            this.liShowNewLicenseInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.liShowNewLicenseInfo.Location = new System.Drawing.Point(208, 695);
            this.liShowNewLicenseInfo.Name = "liShowNewLicenseInfo";
            this.liShowNewLicenseInfo.Size = new System.Drawing.Size(165, 20);
            this.liShowNewLicenseInfo.TabIndex = 6;
            this.liShowNewLicenseInfo.TabStop = true;
            this.liShowNewLicenseInfo.Text = "Show new license info";
            this.liShowNewLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.liShowNewLicenseInfo_LinkClicked);
            // 
            // frmRenewDrivingLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(788, 742);
            this.Controls.Add(this.liShowNewLicenseInfo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRenew);
            this.Controls.Add(this.liShowDrivingLicenseInfo);
            this.Controls.Add(this.labelRenewDrivingLicense);
            this.Controls.Add(this.ctrlLicenseCardFilter1);
            this.Name = "frmRenewDrivingLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRenewDrivingLicense";
            this.Load += new System.EventHandler(this.frmRenewDrivingLicense_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlLicenseCardFilter ctrlLicenseCardFilter1;
        private System.Windows.Forms.Label labelRenewDrivingLicense;
        private System.Windows.Forms.LinkLabel liShowDrivingLicenseInfo;
        private System.Windows.Forms.Button btnRenew;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbIssueDate;
        private System.Windows.Forms.Label labelIssueDate;
        private System.Windows.Forms.Label lbApplicationDate;
        private System.Windows.Forms.Label labelApplicationDate;
        private System.Windows.Forms.Label lbRLAID;
        private System.Windows.Forms.Label labelRLDID;
        private System.Windows.Forms.TextBox tbNotes;
        private System.Windows.Forms.Label labelNotes;
        private System.Windows.Forms.Label lbTotalFees;
        private System.Windows.Forms.Label labelTotalFees;
        private System.Windows.Forms.Label lbCreatedBy;
        private System.Windows.Forms.Label labelCreatedBy;
        private System.Windows.Forms.Label lbLicenseFees;
        private System.Windows.Forms.Label labelLicenseFees;
        private System.Windows.Forms.Label lbApplicationFees;
        private System.Windows.Forms.Label labelApplicationFees;
        private System.Windows.Forms.Label lbExpirationDate;
        private System.Windows.Forms.Label labelExpirationDate;
        private System.Windows.Forms.Label lbOldLicenseID;
        private System.Windows.Forms.Label labelOldLicenseID;
        private System.Windows.Forms.Label lbRenewedLicenseID;
        private System.Windows.Forms.Label labelRenewedLicenseID;
        private System.Windows.Forms.LinkLabel liShowNewLicenseInfo;
    }
}