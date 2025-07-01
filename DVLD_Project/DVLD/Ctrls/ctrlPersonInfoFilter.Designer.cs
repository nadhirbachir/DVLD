namespace DVLD
{
    partial class ctrlPersonInfoFilter
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
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.txbFilter = new System.Windows.Forms.TextBox();
            this.cbOption = new System.Windows.Forms.ComboBox();
            this.ctrlPersonInfo1 = new DVLD.ctrlPersonInfo();
            this.gbFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.Location = new System.Drawing.Point(328, 18);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(75, 23);
            this.btnAddPerson.TabIndex = 6;
            this.btnAddPerson.Text = "Add Person";
            this.btnAddPerson.UseVisualStyleBackColor = true;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.btnFilter);
            this.gbFilter.Controls.Add(this.btnAddPerson);
            this.gbFilter.Controls.Add(this.txbFilter);
            this.gbFilter.Controls.Add(this.cbOption);
            this.gbFilter.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFilter.Location = new System.Drawing.Point(11, 7);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(572, 51);
            this.gbFilter.TabIndex = 7;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Person Filter";
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(244, 19);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(78, 23);
            this.btnFilter.TabIndex = 6;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // txbFilter
            // 
            this.txbFilter.Location = new System.Drawing.Point(138, 21);
            this.txbFilter.MaxLength = 20;
            this.txbFilter.Name = "txbFilter";
            this.txbFilter.Size = new System.Drawing.Size(100, 20);
            this.txbFilter.TabIndex = 5;
            this.txbFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbFilter_KeyPress);
            // 
            // cbOption
            // 
            this.cbOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOption.FormattingEnabled = true;
            this.cbOption.Items.AddRange(new object[] {
            "National No",
            "Person ID"});
            this.cbOption.Location = new System.Drawing.Point(11, 20);
            this.cbOption.Name = "cbOption";
            this.cbOption.Size = new System.Drawing.Size(121, 22);
            this.cbOption.TabIndex = 4;
            this.cbOption.SelectedIndexChanged += new System.EventHandler(this.cbOption_SelectedIndexChanged);
            // 
            // ctrlPersonInfo1
            // 
            this.ctrlPersonInfo1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ctrlPersonInfo1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlPersonInfo1.Location = new System.Drawing.Point(9, 64);
            this.ctrlPersonInfo1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ctrlPersonInfo1.Name = "ctrlPersonInfo1";
            this.ctrlPersonInfo1.Size = new System.Drawing.Size(580, 266);
            this.ctrlPersonInfo1.TabIndex = 5;
            this.ctrlPersonInfo1.WhenPersonFound += new System.Action<DVLD_Business.clsPerson>(this.ctrlPersonInfo1_WhenPersonFound);
            // 
            // ctrlPersonInfoFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.gbFilter);
            this.Controls.Add(this.ctrlPersonInfo1);
            this.Name = "ctrlPersonInfoFilter";
            this.Size = new System.Drawing.Size(593, 329);
            this.Load += new System.EventHandler(this.ctrlPersonInfoFilter_Load);
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private ctrlPersonInfo ctrlPersonInfo1;
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.ComboBox cbOption;
        private System.Windows.Forms.TextBox txbFilter;
    }
}
