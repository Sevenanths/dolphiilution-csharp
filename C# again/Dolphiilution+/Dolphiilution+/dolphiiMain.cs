using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Dolphiilution_
{
    public partial class dolphiiMain : Form
    {
        public List<string> choicelist = new List<string>();
        public List<string> patchlist = new List<string>();

        public string activesxmlname;

        //string[] choices;
        //string[] patches;
        public dolphiiMain()
        {
            InitializeComponent();
        }

        private void dolphiiMain_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.firstrun == true) //if this is the first time a user is using the program, we'll ask him/her to fill in the settings
            {
                firstRun settings = new firstRun(); // standard C# stuff
                settings.Show();
                MessageBox.Show("It looks like this is the first time you're running this program. Please fill in all settings.");
            }
            else
            {
                mainCode populate = new mainCode(); // if not, just populate all the lists
                populate.populateGamesList(Properties.Settings.Default.wiigamespath, cbxGames); //game list
                populate.generateXML(Properties.Settings.Default.riivopath, cbxXML); //XML list
            }
        }
        private void cbxGames_SelectedIndexChanged(object sender, EventArgs e)
        {
            mainCode mainCodes = new mainCode();
            //lblGameID.Text = getHex.generateGameID(Properties.Settings.Default.wiigamespath + "/" + cbxGames.SelectedItem.ToString());
            mainCodes.checkIfDecompiled(Properties.Settings.Default.wiigamespath, cbxGames, btnDecompiled, btnOpenPatch);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            firstRun settings = new firstRun(); //showing th esettings
            settings.Show();
        }

        private void cbxXML_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxChoices.DataSource = null;
            cbxChoices.DataBindings.Clear();
            txtPatch.Text = "";
            activesxmlname = "/configurations/" + cbxXML.SelectedItem.ToString() + ".txt";
            parseXML xmlParser = new parseXML();
            xmlParser.checkIfConfigExists(Properties.Settings.Default.riivopath + "//riivolution/" + cbxXML.SelectedItem.ToString() + ".xml", activesxmlname, lvwOptions, choicelist, patchlist);
        }

        private void lvwOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            parseXML bla = new parseXML();
            bla.populateChoices(lvwOptions, cbxChoices, choicelist, activesxmlname);
        }

        private void cbxChoices_SelectedIndexChanged(object sender, EventArgs e)
        {
            parseXML patch = new parseXML();
            patch.populatePatches(lvwOptions, cbxChoices, txtPatch, choicelist, patchlist, activesxmlname);
        }

        private void cbxChoices_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(lvwOptions.SelectedItems[0].Tag.ToString());
        }

        private void btnDecompiled_Click(object sender, EventArgs e)
        {
            mainCode mainCodes = new mainCode();
            mainCodes.decompileButtonAction(Properties.Settings.Default.wiigamespath, cbxGames, btnDecompiled);
            mainCodes.checkIfDecompiled(Properties.Settings.Default.wiigamespath, cbxGames, btnDecompiled, btnOpenPatch);
        }

        private void btnPatch_Click(object sender, EventArgs e)
        {
            patch isoPatch = new patch();
            isoPatch.determineIfDATA(Properties.Settings.Default.wiigamespath, cbxGames);
            isoPatch.patchParse(activesxmlname, Properties.Settings.Default.riivopath + "/riivolution/" + cbxXML.Text + ".xml", Properties.Settings.Default.wiigamespath + "/rii/" + Path.GetFileNameWithoutExtension(cbxGames.Text), Properties.Settings.Default.riivopath, "P", cbxGames);
        }
    }
}
