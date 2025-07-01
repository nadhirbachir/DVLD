namespace DVLD
{
    partial class frmEditApplicationType
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
            this.tbAppTypeTitle = new System.Windows.Forms.TextBox();
            this.tbAppTypeFees = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            this.labelUpdatingApplicationType = new System.Windows.Forms.Label();
            this.labelAppTypeName = new System.Windows.Forms.Label();
            this.labelAppTypeFees = new System.Windows.Forms.Label();
            this.lbApplicationTypeID = new System.Windows.Forms.Label();
            this.labelAppID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbAppTypeTitle
            // 
            this.tbAppTypeTitle.Location = new System.Drawing.Point(138, 125);
            this.tbAppTypeTitle.Name = "tbAppTypeTitle";
            this.tbAppTypeTitle.Size = new System.Drawing.Size(226, 20);
            this.tbAppTypeTitle.TabIndex = 0;
            this.tbAppTypeTitle.Validating += new System.ComponentModel.CancelEventHandler(this.tbAppTypeTitle_Validating);
            // 
            // tbAppTypeFees
            // 
            this.tbAppTypeFees.Location = new System.Drawing.Point(138, 159);
            this.tbAppTypeFees.Name = "tbAppTypeFees";
            this.tbAppTypeFees.Size = new System.Drawing.Size(124, 20);
            this.tbAppTypeFees.TabIndex = 1;
            this.tbAppTypeFees.TextChanged += new System.EventHandler(this.tbAppTypeFees_TextChanged);
            this.tbAppTypeFees.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAppTypeFees_KeyPress);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Green;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(268, 156);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // labelUpdatingApplicationType
            // 
            this.labelUpdatingApplicationType.AutoSize = true;
            this.labelUpdatingApplicationType.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUpdatingApplicationType.Location = new System.Drawing.Point(12, 9);
            this.labelUpdatingApplicationType.Name = "labelUpdatingApplicationType";
            this.labelUpdatingApplicationType.Size = new System.Drawing.Size(352, 32);
            this.labelUpdatingApplicationType.TabIndex = 3;
            this.labelUpdatingApplicationType.Text = "Updating application type";
            // 
            // labelAppTypeName
            // 
            this.labelAppTypeName.AutoSize = true;
            this.labelAppTypeName.Location = new System.Drawing.Point(22, 130);
            this.labelAppTypeName.Name = "labelAppTypeName";
            this.labelAppTypeName.Size = new System.Drawing.Size(114, 13);
            this.labelAppTypeName.TabIndex = 4;
            this.labelAppTypeName.Text = "Application type name:";
            // 
            // labelAppTypeFees
            // 
            this.labelAppTypeFees.AutoSize = true;
            this.labelAppTypeFees.Location = new System.Drawing.Point(25, 162);
            this.labelAppTypeFees.Name = "labelAppTypeFees";
            this.labelAppTypeFees.Size = new System.Drawing.Size(107, 13);
            this.labelAppTypeFees.TabIndex = 5;
            this.labelAppTypeFees.Text = "application type fees:";
            // 
            // lbApplicationTypeID
            // 
            this.lbApplicationTypeID.AutoSize = true;
            this.lbApplicationTypeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApplicationTypeID.Location = new System.Drawing.Point(135, 95);
            this.lbApplicationTypeID.Name = "lbApplicationTypeID";
            this.lbApplicationTypeID.Size = new System.Drawing.Size(55, 16);
            this.lbApplicationTypeID.TabIndex = 6;
            this.lbApplicationTypeID.Text = "            ";
            // 
            // labelAppID
            // 
            this.labelAppID.AutoSize = true;
            this.labelAppID.Location = new System.Drawing.Point(30, 98);
            this.labelAppID.Name = "labelAppID";
            this.labelAppID.Size = new System.Drawing.Size(99, 13);
            this.labelAppID.TabIndex = 7;
            this.labelAppID.Text = "Application type ID:";
            // 
            // frmEditApplicationType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(385, 205);
            this.Controls.Add(this.labelAppID);
            this.Controls.Add(this.lbApplicationTypeID);
            this.Controls.Add(this.labelAppTypeFees);
            this.Controls.Add(this.labelAppTypeName);
            this.Controls.Add(this.labelUpdatingApplicationType);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbAppTypeFees);
            this.Controls.Add(this.tbAppTypeTitle);
            this.Name = "frmEditApplicationType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEditApplicationType";
            this.Load += new System.EventHandler(this.frmEditApplicationType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbAppTypeTitle;
        private System.Windows.Forms.TextBox tbAppTypeFees;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label labelAppID;
        private System.Windows.Forms.Label lbApplicationTypeID;
        private System.Windows.Forms.Label labelAppTypeFees;
        private System.Windows.Forms.Label labelAppTypeName;
        private System.Windows.Forms.Label labelUpdatingApplicationType;
    }
}