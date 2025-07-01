namespace DVLD
{
    partial class frmIDLInfo
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
            this.ctrlIDLInfo1 = new DVLD.ctrlIDLInfo();
            this.btnClose = new System.Windows.Forms.Button();
            this.labelHeader = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ctrlIDLInfo1
            // 
            this.ctrlIDLInfo1.BackColor = System.Drawing.Color.White;
            this.ctrlIDLInfo1.Location = new System.Drawing.Point(3, 70);
            this.ctrlIDLInfo1.Name = "ctrlIDLInfo1";
            this.ctrlIDLInfo1.Size = new System.Drawing.Size(694, 239);
            this.ctrlIDLInfo1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Teal;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(601, 311);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(91, 44);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.ForeColor = System.Drawing.Color.Teal;
            this.labelHeader.Location = new System.Drawing.Point(59, 23);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(586, 44);
            this.labelHeader.TabIndex = 2;
            this.labelHeader.Text = "Driver International License info";
            // 
            // frmIDLInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(698, 360);
            this.Controls.Add(this.labelHeader);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ctrlIDLInfo1);
            this.MaximumSize = new System.Drawing.Size(714, 399);
            this.MinimumSize = new System.Drawing.Size(714, 399);
            this.Name = "frmIDLInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmIDLInfo";
            this.Load += new System.EventHandler(this.frmIDLInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlIDLInfo ctrlIDLInfo1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label labelHeader;
    }
}