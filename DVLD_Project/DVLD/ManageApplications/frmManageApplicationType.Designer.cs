namespace DVLD
{
    partial class frmManageApplicationType
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
            this.dgvApplicationType = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editApplToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelManageApplicationsType = new System.Windows.Forms.Label();
            this.labelRecords = new System.Windows.Forms.Label();
            this.lbRecords = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplicationType)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvApplicationType
            // 
            this.dgvApplicationType.AllowUserToAddRows = false;
            this.dgvApplicationType.AllowUserToDeleteRows = false;
            this.dgvApplicationType.AllowUserToOrderColumns = true;
            this.dgvApplicationType.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvApplicationType.BackgroundColor = System.Drawing.Color.White;
            this.dgvApplicationType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvApplicationType.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvApplicationType.Location = new System.Drawing.Point(12, 109);
            this.dgvApplicationType.MultiSelect = false;
            this.dgvApplicationType.Name = "dgvApplicationType";
            this.dgvApplicationType.ReadOnly = true;
            this.dgvApplicationType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvApplicationType.Size = new System.Drawing.Size(489, 298);
            this.dgvApplicationType.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editApplToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(183, 26);
            // 
            // editApplToolStripMenuItem
            // 
            this.editApplToolStripMenuItem.Name = "editApplToolStripMenuItem";
            this.editApplToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.editApplToolStripMenuItem.Text = "Edit Application info";
            this.editApplToolStripMenuItem.Click += new System.EventHandler(this.editApplToolStripMenuItem_Click);
            // 
            // labelManageApplicationsType
            // 
            this.labelManageApplicationsType.AutoSize = true;
            this.labelManageApplicationsType.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelManageApplicationsType.Location = new System.Drawing.Point(73, 21);
            this.labelManageApplicationsType.Name = "labelManageApplicationsType";
            this.labelManageApplicationsType.Size = new System.Drawing.Size(378, 34);
            this.labelManageApplicationsType.TabIndex = 2;
            this.labelManageApplicationsType.Text = "Manage Applications Type";
            // 
            // labelRecords
            // 
            this.labelRecords.AutoSize = true;
            this.labelRecords.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRecords.Location = new System.Drawing.Point(12, 419);
            this.labelRecords.Name = "labelRecords";
            this.labelRecords.Size = new System.Drawing.Size(62, 16);
            this.labelRecords.TabIndex = 3;
            this.labelRecords.Text = "Records:";
            // 
            // lbRecords
            // 
            this.lbRecords.AutoSize = true;
            this.lbRecords.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecords.Location = new System.Drawing.Point(76, 419);
            this.lbRecords.Name = "lbRecords";
            this.lbRecords.Size = new System.Drawing.Size(23, 16);
            this.lbRecords.TabIndex = 4;
            this.lbRecords.Text = "    ";
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
            this.btnClose.Location = new System.Drawing.Point(403, 412);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(98, 26);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmManageApplicationType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(520, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lbRecords);
            this.Controls.Add(this.labelRecords);
            this.Controls.Add(this.labelManageApplicationsType);
            this.Controls.Add(this.dgvApplicationType);
            this.Name = "frmManageApplicationType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmManageApplicationType";
            this.Load += new System.EventHandler(this.frmManageApplicationType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplicationType)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvApplicationType;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editApplToolStripMenuItem;
        private System.Windows.Forms.Label labelManageApplicationsType;
        private System.Windows.Forms.Label labelRecords;
        private System.Windows.Forms.Label lbRecords;
        private System.Windows.Forms.Button btnClose;
    }
}