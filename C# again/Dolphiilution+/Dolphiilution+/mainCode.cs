using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

namespace Dolphiilution_
{
    class mainCode
    {
        public void populateGamesList(string wiigamespath, ComboBox cbxGames)
        {
            if (!(Directory.Exists(wiigamespath + "/rii"))) //checking if the rii folder exists, this is important as all the mods go there
            {
                Directory.CreateDirectory(wiigamespath + "/rii"); //creating it
            }
            cbxGames.Items.Clear(); //removing all items just in case
            string[] games = Directory.GetFiles(wiigamespath); //creating a list of all ISO and WBFS files, then displaying them in the combobox
            foreach (string game in games)
            {
                if (Path.GetFileName(game).ToLower().Contains(".iso") || Path.GetFileName(game).ToLower().Contains("wbfs"))
                {
                    cbxGames.Items.Add(Path.GetFileName(game));
                }
            }
        }
        public string generateGameID(string isopath)
        {
            string output = string.Empty; // general setup
            string error = string.Empty;

            Process wit = new Process();                                           //long complicated code just to fetch a game id
            wit.StartInfo.FileName = Application.StartupPath + "/WIT/wit.exe";
            wit.StartInfo.Arguments = "id " + "\"" + isopath + "\"";
            wit.StartInfo.RedirectStandardError = true;
            wit.StartInfo.RedirectStandardOutput = true;
            wit.StartInfo.UseShellExecute = false;
            wit.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            wit.StartInfo.CreateNoWindow = true;
            wit.Start();

            using (StreamReader streamReader = wit.StandardOutput)
            {
                output = streamReader.ReadToEnd();
                return output; //return the ID
            }
        }
        public void generateXML(string riivopath, ComboBox cbxXML)
        {
            if (Directory.Exists(riivopath + "//riivolution")) //check if the path selected is a valid one. If not it just won't work.
            {
                string[] files = Directory.GetFiles(riivopath + "//riivolution"); //generating a file list
                foreach (string file in files)
                {
                    if (file.ToLower().Contains(".xml"))
                    {
                        cbxXML.Items.Add(Path.GetFileNameWithoutExtension(file)); //adding all XML files
                    }
                }
            }
        }
    }
}
