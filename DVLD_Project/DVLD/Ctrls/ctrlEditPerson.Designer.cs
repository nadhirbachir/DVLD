namespace DVLD
{
    partial class ctrlEditPerson
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
            this.components = new System.ComponentModel.Container();
            this.labelPerson = new System.Windows.Forms.Label();
            this.tbNationalNo = new System.Windows.Forms.TextBox();
            this.labelNationalNo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSecondName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbThirdName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.gbGender = new System.Windows.Forms.GroupBox();
            this.rdFemale = new System.Windows.Forms.RadioButton();
            this.rdMale = new System.Windows.Forms.RadioButton();
            this.labelDateOfBirth = new System.Windows.Forms.Label();
            this.cbCountries = new System.Windows.Forms.ComboBox();
            this.pbProfilePicture = new System.Windows.Forms.PictureBox();
            this.btnPicture = new System.Windows.Forms.Button();
            this.btnRemovePicture = new System.Windows.Forms.Button();
            this.SelectProfilePictureDialog = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            this.labelPersonID = new System.Windows.Forms.Label();
            this.lbPersonID = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.gbGender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPerson
            // 
            this.labelPerson.AutoSize = true;
            this.labelPerson.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPerson.ForeColor = System.Drawing.Color.Red;
            this.labelPerson.Location = new System.Drawing.Point(257, 23);
            this.labelPerson.Name = "labelPerson";
            this.labelPerson.Size = new System.Drawing.Size(232, 32);
            this.labelPerson.TabIndex = 0;
            this.labelPerson.Text = "Add New Person";
            // 
            // tbNationalNo
            // 
            this.tbNationalNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbNationalNo.Location = new System.Drawing.Point(39, 73);
            this.tbNationalNo.MaxLength = 20;
            this.tbNationalNo.Name = "tbNationalNo";
            this.tbNationalNo.Size = new System.Drawing.Size(100, 20);
            this.tbNationalNo.TabIndex = 0;
            this.tbNationalNo.Validating += new System.ComponentModel.CancelEventHandler(this.tbNationalNo_Validating);
            // 
            // labelNationalNo
            // 
            this.labelNationalNo.AutoSize = true;
            this.labelNationalNo.Location = new System.Drawing.Point(38, 57);
            this.labelNationalNo.Name = "labelNationalNo";
            this.labelNationalNo.Size = new System.Drawing.Size(60, 13);
            this.labelNationalNo.TabIndex = 2;
            this.labelNationalNo.Text = "NationalNo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "First Name";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(39, 112);
            this.tbFirstName.MaxLength = 20;
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(146, 20);
            this.tbFirstName.TabIndex = 1;
            this.tbFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.EmptyField_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Second Name (optional)";
            // 
            // tbSecondName
            // 
            this.tbSecondName.Location = new System.Drawing.Point(230, 112);
            this.tbSecondName.MaxLength = 20;
            this.tbSecondName.Name = "tbSecondName";
            this.tbSecondName.Size = new System.Drawing.Size(146, 20);
            this.tbSecondName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(416, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Third Name (optional)";
            // 
            // tbThirdName
            // 
            this.tbThirdName.Location = new System.Drawing.Point(419, 112);
            this.tbThirdName.MaxLength = 20;
            this.tbThirdName.Name = "tbThirdName";
            this.tbThirdName.Size = new System.Drawing.Size(146, 20);
            this.tbThirdName.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(605, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Last Name";
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(608, 112);
            this.tbLastName.MaxLength = 20;
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(146, 20);
            this.tbLastName.TabIndex = 4;
            this.tbLastName.Validating += new System.ComponentModel.CancelEventHandler(this.EmptyField_Validating);
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(38, 224);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(38, 13);
            this.labelPhone.TabIndex = 12;
            this.labelPhone.Text = "Phone";
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(40, 240);
            this.tbPhone.MaxLength = 20;
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(146, 20);
            this.tbPhone.TabIndex = 9;
            this.tbPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPhone_KeyPress);
            this.tbPhone.Validating += new System.ComponentModel.CancelEventHandler(this.EmptyField_Validating);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(228, 224);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(78, 13);
            this.labelEmail.TabIndex = 14;
            this.labelEmail.Text = "Email (optional)";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(230, 240);
            this.tbEmail.MaxLength = 20;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(146, 20);
            this.tbEmail.TabIndex = 10;
            this.tbEmail.Validating += new System.ComponentModel.CancelEventHandler(this.tbEmail_Validating);
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(38, 271);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(45, 13);
            this.labelAddress.TabIndex = 16;
            this.labelAddress.Text = "Address";
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(40, 287);
            this.tbAddress.MaxLength = 20;
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(145, 20);
            this.tbAddress.TabIndex = 8;
            this.tbAddress.Validating += new System.ComponentModel.CancelEventHandler(this.EmptyField_Validating);
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Location = new System.Drawing.Point(230, 182);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(199, 20);
            this.dtpBirthDate.TabIndex = 7;
            this.dtpBirthDate.Value = new System.DateTime(2024, 8, 1, 0, 0, 0, 0);
            // 
            // gbGender
            // 
            this.gbGender.Controls.Add(this.rdFemale);
            this.gbGender.Controls.Add(this.rdMale);
            this.gbGender.Location = new System.Drawing.Point(40, 167);
            this.gbGender.Name = "gbGender";
            this.gbGender.Size = new System.Drawing.Size(126, 46);
            this.gbGender.TabIndex = 20;
            this.gbGender.TabStop = false;
            this.gbGender.Text = "Gender";
            // 
            // rdFemale
            // 
            this.rdFemale.AutoSize = true;
            this.rdFemale.Location = new System.Drawing.Point(61, 19);
            this.rdFemale.Name = "rdFemale";
            this.rdFemale.Size = new System.Drawing.Size(59, 17);
            this.rdFemale.TabIndex = 6;
            this.rdFemale.TabStop = true;
            this.rdFemale.Text = "Female";
            this.rdFemale.UseVisualStyleBackColor = true;
            this.rdFemale.CheckedChanged += new System.EventHandler(this.rdGender_CheckedChanged);
            // 
            // rdMale
            // 
            this.rdMale.AutoSize = true;
            this.rdMale.Checked = true;
            this.rdMale.Location = new System.Drawing.Point(8, 19);
            this.rdMale.Name = "rdMale";
            this.rdMale.Size = new System.Drawing.Size(48, 17);
            this.rdMale.TabIndex = 5;
            this.rdMale.TabStop = true;
            this.rdMale.Text = "Male";
            this.rdMale.UseVisualStyleBackColor = true;
            // 
            // labelDateOfBirth
            // 
            this.labelDateOfBirth.AutoSize = true;
            this.labelDateOfBirth.Location = new System.Drawing.Point(228, 166);
            this.labelDateOfBirth.Name = "labelDateOfBirth";
            this.labelDateOfBirth.Size = new System.Drawing.Size(68, 13);
            this.labelDateOfBirth.TabIndex = 21;
            this.labelDateOfBirth.Text = "Date Of Birth";
            // 
            // cbCountries
            // 
            this.cbCountries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCountries.FormattingEnabled = true;
            this.cbCountries.Location = new System.Drawing.Point(40, 334);
            this.cbCountries.Name = "cbCountries";
            this.cbCountries.Size = new System.Drawing.Size(121, 21);
            this.cbCountries.TabIndex = 11;
            // 
            // pbProfilePicture
            // 
            this.pbProfilePicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pbProfilePicture.Location = new System.Drawing.Point(568, 173);
            this.pbProfilePicture.Name = "pbProfilePicture";
            this.pbProfilePicture.Size = new System.Drawing.Size(186, 186);
            this.pbProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbProfilePicture.TabIndex = 23;
            this.pbProfilePicture.TabStop = false;
            // 
            // btnPicture
            // 
            this.btnPicture.Location = new System.Drawing.Point(569, 144);
            this.btnPicture.Name = "btnPicture";
            this.btnPicture.Size = new System.Drawing.Size(90, 25);
            this.btnPicture.TabIndex = 12;
            this.btnPicture.Text = "Select Picture";
            this.btnPicture.UseVisualStyleBackColor = true;
            this.btnPicture.Click += new System.EventHandler(this.btnPicture_Click);
            // 
            // btnRemovePicture
            // 
            this.btnRemovePicture.Location = new System.Drawing.Point(664, 144);
            this.btnRemovePicture.Name = "btnRemovePicture";
            this.btnRemovePicture.Size = new System.Drawing.Size(90, 25);
            this.btnRemovePicture.TabIndex = 13;
            this.btnRemovePicture.Text = "Remove picture";
            this.btnRemovePicture.UseVisualStyleBackColor = true;
            this.btnRemovePicture.Click += new System.EventHandler(this.btnRemovePicture_Click);
            // 
            // SelectProfilePictureDialog
            // 
            this.SelectProfilePictureDialog.FileName = "Profile_Picture";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Green;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(460, 322);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(102, 37);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // labelPersonID
            // 
            this.labelPersonID.AutoSize = true;
            this.labelPersonID.BackColor = System.Drawing.Color.White;
            this.labelPersonID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPersonID.Location = new System.Drawing.Point(574, 340);
            this.labelPersonID.Margin = new System.Windows.Forms.Padding(0);
            this.labelPersonID.Name = "labelPersonID";
            this.labelPersonID.Size = new System.Drawing.Size(86, 19);
            this.labelPersonID.TabIndex = 28;
            this.labelPersonID.Text = "PersonID:";
            // 
            // lbPersonID
            // 
            this.lbPersonID.AutoSize = true;
            this.lbPersonID.BackColor = System.Drawing.Color.White;
            this.lbPersonID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPersonID.Location = new System.Drawing.Point(660, 340);
            this.lbPersonID.Margin = new System.Windows.Forms.Padding(0);
            this.lbPersonID.Name = "lbPersonID";
            this.lbPersonID.Size = new System.Drawing.Size(57, 19);
            this.lbPersonID.TabIndex = 29;
            this.lbPersonID.Text = "[ ??? ]";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Teal;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(352, 322);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(102, 37);
            this.btnClose.TabIndex = 30;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ctrlEditPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lbPersonID);
            this.Controls.Add(this.labelPersonID);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnRemovePicture);
            this.Controls.Add(this.btnPicture);
            this.Controls.Add(this.pbProfilePicture);
            this.Controls.Add(this.cbCountries);
            this.Controls.Add(this.labelDateOfBirth);
            this.Controls.Add(this.gbGender);
            this.Controls.Add(this.dtpBirthDate);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbThirdName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbSecondName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.labelNationalNo);
            this.Controls.Add(this.tbNationalNo);
            this.Controls.Add(this.labelPerson);
            this.Name = "ctrlEditPerson";
            this.Size = new System.Drawing.Size(790, 390);
            this.Load += new System.EventHandler(this.ctrlEditPerson_Load);
            this.gbGender.ResumeLayout(false);
            this.gbGender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPerson;
        private System.Windows.Forms.TextBox tbNationalNo;
        private System.Windows.Forms.Label labelNationalNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSecondName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbThirdName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.GroupBox gbGender;
        private System.Windows.Forms.RadioButton rdFemale;
        private System.Windows.Forms.RadioButton rdMale;
        private System.Windows.Forms.Label labelDateOfBirth;
        private System.Windows.Forms.ComboBox cbCountries;
        private System.Windows.Forms.PictureBox pbProfilePicture;
        private System.Windows.Forms.Button btnPicture;
        private System.Windows.Forms.Button btnRemovePicture;
        private System.Windows.Forms.OpenFileDialog SelectProfilePictureDialog;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lbPersonID;
        private System.Windows.Forms.Label labelPersonID;
        private System.Windows.Forms.Button btnClose;
    }
}
