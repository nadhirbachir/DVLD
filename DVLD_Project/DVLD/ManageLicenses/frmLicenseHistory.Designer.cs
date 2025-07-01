namespace DVLD
{
    partial class frmLicenseHistory
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpLDL = new System.Windows.Forms.TabPage();
            this.labelLDLHHeader = new System.Windows.Forms.Label();
            this.dgvLDL = new System.Windows.Forms.DataGridView();
            this.cmsLDL = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.showLicenseInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.renewLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.tpIDL = new System.Windows.Forms.TabPage();
            this.labelIDLHHeader = new System.Windows.Forms.Label();
            this.dgvIDL = new System.Windows.Forms.DataGridView();
            this.cmsIDL = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.showInternationalDrivingLicenseInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.labelDLH = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.ctrlPersonInfoFilter1 = new DVLD.ctrlPersonInfoFilter();
            this.replaceLicenseForLostOrDamagedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.tabControl1.SuspendLayout();
            this.tpLDL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLDL)).BeginInit();
            this.cmsLDL.SuspendLayout();
            this.tpIDL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIDL)).BeginInit();
            this.cmsIDL.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpLDL);
            this.tabControl1.Controls.Add(this.tpIDL);
            this.tabControl1.Location = new System.Drawing.Point(12, 408);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1004, 274);
            this.tabControl1.TabIndex = 1;
            // 
            // tpLDL
            // 
            this.tpLDL.Controls.Add(this.labelLDLHHeader);
            this.tpLDL.Controls.Add(this.dgvLDL);
            this.tpLDL.Location = new System.Drawing.Point(4, 22);
            this.tpLDL.Name = "tpLDL";
            this.tpLDL.Padding = new System.Windows.Forms.Padding(3);
            this.tpLDL.Size = new System.Drawing.Size(996, 248);
            this.tpLDL.TabIndex = 0;
            this.tpLDL.Text = "Local driving licenses";
            this.tpLDL.UseVisualStyleBackColor = true;
            // 
            // labelLDLHHeader
            // 
            this.labelLDLHHeader.AutoSize = true;
            this.labelLDLHHeader.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLDLHHeader.Location = new System.Drawing.Point(318, 16);
            this.labelLDLHHeader.Name = "labelLDLHHeader";
            this.labelLDLHHeader.Size = new System.Drawing.Size(293, 22);
            this.labelLDLHHeader.TabIndex = 1;
            this.labelLDLHHeader.Text = "Local Driving Licenses History";
            // 
            // dgvLDL
            // 
            this.dgvLDL.AllowUserToAddRows = false;
            this.dgvLDL.AllowUserToDeleteRows = false;
            this.dgvLDL.AllowUserToOrderColumns = true;
            this.dgvLDL.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvLDL.BackgroundColor = System.Drawing.Color.White;
            this.dgvLDL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLDL.ContextMenuStrip = this.cmsLDL;
            this.dgvLDL.Location = new System.Drawing.Point(3, 41);
            this.dgvLDL.MultiSelect = false;
            this.dgvLDL.Name = "dgvLDL";
            this.dgvLDL.ReadOnly = true;
            this.dgvLDL.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLDL.Size = new System.Drawing.Size(990, 204);
            this.dgvLDL.TabIndex = 0;
            // 
            // cmsLDL
            // 
            this.cmsLDL.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsLDL.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem4,
            this.showLicenseInfoToolStripMenuItem,
            this.toolStripMenuItem3,
            this.renewLicenseToolStripMenuItem,
            this.toolStripMenuItem5,
            this.replaceLicenseForLostOrDamagedToolStripMenuItem,
            this.toolStripMenuItem6});
            this.cmsLDL.Name = "cmsLDL";
            this.cmsLDL.Size = new System.Drawing.Size(343, 128);
            this.cmsLDL.Opening += new System.ComponentModel.CancelEventHandler(this.cmsLDL_Opening);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(339, 6);
            // 
            // showLicenseInfoToolStripMenuItem
            // 
            this.showLicenseInfoToolStripMenuItem.Name = "showLicenseInfoToolStripMenuItem";
            this.showLicenseInfoToolStripMenuItem.Size = new System.Drawing.Size(342, 26);
            this.showLicenseInfoToolStripMenuItem.Text = "Show License Info";
            this.showLicenseInfoToolStripMenuItem.Click += new System.EventHandler(this.showLicenseInfoToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(339, 6);
            // 
            // renewLicenseToolStripMenuItem
            // 
            this.renewLicenseToolStripMenuItem.Name = "renewLicenseToolStripMenuItem";
            this.renewLicenseToolStripMenuItem.Size = new System.Drawing.Size(342, 26);
            this.renewLicenseToolStripMenuItem.Text = "Renew License";
            this.renewLicenseToolStripMenuItem.Click += new System.EventHandler(this.renewLicenseToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(339, 6);
            // 
            // tpIDL
            // 
            this.tpIDL.Controls.Add(this.labelIDLHHeader);
            this.tpIDL.Controls.Add(this.dgvIDL);
            this.tpIDL.Location = new System.Drawing.Point(4, 22);
            this.tpIDL.Name = "tpIDL";
            this.tpIDL.Padding = new System.Windows.Forms.Padding(3);
            this.tpIDL.Size = new System.Drawing.Size(996, 248);
            this.tpIDL.TabIndex = 1;
            this.tpIDL.Text = "International driving licenses";
            this.tpIDL.UseVisualStyleBackColor = true;
            // 
            // labelIDLHHeader
            // 
            this.labelIDLHHeader.AutoSize = true;
            this.labelIDLHHeader.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIDLHHeader.Location = new System.Drawing.Point(290, 16);
            this.labelIDLHHeader.Name = "labelIDLHHeader";
            this.labelIDLHHeader.Size = new System.Drawing.Size(358, 22);
            this.labelIDLHHeader.TabIndex = 2;
            this.labelIDLHHeader.Text = "International Driving Licenses History";
            // 
            // dgvIDL
            // 
            this.dgvIDL.AllowUserToAddRows = false;
            this.dgvIDL.AllowUserToDeleteRows = false;
            this.dgvIDL.AllowUserToOrderColumns = true;
            this.dgvIDL.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvIDL.BackgroundColor = System.Drawing.Color.White;
            this.dgvIDL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIDL.ContextMenuStrip = this.cmsIDL;
            this.dgvIDL.Location = new System.Drawing.Point(3, 41);
            this.dgvIDL.MultiSelect = false;
            this.dgvIDL.Name = "dgvIDL";
            this.dgvIDL.ReadOnly = true;
            this.dgvIDL.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIDL.Size = new System.Drawing.Size(990, 204);
            this.dgvIDL.TabIndex = 1;
            // 
            // cmsIDL
            // 
            this.cmsIDL.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsIDL.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.showInternationalDrivingLicenseInfoToolStripMenuItem,
            this.toolStripMenuItem2});
            this.cmsIDL.Name = "cmsIDL";
            this.cmsIDL.Size = new System.Drawing.Size(359, 42);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(355, 6);
            // 
            // showInternationalDrivingLicenseInfoToolStripMenuItem
            // 
            this.showInternationalDrivingLicenseInfoToolStripMenuItem.Name = "showInternationalDrivingLicenseInfoToolStripMenuItem";
            this.showInternationalDrivingLicenseInfoToolStripMenuItem.Size = new System.Drawing.Size(358, 26);
            this.showInternationalDrivingLicenseInfoToolStripMenuItem.Text = "Show international driving license info";
            this.showInternationalDrivingLicenseInfoToolStripMenuItem.Click += new System.EventHandler(this.showInternationalDrivingLicenseInfoToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(355, 6);
            // 
            // labelDLH
            // 
            this.labelDLH.AutoSize = true;
            this.labelDLH.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDLH.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelDLH.Location = new System.Drawing.Point(211, 26);
            this.labelDLH.Name = "labelDLH";
            this.labelDLH.Size = new System.Drawing.Size(571, 44);
            this.labelDLH.TabIndex = 2;
            this.labelDLH.Text = "Person Driving License History";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Teal;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(916, 684);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(96, 43);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ctrlPersonInfoFilter1
            // 
            this.ctrlPersonInfoFilter1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ctrlPersonInfoFilter1.Location = new System.Drawing.Point(199, 73);
            this.ctrlPersonInfoFilter1.Name = "ctrlPersonInfoFilter1";
            this.ctrlPersonInfoFilter1.Size = new System.Drawing.Size(593, 329);
            this.ctrlPersonInfoFilter1.TabIndex = 0;
            this.ctrlPersonInfoFilter1.PersonSelected += new System.Action<int>(this.ctrlPersonInfoFilter1_PersonSelected);
            // 
            // replaceLicenseForLostOrDamagedToolStripMenuItem
            // 
            this.replaceLicenseForLostOrDamagedToolStripMenuItem.Name = "replaceLicenseForLostOrDamagedToolStripMenuItem";
            this.replaceLicenseForLostOrDamagedToolStripMenuItem.Size = new System.Drawing.Size(342, 26);
            this.replaceLicenseForLostOrDamagedToolStripMenuItem.Text = "Replace license for lost or damaged";
            this.replaceLicenseForLostOrDamagedToolStripMenuItem.Click += new System.EventHandler(this.replaceLicenseForLostOrDamagedToolStripMenuItem_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(339, 6);
            // 
            // frmLicenseHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1028, 733);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.labelDLH);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.ctrlPersonInfoFilter1);
            this.MaximumSize = new System.Drawing.Size(1044, 772);
            this.MinimumSize = new System.Drawing.Size(1044, 772);
            this.Name = "frmLicenseHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLicenseHistory";
            this.tabControl1.ResumeLayout(false);
            this.tpLDL.ResumeLayout(false);
            this.tpLDL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLDL)).EndInit();
            this.cmsLDL.ResumeLayout(false);
            this.tpIDL.ResumeLayout(false);
            this.tpIDL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIDL)).EndInit();
            this.cmsIDL.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlPersonInfoFilter ctrlPersonInfoFilter1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpLDL;
        private System.Windows.Forms.TabPage tpIDL;
        private System.Windows.Forms.DataGridView dgvLDL;
        private System.Windows.Forms.Label labelLDLHHeader;
        private System.Windows.Forms.Label labelIDLHHeader;
        private System.Windows.Forms.DataGridView dgvIDL;
        private System.Windows.Forms.ContextMenuStrip cmsLDL;
        private System.Windows.Forms.ToolStripMenuItem showLicenseInfoToolStripMenuItem;
        private System.Windows.Forms.Label labelDLH;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ContextMenuStrip cmsIDL;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem showInternationalDrivingLicenseInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem renewLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem replaceLicenseForLostOrDamagedToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
    }
}