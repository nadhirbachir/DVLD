namespace DVLD
{
    partial class frmAddEdit_LDL_Applications
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
            this.tcLDLApplication = new System.Windows.Forms.TabControl();
            this.tabSelectPerson = new System.Windows.Forms.TabPage();
            this.btnNext = new System.Windows.Forms.Button();
            this.ctrlPersonInfoFilter1 = new DVLD.ctrlPersonInfoFilter();
            this.tabSelectLicenseClass = new System.Windows.Forms.TabPage();
            this.lbCreatedBy = new System.Windows.Forms.Label();
            this.lbApplicationFees = new System.Windows.Forms.Label();
            this.lbApplicationDate = new System.Windows.Forms.Label();
            this.lbDLApplicationID = new System.Windows.Forms.Label();
            this.cbLicenseClass = new System.Windows.Forms.ComboBox();
            this.labelCreatedBy = new System.Windows.Forms.Label();
            this.labelApplicationFees = new System.Windows.Forms.Label();
            this.labelLicenseClass = new System.Windows.Forms.Label();
            this.labelApplicationDate = new System.Windows.Forms.Label();
            this.labelApplicationID = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.labelAddEdit = new System.Windows.Forms.Label();
            this.tcLDLApplication.SuspendLayout();
            this.tabSelectPerson.SuspendLayout();
            this.tabSelectLicenseClass.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcLDLApplication
            // 
            this.tcLDLApplication.Controls.Add(this.tabSelectPerson);
            this.tcLDLApplication.Controls.Add(this.tabSelectLicenseClass);
            this.tcLDLApplication.Location = new System.Drawing.Point(12, 61);
            this.tcLDLApplication.Name = "tcLDLApplication";
            this.tcLDLApplication.SelectedIndex = 0;
            this.tcLDLApplication.Size = new System.Drawing.Size(598, 397);
            this.tcLDLApplication.TabIndex = 0;
            // 
            // tabSelectPerson
            // 
            this.tabSelectPerson.BackColor = System.Drawing.Color.White;
            this.tabSelectPerson.Controls.Add(this.btnNext);
            this.tabSelectPerson.Controls.Add(this.ctrlPersonInfoFilter1);
            this.tabSelectPerson.Location = new System.Drawing.Point(4, 22);
            this.tabSelectPerson.Name = "tabSelectPerson";
            this.tabSelectPerson.Padding = new System.Windows.Forms.Padding(3);
            this.tabSelectPerson.Size = new System.Drawing.Size(590, 371);
            this.tabSelectPerson.TabIndex = 0;
            this.tabSelectPerson.Text = "Person";
            // 
            // btnNext
            // 
            this.btnNext.Enabled = false;
            this.btnNext.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnNext.FlatAppearance.BorderSize = 2;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(485, 328);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(99, 37);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // ctrlPersonInfoFilter1
            // 
            this.ctrlPersonInfoFilter1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ctrlPersonInfoFilter1.Location = new System.Drawing.Point(0, 0);
            this.ctrlPersonInfoFilter1.Name = "ctrlPersonInfoFilter1";
            this.ctrlPersonInfoFilter1.Size = new System.Drawing.Size(593, 329);
            this.ctrlPersonInfoFilter1.TabIndex = 0;
            this.ctrlPersonInfoFilter1.PersonSelected += new System.Action<int>(this.ctrlPersonInfoFilter1_PersonSelected);
            // 
            // tabSelectLicenseClass
            // 
            this.tabSelectLicenseClass.Controls.Add(this.lbCreatedBy);
            this.tabSelectLicenseClass.Controls.Add(this.lbApplicationFees);
            this.tabSelectLicenseClass.Controls.Add(this.lbApplicationDate);
            this.tabSelectLicenseClass.Controls.Add(this.lbDLApplicationID);
            this.tabSelectLicenseClass.Controls.Add(this.cbLicenseClass);
            this.tabSelectLicenseClass.Controls.Add(this.labelCreatedBy);
            this.tabSelectLicenseClass.Controls.Add(this.labelApplicationFees);
            this.tabSelectLicenseClass.Controls.Add(this.labelLicenseClass);
            this.tabSelectLicenseClass.Controls.Add(this.labelApplicationDate);
            this.tabSelectLicenseClass.Controls.Add(this.labelApplicationID);
            this.tabSelectLicenseClass.Location = new System.Drawing.Point(4, 22);
            this.tabSelectLicenseClass.Name = "tabSelectLicenseClass";
            this.tabSelectLicenseClass.Padding = new System.Windows.Forms.Padding(3);
            this.tabSelectLicenseClass.Size = new System.Drawing.Size(590, 371);
            this.tabSelectLicenseClass.TabIndex = 1;
            this.tabSelectLicenseClass.Text = "Local driving license";
            this.tabSelectLicenseClass.UseVisualStyleBackColor = true;
            // 
            // lbCreatedBy
            // 
            this.lbCreatedBy.AutoSize = true;
            this.lbCreatedBy.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCreatedBy.Location = new System.Drawing.Point(140, 225);
            this.lbCreatedBy.Name = "lbCreatedBy";
            this.lbCreatedBy.Size = new System.Drawing.Size(39, 16);
            this.lbCreatedBy.TabIndex = 9;
            this.lbCreatedBy.Text = "[???]";
            // 
            // lbApplicationFees
            // 
            this.lbApplicationFees.AutoSize = true;
            this.lbApplicationFees.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApplicationFees.Location = new System.Drawing.Point(175, 187);
            this.lbApplicationFees.Name = "lbApplicationFees";
            this.lbApplicationFees.Size = new System.Drawing.Size(39, 16);
            this.lbApplicationFees.TabIndex = 8;
            this.lbApplicationFees.Text = "[???]";
            // 
            // lbApplicationDate
            // 
            this.lbApplicationDate.AutoSize = true;
            this.lbApplicationDate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApplicationDate.Location = new System.Drawing.Point(175, 111);
            this.lbApplicationDate.Name = "lbApplicationDate";
            this.lbApplicationDate.Size = new System.Drawing.Size(39, 16);
            this.lbApplicationDate.TabIndex = 7;
            this.lbApplicationDate.Text = "[???]";
            // 
            // lbDLApplicationID
            // 
            this.lbDLApplicationID.AutoSize = true;
            this.lbDLApplicationID.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDLApplicationID.Location = new System.Drawing.Point(184, 73);
            this.lbDLApplicationID.Name = "lbDLApplicationID";
            this.lbDLApplicationID.Size = new System.Drawing.Size(39, 16);
            this.lbDLApplicationID.TabIndex = 6;
            this.lbDLApplicationID.Text = "[???]";
            // 
            // cbLicenseClass
            // 
            this.cbLicenseClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLicenseClass.FormattingEnabled = true;
            this.cbLicenseClass.Location = new System.Drawing.Point(156, 144);
            this.cbLicenseClass.Name = "cbLicenseClass";
            this.cbLicenseClass.Size = new System.Drawing.Size(201, 21);
            this.cbLicenseClass.TabIndex = 5;
            // 
            // labelCreatedBy
            // 
            this.labelCreatedBy.AutoSize = true;
            this.labelCreatedBy.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreatedBy.Location = new System.Drawing.Point(53, 225);
            this.labelCreatedBy.Name = "labelCreatedBy";
            this.labelCreatedBy.Size = new System.Drawing.Size(81, 16);
            this.labelCreatedBy.TabIndex = 4;
            this.labelCreatedBy.Text = "Created By:";
            // 
            // labelApplicationFees
            // 
            this.labelApplicationFees.AutoSize = true;
            this.labelApplicationFees.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApplicationFees.Location = new System.Drawing.Point(53, 187);
            this.labelApplicationFees.Name = "labelApplicationFees";
            this.labelApplicationFees.Size = new System.Drawing.Size(117, 16);
            this.labelApplicationFees.TabIndex = 3;
            this.labelApplicationFees.Text = "Application Fees:";
            // 
            // labelLicenseClass
            // 
            this.labelLicenseClass.AutoSize = true;
            this.labelLicenseClass.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLicenseClass.Location = new System.Drawing.Point(53, 149);
            this.labelLicenseClass.Name = "labelLicenseClass";
            this.labelLicenseClass.Size = new System.Drawing.Size(97, 16);
            this.labelLicenseClass.TabIndex = 2;
            this.labelLicenseClass.Text = "License Class:";
            // 
            // labelApplicationDate
            // 
            this.labelApplicationDate.AutoSize = true;
            this.labelApplicationDate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApplicationDate.Location = new System.Drawing.Point(53, 111);
            this.labelApplicationDate.Name = "labelApplicationDate";
            this.labelApplicationDate.Size = new System.Drawing.Size(116, 16);
            this.labelApplicationDate.TabIndex = 1;
            this.labelApplicationDate.Text = "Application Date:";
            // 
            // labelApplicationID
            // 
            this.labelApplicationID.AutoSize = true;
            this.labelApplicationID.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApplicationID.Location = new System.Drawing.Point(53, 73);
            this.labelApplicationID.Name = "labelApplicationID";
            this.labelApplicationID.Size = new System.Drawing.Size(125, 16);
            this.labelApplicationID.TabIndex = 0;
            this.labelApplicationID.Text = "D.L Application ID:";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Green;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(506, 464);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 48);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.btnClose.Location = new System.Drawing.Point(400, 464);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 48);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // labelAddEdit
            // 
            this.labelAddEdit.AutoSize = true;
            this.labelAddEdit.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddEdit.Location = new System.Drawing.Point(23, 9);
            this.labelAddEdit.Name = "labelAddEdit";
            this.labelAddEdit.Size = new System.Drawing.Size(564, 32);
            this.labelAddEdit.TabIndex = 3;
            this.labelAddEdit.Text = "Add new Local driving license application";
            // 
            // frmAddEdit_LDL_Applications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(623, 524);
            this.Controls.Add(this.labelAddEdit);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tcLDLApplication);
            this.MaximumSize = new System.Drawing.Size(639, 563);
            this.MinimumSize = new System.Drawing.Size(639, 563);
            this.Name = "frmAddEdit_LDL_Applications";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddEdit_LDL_Aplications";
            this.Load += new System.EventHandler(this.frmAddEdit_LDL_Applications_Load);
            this.tcLDLApplication.ResumeLayout(false);
            this.tabSelectPerson.ResumeLayout(false);
            this.tabSelectLicenseClass.ResumeLayout(false);
            this.tabSelectLicenseClass.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tcLDLApplication;
        private System.Windows.Forms.TabPage tabSelectPerson;
        private System.Windows.Forms.TabPage tabSelectLicenseClass;
        private ctrlPersonInfoFilter ctrlPersonInfoFilter1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label labelApplicationFees;
        private System.Windows.Forms.Label labelLicenseClass;
        private System.Windows.Forms.Label labelApplicationDate;
        private System.Windows.Forms.Label labelApplicationID;
        private System.Windows.Forms.Label labelCreatedBy;
        private System.Windows.Forms.ComboBox cbLicenseClass;
        private System.Windows.Forms.Label lbCreatedBy;
        private System.Windows.Forms.Label lbApplicationFees;
        private System.Windows.Forms.Label lbApplicationDate;
        private System.Windows.Forms.Label lbDLApplicationID;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label labelAddEdit;
    }
}