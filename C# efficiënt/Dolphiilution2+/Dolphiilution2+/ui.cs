using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

namespace Dolphiilution2_
{
    class ui
    {
        public void populateGamesList(string gamesdirectory, ComboBox cbxGames)
        {
            cbxGames.Items.Clear(); // removing all items - in case of switching between gc and Wii (or empty!)
            if (!(gamesdirectory == "")) // if no platform is selected just leave everything blank
            {
            if (!(Directory.Exists(gamesdirectory + "/rii"))) // if the folder for mods doesn't exist, create it (important, as all the mods go here)
            {
                Directory.CreateDirectory(gamesdirectory + "/rii");
            }

            string[] games = Directory.GetFiles(gamesdirectory); // get all the files in the directory, see if they're compatible and add them to the listbox
            foreach (string game in games)
            {
                if (Path.GetExtension(game).ToLower() == ".iso" || Path.GetExtension(game).ToLower() == ".wbfs" || Path.GetExtension(game).ToLower() == ".gcm")
                {
                    cbxGames.Items.Add(Path.GetFileName(game));
                }
            }
          }
        }

        public void checkAndBoxart(string isopath, string riifolder, Button btnDecompiled, Button btnOpenPatch, Button btnLaunch, PictureBox pbxBoxart, PictureBox pbxRegion)
        {
            // check if the game has been decompiled earlier, and if so, change the according buttons
            if (Directory.Exists(riifolder + "/" + Path.GetFileNameWithoutExtension(isopath)))
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

            string gameid = generateGameID(isopath);

            // grabbing the boxart (my favorite part!!!)
            if (gameid == "")
            {
                pbxBoxart.Image = null;
                pbxRegion.Image = null;
            }
            else
            {
                pbxBoxart.Load("http://www.wiiboxart.com/artwork/cover/" + gameid.Replace(System.Environment.NewLine, "") + ".png");
                switch (gameid[3].ToString())
                {
                    case "P": pbxRegion.Image = Properties.Resources.pal;
                        break;
                    case "E": pbxRegion.Image = Properties.Resources.ntsc;
                        break;
                    case "J": pbxRegion.Image = Properties.Resources.ntscj;
                        break;
                }
            }
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
        public void decompileGame(string isopath, string riifolderpath)
        {
            Process extractISO = new Process();

            //Debug.WriteLine("extract \"" + isoPath + "\" \"" + gamesPath + "/rii/" + Path.GetFileName(gamesPath + "/" + Path.GetFileNameWithoutExtension(isoPath)) + "\"");
            extractISO.StartInfo.Arguments = "extract \"" + isopath + "\" \"" + riifolderpath + Path.GetFileNameWithoutExtension(isopath) + "\""; /* setting up arguments (looks complicated but all it is is a bunch of escape characters lol */
            extractISO.StartInfo.WindowStyle = ProcessWindowStyle.Hidden; // making sure you don't see it
            extractISO.StartInfo.CreateNoWindow = true; // same
            extractISO.StartInfo.FileName = Application.StartupPath + "/WIT/wit.exe";
            extractISO.Start(); /* starting WIT and making it do everything it needs to do */
            extractISO.WaitForExit();
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
