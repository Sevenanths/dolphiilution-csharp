using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;

namespace Dolphiilution
{
    class dolPatcher
    {
        private dolBrew brew;
        public void patchDol(string settingslocation, string isoPath, string dvdroot, string apploader, string dollocation, string dolphinpath)
        {
            StringBuilder newFile = new StringBuilder();

            string temp = "";

            string[] file = File.ReadAllLines(@settingslocation + "/Config/Dolphin.ini");

            foreach (string line in file)
            {

                if (line.Contains("DVDRoot = "))
                {

                    temp = line.Replace(line, "DVDRoot = " + dvdroot);

                    newFile.Append(temp + "\r\n");

                    continue;

                }

                if (line.Contains("Apploader = "))
                {

                    temp = line.Replace(line, "Apploader = " + apploader);

                    newFile.Append(temp + "\r\n");

                    continue;

                }

                newFile.Append(line + "\r\n");

            }

            File.WriteAllText(@settingslocation + "/Config/Dolphin.ini", newFile.ToString());


            checkSaveFiles(toHex(isoPath), settingslocation);


            Process dolphinproc = new Process();
            dolphinproc.StartInfo.FileName = dolphinpath;
            dolphinproc.StartInfo.Arguments = "/e \"" + dollocation + "\"";
            dolphinproc.Start();
        }
        public void checkSaveFiles(string hexid, string settingslocation)
        {
            string lastplayed = Application.StartupPath + "/dolphii/lastplayed";
            string dolphiisavepath = Application.StartupPath + "/dolphii/saves/";
      

            if (!(File.Exists(lastplayed))){
                File.Create(lastplayed).Dispose();
                File.WriteAllText(lastplayed, hexid);
            }
            else
            {
                if (!(File.ReadAllText(lastplayed) == hexid))
                {
                    writeSaveFiles(hexid);

                    string[] normalgamesD = Directory.GetDirectories(dolphiisavepath);
                    foreach (string game in normalgamesD)
                    {
                        if (game.Contains(hexid))
                        {
                            restoreSaveFiles(game);
                        }
                    }
                }
            }
        }

        public void writeSaveFiles(string hexid)
        {
            string dolphiisavepath = Application.StartupPath + "/dolphii/saves/";
            string lastplayed = Application.StartupPath + "/dolphii/lastplayed";


            CopyDir(System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/Dolphin Emulator/Wii/title/ffffffff/ffffffff", dolphiisavepath + "/" + hexid);
            File.WriteAllText(lastplayed, hexid);
       }
        public void restoreSaveFiles(string originalpath)
        {
            CopyDir(originalpath, System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/Dolphin Emulator/Wii/title/ffffffff/ffffffff");
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
        public void finish()
        {
            brew.pbxWindots.Image = null;
        }
        public static void CopyDir(string source, string target)
        {
            Console.WriteLine("\nCopying Directory:\n  \"{0}\"\n-> \"{1}\"", source, target);

            if (!Directory.Exists(target)) Directory.CreateDirectory(target);
            string[] sysEntries = Directory.GetFileSystemEntries(source);

            foreach (string sysEntry in sysEntries)
            {
                string fileName = Path.GetFileName(sysEntry);
                string targetPath = Path.Combine(target, fileName);
                if (Directory.Exists(sysEntry))
                    CopyDir(sysEntry, targetPath);
                else
                {
                    Console.WriteLine("\tCopying \"{0}\"", fileName);
                    File.Copy(sysEntry, targetPath, true);
                }
            }
        }
    }
}
