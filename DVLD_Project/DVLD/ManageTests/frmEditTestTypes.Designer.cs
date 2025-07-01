namespace DVLD
{
    partial class frmEditTestTypes
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
            this.tbTestName = new System.Windows.Forms.TextBox();
            this.tbTestDescription = new System.Windows.Forms.TextBox();
            this.tbTestFees = new System.Windows.Forms.TextBox();
            this.labelTestName = new System.Windows.Forms.Label();
            this.labelTestDescription = new System.Windows.Forms.Label();
            this.labelTestFees = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancle = new System.Windows.Forms.Button();
            this.labelEditTestTypes = new System.Windows.Forms.Label();
            this.labelTestTypeID = new System.Windows.Forms.Label();
            this.lbTestTypeID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbTestName
            // 
            this.tbTestName.Location = new System.Drawing.Point(12, 112);
            this.tbTestName.Name = "tbTestName";
            this.tbTestName.Size = new System.Drawing.Size(180, 20);
            this.tbTestName.TabIndex = 0;
            this.tbTestName.Validating += new System.ComponentModel.CancelEventHandler(this.tbTestName_Validating);
            // 
            // tbTestDescription
            // 
            this.tbTestDescription.Location = new System.Drawing.Point(12, 156);
            this.tbTestDescription.Multiline = true;
            this.tbTestDescription.Name = "tbTestDescription";
            this.tbTestDescription.Size = new System.Drawing.Size(331, 138);
            this.tbTestDescription.TabIndex = 1;
            this.tbTestDescription.Validating += new System.ComponentModel.CancelEventHandler(this.tbTestDescription_Validating);
            // 
            // tbTestFees
            // 
            this.tbTestFees.Location = new System.Drawing.Point(220, 112);
            this.tbTestFees.Name = "tbTestFees";
            this.tbTestFees.Size = new System.Drawing.Size(123, 20);
            this.tbTestFees.TabIndex = 2;
            this.tbTestFees.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTestFees_KeyPress);
            this.tbTestFees.Validating += new System.ComponentModel.CancelEventHandler(this.tbTestFees_Validating);
            // 
            // labelTestName
            // 
            this.labelTestName.AutoSize = true;
            this.labelTestName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTestName.Location = new System.Drawing.Point(9, 93);
            this.labelTestName.Name = "labelTestName";
            this.labelTestName.Size = new System.Drawing.Size(71, 16);
            this.labelTestName.TabIndex = 3;
            this.labelTestName.Text = "Test name:";
            // 
            // labelTestDescription
            // 
            this.labelTestDescription.AutoSize = true;
            this.labelTestDescription.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTestDescription.Location = new System.Drawing.Point(9, 137);
            this.labelTestDescription.Name = "labelTestDescription";
            this.labelTestDescription.Size = new System.Drawing.Size(102, 16);
            this.labelTestDescription.TabIndex = 4;
            this.labelTestDescription.Text = "Test description:";
            // 
            // labelTestFees
            // 
            this.labelTestFees.AutoSize = true;
            this.labelTestFees.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTestFees.Location = new System.Drawing.Point(217, 93);
            this.labelTestFees.Name = "labelTestFees";
            this.labelTestFees.Size = new System.Drawing.Size(68, 16);
            this.labelTestFees.TabIndex = 5;
            this.labelTestFees.Text = "Test Fees:";
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
            this.btnSave.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(242, 300);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(101, 36);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancle
            // 
            this.btnCancle.BackColor = System.Drawing.Color.Teal;
            this.btnCancle.FlatAppearance.BorderSize = 0;
            this.btnCancle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCancle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancle.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancle.ForeColor = System.Drawing.Color.White;
            this.btnCancle.Location = new System.Drawing.Point(135, 300);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(101, 36);
            this.btnCancle.TabIndex = 7;
            this.btnCancle.Text = "Cancle";
            this.btnCancle.UseVisualStyleBackColor = false;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // labelEditTestTypes
            // 
            this.labelEditTestTypes.AutoSize = true;
            this.labelEditTestTypes.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEditTestTypes.Location = new System.Drawing.Point(70, 9);
            this.labelEditTestTypes.Name = "labelEditTestTypes";
            this.labelEditTestTypes.Size = new System.Drawing.Size(215, 32);
            this.labelEditTestTypes.TabIndex = 8;
            this.labelEditTestTypes.Text = "Edit Test Types";
            // 
            // labelTestTypeID
            // 
            this.labelTestTypeID.AutoSize = true;
            this.labelTestTypeID.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTestTypeID.Location = new System.Drawing.Point(9, 66);
            this.labelTestTypeID.Name = "labelTestTypeID";
            this.labelTestTypeID.Size = new System.Drawing.Size(87, 16);
            this.labelTestTypeID.TabIndex = 9;
            this.labelTestTypeID.Text = "Test Type ID:";
            // 
            // lbTestTypeID
            // 
            this.lbTestTypeID.AutoSize = true;
            this.lbTestTypeID.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTestTypeID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbTestTypeID.Location = new System.Drawing.Point(102, 66);
            this.lbTestTypeID.Name = "lbTestTypeID";
            this.lbTestTypeID.Size = new System.Drawing.Size(55, 16);
            this.lbTestTypeID.TabIndex = 10;
            this.lbTestTypeID.Text = "            ";
            // 
            // frmEditTestTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(357, 346);
            this.Controls.Add(this.lbTestTypeID);
            this.Controls.Add(this.labelTestTypeID);
            this.Controls.Add(this.labelEditTestTypes);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.labelTestFees);
            this.Controls.Add(this.labelTestDescription);
            this.Controls.Add(this.labelTestName);
            this.Controls.Add(this.tbTestFees);
            this.Controls.Add(this.tbTestDescription);
            this.Controls.Add(this.tbTestName);
            this.Name = "frmEditTestTypes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEditTestTypes";
            this.Load += new System.EventHandler(this.frmEditTestTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTestName;
        private System.Windows.Forms.TextBox tbTestDescription;
        private System.Windows.Forms.TextBox tbTestFees;
        private System.Windows.Forms.Label labelTestName;
        private System.Windows.Forms.Label labelTestDescription;
        private System.Windows.Forms.Label labelTestFees;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lbTestTypeID;
        private System.Windows.Forms.Label labelTestTypeID;
        private System.Windows.Forms.Label labelEditTestTypes;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Button btnSave;
    }
}