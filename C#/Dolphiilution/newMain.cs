using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;


namespace Dolphiilution
{
    public partial class newMain : Form
    {
        public string isoPath;
        public string riivoPath;
        public List<string> choicelist = new List<string>();
        public List<string> patchlist = new List<string>();
        public bool extracted = false;
        public newMain()
        {
            InitializeComponent();
        }

        private void loadISOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // loading the iso and checking if it exists

            OpenFileDialog isoOpener = new OpenFileDialog();
            isoOpener.Filter = "ISO files (*.iso) | *.iso";
            isoOpener.Title = "Select ISO..";

            if (isoOpener.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(isoOpener.FileName))
                {
                    isoPath = isoOpener.FileName;

                    bgwExtractISO.RunWorkerAsync();
                }
            }
        }

        private void loadRiivolutionFileStructureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog riivolutionPathPicker = new FolderBrowserDialog();
            riivolutionPathPicker.Description = "Select the folder (or drive, SD cards should work too!) where you have your Riivolution file structure saved.";

            if (riivolutionPathPicker.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (Directory.Exists(riivolutionPathPicker.SelectedPath + "//riivolution"))
                {
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

        private void cbxChoices_DataSourceChanged(object sender, EventArgs e)
        {
            /*
			*The following code is required to remove 
			*existing items from the Items collection
			*when the DataSource is set to null.
			*/


            if (cbxChoices.DataSource == null)
            {
                cbxChoices.Items.Clear();
            }
        }

        private void btnPatch_Click(object sender, EventArgs e)
        {
            if (extracted == true)
            {
                isoPatcher patchISO = new isoPatcher();
                patchISO.patchIso(lvwRiivolution, Application.StartupPath + "/lol.iso", riivoPath + "//riivolution/" + cbxRiivolutionXML.SelectedItem.ToString() + ".xml", riivoPath);
            }
            else
            {
                MessageBox.Show("The ISO is not yet extracted. Please wait.","",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bgwExtractISO_DoWork(object sender, DoWorkEventArgs e)
        {
            if (MessageBox.Show("Is the game you are modifying the same as the last one you modified using this program? When 'Yes' is pressed, I will skip the extraction of the ISO.", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                extracted = true;
            }
            else
            {
                if (Directory.Exists(Application.StartupPath + "/ex"))
                {
                    Directory.Delete(Application.StartupPath + "/ex", true);
                }
                Process extractISO = new Process();
                extractISO.StartInfo.Arguments = "extract \"" + isoPath + "\" \"" + Application.StartupPath + "/ex";
                extractISO.StartInfo.FileName = Application.StartupPath + "/WIT/wit.exe";

                extractISO.Start();
                extractISO.WaitForExit();
                extracted = true;
                MessageBox.Show("ISO extracted!");
            }
        }

        private void newMain_Load(object sender, EventArgs e)
        {

        }

        
    }
}
