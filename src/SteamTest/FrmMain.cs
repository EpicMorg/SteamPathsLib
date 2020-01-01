using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;
using EpicMorg.SteamPathsLib;
using System.Reflection;

namespace SteamTest
{
    public partial class FrmMain : Form
    {

        public static readonly int SOURCE_SDK_BASE_2007_APP_ID = 218;
        public static readonly int SOURCE_SDK_BASE_2013_SINGLEPLAYER_APP_ID = 243730;

        private void Screenshot(string filepath, string filename, ImageFormat format)
        {
            var bounds = Bounds;

            using (var bitmap = new Bitmap(bounds.Width, bounds.Height))
            {
                using (var g = Graphics.FromImage(bitmap))
                {
                    g.CopyFromScreen(new Point(bounds.Left, bounds.Top), Point.Empty, bounds.Size);
                }
                var fullpaths = filepath + "\\" + filename;
                bitmap.Save(fullpaths, format);
            }
        }

        public FrmMain()
        {
            InitializeComponent();
            textBoxTestAppId.Value = (decimal)SOURCE_SDK_BASE_2013_SINGLEPLAYER_APP_ID;
            this.Text = Text + " " + Assembly.GetExecutingAssembly().GetName().Version.ToString();
;        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            CheckAll();
        }

        private void ButtonreCheck_Click(object sender, EventArgs e)
        {
            CheckAll();
        }

        private void CheckAll()
        {
            CheckRegValveReg();
            CheckRegValveSteamReg();
            CheckRegValveSteamApps();
            CheckRegValveSteamExe();
            CheckRegValveSteamExePid();
            CheckRegValveSteamPath();
            CheckRegValveSteamSmodPath();
            CheckRegValveSteamApp240();
            CheckRegValveSteamApp218();
            CheckRegValveSteamAppCustom();
        }

        private void CheckRegValveReg()
        {
            try
            {
                // Example of using this awesome library
                var text = SteamPathsUtil.GetValveKeyRegistry();

                checkBoxVavleReg.Checked = true;
                checkBoxVavleReg.ForeColor = Color.Green;
                txtVavleReg.Text = text;
            }
            catch (Exception ex)
            {
                checkBoxVavleReg.Checked = checkBoxVavleSteamReg.Checked = false;
                checkBoxVavleReg.ForeColor = checkBoxVavleSteamReg.ForeColor = Color.Red;
                txtVavleReg.Text = @"Not found";
                Console.WriteLine(ex);
            }

        }

        private void CheckRegValveSteamReg()
        {
            try
            {
                // Example of using this awesome library
                var text = SteamPathsUtil.GetSteamKeyRegistry();

                checkBoxVavleSteamReg.Checked = true;
                checkBoxVavleSteamReg.ForeColor = Color.Green;
                txtVavleSteamReg.Text = text;
            }
            catch (Exception ex)
            {
                checkBoxVavleSteamReg.Checked = checkBoxVavleSteamReg.Checked = false;
                checkBoxVavleSteamReg.ForeColor = checkBoxVavleSteamReg.ForeColor = Color.Red;
                txtVavleSteamReg.Text = @"Not found";
                Console.WriteLine(ex);
            }
        }

        private void CheckRegValveSteamApps()
        {

            try
            {
                // Example of using this awesome library
                var text = SteamPathsUtil.GetSteamAppsKeyRegistry();

                checkBoxVavleSteamApps.Checked = true;
                checkBoxVavleSteamApps.ForeColor = Color.Green;
                txtBoxVavleSteamApps.Text = text;
            }
            catch (Exception ex)
            {
                checkBoxVavleSteamApps.Checked = checkBoxVavleSteamApps.Checked = false;
                checkBoxVavleSteamApps.ForeColor = checkBoxVavleSteamApps.ForeColor = Color.Red;
                txtBoxVavleSteamApps.Text = @"Not found";
                Console.WriteLine(ex);
            }
        }

        private void CheckRegValveSteamExe()
        {
            try
            {
                // Example of using this awesome library
                var text = SteamPathsUtil.GetSteamExePath();

                checkBoxVavleSteamExe.Checked = true;
                checkBoxVavleSteamExe.ForeColor = Color.Green;
                checkBoxVavleSteamExe.CheckState = CheckState.Checked;
                txtBoxVavleSteamExe.Text = text;

                if (txtBoxVavleSteamExe.Text == @"")
                {
                    checkBoxVavleSteamExe.ForeColor = Color.OrangeRed;
                    checkBoxVavleSteamExe.CheckState = CheckState.Indeterminate;
                    toolTip.SetToolTip(checkBoxVavleSteamExe, "SteamPath is presented but empty");
                }

            }
            catch (Exception ex)
            {
                checkBoxVavleSteamExe.Checked = checkBoxVavleSteamExe.Checked = false;
                checkBoxVavleSteamExe.ForeColor = checkBoxVavleSteamExe.ForeColor = Color.Red;
                checkBoxVavleSteamExe.CheckState = CheckState.Unchecked;
                txtBoxVavleSteamExe.Text = @"Not found";
                Console.WriteLine(ex);
            }
        }

