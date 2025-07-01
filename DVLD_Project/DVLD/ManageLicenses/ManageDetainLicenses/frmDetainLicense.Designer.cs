namespace DVLD
{
    partial class frmDetainLicense
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
            this.labelDetainID = new System.Windows.Forms.Label();
            this.lbDetainID = new System.Windows.Forms.Label();
            this.lbDetainDate = new System.Windows.Forms.Label();
            this.labelDetainDate = new System.Windows.Forms.Label();
            this.lbCreatedBy = new System.Windows.Forms.Label();
            this.labelCreatedBy = new System.Windows.Forms.Label();
            this.lbLicenseID = new System.Windows.Forms.Label();
            this.labelLicenseID = new System.Windows.Forms.Label();
            this.labelFineFees = new System.Windows.Forms.Label();
            this.gbDetainInfo = new System.Windows.Forms.GroupBox();
            this.tbFineFees = new System.Windows.Forms.TextBox();
            this.liShowLicensesHistory = new System.Windows.Forms.LinkLabel();
            this.liDetainedLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.btnDetain = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.labelHeader = new System.Windows.Forms.Label();
            this.ctrlLicenseCardFilter1 = new DVLD.ctrlLicenseCardFilter();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbDetainInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
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
            this.labelLicenseID.Location = new System.Drawing.Point(330, 36);
            this.labelLicenseID.Name = "labelLicenseID";
            this.labelLicenseID.Size = new System.Drawing.Size(84, 16);
            this.labelLicenseID.TabIndex = 5;
            this.labelLicenseID.Text = "License ID:";
            this.labelLicenseID.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            // gbDetainInfo
            // 
            this.gbDetainInfo.Controls.Add(this.tbFineFees);
            this.gbDetainInfo.Controls.Add(this.labelFineFees);
            this.gbDetainInfo.Controls.Add(this.lbCreatedBy);
            this.gbDetainInfo.Controls.Add(this.labelCreatedBy);
            this.gbDetainInfo.Controls.Add(this.lbLicenseID);
            this.gbDetainInfo.Controls.Add(this.labelLicenseID);
            this.gbDetainInfo.Controls.Add(this.lbDetainDate);
            this.gbDetainInfo.Controls.Add(this.labelDetainDate);
            this.gbDetainInfo.Controls.Add(this.lbDetainID);
            this.gbDetainInfo.Controls.Add(this.labelDetainID);
            this.gbDetainInfo.Location = new System.Drawing.Point(4, 458);
            this.gbDetainInfo.Name = "gbDetainInfo";
            this.gbDetainInfo.Size = new System.Drawing.Size(774, 135);
            this.gbDetainInfo.TabIndex = 10;
            this.gbDetainInfo.TabStop = false;
            this.gbDetainInfo.Text = "groupBox1";
            // 
            // tbFineFees
            // 
            this.tbFineFees.Location = new System.Drawing.Point(110, 95);
            this.tbFineFees.Name = "tbFineFees";
            this.tbFineFees.Size = new System.Drawing.Size(156, 20);
            this.tbFineFees.TabIndex = 10;
            this.tbFineFees.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFineFees_KeyPress);
            this.tbFineFees.Validating += new System.ComponentModel.CancelEventHandler(this.tbFineFees_Validating);
            // 
            // liShowLicensesHistory
            // 
            this.liShowLicensesHistory.AutoSize = true;
            this.liShowLicensesHistory.Enabled = false;
            this.liShowLicensesHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.liShowLicensesHistory.Location = new System.Drawing.Point(11, 608);
            this.liShowLicensesHistory.Name = "liShowLicensesHistory";
            this.liShowLicensesHistory.Size = new System.Drawing.Size(169, 20);
            this.liShowLicensesHistory.TabIndex = 11;
            this.liShowLicensesHistory.TabStop = true;
            this.liShowLicensesHistory.Text = "Show Licenses History";
            this.liShowLicensesHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.liShowLicensesHistory_LinkClicked);
            // 
            // liDetainedLicenseInfo
            // 
            this.liDetainedLicenseInfo.AutoSize = true;
            this.liDetainedLicenseInfo.Enabled = false;
            this.liDetainedLicenseInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.liDetainedLicenseInfo.Location = new System.Drawing.Point(196, 608);
            this.liDetainedLicenseInfo.Name = "liDetainedLicenseInfo";
            this.liDetainedLicenseInfo.Size = new System.Drawing.Size(207, 20);
            this.liDetainedLicenseInfo.TabIndex = 12;
            this.liDetainedLicenseInfo.TabStop = true;
            this.liDetainedLicenseInfo.Text = "Show Detained License info";
            this.liDetainedLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.liDetainedLicenseInfo_LinkClicked);
            // 
            // btnDetain
            // 
            this.btnDetain.BackColor = System.Drawing.Color.Maroon;
            this.btnDetain.Enabled = false;
            this.btnDetain.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDetain.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDetain.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDetain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetain.ForeColor = System.Drawing.Color.White;
            this.btnDetain.Location = new System.Drawing.Point(665, 600);
            this.btnDetain.Name = "btnDetain";
            this.btnDetain.Size = new System.Drawing.Size(104, 39);
            this.btnDetain.TabIndex = 13;
            this.btnDetain.Text = "Detain";
            this.btnDetain.UseVisualStyleBackColor = false;
            this.btnDetain.Click += new System.EventHandler(this.btnDetain_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Teal;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(555, 600);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(104, 39);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.ForeColor = System.Drawing.Color.Maroon;
            this.labelHeader.Location = new System.Drawing.Point(247, 9);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(283, 44);
            this.labelHeader.TabIndex = 15;
            this.labelHeader.Text = "Detain License";
            // 
            // ctrlLicenseCardFilter1
            // 
            this.ctrlLicenseCardFilter1.BackColor = System.Drawing.Color.White;
            this.ctrlLicenseCardFilter1.Location = new System.Drawing.Point(1, 61);
            this.ctrlLicenseCardFilter1.Name = "ctrlLicenseCardFilter1";
            this.ctrlLicenseCardFilter1.Size = new System.Drawing.Size(780, 388);
            this.ctrlLicenseCardFilter1.TabIndex = 0;
            this.ctrlLicenseCardFilter1.OnLicenseSelected += new System.Action<int>(this.ctrlLicenseCardFilter1_OnLicenseSelected);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmDetainLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(781, 651);
            this.Controls.Add(this.labelHeader);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDetain);
            this.Controls.Add(this.liDetainedLicenseInfo);
            this.Controls.Add(this.liShowLicensesHistory);
            this.Controls.Add(this.gbDetainInfo);
            this.Controls.Add(this.ctrlLicenseCardFilter1);
            this.MaximumSize = new System.Drawing.Size(797, 690);
            this.MinimumSize = new System.Drawing.Size(797, 690);
            this.Name = "frmDetainLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDetainLicense";
            this.gbDetainInfo.ResumeLayout(false);
            this.gbDetainInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlLicenseCardFilter ctrlLicenseCardFilter1;
        private System.Windows.Forms.Label labelDetainID;
        private System.Windows.Forms.Label lbDetainID;
        private System.Windows.Forms.Label lbDetainDate;
        private System.Windows.Forms.Label labelDetainDate;
        private System.Windows.Forms.Label lbCreatedBy;
        private System.Windows.Forms.Label labelCreatedBy;
        private System.Windows.Forms.Label lbLicenseID;
        private System.Windows.Forms.Label labelLicenseID;
        private System.Windows.Forms.Label labelFineFees;
        private System.Windows.Forms.GroupBox gbDetainInfo;
        private System.Windows.Forms.TextBox tbFineFees;
        private System.Windows.Forms.LinkLabel liShowLicensesHistory;
        private System.Windows.Forms.LinkLabel liDetainedLicenseInfo;
        private System.Windows.Forms.Button btnDetain;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}