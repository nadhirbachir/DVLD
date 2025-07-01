namespace DVLD
{
    partial class frmIssueDLFirstTime
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
            this.ctrlLDLAInfo1 = new DVLD.ctrlLDLAInfo();
            this.labelHeader = new System.Windows.Forms.Label();
            this.labelExtraNotes = new System.Windows.Forms.Label();
            this.tbNotes = new System.Windows.Forms.TextBox();
            this.btnIssue = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ctrlLDLAInfo1
            // 
            this.ctrlLDLAInfo1.BackColor = System.Drawing.Color.White;
            this.ctrlLDLAInfo1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlLDLAInfo1.Location = new System.Drawing.Point(3, 62);
            this.ctrlLDLAInfo1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ctrlLDLAInfo1.Name = "ctrlLDLAInfo1";
            this.ctrlLDLAInfo1.Size = new System.Drawing.Size(780, 369);
            this.ctrlLDLAInfo1.TabIndex = 0;
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.Location = new System.Drawing.Point(120, 14);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(554, 44);
            this.labelHeader.TabIndex = 1;
            this.labelHeader.Text = "Issue Driving license first time";
            // 
            // labelExtraNotes
            // 
            this.labelExtraNotes.AutoSize = true;
            this.labelExtraNotes.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExtraNotes.Location = new System.Drawing.Point(10, 442);
            this.labelExtraNotes.Name = "labelExtraNotes";
            this.labelExtraNotes.Size = new System.Drawing.Size(95, 18);
            this.labelExtraNotes.TabIndex = 2;
            this.labelExtraNotes.Text = "Extra Notes:";
            // 
            // tbNotes
            // 
            this.tbNotes.Location = new System.Drawing.Point(111, 442);
            this.tbNotes.Multiline = true;
            this.tbNotes.Name = "tbNotes";
            this.tbNotes.Size = new System.Drawing.Size(667, 110);
            this.tbNotes.TabIndex = 3;
            // 
            // btnIssue
            // 
            this.btnIssue.BackColor = System.Drawing.Color.Green;
            this.btnIssue.FlatAppearance.BorderSize = 0;
            this.btnIssue.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnIssue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnIssue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIssue.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssue.ForeColor = System.Drawing.Color.White;
            this.btnIssue.Location = new System.Drawing.Point(676, 558);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(102, 44);
            this.btnIssue.TabIndex = 4;
            this.btnIssue.Text = "Issue";
            this.btnIssue.UseVisualStyleBackColor = false;
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
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
            this.btnClose.Location = new System.Drawing.Point(568, 558);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(102, 44);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmIssueDLFirstTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(785, 609);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnIssue);
            this.Controls.Add(this.tbNotes);
            this.Controls.Add(this.labelExtraNotes);
            this.Controls.Add(this.labelHeader);
            this.Controls.Add(this.ctrlLDLAInfo1);
            this.Name = "frmIssueDLFirstTime";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmIssueDLFirstTime";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlLDLAInfo ctrlLDLAInfo1;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Label labelExtraNotes;
        private System.Windows.Forms.TextBox tbNotes;
        private System.Windows.Forms.Button btnIssue;
        private System.Windows.Forms.Button btnClose;
    }
}