using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

namespace Dolphiilution_
{
    class postpatch
    {
        public void copyDol(string riifolderpath, string isopath) // applying StapleButter's Dolphin filetree hack here! Props to SB (previously known as Mega-Mario) for this! Also, thanks a bunch for hosting a community for us dramakids on Kuribo64! Hugs <3
        {
            string filesprefix;
            string sysprefix;

            if (Directory.Exists(riifolderpath + "/DATA/"))
            {
                filesprefix = "/DATA/files/";
                sysprefix = "/DATA/sys/";
            }
            else
            {
                filesprefix = "/files/";
                sysprefix = "/sys/";
            }

            string dollocation = riifolderpath + filesprefix + "main.dol";
            string dvdroot = riifolderpath + filesprefix;
            string apploader = riifolderpath + filesprefix + "apploader.img";

            File.Copy(riifolderpath + sysprefix + "main.dol", dollocation, true);
            File.Copy(riifolderpath + sysprefix + "apploader.img", apploader, true);

            dolphinIniHaxx0rz(dollocation, dvdroot, apploader, Properties.Settings.Default.globaluserpath, isopath);
        }
        public void dolphinIniHaxx0rz(string dollocation, string dvdroot, string apploader, string dolphinglobaluserfolder, string isopath)
        {
            string configurationfile = dolphinglobaluserfolder + "/Config/Dolphin.ini";
            string[] configlines = File.ReadAllLines(configurationfile);
            int counter = 0;
            foreach (string configline in configlines)
            {
                // I'm going to have to use regular if statements because 'switch' apparently does not support this. "bleh" - Count Bleck

                if (configline.Contains("DVDRoot = "))
                {
                    configlines[counter] = "DVDRoot = " + dvdroot;
                }
                if (configline.Contains("Apploader = "))
                {
                    configlines[counter] = "Apploader = " + apploader;
                }
                counter++;
            }
            File.WriteAllLines(configurationfile, configlines);

            checkSaveFiles(toHex(isopath), isopath, Properties.Settings.Default.globaluserpath);
            
            // time to finally run the Dolphins! :3

            Process dolphinproc = new Process();
            dolphinproc.StartInfo.FileName = Properties.Settings.Default.dolphinpath;
            dolphinproc.StartInfo.Arguments = "/e \"" + dollocation + "\"";
            dolphinproc.Start();

        }
        public void checkSaveFiles(string hexid, string isopath, string globaluserdirectory)
        {
            string apppath = Application.StartupPath;

            string lastplayed = apppath + "/settings/lastplayed";
            string lastisoplayed = apppath + "/settings/lastisoplayed";
            string savespath = apppath + "/saves/";

            if (!(File.Exists(lastplayed)))
            {
                File.Create(lastplayed).Dispose();
                File.WriteAllText(lastplayed, hexid);
                File.WriteAllText(lastisoplayed, isopath);
            }
            else
            {
                if (!(File.ReadAllText(lastplayed) == hexid))
                {
                    // writing the save file back from the ffffffff folder to the magical Dolphii savegames collection, free of charge!
                    patch.CopyDir(globaluserdirectory + "/Wii/title/ffffffff/ffffffff", savespath + hexid);
                    File.WriteAllText(lastplayed, hexid);
                    File.WriteAllText(lastisoplayed, isopath);

                    // if a previous save file is recognised, grab it and restore it to the ffffffff folder
                    string[] savefilesfolder = Directory.GetDirectories(savespath);
                    foreach (string savefile in savefilesfolder)
                    {
                        if (savefile.Contains(hexid))
                        {
                            patch.CopyDir(savefile, globaluserdirectory + "/Wii/title/ffffffff/ffffffff"); // that's what's happening here btw
                        }
                    }
                }
            }
        }
        public string toHex(string isoPath)
        {
            string output = string.Empty;
            string error = string.Empty;

            Process wit = new Process();
            wit.StartInfo.FileName = Application.StartupPath + "/WIT/wit.exe";
            wit.StartInfo.Arguments = "id " + "\"" + isoPath + "\"";
            wit.StartInfo.RedirectStandardError = true;
            wit.StartInfo.RedirectStandardOutput = true;
            wit.StartInfo.UseShellExecute = false;
            wit.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            wit.StartInfo.CreateNoWindow = true;
            wit.Start();

            using (StreamReader streamReader = wit.StandardOutput)
            {
                output = streamReader.ReadToEnd();
            }

            string symbols = " !\"#$%&'()*+,-./0123456789:;<=>?@";
            string loAZ = "abcdefghijklmnopqrstuvwxyz";
            symbols += loAZ.ToUpper();
            symbols += "[\\]^_`";
            symbols += loAZ;
            symbols += "{|}~";

            string valueStr = output.Substring(0, 4);
            string hexChars = "0123456789abcdef";
            string text = "";
            for (int i = 0; i < valueStr.Length; i++)
            {
                char oneChar = valueStr[i];
                int asciiValue = symbols.IndexOf(oneChar) + 32;
                int index1 = asciiValue % 16;
                int index2 = (asciiValue - index1) / 16;
                if (text != "") text += ":";
                text += hexChars[index2];
                text += hexChars[index1];
            }

            text = text.Replace(":", "");
            return text;
        }
    }
}
