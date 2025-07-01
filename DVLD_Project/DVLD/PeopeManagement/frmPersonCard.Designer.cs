namespace DVLD
{
    partial class frmPersonCard
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
            this.labelPersonCard = new System.Windows.Forms.Label();
            this.ctrlPersonInfo1 = new DVLD.ctrlPersonInfo();
            this.SuspendLayout();
            // 
            // labelPersonCard
            // 
            this.labelPersonCard.AutoSize = true;
            this.labelPersonCard.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPersonCard.ForeColor = System.Drawing.Color.Red;
            this.labelPersonCard.Location = new System.Drawing.Point(215, 19);
            this.labelPersonCard.Name = "labelPersonCard";
            this.labelPersonCard.Size = new System.Drawing.Size(178, 32);
            this.labelPersonCard.TabIndex = 1;
            this.labelPersonCard.Text = "Person Card";
            // 
            // ctrlPersonInfo1
            // 
            this.ctrlPersonInfo1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ctrlPersonInfo1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlPersonInfo1.Location = new System.Drawing.Point(13, 65);
            this.ctrlPersonInfo1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ctrlPersonInfo1.Name = "ctrlPersonInfo1";
            this.ctrlPersonInfo1.Size = new System.Drawing.Size(580, 266);
            this.ctrlPersonInfo1.TabIndex = 2;
            // 
            // frmPersonCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(608, 340);
            this.Controls.Add(this.ctrlPersonInfo1);
            this.Controls.Add(this.labelPersonCard);
            this.MaximumSize = new System.Drawing.Size(624, 379);
            this.MinimumSize = new System.Drawing.Size(624, 379);
            this.Name = "frmPersonCard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPersonCard";
            this.Load += new System.EventHandler(this.frmPersonCard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelPersonCard;
        private ctrlPersonInfo ctrlPersonInfo1;
    }
}