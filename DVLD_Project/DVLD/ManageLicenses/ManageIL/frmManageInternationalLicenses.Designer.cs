namespace DVLD
{
    partial class frmManageInternationalLicenses
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
            this.dgvIL = new System.Windows.Forms.DataGridView();
            this.btnAddIL = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.labelRecord = new System.Windows.Forms.Label();
            this.lbRecord = new System.Windows.Forms.Label();
            this.cmsILManagement = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showInternationalLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPersonDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.labelFilterBy = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIL)).BeginInit();
            this.cmsILManagement.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvIL
            // 
            this.dgvIL.AllowUserToAddRows = false;
            this.dgvIL.AllowUserToDeleteRows = false;
            this.dgvIL.AllowUserToOrderColumns = true;
            this.dgvIL.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvIL.BackgroundColor = System.Drawing.Color.White;
            this.dgvIL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIL.ContextMenuStrip = this.cmsILManagement;
            this.dgvIL.Location = new System.Drawing.Point(12, 130);
            this.dgvIL.MultiSelect = false;
            this.dgvIL.Name = "dgvIL";
            this.dgvIL.ReadOnly = true;
            this.dgvIL.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIL.Size = new System.Drawing.Size(938, 261);
            this.dgvIL.TabIndex = 0;
            // 
            // btnAddIL
            // 
            this.btnAddIL.BackColor = System.Drawing.Color.Green;
            this.btnAddIL.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAddIL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAddIL.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddIL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddIL.ForeColor = System.Drawing.Color.White;
            this.btnAddIL.Location = new System.Drawing.Point(845, 78);
            this.btnAddIL.Name = "btnAddIL";
            this.btnAddIL.Size = new System.Drawing.Size(105, 46);
            this.btnAddIL.TabIndex = 1;
            this.btnAddIL.Text = "Add I.L";
            this.btnAddIL.UseVisualStyleBackColor = false;
            this.btnAddIL.Click += new System.EventHandler(this.btnAddIL_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Teal;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(845, 397);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(105, 46);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // labelRecord
            // 
            this.labelRecord.AutoSize = true;
            this.labelRecord.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRecord.Location = new System.Drawing.Point(12, 411);
            this.labelRecord.Name = "labelRecord";
            this.labelRecord.Size = new System.Drawing.Size(80, 19);
            this.labelRecord.TabIndex = 3;
            this.labelRecord.Text = "Records:";
            // 
            // lbRecord
            // 
            this.lbRecord.AutoSize = true;
            this.lbRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbRecord.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecord.Location = new System.Drawing.Point(98, 411);
            this.lbRecord.Name = "lbRecord";
            this.lbRecord.Size = new System.Drawing.Size(57, 19);
            this.lbRecord.TabIndex = 4;
            this.lbRecord.Text = "[ ??? ]";
            // 
            // cmsILManagement
            // 
            this.cmsILManagement.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsILManagement.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showPersonDetailsToolStripMenuItem,
            this.showInternationalLicenseToolStripMenuItem,
            this.shoToolStripMenuItem});
            this.cmsILManagement.Name = "cmsILManagement";
            this.cmsILManagement.Size = new System.Drawing.Size(283, 82);
            // 
            // showInternationalLicenseToolStripMenuItem
            // 
            this.showInternationalLicenseToolStripMenuItem.Name = "showInternationalLicenseToolStripMenuItem";
            this.showInternationalLicenseToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.showInternationalLicenseToolStripMenuItem.Text = "Show International License";
            this.showInternationalLicenseToolStripMenuItem.Click += new System.EventHandler(this.showInternationalLicenseToolStripMenuItem_Click);
            // 
            // showPersonDetailsToolStripMenuItem
            // 
            this.showPersonDetailsToolStripMenuItem.Name = "showPersonDetailsToolStripMenuItem";
            this.showPersonDetailsToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.showPersonDetailsToolStripMenuItem.Text = "Show Person details";
            this.showPersonDetailsToolStripMenuItem.Click += new System.EventHandler(this.showPersonDetailsToolStripMenuItem_Click);
            // 
            // shoToolStripMenuItem
            // 
            this.shoToolStripMenuItem.Name = "shoToolStripMenuItem";
            this.shoToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.shoToolStripMenuItem.Text = "Show Person license history";
            this.shoToolStripMenuItem.Click += new System.EventHandler(this.shoToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(165, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(684, 44);
            this.label1.TabIndex = 6;
            this.label1.Text = "Manage international driving licenses";
            // 
            // cbFilter
            // 
            this.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Items.AddRange(new object[] {
            "None",
            "I.L ID",
            "Application ID",
            "Driver ID",
            "L.L ID",
            "Is Active"});
            this.cbFilter.Location = new System.Drawing.Point(90, 103);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(147, 21);
            this.cbFilter.TabIndex = 7;
            // 
            // labelFilterBy
            // 
            this.labelFilterBy.AutoSize = true;
            this.labelFilterBy.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilterBy.Location = new System.Drawing.Point(13, 103);
            this.labelFilterBy.Name = "labelFilterBy";
            this.labelFilterBy.Size = new System.Drawing.Size(71, 18);
            this.labelFilterBy.TabIndex = 8;
            this.labelFilterBy.Text = "Filter By:";
            // 
            // frmManageInternationalLicenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(962, 450);
            this.Controls.Add(this.labelFilterBy);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbRecord);
            this.Controls.Add(this.labelRecord);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddIL);
            this.Controls.Add(this.dgvIL);
            this.MaximumSize = new System.Drawing.Size(978, 489);
            this.MinimumSize = new System.Drawing.Size(978, 489);
            this.Name = "frmManageInternationalLicenses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmManageInternationalLicenses";
            this.Load += new System.EventHandler(this.frmManageInternationalLicenses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIL)).EndInit();
            this.cmsILManagement.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvIL;
        private System.Windows.Forms.Button btnAddIL;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label labelRecord;
        private System.Windows.Forms.Label lbRecord;
        private System.Windows.Forms.ContextMenuStrip cmsILManagement;
        private System.Windows.Forms.ToolStripMenuItem showInternationalLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPersonDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shoToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Label labelFilterBy;
    }
}