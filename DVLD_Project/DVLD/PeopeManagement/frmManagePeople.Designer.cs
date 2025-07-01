namespace DVLD
{
    partial class frmManagePeople
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
            this.dgvPeople = new System.Windows.Forms.DataGridView();
            this.cmsManagePeople = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showPersonCardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.addPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.sendEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendSMSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.tbFilterPersonID = new System.Windows.Forms.TextBox();
            this.tbFilterPhone = new System.Windows.Forms.TextBox();
            this.tbFilterString = new System.Windows.Forms.TextBox();
            this.cbFilterGender = new System.Windows.Forms.ComboBox();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.labelManagePeople = new System.Windows.Forms.Label();
            this.lbTotalRecords = new System.Windows.Forms.Label();
            this.labelTotalRecords = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeople)).BeginInit();
            this.cmsManagePeople.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPeople
            // 
            this.dgvPeople.AllowUserToAddRows = false;
            this.dgvPeople.AllowUserToDeleteRows = false;
            this.dgvPeople.AllowUserToOrderColumns = true;
            this.dgvPeople.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPeople.BackgroundColor = System.Drawing.Color.White;
            this.dgvPeople.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeople.ContextMenuStrip = this.cmsManagePeople;
            this.dgvPeople.Location = new System.Drawing.Point(12, 142);
            this.dgvPeople.MultiSelect = false;
            this.dgvPeople.Name = "dgvPeople";
            this.dgvPeople.ReadOnly = true;
            this.dgvPeople.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPeople.Size = new System.Drawing.Size(1007, 350);
            this.dgvPeople.TabIndex = 0;
            // 
            // cmsManagePeople
            // 
            this.cmsManagePeople.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showPersonCardToolStripMenuItem,
            this.toolStripMenuItem2,
            this.addPersonToolStripMenuItem,
            this.editPersonToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripMenuItem1,
            this.sendEmailToolStripMenuItem,
            this.sendSMSToolStripMenuItem});
            this.cmsManagePeople.Name = "cmsManagePeople";
            this.cmsManagePeople.Size = new System.Drawing.Size(171, 148);
            // 
            // showPersonCardToolStripMenuItem
            // 
            this.showPersonCardToolStripMenuItem.Name = "showPersonCardToolStripMenuItem";
            this.showPersonCardToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.showPersonCardToolStripMenuItem.Text = "Show Person Card";
            this.showPersonCardToolStripMenuItem.Click += new System.EventHandler(this.showPersonCardToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(167, 6);
            // 
            // addPersonToolStripMenuItem
            // 
            this.addPersonToolStripMenuItem.Name = "addPersonToolStripMenuItem";
            this.addPersonToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.addPersonToolStripMenuItem.Text = "Add";
            this.addPersonToolStripMenuItem.Click += new System.EventHandler(this.addPersonToolStripMenuItem_Click);
            // 
            // editPersonToolStripMenuItem
            // 
            this.editPersonToolStripMenuItem.Name = "editPersonToolStripMenuItem";
            this.editPersonToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.editPersonToolStripMenuItem.Text = "Edit";
            this.editPersonToolStripMenuItem.Click += new System.EventHandler(this.editPersonToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(167, 6);
            // 
            // sendEmailToolStripMenuItem
            // 
            this.sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
            this.sendEmailToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.sendEmailToolStripMenuItem.Text = "Send Email";
            this.sendEmailToolStripMenuItem.Click += new System.EventHandler(this.sendEmailToolStripMenuItem_Click);
            // 
            // sendSMSToolStripMenuItem
            // 
            this.sendSMSToolStripMenuItem.Name = "sendSMSToolStripMenuItem";
            this.sendSMSToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.sendSMSToolStripMenuItem.Text = "Send SMS";
            this.sendSMSToolStripMenuItem.Click += new System.EventHandler(this.sendSMSToolStripMenuItem_Click);
            // 
            // cbFilter
            // 
            this.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Items.AddRange(new object[] {
            "None",
            "PersonID",
            "NationalNo",
            "First Name",
            "Second Name",
            "Third Name",
            "Last Name",
            "Gender",
            "Country",
            "Phone",
            "Email"});
            this.cbFilter.Location = new System.Drawing.Point(12, 115);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(121, 21);
            this.cbFilter.TabIndex = 2;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // tbFilterPersonID
            // 
            this.tbFilterPersonID.Location = new System.Drawing.Point(139, 116);
            this.tbFilterPersonID.Name = "tbFilterPersonID";
            this.tbFilterPersonID.Size = new System.Drawing.Size(143, 20);
            this.tbFilterPersonID.TabIndex = 3;
            this.tbFilterPersonID.TextChanged += new System.EventHandler(this.tbFilterPersonID_TextChanged);
            this.tbFilterPersonID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFilterPersonID_KeyPress);
            // 
            // tbFilterPhone
            // 
            this.tbFilterPhone.Location = new System.Drawing.Point(139, 115);
            this.tbFilterPhone.Name = "tbFilterPhone";
            this.tbFilterPhone.Size = new System.Drawing.Size(143, 20);
            this.tbFilterPhone.TabIndex = 4;
            this.tbFilterPhone.TextChanged += new System.EventHandler(this.tbFilterPhone_TextChanged);
            this.tbFilterPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFilterPhone_KeyPress);
            // 
            // tbFilterString
            // 
            this.tbFilterString.Location = new System.Drawing.Point(139, 116);
            this.tbFilterString.Name = "tbFilterString";
            this.tbFilterString.Size = new System.Drawing.Size(143, 20);
            this.tbFilterString.TabIndex = 5;
            this.tbFilterString.TextChanged += new System.EventHandler(this.tbFilterString_TextChanged);
            // 
            // cbFilterGender
            // 
            this.cbFilterGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterGender.FormattingEnabled = true;
            this.cbFilterGender.Items.AddRange(new object[] {
            "NoFilter",
            "Male",
            "Female"});
            this.cbFilterGender.Location = new System.Drawing.Point(139, 115);
            this.cbFilterGender.Name = "cbFilterGender";
            this.cbFilterGender.Size = new System.Drawing.Size(82, 21);
            this.cbFilterGender.TabIndex = 6;
            this.cbFilterGender.SelectedIndexChanged += new System.EventHandler(this.cbFilterGender_SelectedIndexChanged);
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.Location = new System.Drawing.Point(927, 93);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(92, 42);
            this.btnAddPerson.TabIndex = 7;
            this.btnAddPerson.Text = "AddPerson";
            this.btnAddPerson.UseVisualStyleBackColor = true;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // labelManagePeople
            // 
            this.labelManagePeople.AutoSize = true;
            this.labelManagePeople.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelManagePeople.Location = new System.Drawing.Point(437, 31);
            this.labelManagePeople.Name = "labelManagePeople";
            this.labelManagePeople.Size = new System.Drawing.Size(212, 32);
            this.labelManagePeople.TabIndex = 8;
            this.labelManagePeople.Text = "Manage People";
            // 
            // lbTotalRecords
            // 
            this.lbTotalRecords.AutoSize = true;
            this.lbTotalRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalRecords.Location = new System.Drawing.Point(95, 505);
            this.lbTotalRecords.Name = "lbTotalRecords";
            this.lbTotalRecords.Size = new System.Drawing.Size(68, 18);
            this.lbTotalRecords.TabIndex = 9;
            this.lbTotalRecords.Text = "            ";
            // 
            // labelTotalRecords
            // 
            this.labelTotalRecords.AutoSize = true;
            this.labelTotalRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalRecords.Location = new System.Drawing.Point(12, 505);
            this.labelTotalRecords.Name = "labelTotalRecords";
            this.labelTotalRecords.Size = new System.Drawing.Size(77, 18);
            this.labelTotalRecords.TabIndex = 10;
            this.labelTotalRecords.Text = "Records:";
            // 
            // frmManagePeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 541);
            this.Controls.Add(this.labelTotalRecords);
            this.Controls.Add(this.lbTotalRecords);
            this.Controls.Add(this.labelManagePeople);
            this.Controls.Add(this.btnAddPerson);
            this.Controls.Add(this.cbFilterGender);
            this.Controls.Add(this.tbFilterString);
            this.Controls.Add(this.tbFilterPhone);
            this.Controls.Add(this.tbFilterPersonID);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.dgvPeople);
            this.MaximumSize = new System.Drawing.Size(1049, 580);
            this.MinimumSize = new System.Drawing.Size(1049, 580);
            this.Name = "frmManagePeople";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmManagePeople";
            this.Load += new System.EventHandler(this.frmManagePeople_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeople)).EndInit();
            this.cmsManagePeople.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPeople;
        private System.Windows.Forms.ContextMenuStrip cmsManagePeople;
        private System.Windows.Forms.ToolStripMenuItem showPersonCardToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem addPersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editPersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sendEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendSMSToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.TextBox tbFilterPersonID;
        private System.Windows.Forms.TextBox tbFilterPhone;
        private System.Windows.Forms.TextBox tbFilterString;
        private System.Windows.Forms.ComboBox cbFilterGender;
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.Label labelManagePeople;
        private System.Windows.Forms.Label lbTotalRecords;
        private System.Windows.Forms.Label labelTotalRecords;
    }
}