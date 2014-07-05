using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dolphiilution_
{
    public partial class firstRun : Form
    {
        public firstRun() //for some reason this is called firstRun. don't judge :p
        {
            InitializeComponent();
        }

        private void btnWiiGames_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog browseForWiiGames = new FolderBrowserDialog();
            browseForWiiGames.Description = "Please select the folder with your Wii games in ISO or WBFS format.";
            if (browseForWiiGames.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.wiigamespath = browseForWiiGames.SelectedPath;
                Properties.Settings.Default.Save();
                txtWiiGames.Text = Properties.Settings.Default.wiigamespath;
            }
        }

        private void btnGCGames_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog browseForGCGames = new FolderBrowserDialog();
            browseForGCGames.Description = "Please select the folder with your Gamecube games in ISO or GCM format.";
            if (browseForGCGames.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.gcgamespath = browseForGCGames.SelectedPath;
                Properties.Settings.Default.Save();
                txtGCGames.Text = Properties.Settings.Default.gcgamespath;
            }
        }

        private void btnDolphinPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog browseForDolphins = new OpenFileDialog();
            browseForDolphins.Title = "Please select your Dolphin.exe executable.";
            browseForDolphins.Filter = "Dolphin Executables|Dolphin.exe";
            if (browseForDolphins.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.dolphinpath = browseForDolphins.FileName;
                Properties.Settings.Default.Save();
                txtDolphinPath.Text = Properties.Settings.Default.dolphinpath;
            }
        }

        private void btnDophinGU_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog browseForUD = new FolderBrowserDialog();
            browseForUD.Description = "Please select your Dolphin Emulator user directory. If you haven't changed it, it is located in your Documents folder.";
            if (browseForUD.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.globaluserpath = browseForUD.SelectedPath;
                Properties.Settings.Default.Save();
                txtDophinUD.Text = Properties.Settings.Default.globaluserpath;
            }  
        }

        private void firstRun_Load(object sender, EventArgs e)
        {
            txtWiiGames.Text = Properties.Settings.Default.wiigamespath;
            txtGCGames.Text = Properties.Settings.Default.gcgamespath;
            txtDolphinPath.Text = Properties.Settings.Default.dolphinpath;
            txtDophinUD.Text = Properties.Settings.Default.globaluserpath;
            txtRiivoPath.Text = Properties.Settings.Default.riivopath;
        }
        private void btnRiivoPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog browseForRiivo = new FolderBrowserDialog();
            browseForRiivo.Description = "Please select the root of your SD, or your fake SD card. There should be a \"riivolution\" folder inside containing your XML files.";
            if (browseForRiivo.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.riivopath = browseForRiivo.SelectedPath;
                Properties.Settings.Default.Save();
                txtRiivoPath.Text = Properties.Settings.Default.riivopath;
            }
        }

        private void firstRun_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.firstrun = false;
            Properties.Settings.Default.Save();
            MessageBox.Show("Please restart the program for your changes to take effect.");
            Application.Exit();
        }
    }
}
