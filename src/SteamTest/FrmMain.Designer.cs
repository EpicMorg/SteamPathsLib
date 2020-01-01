namespace SteamTest
{
    partial class FrmMain
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
            if (disposing && (components != null)) {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.checkBoxVavleReg = new System.Windows.Forms.CheckBox();
            this.checkBoxVavleSteamReg = new System.Windows.Forms.CheckBox();
            this.txtVavleReg = new System.Windows.Forms.TextBox();
            this.txtVavleSteamReg = new System.Windows.Forms.TextBox();
            this.checkBoxVavleSteamExe = new System.Windows.Forms.CheckBox();
            this.checkBoxVavleSteamSmodPath = new System.Windows.Forms.CheckBox();
            this.checkBoxVavleSteamPath = new System.Windows.Forms.CheckBox();
            this.txtBoxVavleSteamPID = new System.Windows.Forms.TextBox();
            this.txtBoxVavleSteamPath = new System.Windows.Forms.TextBox();
            this.txtBoxVavleSteamExe = new System.Windows.Forms.TextBox();
            this.checkBoxVavleSteamApps = new System.Windows.Forms.CheckBox();
            this.txtBoxVavleSteamApps = new System.Windows.Forms.TextBox();
            this.groupBoxRegTest = new System.Windows.Forms.GroupBox();
            this.checkBoxVavleSteamPID = new System.Windows.Forms.CheckBox();
            this.txtBoxVavleSteamSmodPath = new System.Windows.Forms.TextBox();
            this.txtBoxVavleSteamApps218 = new System.Windows.Forms.TextBox();
            this.txtBoxVavleSteamApps243730 = new System.Windows.Forms.TextBox();
            this.checkBoxVavleSteamApps218 = new System.Windows.Forms.CheckBox();
            this.checkBoxVavleSteamApps218Installed = new System.Windows.Forms.CheckBox();
            this.checkBoxVavleSteamApps243730Installed = new System.Windows.Forms.CheckBox();
            this.checkBoxVavleSteamApps243730 = new System.Windows.Forms.CheckBox();
            this.btnGetScreenShot = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.buttonreCheck = new System.Windows.Forms.Button();
            this.checkBoxVavleSteamAppsCustomInstalled = new System.Windows.Forms.CheckBox();
            this.checkBoxVavleSteamAppsCustom = new System.Windows.Forms.CheckBox();
            this.txtBoxVavleSteamAppsCustom = new System.Windows.Forms.TextBox();
            this.labelHR = new System.Windows.Forms.Label();
            this.textBoxTestAppId = new System.Windows.Forms.NumericUpDown();
            this.groupBoxRegTest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxTestAppId)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBoxVavleReg
            // 
            this.checkBoxVavleReg.AutoCheck = false;
            this.checkBoxVavleReg.AutoSize = true;
            this.checkBoxVavleReg.Location = new System.Drawing.Point(12, 21);
            this.checkBoxVavleReg.Name = "checkBoxVavleReg";
            this.checkBoxVavleReg.Size = new System.Drawing.Size(200, 17);
            this.checkBoxVavleReg.TabIndex = 0;
            this.checkBoxVavleReg.Text = "The presence \"Valve\" in the registry:";
            this.checkBoxVavleReg.UseVisualStyleBackColor = true;
            // 
            // checkBoxVavleSteamReg
            // 
            this.checkBoxVavleSteamReg.AutoCheck = false;
            this.checkBoxVavleSteamReg.AutoSize = true;
            this.checkBoxVavleSteamReg.Location = new System.Drawing.Point(12, 47);
            this.checkBoxVavleSteamReg.Name = "checkBoxVavleSteamReg";
            this.checkBoxVavleSteamReg.Size = new System.Drawing.Size(203, 17);
            this.checkBoxVavleSteamReg.TabIndex = 0;
            this.checkBoxVavleSteamReg.Text = "The presence \"Steam\" in the registry:";
            this.checkBoxVavleSteamReg.UseVisualStyleBackColor = true;
            // 
            // txtVavleReg
            // 
            this.txtVavleReg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVavleReg.Location = new System.Drawing.Point(218, 19);
            this.txtVavleReg.Name = "txtVavleReg";
            this.txtVavleReg.ReadOnly = true;
            this.txtVavleReg.Size = new System.Drawing.Size(300, 20);
            this.txtVavleReg.TabIndex = 1;
            // 
            // txtVavleSteamReg
            // 
            this.txtVavleSteamReg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVavleSteamReg.Location = new System.Drawing.Point(218, 45);
            this.txtVavleSteamReg.Name = "txtVavleSteamReg";
            this.txtVavleSteamReg.ReadOnly = true;
            this.txtVavleSteamReg.Size = new System.Drawing.Size(300, 20);
            this.txtVavleSteamReg.TabIndex = 1;
            // 
            // checkBoxVavleSteamExe
            // 
            this.checkBoxVavleSteamExe.AutoCheck = false;
            this.checkBoxVavleSteamExe.AutoSize = true;
            this.checkBoxVavleSteamExe.Location = new System.Drawing.Point(12, 73);
            this.checkBoxVavleSteamExe.Name = "checkBoxVavleSteamExe";
            this.checkBoxVavleSteamExe.Size = new System.Drawing.Size(74, 17);
            this.checkBoxVavleSteamExe.TabIndex = 0;
            this.checkBoxVavleSteamExe.Text = "SteamExe";
            this.checkBoxVavleSteamExe.UseVisualStyleBackColor = true;
            // 
            // checkBoxVavleSteamSmodPath
            // 
            this.checkBoxVavleSteamSmodPath.AutoCheck = false;
            this.checkBoxVavleSteamSmodPath.AutoSize = true;
            this.checkBoxVavleSteamSmodPath.Location = new System.Drawing.Point(12, 151);
            this.checkBoxVavleSteamSmodPath.Name = "checkBoxVavleSteamSmodPath";
            this.checkBoxVavleSteamSmodPath.Size = new System.Drawing.Size(130, 17);
            this.checkBoxVavleSteamSmodPath.TabIndex = 0;
            this.checkBoxVavleSteamSmodPath.Text = "SourceModInstallPath";
            this.checkBoxVavleSteamSmodPath.UseVisualStyleBackColor = true;
            // 
            // checkBoxVavleSteamPath
            // 
            this.checkBoxVavleSteamPath.AutoCheck = false;
            this.checkBoxVavleSteamPath.AutoSize = true;
            this.checkBoxVavleSteamPath.Location = new System.Drawing.Point(12, 99);
            this.checkBoxVavleSteamPath.Name = "checkBoxVavleSteamPath";
            this.checkBoxVavleSteamPath.Size = new System.Drawing.Size(78, 17);
            this.checkBoxVavleSteamPath.TabIndex = 0;
            this.checkBoxVavleSteamPath.Text = "SteamPath";
            this.checkBoxVavleSteamPath.UseVisualStyleBackColor = true;
            // 
            // txtBoxVavleSteamPID
            // 
            this.txtBoxVavleSteamPID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxVavleSteamPID.Location = new System.Drawing.Point(218, 123);
            this.txtBoxVavleSteamPID.Name = "txtBoxVavleSteamPID";
            this.txtBoxVavleSteamPID.ReadOnly = true;
            this.txtBoxVavleSteamPID.Size = new System.Drawing.Size(300, 20);
            this.txtBoxVavleSteamPID.TabIndex = 1;
            // 
            // txtBoxVavleSteamPath
            // 
            this.txtBoxVavleSteamPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxVavleSteamPath.Location = new System.Drawing.Point(218, 97);
            this.txtBoxVavleSteamPath.Name = "txtBoxVavleSteamPath";
            this.txtBoxVavleSteamPath.ReadOnly = true;
            this.txtBoxVavleSteamPath.Size = new System.Drawing.Size(300, 20);
            this.txtBoxVavleSteamPath.TabIndex = 1;
            // 
            // txtBoxVavleSteamExe
            // 
            this.txtBoxVavleSteamExe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxVavleSteamExe.Location = new System.Drawing.Point(218, 71);
            this.txtBoxVavleSteamExe.Name = "txtBoxVavleSteamExe";
            this.txtBoxVavleSteamExe.ReadOnly = true;
            this.txtBoxVavleSteamExe.Size = new System.Drawing.Size(300, 20);
            this.txtBoxVavleSteamExe.TabIndex = 1;
            // 
            // checkBoxVavleSteamApps
            // 
            this.checkBoxVavleSteamApps.AutoCheck = false;
            this.checkBoxVavleSteamApps.AutoSize = true;
            this.checkBoxVavleSteamApps.Location = new System.Drawing.Point(12, 177);
            this.checkBoxVavleSteamApps.Name = "checkBoxVavleSteamApps";
            this.checkBoxVavleSteamApps.Size = new System.Drawing.Size(186, 17);
            this.checkBoxVavleSteamApps.TabIndex = 0;
            this.checkBoxVavleSteamApps.Text = "Наличие ключа Apps в реестре:";
            this.checkBoxVavleSteamApps.UseVisualStyleBackColor = true;
            // 
            // txtBoxVavleSteamApps
            // 
            this.txtBoxVavleSteamApps.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxVavleSteamApps.Location = new System.Drawing.Point(218, 175);
            this.txtBoxVavleSteamApps.Name = "txtBoxVavleSteamApps";
            this.txtBoxVavleSteamApps.ReadOnly = true;
            this.txtBoxVavleSteamApps.Size = new System.Drawing.Size(300, 20);
            this.txtBoxVavleSteamApps.TabIndex = 1;
            // 
            // groupBoxRegTest
            // 
            this.groupBoxRegTest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxRegTest.Controls.Add(this.textBoxTestAppId);
            this.groupBoxRegTest.Controls.Add(this.labelHR);
            this.groupBoxRegTest.Controls.Add(this.checkBoxVavleSteamPID);
            this.groupBoxRegTest.Controls.Add(this.checkBoxVavleReg);
            this.groupBoxRegTest.Controls.Add(this.checkBoxVavleSteamSmodPath);
            this.groupBoxRegTest.Controls.Add(this.checkBoxVavleSteamPath);
            this.groupBoxRegTest.Controls.Add(this.checkBoxVavleSteamReg);
            this.groupBoxRegTest.Controls.Add(this.txtBoxVavleSteamSmodPath);
            this.groupBoxRegTest.Controls.Add(this.txtBoxVavleSteamAppsCustom);
            this.groupBoxRegTest.Controls.Add(this.txtBoxVavleSteamApps218);
            this.groupBoxRegTest.Controls.Add(this.txtBoxVavleSteamApps243730);
            this.groupBoxRegTest.Controls.Add(this.txtBoxVavleSteamPID);
            this.groupBoxRegTest.Controls.Add(this.txtBoxVavleSteamApps);
            this.groupBoxRegTest.Controls.Add(this.checkBoxVavleSteamAppsCustom);
            this.groupBoxRegTest.Controls.Add(this.checkBoxVavleSteamApps218);
            this.groupBoxRegTest.Controls.Add(this.checkBoxVavleSteamAppsCustomInstalled);
            this.groupBoxRegTest.Controls.Add(this.txtBoxVavleSteamPath);
            this.groupBoxRegTest.Controls.Add(this.checkBoxVavleSteamApps218Installed);
            this.groupBoxRegTest.Controls.Add(this.checkBoxVavleSteamApps243730Installed);
            this.groupBoxRegTest.Controls.Add(this.checkBoxVavleSteamApps243730);
            this.groupBoxRegTest.Controls.Add(this.txtBoxVavleSteamExe);
            this.groupBoxRegTest.Controls.Add(this.checkBoxVavleSteamApps);
            this.groupBoxRegTest.Controls.Add(this.checkBoxVavleSteamExe);
            this.groupBoxRegTest.Controls.Add(this.txtVavleSteamReg);
            this.groupBoxRegTest.Controls.Add(this.txtVavleReg);
            this.groupBoxRegTest.Location = new System.Drawing.Point(12, 12);
            this.groupBoxRegTest.Name = "groupBoxRegTest";
            this.groupBoxRegTest.Size = new System.Drawing.Size(530, 369);
            this.groupBoxRegTest.TabIndex = 3;
            this.groupBoxRegTest.TabStop = false;
            this.groupBoxRegTest.Text = "Registry Test:";
            // 
            // checkBoxVavleSteamPID
            // 
            this.checkBoxVavleSteamPID.AutoCheck = false;
            this.checkBoxVavleSteamPID.AutoSize = true;
            this.checkBoxVavleSteamPID.Location = new System.Drawing.Point(12, 125);
            this.checkBoxVavleSteamPID.Name = "checkBoxVavleSteamPID";
            this.checkBoxVavleSteamPID.Size = new System.Drawing.Size(160, 17);
            this.checkBoxVavleSteamPID.TabIndex = 2;
            this.checkBoxVavleSteamPID.Text = "Steam Active Process (PID):";
            this.checkBoxVavleSteamPID.UseVisualStyleBackColor = true;
            // 
            // txtBoxVavleSteamSmodPath
            // 
            this.txtBoxVavleSteamSmodPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxVavleSteamSmodPath.Location = new System.Drawing.Point(218, 149);
            this.txtBoxVavleSteamSmodPath.Name = "txtBoxVavleSteamSmodPath";
            this.txtBoxVavleSteamSmodPath.ReadOnly = true;
            this.txtBoxVavleSteamSmodPath.Size = new System.Drawing.Size(300, 20);
            this.txtBoxVavleSteamSmodPath.TabIndex = 1;
            // 
            // txtBoxVavleSteamApps218
            // 
            this.txtBoxVavleSteamApps218.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxVavleSteamApps218.Location = new System.Drawing.Point(218, 247);
            this.txtBoxVavleSteamApps218.Name = "txtBoxVavleSteamApps218";
            this.txtBoxVavleSteamApps218.ReadOnly = true;
            this.txtBoxVavleSteamApps218.Size = new System.Drawing.Size(300, 20);
            this.txtBoxVavleSteamApps218.TabIndex = 1;
            // 
            // txtBoxVavleSteamApps243730
            // 
            this.txtBoxVavleSteamApps243730.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxVavleSteamApps243730.Location = new System.Drawing.Point(218, 201);
            this.txtBoxVavleSteamApps243730.Name = "txtBoxVavleSteamApps243730";
            this.txtBoxVavleSteamApps243730.ReadOnly = true;
            this.txtBoxVavleSteamApps243730.Size = new System.Drawing.Size(300, 20);
            this.txtBoxVavleSteamApps243730.TabIndex = 1;
            // 
            // checkBoxVavleSteamApps218
            // 
            this.checkBoxVavleSteamApps218.AutoCheck = false;
            this.checkBoxVavleSteamApps218.AutoSize = true;
            this.checkBoxVavleSteamApps218.Location = new System.Drawing.Point(12, 249);
            this.checkBoxVavleSteamApps218.Name = "checkBoxVavleSteamApps218";
            this.checkBoxVavleSteamApps218.Size = new System.Drawing.Size(150, 17);
            this.checkBoxVavleSteamApps218.TabIndex = 0;
            this.checkBoxVavleSteamApps218.Text = "appID: 2018 (SSDK 2007)";
            this.checkBoxVavleSteamApps218.UseVisualStyleBackColor = true;
            // 
            // checkBoxVavleSteamApps218Installed
            // 
            this.checkBoxVavleSteamApps218Installed.AutoCheck = false;
            this.checkBoxVavleSteamApps218Installed.AutoSize = true;
            this.checkBoxVavleSteamApps218Installed.Location = new System.Drawing.Point(25, 272);
            this.checkBoxVavleSteamApps218Installed.Name = "checkBoxVavleSteamApps218Installed";
            this.checkBoxVavleSteamApps218Installed.Size = new System.Drawing.Size(65, 17);
            this.checkBoxVavleSteamApps218Installed.TabIndex = 0;
            this.checkBoxVavleSteamApps218Installed.Text = "Installed";
            this.checkBoxVavleSteamApps218Installed.UseVisualStyleBackColor = true;
            // 
            // checkBoxVavleSteamApps243730Installed
            // 
            this.checkBoxVavleSteamApps243730Installed.AutoCheck = false;
            this.checkBoxVavleSteamApps243730Installed.AutoSize = true;
            this.checkBoxVavleSteamApps243730Installed.Location = new System.Drawing.Point(25, 226);
            this.checkBoxVavleSteamApps243730Installed.Name = "checkBoxVavleSteamApps243730Installed";
            this.checkBoxVavleSteamApps243730Installed.Size = new System.Drawing.Size(65, 17);
            this.checkBoxVavleSteamApps243730Installed.TabIndex = 0;
            this.checkBoxVavleSteamApps243730Installed.Text = "Installed";
            this.checkBoxVavleSteamApps243730Installed.UseVisualStyleBackColor = true;
            // 
            // checkBoxVavleSteamApps243730
            // 
            this.checkBoxVavleSteamApps243730.AutoCheck = false;
            this.checkBoxVavleSteamApps243730.AutoSize = true;
            this.checkBoxVavleSteamApps243730.Location = new System.Drawing.Point(12, 203);
            this.checkBoxVavleSteamApps243730.Name = "checkBoxVavleSteamApps243730";
            this.checkBoxVavleSteamApps243730.Size = new System.Drawing.Size(179, 17);
            this.checkBoxVavleSteamApps243730.TabIndex = 0;
            this.checkBoxVavleSteamApps243730.Text = "appID: 243730 (SSDK 2013 SP)";
            this.checkBoxVavleSteamApps243730.UseVisualStyleBackColor = true;
            // 
            // btnGetScreenShot
            // 
            this.btnGetScreenShot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetScreenShot.Location = new System.Drawing.Point(395, 387);
            this.btnGetScreenShot.Name = "btnGetScreenShot";
            this.btnGetScreenShot.Size = new System.Drawing.Size(147, 23);
            this.btnGetScreenShot.TabIndex = 4;
            this.btnGetScreenShot.Text = "Save Screenshot";
            this.btnGetScreenShot.UseVisualStyleBackColor = true;
            this.btnGetScreenShot.Click += new System.EventHandler(this.BtnGetScreenShot_Click);
            // 
            // buttonreCheck
            // 
            this.buttonreCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonreCheck.Location = new System.Drawing.Point(12, 387);
            this.buttonreCheck.Name = "buttonreCheck";
            this.buttonreCheck.Size = new System.Drawing.Size(147, 23);
            this.buttonreCheck.TabIndex = 5;
            this.buttonreCheck.Text = "Recheck";
            this.buttonreCheck.UseVisualStyleBackColor = true;
            this.buttonreCheck.Click += new System.EventHandler(this.ButtonreCheck_Click);
            // 
            // checkBoxVavleSteamAppsCustomInstalled
            // 
            this.checkBoxVavleSteamAppsCustomInstalled.AutoCheck = false;
            this.checkBoxVavleSteamAppsCustomInstalled.AutoSize = true;
            this.checkBoxVavleSteamAppsCustomInstalled.Location = new System.Drawing.Point(25, 341);
            this.checkBoxVavleSteamAppsCustomInstalled.Name = "checkBoxVavleSteamAppsCustomInstalled";
            this.checkBoxVavleSteamAppsCustomInstalled.Size = new System.Drawing.Size(65, 17);
            this.checkBoxVavleSteamAppsCustomInstalled.TabIndex = 0;
            this.checkBoxVavleSteamAppsCustomInstalled.Text = "Installed";
            this.checkBoxVavleSteamAppsCustomInstalled.UseVisualStyleBackColor = true;
            // 
            // checkBoxVavleSteamAppsCustom
            // 
            this.checkBoxVavleSteamAppsCustom.AutoCheck = false;
            this.checkBoxVavleSteamAppsCustom.AutoSize = true;
            this.checkBoxVavleSteamAppsCustom.Location = new System.Drawing.Point(12, 318);
            this.checkBoxVavleSteamAppsCustom.Name = "checkBoxVavleSteamAppsCustom";
            this.checkBoxVavleSteamAppsCustom.Size = new System.Drawing.Size(58, 17);
            this.checkBoxVavleSteamAppsCustom.TabIndex = 0;
            this.checkBoxVavleSteamAppsCustom.Text = "appID:";
            this.checkBoxVavleSteamAppsCustom.UseVisualStyleBackColor = true;
            // 
            // txtBoxVavleSteamAppsCustom
            // 
            this.txtBoxVavleSteamAppsCustom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxVavleSteamAppsCustom.Location = new System.Drawing.Point(218, 316);
            this.txtBoxVavleSteamAppsCustom.Name = "txtBoxVavleSteamAppsCustom";
            this.txtBoxVavleSteamAppsCustom.ReadOnly = true;
            this.txtBoxVavleSteamAppsCustom.Size = new System.Drawing.Size(300, 20);
            this.txtBoxVavleSteamAppsCustom.TabIndex = 1;
            // 
            // labelHR
            // 
            this.labelHR.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelHR.Location = new System.Drawing.Point(6, 292);
            this.labelHR.Name = "labelHR";
            this.labelHR.Size = new System.Drawing.Size(518, 23);
            this.labelHR.TabIndex = 3;
            this.labelHR.Text = "_________________________________________________________________________________" +
    "____________________";
            // 
            // textBoxTestAppId
            // 
            this.textBoxTestAppId.Location = new System.Drawing.Point(218, 341);
            this.textBoxTestAppId.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.textBoxTestAppId.Name = "textBoxTestAppId";
            this.textBoxTestAppId.Size = new System.Drawing.Size(300, 20);
            this.textBoxTestAppId.TabIndex = 7;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 422);
            this.Controls.Add(this.buttonreCheck);
            this.Controls.Add(this.btnGetScreenShot);
            this.Controls.Add(this.groupBoxRegTest);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Steam Test Example";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.groupBoxRegTest.ResumeLayout(false);
            this.groupBoxRegTest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxTestAppId)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxVavleReg;
        private System.Windows.Forms.CheckBox checkBoxVavleSteamReg;
        private System.Windows.Forms.TextBox txtVavleReg;
        private System.Windows.Forms.TextBox txtVavleSteamReg;
        private System.Windows.Forms.CheckBox checkBoxVavleSteamExe;
        private System.Windows.Forms.CheckBox checkBoxVavleSteamSmodPath;
        private System.Windows.Forms.CheckBox checkBoxVavleSteamPath;
        private System.Windows.Forms.TextBox txtBoxVavleSteamPID;
        private System.Windows.Forms.TextBox txtBoxVavleSteamPath;
        private System.Windows.Forms.TextBox txtBoxVavleSteamExe;
        private System.Windows.Forms.CheckBox checkBoxVavleSteamApps;
        private System.Windows.Forms.TextBox txtBoxVavleSteamApps;
        private System.Windows.Forms.GroupBox groupBoxRegTest;
        private System.Windows.Forms.TextBox txtBoxVavleSteamApps243730;
        private System.Windows.Forms.CheckBox checkBoxVavleSteamApps243730;
        private System.Windows.Forms.CheckBox checkBoxVavleSteamPID;
        private System.Windows.Forms.TextBox txtBoxVavleSteamSmodPath;
        private System.Windows.Forms.Button btnGetScreenShot;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button buttonreCheck;
        private System.Windows.Forms.TextBox txtBoxVavleSteamApps218;
        private System.Windows.Forms.CheckBox checkBoxVavleSteamApps218;
        private System.Windows.Forms.CheckBox checkBoxVavleSteamApps218Installed;
        private System.Windows.Forms.CheckBox checkBoxVavleSteamApps243730Installed;
        private System.Windows.Forms.TextBox txtBoxVavleSteamAppsCustom;
        private System.Windows.Forms.CheckBox checkBoxVavleSteamAppsCustom;
        private System.Windows.Forms.CheckBox checkBoxVavleSteamAppsCustomInstalled;
        private System.Windows.Forms.Label labelHR;
        private System.Windows.Forms.NumericUpDown textBoxTestAppId;
    }
}