        private void CheckRegValveSteamExePid()
        {
            try
            {
                // Example of using this awesome library
                var text = SteamPathsUtil.GetSteamExePid();

                checkBoxVavleSteamPID.Checked = true;
                checkBoxVavleSteamPID.ForeColor = Color.Green;
                checkBoxVavleSteamPID.CheckState = CheckState.Checked;
                txtBoxVavleSteamPID.Text = text;

                if (txtBoxVavleSteamPID.Text == @"0")
                {
                    checkBoxVavleSteamPID.ForeColor = Color.OrangeRed;
                    checkBoxVavleSteamPID.CheckState = CheckState.Indeterminate;
                    toolTip.SetToolTip(checkBoxVavleSteamPID, "Steam installed but not running");
                }

            }
            catch (Exception ex)
            {
                checkBoxVavleSteamPID.Checked = checkBoxVavleSteamPID.Checked = false;
                checkBoxVavleSteamPID.ForeColor = checkBoxVavleSteamPID.ForeColor = Color.Red;
                checkBoxVavleSteamPath.CheckState = CheckState.Unchecked;
                txtBoxVavleSteamPID.Text = @"Not found";
                Console.WriteLine(ex);
            }

        }

        private void CheckRegValveSteamPath()
        {
            try
            {
                // Example of using this awesome library
                var text = SteamPathsUtil.GetSteamDirectoryPath();

                checkBoxVavleSteamPath.Checked = true;
                checkBoxVavleSteamPath.ForeColor = Color.Green;
                checkBoxVavleSteamPath.CheckState = CheckState.Checked;
                txtBoxVavleSteamPath.Text = text;

                if (txtBoxVavleSteamPath.Text == @"")
                {
                    checkBoxVavleSteamPath.ForeColor = Color.OrangeRed;
                    checkBoxVavleSteamPath.CheckState = CheckState.Indeterminate;
                    toolTip.SetToolTip(checkBoxVavleSteamPath, "SteamPath is presented but empty");
                }

            }
            catch (Exception ex)
            {
                checkBoxVavleSteamPath.Checked = checkBoxVavleSteamPath.Checked = false;
                checkBoxVavleSteamPath.ForeColor = checkBoxVavleSteamPath.ForeColor = Color.Red;
                checkBoxVavleSteamPath.CheckState = CheckState.Unchecked;
                txtBoxVavleSteamPath.Text = @"Not found";
                Console.WriteLine(ex);
            }
        }

        private void CheckRegValveSteamSmodPath()
        {
            try
            {
                // Example of using this awesome library
                var text = SteamPathsUtil.GetOriginalSourceModDirectoryPath();

                checkBoxVavleSteamSmodPath.Checked = true;
                checkBoxVavleSteamSmodPath.ForeColor = Color.Green;
                checkBoxVavleSteamSmodPath.CheckState = CheckState.Checked;
                txtBoxVavleSteamSmodPath.Text = text;

                if (txtBoxVavleSteamSmodPath.Text == @"")
                {
                    checkBoxVavleSteamSmodPath.ForeColor = Color.OrangeRed;
                    checkBoxVavleSteamSmodPath.CheckState = CheckState.Indeterminate;
                    toolTip.SetToolTip(checkBoxVavleSteamSmodPath, "SourceModInstallPath is presented but empty!");
                }

            }
            catch (Exception ex)
            {
                checkBoxVavleSteamSmodPath.Checked = checkBoxVavleSteamSmodPath.Checked = false;
                checkBoxVavleSteamSmodPath.ForeColor = checkBoxVavleSteamSmodPath.ForeColor = Color.Red;
                checkBoxVavleSteamSmodPath.CheckState = CheckState.Unchecked;
                txtBoxVavleSteamSmodPath.Text = @"Not found";
                Console.WriteLine(ex);
            }
        }



        private void CheckRegValveSteamApp240()
        {
            CheckSteamAppById(SOURCE_SDK_BASE_2013_SINGLEPLAYER_APP_ID, txtBoxVavleSteamApps243730, checkBoxVavleSteamApps243730, checkBoxVavleSteamApps243730Installed);
        }

        private void CheckRegValveSteamApp218()
        {
            CheckSteamAppById(SOURCE_SDK_BASE_2007_APP_ID, txtBoxVavleSteamApps218, checkBoxVavleSteamApps218, checkBoxVavleSteamApps218Installed);
        }

        private void CheckRegValveSteamAppCustom()
        {
            var appId = Decimal.ToInt32(textBoxTestAppId.Value);

            CheckSteamAppById(appId, txtBoxVavleSteamAppsCustom, checkBoxVavleSteamAppsCustom, checkBoxVavleSteamAppsCustomInstalled);
        }

            private void CheckSteamAppById(int appId, TextBox outputTextBox, CheckBox outputCheckBox, CheckBox outputInstalledCheckBox)
        {
            var check = SteamPathsUtil.IsInstalledApps(appId);
            var path = SteamPathsUtil.GetInstalledAppKeyRegistryById(appId);

            outputTextBox.Text = path;

            if (check)
            {
                outputCheckBox.Checked = true;
                outputCheckBox.ForeColor = Color.Green;

                outputInstalledCheckBox.Checked = true;
                outputInstalledCheckBox.ForeColor = Color.Green;
                outputInstalledCheckBox.Text = "Installed: " + appId;
            }
            else
            {
                outputCheckBox.Checked = false;
                outputCheckBox.ForeColor = Color.Red;

                outputInstalledCheckBox.Checked = false;
                outputInstalledCheckBox.ForeColor = Color.Red;
                outputInstalledCheckBox.Text = "Installed: " + appId;

            }
        }


        private void BtnGetScreenShot_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.ShowDialog();
            var desktopFolder = folderBrowserDialog.SelectedPath;
            try
            {
                Screenshot(desktopFolder, "SteamTest.Png", ImageFormat.Png);
                MessageBox.Show(@"Success! Saved to selected path" + Environment.NewLine + desktopFolder, @"Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show(@"Not success. Can not save to selected path" + Environment.NewLine + desktopFolder, @"Not success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void textBoxTestAppId_TextChanged(object sender, EventArgs e)
        {
            checkBoxVavleSteamAppsCustom.Text = "appID: " + textBoxTestAppId.Text;
        }
    }
}
