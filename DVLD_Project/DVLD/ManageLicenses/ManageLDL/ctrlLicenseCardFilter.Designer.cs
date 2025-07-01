namespace DVLD
{
    partial class ctrlLicenseCardFilter
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbLicenseID = new System.Windows.Forms.TextBox();
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.labelLicenseID = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.ctrlLicenseCard1 = new DVLD.ctrlLicenseCard();
            this.gbFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbLicenseID
            // 
            this.tbLicenseID.Location = new System.Drawing.Point(258, 22);
            this.tbLicenseID.MaxLength = 200;
            this.tbLicenseID.Name = "tbLicenseID";
            this.tbLicenseID.Size = new System.Drawing.Size(190, 20);
            this.tbLicenseID.TabIndex = 1;
            this.tbLicenseID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbLicenseID_KeyPress);
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.labelLicenseID);
            this.gbFilter.Controls.Add(this.btnSearch);
            this.gbFilter.Controls.Add(this.tbLicenseID);
            this.gbFilter.Location = new System.Drawing.Point(3, 3);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(774, 59);
            this.gbFilter.TabIndex = 2;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "License Filter";
            // 
            // labelLicenseID
            // 
            this.labelLicenseID.AutoSize = true;
            this.labelLicenseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLicenseID.Location = new System.Drawing.Point(168, 23);
            this.labelLicenseID.Name = "labelLicenseID";
            this.labelLicenseID.Size = new System.Drawing.Size(84, 16);
            this.labelLicenseID.TabIndex = 3;
            this.labelLicenseID.Text = "License ID:";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Green;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(454, 15);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(84, 32);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // ctrlLicenseCard1
            // 
            this.ctrlLicenseCard1.BackColor = System.Drawing.Color.White;
            this.ctrlLicenseCard1.Location = new System.Drawing.Point(-1, 68);
            this.ctrlLicenseCard1.Name = "ctrlLicenseCard1";
            this.ctrlLicenseCard1.Size = new System.Drawing.Size(781, 320);
            this.ctrlLicenseCard1.TabIndex = 3;
            this.ctrlLicenseCard1.WhenLicenseFound += new System.Action<DVLD_Business.clsLicense>(this.ctrlLicenseCard1_WhenLicenseFound);
            // 
            // ctrlLicenseCardFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ctrlLicenseCard1);
            this.Controls.Add(this.gbFilter);
            this.Name = "ctrlLicenseCardFilter";
            this.Size = new System.Drawing.Size(780, 388);
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox tbLicenseID;
        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.Label labelLicenseID;
        private System.Windows.Forms.Button btnSearch;
        private ctrlLicenseCard ctrlLicenseCard1;
    }
}
