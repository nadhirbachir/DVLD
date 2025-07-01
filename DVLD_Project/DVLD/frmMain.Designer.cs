namespace DVLD
{
    partial class frmMain
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
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.applicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.driverLicenseServicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newDrivingLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localDrivingLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.internationalDrivingLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renewDrivingLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.replacementForLostOrDamagedDrivingLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.releaseDetainedDrivingLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.managToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newLocalDLApplicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageInternationalDLApplicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.detainedDriverLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageDetainedLicensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detainALicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.releaseLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.manageApplicationTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageTestTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.driversToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peopleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLoginUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMain
            // 
            this.msMain.BackColor = System.Drawing.Color.Gray;
            this.msMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.msMain.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applicationsToolStripMenuItem,
            this.driversToolStripMenuItem,
            this.peopleToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.accountSettingsToolStripMenuItem});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Margin = new System.Windows.Forms.Padding(10, 4, 0, 4);
            this.msMain.Name = "msMain";
            this.msMain.Padding = new System.Windows.Forms.Padding(20, 8, 0, 8);
            this.msMain.Size = new System.Drawing.Size(222, 450);
            this.msMain.TabIndex = 1;
            this.msMain.Text = "menuStrip1";
            this.msMain.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.msMain_ItemClicked);
            // 
            // applicationsToolStripMenuItem
            // 
            this.applicationsToolStripMenuItem.BackColor = System.Drawing.Color.LightGray;
            this.applicationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.driverLicenseServicesToolStripMenuItem,
            this.toolStripMenuItem1,
            this.managToolStripMenuItem,
            this.toolStripMenuItem2,
            this.detainedDriverLicenseToolStripMenuItem,
            this.toolStripMenuItem3,
            this.manageApplicationTypesToolStripMenuItem,
            this.manageTestTypesToolStripMenuItem});
            this.applicationsToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10, 4, 0, 4);
            this.applicationsToolStripMenuItem.Name = "applicationsToolStripMenuItem";
            this.applicationsToolStripMenuItem.Padding = new System.Windows.Forms.Padding(10, 5, 3, 5);
            this.applicationsToolStripMenuItem.Size = new System.Drawing.Size(171, 36);
            this.applicationsToolStripMenuItem.Text = "Applications";
            // 
            // driverLicenseServicesToolStripMenuItem
            // 
            this.driverLicenseServicesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newDrivingLicenseToolStripMenuItem,
            this.renewDrivingLicenseToolStripMenuItem,
            this.toolStripMenuItem4,
            this.replacementForLostOrDamagedDrivingLicenseToolStripMenuItem,
            this.toolStripMenuItem5,
            this.releaseDetainedDrivingLicenseToolStripMenuItem});
            this.driverLicenseServicesToolStripMenuItem.Name = "driverLicenseServicesToolStripMenuItem";
            this.driverLicenseServicesToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0);
            this.driverLicenseServicesToolStripMenuItem.Size = new System.Drawing.Size(318, 24);
            this.driverLicenseServicesToolStripMenuItem.Text = "Driver License Services";
            // 
            // newDrivingLicenseToolStripMenuItem
            // 
            this.newDrivingLicenseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localDrivingLicenseToolStripMenuItem,
            this.internationalDrivingLicenseToolStripMenuItem});
            this.newDrivingLicenseToolStripMenuItem.Name = "newDrivingLicenseToolStripMenuItem";
            this.newDrivingLicenseToolStripMenuItem.Size = new System.Drawing.Size(473, 26);
            this.newDrivingLicenseToolStripMenuItem.Text = "New Driving License";
            // 
            // localDrivingLicenseToolStripMenuItem
            // 
            this.localDrivingLicenseToolStripMenuItem.Name = "localDrivingLicenseToolStripMenuItem";
            this.localDrivingLicenseToolStripMenuItem.Size = new System.Drawing.Size(346, 26);
            this.localDrivingLicenseToolStripMenuItem.Text = "Local Driving License";
            this.localDrivingLicenseToolStripMenuItem.Click += new System.EventHandler(this.localDrivingLicenseToolStripMenuItem_Click);
            // 
            // internationalDrivingLicenseToolStripMenuItem
            // 
            this.internationalDrivingLicenseToolStripMenuItem.Name = "internationalDrivingLicenseToolStripMenuItem";
            this.internationalDrivingLicenseToolStripMenuItem.Size = new System.Drawing.Size(346, 26);
            this.internationalDrivingLicenseToolStripMenuItem.Text = "International Driving License";
            this.internationalDrivingLicenseToolStripMenuItem.Click += new System.EventHandler(this.internationalDrivingLicenseToolStripMenuItem_Click);
            // 
            // renewDrivingLicenseToolStripMenuItem
            // 
            this.renewDrivingLicenseToolStripMenuItem.Name = "renewDrivingLicenseToolStripMenuItem";
            this.renewDrivingLicenseToolStripMenuItem.Size = new System.Drawing.Size(473, 26);
            this.renewDrivingLicenseToolStripMenuItem.Text = "Renew Driving License";
            this.renewDrivingLicenseToolStripMenuItem.Click += new System.EventHandler(this.renewDrivingLicenseToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(470, 6);
            // 
            // replacementForLostOrDamagedDrivingLicenseToolStripMenuItem
            // 
            this.replacementForLostOrDamagedDrivingLicenseToolStripMenuItem.Name = "replacementForLostOrDamagedDrivingLicenseToolStripMenuItem";
            this.replacementForLostOrDamagedDrivingLicenseToolStripMenuItem.Size = new System.Drawing.Size(473, 26);
            this.replacementForLostOrDamagedDrivingLicenseToolStripMenuItem.Text = "Replacement for Lost or Damaged License";
            this.replacementForLostOrDamagedDrivingLicenseToolStripMenuItem.Click += new System.EventHandler(this.replacementForLostOrDamagedDrivingLicenseToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(470, 6);
            // 
            // releaseDetainedDrivingLicenseToolStripMenuItem
            // 
            this.releaseDetainedDrivingLicenseToolStripMenuItem.Name = "releaseDetainedDrivingLicenseToolStripMenuItem";
            this.releaseDetainedDrivingLicenseToolStripMenuItem.Size = new System.Drawing.Size(473, 26);
            this.releaseDetainedDrivingLicenseToolStripMenuItem.Text = "Release Detained Driving License";
            this.releaseDetainedDrivingLicenseToolStripMenuItem.Click += new System.EventHandler(this.releaseDetainedDrivingLicenseToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(315, 6);
            // 
            // managToolStripMenuItem
            // 
            this.managToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newLocalDLApplicationsToolStripMenuItem,
            this.manageInternationalDLApplicationsToolStripMenuItem});
            this.managToolStripMenuItem.Name = "managToolStripMenuItem";
            this.managToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0);
            this.managToolStripMenuItem.Size = new System.Drawing.Size(318, 24);
            this.managToolStripMenuItem.Text = "Manage Applications";
            // 
            // newLocalDLApplicationsToolStripMenuItem
            // 
            this.newLocalDLApplicationsToolStripMenuItem.Name = "newLocalDLApplicationsToolStripMenuItem";
            this.newLocalDLApplicationsToolStripMenuItem.Size = new System.Drawing.Size(434, 26);
            this.newLocalDLApplicationsToolStripMenuItem.Text = "Manage Local D.L applications";
            this.newLocalDLApplicationsToolStripMenuItem.Click += new System.EventHandler(this.newLocalDLApplicationsToolStripMenuItem_Click);
            // 
            // manageInternationalDLApplicationsToolStripMenuItem
            // 
            this.manageInternationalDLApplicationsToolStripMenuItem.Name = "manageInternationalDLApplicationsToolStripMenuItem";
            this.manageInternationalDLApplicationsToolStripMenuItem.Size = new System.Drawing.Size(434, 26);
            this.manageInternationalDLApplicationsToolStripMenuItem.Text = "Manage International D.L  applications";
            this.manageInternationalDLApplicationsToolStripMenuItem.Click += new System.EventHandler(this.manageInternationalDLApplicationsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(315, 6);
            // 
            // detainedDriverLicenseToolStripMenuItem
            // 
            this.detainedDriverLicenseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageDetainedLicensesToolStripMenuItem,
            this.detainALicenseToolStripMenuItem,
            this.releaseLicenseToolStripMenuItem});
            this.detainedDriverLicenseToolStripMenuItem.Name = "detainedDriverLicenseToolStripMenuItem";
            this.detainedDriverLicenseToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0);
            this.detainedDriverLicenseToolStripMenuItem.Size = new System.Drawing.Size(318, 24);
            this.detainedDriverLicenseToolStripMenuItem.Text = "Detained License";
            // 
            // manageDetainedLicensesToolStripMenuItem
            // 
            this.manageDetainedLicensesToolStripMenuItem.Name = "manageDetainedLicensesToolStripMenuItem";
            this.manageDetainedLicensesToolStripMenuItem.Size = new System.Drawing.Size(330, 26);
            this.manageDetainedLicensesToolStripMenuItem.Text = "Manage Detained Licenses";
            this.manageDetainedLicensesToolStripMenuItem.Click += new System.EventHandler(this.manageDetainedLicensesToolStripMenuItem_Click);
            // 
            // detainALicenseToolStripMenuItem
            // 
            this.detainALicenseToolStripMenuItem.Name = "detainALicenseToolStripMenuItem";
            this.detainALicenseToolStripMenuItem.Size = new System.Drawing.Size(330, 26);
            this.detainALicenseToolStripMenuItem.Text = "Detain A License";
            this.detainALicenseToolStripMenuItem.Click += new System.EventHandler(this.detainALicenseToolStripMenuItem_Click);
            // 
            // releaseLicenseToolStripMenuItem
            // 
            this.releaseLicenseToolStripMenuItem.Name = "releaseLicenseToolStripMenuItem";
            this.releaseLicenseToolStripMenuItem.Size = new System.Drawing.Size(330, 26);
            this.releaseLicenseToolStripMenuItem.Text = "Release License";
            this.releaseLicenseToolStripMenuItem.Click += new System.EventHandler(this.releaseLicenseToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(315, 6);
            // 
            // manageApplicationTypesToolStripMenuItem
            // 
            this.manageApplicationTypesToolStripMenuItem.Name = "manageApplicationTypesToolStripMenuItem";
            this.manageApplicationTypesToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0);
            this.manageApplicationTypesToolStripMenuItem.Size = new System.Drawing.Size(318, 24);
            this.manageApplicationTypesToolStripMenuItem.Text = "Manage Application types";
            this.manageApplicationTypesToolStripMenuItem.Click += new System.EventHandler(this.manageApplicationTypesToolStripMenuItem_Click);
            // 
            // manageTestTypesToolStripMenuItem
            // 
            this.manageTestTypesToolStripMenuItem.Name = "manageTestTypesToolStripMenuItem";
            this.manageTestTypesToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0);
            this.manageTestTypesToolStripMenuItem.Size = new System.Drawing.Size(318, 24);
            this.manageTestTypesToolStripMenuItem.Text = "Manage Test types";
            this.manageTestTypesToolStripMenuItem.Click += new System.EventHandler(this.manageTestTypesToolStripMenuItem_Click);
            // 
            // driversToolStripMenuItem
            // 
            this.driversToolStripMenuItem.BackColor = System.Drawing.Color.LightGray;
            this.driversToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10, 4, 0, 4);
            this.driversToolStripMenuItem.Name = "driversToolStripMenuItem";
            this.driversToolStripMenuItem.Padding = new System.Windows.Forms.Padding(20, 8, 0, 8);
            this.driversToolStripMenuItem.Size = new System.Drawing.Size(171, 42);
            this.driversToolStripMenuItem.Text = "Drivers";
            this.driversToolStripMenuItem.Click += new System.EventHandler(this.driversToolStripMenuItem_Click);
            // 
            // peopleToolStripMenuItem
            // 
            this.peopleToolStripMenuItem.BackColor = System.Drawing.Color.LightGray;
            this.peopleToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10, 4, 0, 4);
            this.peopleToolStripMenuItem.Name = "peopleToolStripMenuItem";
            this.peopleToolStripMenuItem.Padding = new System.Windows.Forms.Padding(20, 8, 0, 8);
            this.peopleToolStripMenuItem.Size = new System.Drawing.Size(171, 42);
            this.peopleToolStripMenuItem.Text = "People";
            this.peopleToolStripMenuItem.Click += new System.EventHandler(this.peopleToolStripMenuItem_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.BackColor = System.Drawing.Color.LightGray;
            this.usersToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10, 4, 0, 4);
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Padding = new System.Windows.Forms.Padding(20, 8, 0, 8);
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(171, 42);
            this.usersToolStripMenuItem.Text = "Users";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // accountSettingsToolStripMenuItem
            // 
            this.accountSettingsToolStripMenuItem.BackColor = System.Drawing.Color.LightGray;
            this.accountSettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showLoginUserToolStripMenuItem,
            this.changePasswordToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.accountSettingsToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10, 4, 0, 4);
            this.accountSettingsToolStripMenuItem.Name = "accountSettingsToolStripMenuItem";
            this.accountSettingsToolStripMenuItem.Padding = new System.Windows.Forms.Padding(20, 8, 0, 8);
            this.accountSettingsToolStripMenuItem.Size = new System.Drawing.Size(171, 42);
            this.accountSettingsToolStripMenuItem.Text = "Account Settings";
            // 
            // showLoginUserToolStripMenuItem
            // 
            this.showLoginUserToolStripMenuItem.Name = "showLoginUserToolStripMenuItem";
            this.showLoginUserToolStripMenuItem.Size = new System.Drawing.Size(266, 26);
            this.showLoginUserToolStripMenuItem.Text = "Show Loged in User";
            this.showLoginUserToolStripMenuItem.Click += new System.EventHandler(this.showLoginUserToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(266, 26);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(266, 26);
            this.logOutToolStripMenuItem.Text = "Log out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::DVLD.Properties.Resources._124515;
            this.ClientSize = new System.Drawing.Size(809, 450);
            this.Controls.Add(this.msMain);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem peopleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLoginUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem applicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem driverLicenseServicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem managToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem detainedDriverLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem manageApplicationTypesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageTestTypesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newDrivingLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localDrivingLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem internationalDrivingLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newLocalDLApplicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageInternationalDLApplicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renewDrivingLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem replacementForLostOrDamagedDrivingLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem releaseDetainedDrivingLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem driversToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageDetainedLicensesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detainALicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem releaseLicenseToolStripMenuItem;
    }
}