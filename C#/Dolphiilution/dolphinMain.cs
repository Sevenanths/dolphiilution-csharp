using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

namespace Dolphiilution
{
    public partial class dolphinMain : Form
    {
        public string gamesPath;
        public string riivoPath;
        public string isoPath;
        public string dolphinPath = "";

        public bool extracted = false;

        public List<string> choicelist = new List<string>();
        public List<string> patchlist = new List<string>();

        public dolphinMain()
        {
            InitializeComponent();
        }

        private void btnGameFolderBrowse_Click(object sender, EventArgs e)
        {
            
        }

        private void lbxGames_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblIsoName.Text = Path.GetFileName(gamesPath + "/" + lbxGames.SelectedItem);
            isoPath = gamesPath + "/" + lbxGames.SelectedItem + ".iso";
            checkIfDecompiled();
        }
        void checkIfDecompiled()
        {
            if (Directory.Exists(gamesPath + "/rii/" + Path.GetFileName(gamesPath + "/" + lbxGames.SelectedItem)))
            {
                btnDecompile.Text = "Decompiled.";
                btnDecompile.Enabled = false;
                extracted = true;

                string virgin = File.ReadAllText(gamesPath + "/rii/" + Path.GetFileName(gamesPath + "/" + Path.GetFileNameWithoutExtension(isoPath)) + "/virgin");
                if (virgin == "yes"){
                    lblVirgin.Text = "Not patched.";
                }
                else
                {
                    lblVirgin.Text = "Patched.";
                }
            }
            else
            {
                btnDecompile.Text = "Decompile";
                lblVirgin.Text = "";
                btnDecompile.Enabled = true;
                extracted = false;
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                Directory.Delete(gamesPath + "/rii/" + Path.GetFileName(gamesPath + "/" + lbxGames.SelectedItem), true);
                checkIfDecompiled();
            }
            catch { }
        }

        private void pnlPlay_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have clicked a button.");
        }

        private void loadWiiGamesFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog browseForGames = new FolderBrowserDialog();
            if (browseForGames.ShowDialog() == DialogResult.OK)
            {
                gamesPath = browseForGames.SelectedPath;
                if (!(Directory.Exists(browseForGames.SelectedPath + "/rii")))
                {
                    Directory.CreateDirectory(browseForGames.SelectedPath + "/rii");
                }
                lbxGames.Items.Clear();
                string[] games = Directory.GetFiles(browseForGames.SelectedPath);
                foreach (string game in games)
                {
                    if (Path.GetFileName(game).ToLower().Contains(".iso") || Path.GetFileName(game).ToLower().Contains(".wbfs"))
                    {
                        lbxGames.Items.Add(Path.GetFileNameWithoutExtension(game));
                    }
                }
            }
        }

        private void loadRiivolutionFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog riivolutionPathPicker = new FolderBrowserDialog();
            riivolutionPathPicker.Description = "Select the folder (or drive, SD cards should work too!) where you have your Riivolution file structure saved.";

            if (riivolutionPathPicker.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (Directory.Exists(riivolutionPathPicker.SelectedPath + "//riivolution"))
                {
                    pnlItems.Enabled = true;
                    riivoPath = riivolutionPathPicker.SelectedPath;
                    string[] files = Directory.GetFiles(riivoPath + "//riivolution");
                    foreach (string file in files)
                    {
                        if (file.Contains(".xml"))
                        {
                            cbxRiivolutionXML.Items.Add(Path.GetFileNameWithoutExtension(file));
                        }
                    }
                }
            }
        }

        private void btnDecompile_Click(object sender, EventArgs e)
        {
            bgwExtractISO.RunWorkerAsync();
        }

        private void bgwExtractISO_DoWork(object sender, DoWorkEventArgs e)
        {
            Process extractISO = new Process();

            extractISO.StartInfo.Arguments = "extract \"" + isoPath + "\" \"" + gamesPath + "/rii/" + Path.GetFileName(gamesPath + "/" + Path.GetFileNameWithoutExtension(isoPath)) + "\"";
            extractISO.StartInfo.FileName = Application.StartupPath + "/WIT/wit.exe";

            File.Create(gamesPath + "/rii/" + Path.GetFileName(gamesPath + "/" + Path.GetFileNameWithoutExtension(isoPath)) + "/virgin").Dispose();
            File.WriteAllText(gamesPath + "/rii/" + Path.GetFileName(gamesPath + "/" + Path.GetFileNameWithoutExtension(isoPath)) + "/virgin", "yes");
            extractISO.Start();
            extractISO.WaitForExit();
            checkIfDecompiled();
        }

        private void btnPatch_Click(object sender, EventArgs e)
        {
            if (extracted == true)
            {
                isoPatcher patchISO = new isoPatcher();
                patchISO.patchIso2(lvwRiivolution, gamesPath, isoPath, riivoPath + "//riivolution/" + cbxRiivolutionXML.SelectedItem.ToString() + ".xml", riivoPath);
                File.WriteAllText(gamesPath + "/rii/" + Path.GetFileName(gamesPath + "/" + Path.GetFileNameWithoutExtension(isoPath)) + "/virgin", "no");
            }
            else
            {
                MessageBox.Show("The ISO is not yet extracted. Please wait.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cbxRiivolutionXML_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxChoices.DataSource = null;
            cbxChoices.DataBindings.Clear();
            txtPatch.Text = "";
            parseXML xmlParser = new parseXML();
            xmlParser.newXMLparser(riivoPath + "//riivolution/" + cbxRiivolutionXML.SelectedItem.ToString() + ".xml", lvwRiivolution, choicelist, patchlist);
        }

        private void lvwRiivolution_SelectedIndexChanged(object sender, EventArgs e)
        {
            parseXML xmlParser = new parseXML();
            xmlParser.getInformation(lvwRiivolution, cbxChoices, txtPatch, choicelist, patchlist);
        }

        private void cbxChoices_SelectedIndexChanged(object sender, EventArgs e)
        {
            parseXML xmlParser = new parseXML();
            xmlParser.getPatchFromCombobox(cbxChoices, txtPatch, patchlist, lvwRiivolution);
        }

        private void selectDolphinPathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dolphinBrowser = new OpenFileDialog();
            dolphinBrowser.Filter = "Dolphin Executables|Dolphin.exe";
            dolphinBrowser.Title = "Browsing for Dolphins.. lolol";

            if (dolphinBrowser.ShowDialog() == DialogResult.OK)
            {
                dolphinPath = dolphinBrowser.FileName;
            }
        }

        private void launchInDolphinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(dolphinPath == ""))
            {
                if (!(lbxGames.SelectedIndex == -1))
                {
                    dolBrew dolPatcher = new dolBrew(this);
                    dolPatcher.Show();
                }
                else
                {
                    MessageBox.Show("Please select a game from the list.");
                }

            }
            else { MessageBox.Show("You haven't selected your Dolphin emulator path yet!"); }

        }

        private void btnDebug_Click(object sender, EventArgs e)
        {
            dolPatcher banaan = new dolPatcher();
            MessageBox.Show(banaan.toHex(isoPath));
            //banaan.copySave(banaan.toHex(isoPath), dolphinPath);

            banaan.writeSaveFiles("C:/Documenten/Dolphin Emulator/Wii/title/00010000/524d4750");
        }

        private void dolphinMain_Load(object sender, EventArgs e)
        {

        }
    }
}
