using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Dolphiilution2_
{
    public partial class frmDolphiiMain : Form
    {
        
        ui ui = new ui();
        parseXML xmlParser = new parseXML();
        patch patch = new patch();

        public string mode;
        public string region;
        public string isopath;
        public string riifolderpath;
        public string gamesfolder;

        public List<string> choicelist = new List<string>();
        public List<string> patchlist = new List<string>();

        public string activesxmlname;

        public frmDolphiiMain()
        {
            InitializeComponent();
        }

        private void lvwPlatform_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwPlatform.SelectedIndices.Count > 0)
            {
                switch (lvwPlatform.SelectedIndices[0])
                {
                    case 0: mode = "wii";
                        break;
                    case 1: mode = "gc";
                        break;
                }

                if (mode == "wii")
                {
                    ui.populateGamesList(Properties.Settings.Default.wiigamespath, cbxGames);
                    ui.generateXML(Properties.Settings.Default.sdpath, cbxXML);
                    riifolderpath = Properties.Settings.Default.wiigamespath + "/rii/";
                    gamesfolder = Properties.Settings.Default.wiigamespath;
                }
                if (mode == "gc")
                {
                    ui.populateGamesList(Properties.Settings.Default.gcgamespath, cbxGames);
                    ui.generateXML(Properties.Settings.Default.sdpath, cbxXML);
                    riifolderpath = Properties.Settings.Default.gcgamespath + "/rii/";
                    gamesfolder = Properties.Settings.Default.gcgamespath;
                }
            }
            else
            {
                mode = "";
                gamesfolder = "";
                riifolderpath = "";
                ui.populateGamesList("", cbxGames);
            }
        }

        private void frmDolphiiMain_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.firstrun == true)
            {
                MessageBox.Show("It looks like this is the first time you're running this program. Please fill in all settings and close the window.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                settings firstRun = new settings();
                firstRun.Show();
            }
        }

        private void cbxGames_SelectedIndexChanged(object sender, EventArgs e)
        {

            isopath = gamesfolder + "/" + cbxGames.Text;
            ui.checkAndBoxart(isopath, riifolderpath, btnDecompiled, btnOpenPatch, btnLaunch, pbxCoverArt, pbxRegion);
        }

        private void btnDecompiled_Click(object sender, EventArgs e)
        {
            ui.decompileGame(isopath, riifolderpath);
            ui.checkAndBoxart(isopath, riifolderpath, btnDecompiled, btnOpenPatch, btnLaunch, pbxCoverArt, pbxRegion);
        }

        private void cbxXML_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxChoices.DataSource = null;
            cbxChoices.DataBindings.Clear();
            txtPatch.Text = "";
            activesxmlname = "/configurations/" + cbxXML.SelectedItem.ToString() + ".txt";
            xmlParser.checkIfConfigExists(Properties.Settings.Default.sdpath + "/riivolution/" + cbxXML.Text + ".xml", activesxmlname, lvwOptions, choicelist, patchlist);
        }

        private void lvwOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            xmlParser.populateChoices(lvwOptions, cbxChoices, choicelist, activesxmlname);
        }

        private void cbxChoices_SelectedIndexChanged(object sender, EventArgs e)
        {
            xmlParser.populatePatches(lvwOptions, cbxChoices, txtPatch, choicelist, patchlist, activesxmlname);
        }

        private void btnPatch_Click(object sender, EventArgs e)
        {
            patch.patchParse(activesxmlname, Properties.Settings.Default.sdpath + "/riivolution/" + cbxXML.Text + ".xml", riifolderpath + Path.GetFileNameWithoutExtension(gamesfolder + "/" + cbxGames.Text), Properties.Settings.Default.sdpath, patch.determineRegion(isopath), cbxGames);         
        }

        private void btnLaunch_Click(object sender, EventArgs e)
        {
            if (!(cbxGames.Text == ""))
            {
                postpatch patchpost = new postpatch();
                patchpost.copyDol(gamesfolder + "/rii/" + Path.GetFileNameWithoutExtension(cbxGames.Text), gamesfolder + "/" + cbxGames.Text);
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            settings settings = new settings(); //showing the settings
            settings.Show();
        }
    }
}
