using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Diagnostics;

namespace Dolphiilution_
{
    class patch
    {
        public void patchParse(string activexmlname, string inputxml, string riifolderpath, string sdcardpath, string region, ComboBox cbx)
        {
            //

            string apppath = Application.StartupPath;
            string dataprefix;
            string backuppath = apppath + "/backups/" + Path.GetFileNameWithoutExtension(cbx.Text);

            if (Directory.Exists(riifolderpath + "/DATA/"))
            {
                dataprefix = "/DATA/files/";
            }
            else
            {
                dataprefix = "/files/";
            }
            
            // RESTORE BACKUP FROM LAST TIME!!!!
            if (Directory.Exists(backuppath))
            {
                CopyDir(backuppath, riifolderpath);
                Directory.Delete(backuppath, true);
            }

            parseXML xmlParser = new parseXML();
            // DETERMINING THE ID FOR EACH PATH FROM THE XML (I could've done this earlier in the code but whatevs)
            string[] xmllines = File.ReadAllLines(apppath + activexmlname);

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(inputxml);

            string root = "/";

            if (!(xmlDoc.SelectSingleNode("//wiidisc").Attributes["root"] == null))
            {
            root = xmlDoc.SelectSingleNode("//wiidisc").Attributes["root"].Value + "/";
            }


            foreach (string line in xmllines)
            {
                string sectionname = line.Split('|')[1];
                string optionname = line.Split('|')[2];
                string choicename = line.Split('|')[3].Split(';')[0];

                string patchid = "";

                XmlNodeList sections = xmlDoc.SelectNodes("//wiidisc/options/section");
                foreach (XmlNode section in sections)
                {
                    XmlNodeList options = xmlDoc.SelectNodes(xmlParser.GetXPathToNode(section) + "/node()");
                    foreach (XmlNode option in options)
                    {
                        if (option.Attributes["name"].Value == optionname)
                        {
                            XmlNodeList choices = xmlDoc.SelectNodes(xmlParser.GetXPathToNode(option) + "/node()");
                            foreach (XmlNode choice in choices)
                            {
                                if (choice.Attributes["name"].Value == choicename)
                                {
                                    patchid = xmlDoc.SelectSingleNode(xmlParser.GetXPathToNode(choice) + "/node()").Attributes["id"].Value;

                                    // PATCH PART
                                    // searching the correct information for the patches (eg what to copy and where to)
                                    XmlNodeList patches = xmlDoc.SelectNodes("//wiidisc/patch");
                                    foreach (XmlNode patch in patches)
                                    {
                                        if (patch.Attributes["id"].Value == patchid)
                                        {
                                            XmlNodeList filesfolders = xmlDoc.SelectNodes(xmlParser.GetXPathToNode(patch) + "/node()");
                                            foreach (XmlNode filefolder in filesfolders)
                                            {
    /* FOLDER PATCH STARTS HERE*/              if (filefolder.Name == "folder")
                                                {                                              
                                                    string disc = "";
                                                    string external = filefolder.Attributes["external"].Value.Replace("{$__region}", region);

                                                    if (!(filefolder.Attributes["disc"] == null)){
                                                        disc = filefolder.Attributes["disc"].Value;

                                                        bool create = false;
                                                        if (!(filefolder.Attributes["create"] == null))
                                                        {
                                                            if ((filefolder.Attributes["create"].Value == "true"))
                                                            {
                                                                create = true;
                                                            }
                                                        }

                                                        string fullpatchpath = sdcardpath + root + "/" + external;

                                                        if (create == false)
                                                        {
                                                           

                                                            string[] filesinpatchfolder = Directory.GetFiles(fullpatchpath);
                                                            foreach (string file in filesinpatchfolder)
                                                            {
                                                                string patchfilename = Path.GetFileName(file);

                                                                if (File.Exists(riifolderpath + dataprefix + disc + "/" + patchfilename))
                                                                {
                                                                    Directory.CreateDirectory(backuppath + disc);
                                                                    File.Copy(riifolderpath + dataprefix + disc + "/" + patchfilename, backuppath + disc + "/" + patchfilename, true);
                                                                }
                                                            }
                                                        }
                                                        //MessageBox.Show(fullpatchpath + "\n" + riifolderpath + disc);
                                                        CopyDir(fullpatchpath, riifolderpath + disc);
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Dolphiilution does not support folder patches without disc folder given yet! Will continue anyway. Can't garantuee if your ISO will work.", "Aww snap!");
                                                    }
                                                }
   /* FILE PATCH STARTS HERE*/                  if (filefolder.Name == "file")
                                                {
                                                    string disc = "";
                                                    disc = filefolder.Attributes["disc"].Value;
                                                    string external = "";
                                                    external = filefolder.Attributes["external"].Value;


                                                    bool create = false;
                                                    if (!(filefolder.Attributes["create"] == null))
                                                    {
                                                        if ((filefolder.Attributes["create"].Value == "true"))
                                                        {
                                                            create = true;
                                                        }
                                                    }
                                                    if (create == false)
                                                    {
                                                        if (File.Exists(riifolderpath + dataprefix + disc))
                                                        {
                                                            System.IO.Directory.CreateDirectory(Path.GetDirectoryName(backuppath + disc));
                                                            File.Copy(riifolderpath + dataprefix + disc, backuppath + disc, true);
                                                        }
                                                    }
                                                    //MessageBox.Show(sdcardpath + root + "/" + external + "\n" + riifolderpath + dataprefix + disc);
                                                    File.Copy(sdcardpath + root + "/" + external, riifolderpath + dataprefix + disc);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        public void determineIfDATA(string gamespath, ComboBox cbx)
        {
            dolphiiMain dolphinMain = new dolphiiMain();
        }
        public string determineRegion(string isopath)
        {
            string output = string.Empty;
            string error = string.Empty;

            Process wit = new Process();
            wit.StartInfo.FileName = Application.StartupPath + "/WIT/wit.exe";
            wit.StartInfo.Arguments = "list -l " + "\"" + isopath + "\"";
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

            if (output.Contains("PAL"))
            {
                return "P";
            }
            if (output.Contains("NTSC-J"))
            {
                return "J";
            }
            if (output.Contains("NTSC"))
            {
                return "E";
            }
            return "";
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

  