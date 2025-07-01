namespace DVLD
{
    partial class frmLDLACard
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
            this.labelLocalDrivinglicenseinformation = new System.Windows.Forms.Label();
            this.ctrlLDLAInfo1 = new DVLD.ctrlLDLAInfo();
            this.SuspendLayout();
            // 
            // labelLocalDrivinglicenseinformation
            // 
            this.labelLocalDrivinglicenseinformation.AutoSize = true;
            this.labelLocalDrivinglicenseinformation.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLocalDrivinglicenseinformation.ForeColor = System.Drawing.Color.Red;
            this.labelLocalDrivinglicenseinformation.Location = new System.Drawing.Point(145, 9);
            this.labelLocalDrivinglicenseinformation.Name = "labelLocalDrivinglicenseinformation";
            this.labelLocalDrivinglicenseinformation.Size = new System.Drawing.Size(496, 42);
            this.labelLocalDrivinglicenseinformation.TabIndex = 1;
            this.labelLocalDrivinglicenseinformation.Text = "Local Driving license information";
            // 
            // ctrlLDLAInfo1
            // 
            this.ctrlLDLAInfo1.BackColor = System.Drawing.Color.White;
            this.ctrlLDLAInfo1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlLDLAInfo1.Location = new System.Drawing.Point(2, 51);
            this.ctrlLDLAInfo1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ctrlLDLAInfo1.Name = "ctrlLDLAInfo1";
            this.ctrlLDLAInfo1.Size = new System.Drawing.Size(780, 369);
            this.ctrlLDLAInfo1.TabIndex = 0;
            // 
            // frmLDLACard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(783, 419);
            this.Controls.Add(this.labelLocalDrivinglicenseinformation);
            this.Controls.Add(this.ctrlLDLAInfo1);
            this.MaximumSize = new System.Drawing.Size(799, 458);
            this.MinimumSize = new System.Drawing.Size(799, 458);
            this.Name = "frmLDLACard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLDLACard";
            this.Load += new System.EventHandler(this.frmLDLACard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlLDLAInfo ctrlLDLAInfo1;
        private System.Windows.Forms.Label labelLocalDrivinglicenseinformation;
    }
}