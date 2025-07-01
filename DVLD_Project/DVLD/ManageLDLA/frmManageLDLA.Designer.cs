namespace DVLD
{
    partial class frmManageLDLA
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
            this.btnAddLDLA = new System.Windows.Forms.Button();
            this.dgvLDLA = new System.Windows.Forms.DataGridView();
            this.ctsLDLA = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiShowLDLACard = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiAddNew = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCancle = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSchedualTest = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiVisionTest = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiWrittenTest = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStreetTest = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiIssueDrivingLicenseFirstTime = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiShowDrivingLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiShowPersonLicenseHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.lbRecords = new System.Windows.Forms.Label();
            this.labelRecords = new System.Windows.Forms.Label();
            this.labelManageLDLAs = new System.Windows.Forms.Label();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.cbStatusFilter = new System.Windows.Forms.ComboBox();
            this.tbFilterString = new System.Windows.Forms.TextBox();
            this.tbDegitFilter = new System.Windows.Forms.TextBox();
            this.labelFilterBy = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLDLA)).BeginInit();
            this.ctsLDLA.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddLDLA
            // 
            this.btnAddLDLA.BackColor = System.Drawing.Color.Teal;
            this.btnAddLDLA.FlatAppearance.BorderSize = 0;
            this.btnAddLDLA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAddLDLA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddLDLA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddLDLA.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddLDLA.ForeColor = System.Drawing.Color.White;
            this.btnAddLDLA.Location = new System.Drawing.Point(937, 91);
            this.btnAddLDLA.Name = "btnAddLDLA";
            this.btnAddLDLA.Size = new System.Drawing.Size(96, 43);
            this.btnAddLDLA.TabIndex = 0;
            this.btnAddLDLA.Text = "Add new";
            this.btnAddLDLA.UseVisualStyleBackColor = false;
            this.btnAddLDLA.Click += new System.EventHandler(this.btnAddLDLA_Click);
            // 
            // dgvLDLA
            // 
            this.dgvLDLA.AllowUserToAddRows = false;
            this.dgvLDLA.AllowUserToDeleteRows = false;
            this.dgvLDLA.AllowUserToOrderColumns = true;
            this.dgvLDLA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvLDLA.BackgroundColor = System.Drawing.Color.White;
            this.dgvLDLA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLDLA.ContextMenuStrip = this.ctsLDLA;
            this.dgvLDLA.Location = new System.Drawing.Point(12, 140);
            this.dgvLDLA.Name = "dgvLDLA";
            this.dgvLDLA.ReadOnly = true;
            this.dgvLDLA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLDLA.Size = new System.Drawing.Size(1021, 237);
            this.dgvLDLA.TabIndex = 1;
            // 
            // ctsLDLA
            // 
            this.ctsLDLA.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiShowLDLACard,
            this.toolStripMenuItem1,
            this.tsmiAddNew,
            this.tsmiEdit,
            this.tsmiDelete,
            this.tsmiCancle,
            this.toolStripMenuItem2,
            this.tsmiSchedualTest,
            this.toolStripMenuItem3,
            this.tsmiIssueDrivingLicenseFirstTime,
            this.toolStripMenuItem4,
            this.tsmiShowDrivingLicense,
            this.toolStripMenuItem5,
            this.tsmiShowPersonLicenseHistory});
            this.ctsLDLA.Name = "contextMenuStrip1";
            this.ctsLDLA.Size = new System.Drawing.Size(242, 254);
            this.ctsLDLA.Opening += new System.ComponentModel.CancelEventHandler(this.ctsLDLA_Opening);
            // 
            // tsmiShowLDLACard
            // 
            this.tsmiShowLDLACard.Name = "tsmiShowLDLACard";
            this.tsmiShowLDLACard.Size = new System.Drawing.Size(241, 22);
            this.tsmiShowLDLACard.Text = "Show LDLA Card";
            this.tsmiShowLDLACard.Click += new System.EventHandler(this.tsmiShowLDLACard_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(238, 6);
            // 
            // tsmiAddNew
            // 
            this.tsmiAddNew.Name = "tsmiAddNew";
            this.tsmiAddNew.Size = new System.Drawing.Size(241, 22);
            this.tsmiAddNew.Text = "Add new LDLA";
            this.tsmiAddNew.Click += new System.EventHandler(this.addNewLDLAToolStripMenuItem_Click);
            // 
            // tsmiEdit
            // 
            this.tsmiEdit.Name = "tsmiEdit";
            this.tsmiEdit.Size = new System.Drawing.Size(241, 22);
            this.tsmiEdit.Text = "Edit";
            this.tsmiEdit.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // tsmiDelete
            // 
            this.tsmiDelete.Name = "tsmiDelete";
            this.tsmiDelete.Size = new System.Drawing.Size(241, 22);
            this.tsmiDelete.Text = "Delete";
            this.tsmiDelete.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // tsmiCancle
            // 
            this.tsmiCancle.Name = "tsmiCancle";
            this.tsmiCancle.Size = new System.Drawing.Size(241, 22);
            this.tsmiCancle.Text = "Cancle";
            this.tsmiCancle.Click += new System.EventHandler(this.cancleToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(238, 6);
            // 
            // tsmiSchedualTest
            // 
            this.tsmiSchedualTest.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiVisionTest,
            this.tsmiWrittenTest,
            this.tsmiStreetTest});
            this.tsmiSchedualTest.Name = "tsmiSchedualTest";
            this.tsmiSchedualTest.Size = new System.Drawing.Size(241, 22);
            this.tsmiSchedualTest.Text = "Schedual Test";
            // 
            // tsmiVisionTest
            // 
            this.tsmiVisionTest.Name = "tsmiVisionTest";
            this.tsmiVisionTest.Size = new System.Drawing.Size(135, 22);
            this.tsmiVisionTest.Text = "Vision test";
            this.tsmiVisionTest.Click += new System.EventHandler(this.tsmiVisionTest_Click);
            // 
            // tsmiWrittenTest
            // 
            this.tsmiWrittenTest.Name = "tsmiWrittenTest";
            this.tsmiWrittenTest.Size = new System.Drawing.Size(135, 22);
            this.tsmiWrittenTest.Text = "Written test";
            this.tsmiWrittenTest.Click += new System.EventHandler(this.tsmiWrittenTest_Click);
            // 
            // tsmiStreetTest
            // 
            this.tsmiStreetTest.Name = "tsmiStreetTest";
            this.tsmiStreetTest.Size = new System.Drawing.Size(135, 22);
            this.tsmiStreetTest.Text = "Street test";
            this.tsmiStreetTest.Click += new System.EventHandler(this.tsmiStreetTest_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(238, 6);
            // 
            // tsmiIssueDrivingLicenseFirstTime
            // 
            this.tsmiIssueDrivingLicenseFirstTime.Name = "tsmiIssueDrivingLicenseFirstTime";
            this.tsmiIssueDrivingLicenseFirstTime.Size = new System.Drawing.Size(241, 22);
            this.tsmiIssueDrivingLicenseFirstTime.Text = "Issue driving license (First Time)";
            this.tsmiIssueDrivingLicenseFirstTime.Click += new System.EventHandler(this.tsmiIssueDrivingLicenseFirstTime_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(238, 6);
            // 
            // tsmiShowDrivingLicense
            // 
            this.tsmiShowDrivingLicense.Name = "tsmiShowDrivingLicense";
            this.tsmiShowDrivingLicense.Size = new System.Drawing.Size(241, 22);
            this.tsmiShowDrivingLicense.Text = "Show Driving License";
            this.tsmiShowDrivingLicense.Click += new System.EventHandler(this.tsmiShowDrivingLicense_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(238, 6);
            // 
            // tsmiShowPersonLicenseHistory
            // 
            this.tsmiShowPersonLicenseHistory.Name = "tsmiShowPersonLicenseHistory";
            this.tsmiShowPersonLicenseHistory.Size = new System.Drawing.Size(241, 22);
            this.tsmiShowPersonLicenseHistory.Text = "Show Person License History";
            this.tsmiShowPersonLicenseHistory.Click += new System.EventHandler(this.tsmiShowPersonLicenseHistory_Click);
            // 
            // lbRecords
            // 
            this.lbRecords.AutoSize = true;
            this.lbRecords.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecords.Location = new System.Drawing.Point(95, 380);
            this.lbRecords.Name = "lbRecords";
            this.lbRecords.Size = new System.Drawing.Size(39, 19);
            this.lbRecords.TabIndex = 2;
            this.lbRecords.Text = "???";
            // 
            // labelRecords
            // 
            this.labelRecords.AutoSize = true;
            this.labelRecords.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRecords.Location = new System.Drawing.Point(9, 380);
            this.labelRecords.Name = "labelRecords";
            this.labelRecords.Size = new System.Drawing.Size(80, 19);
            this.labelRecords.TabIndex = 4;
            this.labelRecords.Text = "Records:";
            // 
            // labelManageLDLAs
            // 
            this.labelManageLDLAs.AutoSize = true;
            this.labelManageLDLAs.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelManageLDLAs.Location = new System.Drawing.Point(153, 28);
            this.labelManageLDLAs.Name = "labelManageLDLAs";
            this.labelManageLDLAs.Size = new System.Drawing.Size(718, 41);
            this.labelManageLDLAs.TabIndex = 5;
            this.labelManageLDLAs.Text = "Manage Local Driving License Applications";
            // 
            // cbFilter
            // 
            this.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Items.AddRange(new object[] {
            "None",
            "L.D.L.A ID",
            "Class Name",
            "National No",
            "Name",
            "Status"});
            this.cbFilter.Location = new System.Drawing.Point(99, 113);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(126, 21);
            this.cbFilter.TabIndex = 6;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // cbStatusFilter
            // 
            this.cbStatusFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatusFilter.FormattingEnabled = true;
            this.cbStatusFilter.Items.AddRange(new object[] {
            "All",
            "New",
            "Cancelled",
            "Completed"});
            this.cbStatusFilter.Location = new System.Drawing.Point(231, 113);
            this.cbStatusFilter.Name = "cbStatusFilter";
            this.cbStatusFilter.Size = new System.Drawing.Size(79, 21);
            this.cbStatusFilter.TabIndex = 7;
            this.cbStatusFilter.Visible = false;
            this.cbStatusFilter.SelectedIndexChanged += new System.EventHandler(this.cbStatusFilter_SelectedIndexChanged);
            // 
            // tbFilterString
            // 
            this.tbFilterString.Location = new System.Drawing.Point(231, 114);
            this.tbFilterString.MaxLength = 200;
            this.tbFilterString.Name = "tbFilterString";
            this.tbFilterString.Size = new System.Drawing.Size(176, 20);
            this.tbFilterString.TabIndex = 8;
            this.tbFilterString.Visible = false;
            this.tbFilterString.TextChanged += new System.EventHandler(this.tbFilterString_TextChanged);
            // 
            // tbDegitFilter
            // 
            this.tbDegitFilter.Location = new System.Drawing.Point(231, 114);
            this.tbDegitFilter.MaxLength = 200;
            this.tbDegitFilter.Name = "tbDegitFilter";
            this.tbDegitFilter.Size = new System.Drawing.Size(176, 20);
            this.tbDegitFilter.TabIndex = 9;
            this.tbDegitFilter.Visible = false;
            this.tbDegitFilter.TextChanged += new System.EventHandler(this.tbDegitFilter_TextChanged);
            this.tbDegitFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDegitFilter_KeyPress);
            // 
            // labelFilterBy
            // 
            this.labelFilterBy.AutoSize = true;
            this.labelFilterBy.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilterBy.Location = new System.Drawing.Point(15, 115);
            this.labelFilterBy.Name = "labelFilterBy";
            this.labelFilterBy.Size = new System.Drawing.Size(78, 19);
            this.labelFilterBy.TabIndex = 10;
            this.labelFilterBy.Text = "Filter By:";
            // 
            // frmManageLDLA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1045, 417);
            this.Controls.Add(this.labelFilterBy);
            this.Controls.Add(this.tbDegitFilter);
            this.Controls.Add(this.tbFilterString);
            this.Controls.Add(this.cbStatusFilter);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.labelManageLDLAs);
            this.Controls.Add(this.labelRecords);
            this.Controls.Add(this.lbRecords);
            this.Controls.Add(this.dgvLDLA);
            this.Controls.Add(this.btnAddLDLA);
            this.MaximumSize = new System.Drawing.Size(1061, 456);
            this.MinimumSize = new System.Drawing.Size(1061, 456);
            this.Name = "frmManageLDLA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmManageLDLA";
            this.Load += new System.EventHandler(this.frmManageLDLA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLDLA)).EndInit();
            this.ctsLDLA.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddLDLA;
        private System.Windows.Forms.DataGridView dgvLDLA;
        private System.Windows.Forms.Label lbRecords;
        private System.Windows.Forms.ContextMenuStrip ctsLDLA;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowLDLACard;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddNew;
        private System.Windows.Forms.ToolStripMenuItem tsmiEdit;
        private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
        private System.Windows.Forms.ToolStripMenuItem tsmiCancle;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.Label labelRecords;
        private System.Windows.Forms.Label labelManageLDLAs;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.ComboBox cbStatusFilter;
        private System.Windows.Forms.TextBox tbFilterString;
        private System.Windows.Forms.TextBox tbDegitFilter;
        private System.Windows.Forms.Label labelFilterBy;
        private System.Windows.Forms.ToolStripMenuItem tsmiSchedualTest;
        private System.Windows.Forms.ToolStripMenuItem tsmiVisionTest;
        private System.Windows.Forms.ToolStripMenuItem tsmiWrittenTest;
        private System.Windows.Forms.ToolStripMenuItem tsmiStreetTest;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem tsmiIssueDrivingLicenseFirstTime;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowDrivingLicense;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowPersonLicenseHistory;
    }
}