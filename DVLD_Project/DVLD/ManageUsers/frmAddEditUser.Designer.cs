namespace DVLD
{
    partial class frmAddEditUser
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
            this.tabCtrlAddEditUser = new System.Windows.Forms.TabControl();
            this.tabPerson = new System.Windows.Forms.TabPage();
            this.ctrlPersonInfoFilter1 = new DVLD.ctrlPersonInfoFilter();
            this.btnNext = new System.Windows.Forms.Button();
            this.tabUser = new System.Windows.Forms.TabPage();
            this.panelUserInformation = new System.Windows.Forms.Panel();
            this.lbUserID = new System.Windows.Forms.Label();
            this.labelUserID = new System.Windows.Forms.Label();
            this.chkIsActive = new System.Windows.Forms.CheckBox();
            this.labelConfirmPassword = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbConfirmPassword = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbAddEdit = new System.Windows.Forms.Label();
            this.tabCtrlAddEditUser.SuspendLayout();
            this.tabPerson.SuspendLayout();
            this.tabUser.SuspendLayout();
            this.panelUserInformation.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabCtrlAddEditUser
            // 
            this.tabCtrlAddEditUser.Controls.Add(this.tabPerson);
            this.tabCtrlAddEditUser.Controls.Add(this.tabUser);
            this.tabCtrlAddEditUser.Location = new System.Drawing.Point(12, 37);
            this.tabCtrlAddEditUser.Name = "tabCtrlAddEditUser";
            this.tabCtrlAddEditUser.SelectedIndex = 0;
            this.tabCtrlAddEditUser.Size = new System.Drawing.Size(609, 410);
            this.tabCtrlAddEditUser.TabIndex = 0;
            // 
            // tabPerson
            // 
            this.tabPerson.Controls.Add(this.ctrlPersonInfoFilter1);
            this.tabPerson.Controls.Add(this.btnNext);
            this.tabPerson.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabPerson.Location = new System.Drawing.Point(4, 22);
            this.tabPerson.Name = "tabPerson";
            this.tabPerson.Padding = new System.Windows.Forms.Padding(3);
            this.tabPerson.Size = new System.Drawing.Size(601, 384);
            this.tabPerson.TabIndex = 0;
            this.tabPerson.Text = "Person informations";
            this.tabPerson.UseVisualStyleBackColor = true;
            // 
            // ctrlPersonInfoFilter1
            // 
            this.ctrlPersonInfoFilter1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ctrlPersonInfoFilter1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ctrlPersonInfoFilter1.Location = new System.Drawing.Point(6, 6);
            this.ctrlPersonInfoFilter1.Name = "ctrlPersonInfoFilter1";
            this.ctrlPersonInfoFilter1.Size = new System.Drawing.Size(593, 329);
            this.ctrlPersonInfoFilter1.TabIndex = 1;
            this.ctrlPersonInfoFilter1.PersonSelected += new System.Action<int>(this.ctrlPersonInfoFilter1_PersonSelected);
            // 
            // btnNext
            // 
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.Enabled = false;
            this.btnNext.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.btnNext.FlatAppearance.BorderSize = 2;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(478, 341);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(111, 37);
            this.btnNext.TabIndex = 0;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // tabUser
            // 
            this.tabUser.Controls.Add(this.panelUserInformation);
            this.tabUser.Location = new System.Drawing.Point(4, 22);
            this.tabUser.Name = "tabUser";
            this.tabUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabUser.Size = new System.Drawing.Size(601, 384);
            this.tabUser.TabIndex = 1;
            this.tabUser.Text = "User infomrations";
            this.tabUser.UseVisualStyleBackColor = true;
            // 
            // panelUserInformation
            // 
            this.panelUserInformation.Controls.Add(this.lbUserID);
            this.panelUserInformation.Controls.Add(this.labelUserID);
            this.panelUserInformation.Controls.Add(this.chkIsActive);
            this.panelUserInformation.Controls.Add(this.labelConfirmPassword);
            this.panelUserInformation.Controls.Add(this.labelPassword);
            this.panelUserInformation.Controls.Add(this.labelUserName);
            this.panelUserInformation.Controls.Add(this.panel1);
            this.panelUserInformation.Controls.Add(this.tbUserName);
            this.panelUserInformation.Enabled = false;
            this.panelUserInformation.Location = new System.Drawing.Point(3, 15);
            this.panelUserInformation.Name = "panelUserInformation";
            this.panelUserInformation.Size = new System.Drawing.Size(308, 215);
            this.panelUserInformation.TabIndex = 10;
            // 
            // lbUserID
            // 
            this.lbUserID.AutoSize = true;
            this.lbUserID.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserID.Location = new System.Drawing.Point(132, 30);
            this.lbUserID.Name = "lbUserID";
            this.lbUserID.Size = new System.Drawing.Size(43, 16);
            this.lbUserID.TabIndex = 17;
            this.lbUserID.Text = "         ";
            // 
            // labelUserID
            // 
            this.labelUserID.AutoSize = true;
            this.labelUserID.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserID.Location = new System.Drawing.Point(73, 30);
            this.labelUserID.Name = "labelUserID";
            this.labelUserID.Size = new System.Drawing.Size(56, 16);
            this.labelUserID.TabIndex = 16;
            this.labelUserID.Text = "User ID:";
            // 
            // chkIsActive
            // 
            this.chkIsActive.AutoSize = true;
            this.chkIsActive.Checked = true;
            this.chkIsActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIsActive.Location = new System.Drawing.Point(135, 167);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(90, 17);
            this.chkIsActive.TabIndex = 15;
            this.chkIsActive.Text = "Is Active user";
            this.chkIsActive.UseVisualStyleBackColor = true;
            // 
            // labelConfirmPassword
            // 
            this.labelConfirmPassword.AutoSize = true;
            this.labelConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfirmPassword.Location = new System.Drawing.Point(35, 132);
            this.labelConfirmPassword.Name = "labelConfirmPassword";
            this.labelConfirmPassword.Size = new System.Drawing.Size(94, 13);
            this.labelConfirmPassword.TabIndex = 14;
            this.labelConfirmPassword.Text = "Confirm Password:";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(73, 106);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(56, 13);
            this.labelPassword.TabIndex = 13;
            this.labelPassword.Text = "Password:";
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.Location = new System.Drawing.Point(69, 74);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(60, 13);
            this.labelUserName.TabIndex = 12;
            this.labelUserName.Text = "UserName:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbConfirmPassword);
            this.panel1.Controls.Add(this.tbPassword);
            this.panel1.Location = new System.Drawing.Point(135, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(139, 49);
            this.panel1.TabIndex = 11;
            // 
            // tbConfirmPassword
            // 
            this.tbConfirmPassword.Location = new System.Drawing.Point(0, 26);
            this.tbConfirmPassword.MaxLength = 200;
            this.tbConfirmPassword.Name = "tbConfirmPassword";
            this.tbConfirmPassword.PasswordChar = '*';
            this.tbConfirmPassword.Size = new System.Drawing.Size(100, 20);
            this.tbConfirmPassword.TabIndex = 2;
            this.tbConfirmPassword.TextChanged += new System.EventHandler(this.tbConfirmPassword_TextChanged);
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(0, 0);
            this.tbPassword.MaxLength = 200;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(100, 20);
            this.tbPassword.TabIndex = 1;
            this.tbPassword.Validating += new System.ComponentModel.CancelEventHandler(this.tbPassword_Validating);
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(135, 71);
            this.tbUserName.MaxLength = 20;
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(100, 20);
            this.tbUserName.TabIndex = 10;
            this.tbUserName.Validating += new System.ComponentModel.CancelEventHandler(this.tbUserName_Validating);
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
            this.btnSave.Location = new System.Drawing.Point(510, 453);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(111, 37);
            this.btnSave.TabIndex = 2;
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
            this.btnClose.Location = new System.Drawing.Point(393, 453);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(111, 37);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lbAddEdit
            // 
            this.lbAddEdit.AutoSize = true;
            this.lbAddEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddEdit.Location = new System.Drawing.Point(12, 9);
            this.lbAddEdit.Name = "lbAddEdit";
            this.lbAddEdit.Size = new System.Drawing.Size(145, 24);
            this.lbAddEdit.TabIndex = 4;
            this.lbAddEdit.Text = "Add New User";
            // 
            // frmAddEditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(639, 502);
            this.Controls.Add(this.lbAddEdit);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tabCtrlAddEditUser);
            this.MaximumSize = new System.Drawing.Size(655, 541);
            this.MinimumSize = new System.Drawing.Size(655, 541);
            this.Name = "frmAddEditUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddEditUser";
            this.Load += new System.EventHandler(this.frmAddEditUser_Load);
            this.tabCtrlAddEditUser.ResumeLayout(false);
            this.tabPerson.ResumeLayout(false);
            this.tabUser.ResumeLayout(false);
            this.panelUserInformation.ResumeLayout(false);
            this.panelUserInformation.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabCtrlAddEditUser;
        private System.Windows.Forms.TabPage tabPerson;
        private System.Windows.Forms.TabPage tabUser;
        private ctrlPersonInfoFilter ctrlPersonInfoFilter1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lbAddEdit;
        private System.Windows.Forms.Panel panelUserInformation;
        private System.Windows.Forms.Label lbUserID;
        private System.Windows.Forms.Label labelUserID;
        private System.Windows.Forms.CheckBox chkIsActive;
        private System.Windows.Forms.Label labelConfirmPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbConfirmPassword;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbUserName;
    }
}