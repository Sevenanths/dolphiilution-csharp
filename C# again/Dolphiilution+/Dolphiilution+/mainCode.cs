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
                if (Path.GetFileName(game).ToLower().Contains(".iso") || Path.GetFileName(game).ToLower().Contains("wbfs")) // seeing if there isn't other junk inside the folder
                {
                    cbxGames.Items.Add(Path.GetFileName(game));
                }
            }
        }
        public void checkIfDecompiled(string gamespath, ComboBox cbx, Button btnDecompiled, Button btnOpenPatch, Button btnLaunch, PictureBox pbxBoxart, PictureBox pbxRegion)
        {
            if (Directory.Exists(gamespath + "/rii/" + Path.GetFileNameWithoutExtension(cbx.Text))) // if the game's mod folder already exists, 
            {
                btnDecompiled.Enabled = true;
                btnDecompiled.Text = "Reset";
                btnOpenPatch.Enabled = true;
                btnLaunch.Enabled = true;
            }
            else                                                                                    // if not, do the same but in reverse
            {
                btnDecompiled.Enabled = true;
                btnDecompiled.Text = "Decompile";
                btnOpenPatch.Enabled = false;
                btnLaunch.Enabled = false;
            }
            extras boxartyay = new extras();                                                        // initialize the right shenanigans 
            postpatch hex = new postpatch();
            boxartyay.getboxart(generateGameID(gamespath + "/" + cbx.Text), pbxBoxart, pbxRegion);  // grab the boxart and region (I like this feature so much omg)
        }
        public void decompileButtonAction(string gamespath, ComboBox cbx, Button btn)
        {
            if (btn.Text == "Reset")                                                                // dunno how I could've done this better, but this action removes the /rii/$isoname directory completely
            {
                if (MessageBox.Show("You're about to remove all your patches you have applied to this specific game. Are you sure you want to continue?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Directory.Delete(gamespath + "/rii/" + Path.GetFileNameWithoutExtension(cbx.Text), true);
                }
            }
            else if (btn.Text == "Decompile")                                                       //
            {
                decompileForm decompile = new decompileForm();                                      // again, initializing
                //decompile.Show();
                decompileGame(gamespath, cbx);                                                      // decompile the game
                //decompile.Close();
            }
        }
        public void openPatchFolder(string gamesPath, ComboBox cbx)
        {

        }
        public void decompileGame(string gamesPath, ComboBox cbx)
        {
            string isoPath = gamesPath + "/" + cbx.Text; // I should've had a better solution to do this, but oh well.

            Process extractISO = new Process();

            //Debug.WriteLine("extract \"" + isoPath + "\" \"" + gamesPath + "/rii/" + Path.GetFileName(gamesPath + "/" + Path.GetFileNameWithoutExtension(isoPath)) + "\"");
            extractISO.StartInfo.Arguments = "extract \"" + isoPath + "\" \"" + gamesPath + "/rii/" + Path.GetFileName(gamesPath + "/" + Path.GetFileNameWithoutExtension(isoPath)) + "\""; /* setting up arguments (looks complicated but all it is is a bunch of escape characters lol */
            extractISO.StartInfo.WindowStyle = ProcessWindowStyle.Hidden; // making sure you don't see it
            extractISO.StartInfo.CreateNoWindow = true; // same
            extractISO.StartInfo.FileName = Application.StartupPath + "/WIT/wit.exe";

            extractISO.Start(); /* starting WIT and making it do everything it needs to do */
            extractISO.WaitForExit();
        }
        public string generateGameID(string isopath)
        {
            string output = string.Empty; // general setup
            string error = string.Empty;

            Process wit = new Process();                                           //long code just to fetch a game id
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
