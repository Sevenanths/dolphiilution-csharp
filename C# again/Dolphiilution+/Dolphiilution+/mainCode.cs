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
        public void checkIfDecompiled(string gamespath, ComboBox cbx, Button btnDecompiled, Button btnOpenPatch)
        {
            if (Directory.Exists(gamespath + "/rii/" + Path.GetFileNameWithoutExtension(cbx.Text)))
            {
                btnDecompiled.Enabled = true;
                btnDecompiled.Text = "Remove patch";
                btnOpenPatch.Enabled = true;
            }
            else
            {
                btnDecompiled.Enabled = true;
                btnDecompiled.Text = "Decompile";
                btnOpenPatch.Enabled = false;
            }
        }
        public void decompileButtonAction(string gamespath, ComboBox cbx, Button btn)
        {
            if (btn.Text == "Remove patch")
            {
                if (MessageBox.Show("You're about to remove all your patches you have applied to this specific game. Are you sure you want to continue?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Directory.Delete(gamespath + "/rii/" + Path.GetFileNameWithoutExtension(cbx.Text), true);
                }
            }
            else if (btn.Text == "Decompile")
            {
                decompileForm decompile = new decompileForm();
                decompile.Show();
                decompileGame(gamespath, cbx);
                decompile.Close();
            }
        }
        public void googleImageSearch()
        { 
        
        }
        public void decompileGame(string gamesPath, ComboBox cbx)
        {
            string isoPath = gamesPath + "/" + cbx.Text;

            Process extractISO = new Process();

            Debug.WriteLine("extract \"" + isoPath + "\" \"" + gamesPath + "/rii/" + Path.GetFileName(gamesPath + "/" + Path.GetFileNameWithoutExtension(isoPath)) + "\"");
            extractISO.StartInfo.Arguments = "extract \"" + isoPath + "\" \"" + gamesPath + "/rii/" + Path.GetFileName(gamesPath + "/" + Path.GetFileNameWithoutExtension(isoPath)) + "\""; /* setting up arguments (looks complicated but all it is is a bunch of escape characters lol */
            extractISO.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            extractISO.StartInfo.CreateNoWindow = true;
            extractISO.StartInfo.FileName = Application.StartupPath + "/WIT/wit.exe";

            extractISO.Start(); /* starting WIT and making it do everything it needs to do */
            extractISO.WaitForExit();
        }
        public void decompileGame2(string gamesPath, ComboBox cbx)
        {
            string isoPath = gamesPath + "/" + cbx.Text;

             // Start the child process.
             Process p = new Process();
             // Redirect the output stream of the child process.
             p.StartInfo.UseShellExecute = false;
             p.StartInfo.RedirectStandardOutput = true;
             p.StartInfo.FileName = Application.StartupPath + "/WIT/wit.exe";
             p.StartInfo.Arguments = "extract \"" + isoPath + "\" \"" + gamesPath + "/rii/" + Path.GetFileName(gamesPath + "/" + Path.GetFileNameWithoutExtension(isoPath)) + "\""; /* setting up arguments (looks complicated but all it is is a bunch of escape characters lol */
             p.Start();
             // Do not wait for the child process to exit before
             // reading to the end of its redirected stream.
             // p.WaitForExit();
             // Read the output stream first and then wait.
             string output = p.StandardOutput.ReadToEnd();
             p.WaitForExit();
                        
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
