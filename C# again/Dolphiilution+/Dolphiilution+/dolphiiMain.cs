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

namespace Dolphiilution_
{
    public partial class dolphiiMain : Form
    {
        //public List<string> choicelist = new List<string>();
        //public List<string> patchlist = new List<string>();

        string[] choices;
        string[] patches;
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
            parseXML xmlParser = new parseXML();
            xmlParser.generateXML(Properties.Settings.Default.riivopath + "//riivolution/" + cbxXML.SelectedItem.ToString() + ".xml", lvwOptions);
        }

        private void lvwOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            parseXML bla = new parseXML();
            bla.populateChoices(lvwOptions, cbxChoices, choices);
        }

        private void cbxChoices_SelectedIndexChanged(object sender, EventArgs e)
        {
            parseXML patch = new parseXML();
            patch.populatePatches(lvwOptions, cbxChoices, txtPatch, choices, patches);
        }
    }
}
