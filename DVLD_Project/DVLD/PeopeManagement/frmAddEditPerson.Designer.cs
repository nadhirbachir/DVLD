namespace DVLD
{
    partial class frmAddEditPerson
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
            this.ctrlEditPerson1 = new DVLD.ctrlEditPerson();
            this.SuspendLayout();
            // 
            // ctrlEditPerson1
            // 
            this.ctrlEditPerson1.BackColor = System.Drawing.Color.White;
            this.ctrlEditPerson1.Location = new System.Drawing.Point(1, 0);
            this.ctrlEditPerson1.Name = "ctrlEditPerson1";
            this.ctrlEditPerson1.Size = new System.Drawing.Size(790, 390);
            this.ctrlEditPerson1.TabIndex = 0;
            // 
            // frmAddEditPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 389);
            this.Controls.Add(this.ctrlEditPerson1);
            this.MaximumSize = new System.Drawing.Size(808, 428);
            this.MinimumSize = new System.Drawing.Size(808, 428);
            this.Name = "frmAddEditPerson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddEditPerson";
            this.Load += new System.EventHandler(this.frmAddEditPerson_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlEditPerson ctrlEditPerson1;
    }
}