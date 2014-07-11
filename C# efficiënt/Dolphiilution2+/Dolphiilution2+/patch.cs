using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

namespace Dolphiilution2_
{
    class patch
    {
        public void patchParse(string activexmlname, string inputxml, string riifolderpath, string sdcardpath, string region, ComboBox cbx)
        {
            //

            string apppath = Application.StartupPath;
            string dataprefix;
            string sysprefix;
            string backuppath = apppath + "/backups/" + Path.GetFileNameWithoutExtension(cbx.Text);

            if (Directory.Exists(riifolderpath + "/DATA/"))
            {
                dataprefix = "/DATA/files/";
                sysprefix = "/DATA/sys/";
            }
            else
            {
                dataprefix = "/files/";
                sysprefix = "/sys/";
            }
            
            // RESTORE BACKUP FROM LAST TIME!!!!
            if (Directory.Exists(backuppath))
            {
                CopyDir(backuppath, riifolderpath);
                Directory.Delete(backuppath, true);
            }

            string dollocation = riifolderpath + dataprefix + "main.dol";
            string dvdroot = riifolderpath + dataprefix;
            string apploader = riifolderpath + dataprefix + "apploader.img";

            File.Copy(riifolderpath + sysprefix + "main.dol", dollocation, true);
            File.Copy(riifolderpath + sysprefix + "apploader.img", apploader, true);

            // listing every single file in the iso for free patches (like the My stuff folder in CTGP)
            string[] allfiles = Directory.GetFiles(riifolderpath + dataprefix,"*.*",SearchOption.AllDirectories);

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
                                                    string fullpatchpath = sdcardpath + root + "/" + external;

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
                                                        CopyDir(fullpatchpath, riifolderpath + dataprefix + disc);
                                                    }
                                                    else // if it is a free folder patch, we're going to have to do it the hard way (I couldn't find a better way for this but feel free to correct)
                                                    {
                                                        string[] filesinpatchfolder = Directory.GetFiles(fullpatchpath); // get an array of all the files in the folder
                                                        foreach (string patchfile in filesinpatchfolder)
                                                        {
                                                            foreach (string discfile in allfiles)
                                                            {
                                                                if (Path.GetFileName(patchfile) == Path.GetFileName(discfile)) // check if the filename the patch file is the same as one from the disk
                                                                {
                                                                    File.Copy(patchfile, discfile, true); // copy if yes
                                                                }
                                                            }
                                                        }
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

                                                string output;
   /* MEMORY PATCH STARTS HERE */               Process wit = new Process();
                                                wit.StartInfo.FileName = Application.StartupPath + "/WIT/wit.exe";
                                                wit.StartInfo.Arguments = "dolpatch \"" + dollocation + "\" xml=" + inputxml;
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
