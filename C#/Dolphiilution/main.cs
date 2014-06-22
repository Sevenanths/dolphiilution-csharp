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
    public partial class frmMainForm : Form
    {
        public string isoPath;
        public string riivoPath;
        public List<string> choices = new List<string>();
        public Dictionary<int, string> choicePath = new Dictionary<int, string>();

        public frmMainForm()
        {
            InitializeComponent();
        }

        private void btnISO_Click(object sender, EventArgs e)
        {
            // loading the iso and checking if it exists

            OpenFileDialog isoOpener = new OpenFileDialog();
            isoOpener.Filter = "ISO files (*.iso) | *.iso";
            isoOpener.Title = "Select ISO..";

            if (isoOpener.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(isoOpener.FileName))
                {
                    txtISO.Text = isoOpener.FileName;
                    isoPath = isoOpener.FileName;

                    // reading the iso contents (ftl)
                    isoContentReader isoReader = new isoContentReader();
                    int lineint = 0;
                    using (StringReader reader = new StringReader(isoReader.readContents(isoPath)))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            lineint++;
                            if (lineint > 4) { 
                            ListViewItem item = new ListViewItem();
                            item.Text = System.IO.Path.GetFileName(line);
                            item.SubItems.Add(line);

                            lvwISO.Items.Add(item);}
                        }
                    }

                    }
                }
            }

        private void btnRiivolution_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog riivolutionPathPicker = new FolderBrowserDialog();
            riivolutionPathPicker.Description = "Select the folder (or drive, SD cards should work too!) where you have your Riivolution file structure saved.";

            if (riivolutionPathPicker.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (Directory.Exists(riivolutionPathPicker.SelectedPath + "//riivolution"))
                {
                    riivoPath = riivolutionPathPicker.SelectedPath;
                    txtRiivolution.Text = riivoPath;
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
            parseXML xmlParser = new parseXML();
            xmlParser.XMLparser(riivoPath + "//riivolution/" + cbxRiivolutionXML.SelectedItem.ToString() + ".xml", dgvRiivolution, choicePath);
        }

        private void frmMainForm_Load(object sender, EventArgs e)
        {
            choices.Add("Enabled");
            choices.Add("Disabled");

            clmChoice.DataSource = choices;
        }

        private void dgvRiivolution_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                try
                {
                    List<string> choices = new List<string>();
                    string[] choicesArray = choicePath[e.RowIndex].Split(';');
                    foreach (string choice in choicesArray)
                    {
                        choices.Add(choice);
                    }
                    clmChoice.DataSource = choices;
                }
                catch(Exception ex)
                {
                    Debug.WriteLine(ex);
                }
            }
        }

        private void dgvRiivolution_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void dgvRiivolution_DataSourceChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dgvRiivolution_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

 
        }
    }

