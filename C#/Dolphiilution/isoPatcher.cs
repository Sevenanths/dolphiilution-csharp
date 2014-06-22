using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Diagnostics;
using System.ComponentModel;


namespace Dolphiilution
{
    class isoPatcher
    {
        private static BackgroundWorker worker = new BackgroundWorker();
        public void patchIso(ListView lvw, string outputpath, string inputxml, string inputfolder)
        {    
            foreach (ListViewItem item in lvw.Items)
            {
                string optionName = item.Text;
                string choiceName = item.Tag.ToString();

                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(inputxml);

                XmlNodeList sections = xmlDoc.SelectNodes("//wiidisc/options/section");
                string patchid = "";
                foreach (XmlNode section in sections)
                {
                    parseXML xmlParser = new parseXML();
                    XmlNodeList options = xmlDoc.SelectNodes(xmlParser.GetXPathToNode(section) + "/node()");
                    foreach (XmlNode option in options)
                    {
                        if (option.Attributes["name"].Value == item.Text)
                        {
                            XmlNodeList choices = xmlDoc.SelectNodes(xmlParser.GetXPathToNode(option) + "/node()");
                            foreach (XmlNode choice in choices)
                            {
                                
                                if (choice.Attributes["name"].Value == item.Tag.ToString())
                                {
                                    patchid = xmlDoc.SelectSingleNode(xmlParser.GetXPathToNode(choice) + "/node()").Attributes["id"].Value;

                                    XmlNodeList patches = xmlDoc.SelectNodes("//wiidisc/patch");
                                    foreach (XmlNode patch in patches)
                                    {
                                        if (patch.Attributes["id"].Value == patchid)
                                        {
                                            {
                                                XmlNodeList folders = xmlDoc.SelectNodes(xmlParser.GetXPathToNode(patch) + "/node()");
                                                foreach (XmlNode folder in folders)
                                                {
                                                    string external = folder.Attributes["external"].Value;
                                                    string disc = "";
                                                    try
                                                    {
                                                       disc = folder.Attributes["disc"].Value;
                                                    }
                                                    catch {}

                                                    if (!(disc == ""))
                                                    {
                                                        MessageBox.Show(inputfolder + external, Application.StartupPath + "/ex" + disc);
                                                        CopyDir(@inputfolder + external, Application.StartupPath + "/ex" + disc);

                                                        worker.RunWorkerAsync();
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
        }
        public void patchIso2(ListView lvw, string gamesPath, string isoPath, string inputxml, string inputfolder)
        {
            foreach (ListViewItem item in lvw.Items)
            {
                string optionName = item.Text;
                string choiceName = item.Tag.ToString();

                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(inputxml);

                XmlNodeList sections = xmlDoc.SelectNodes("//wiidisc/options/section");
                string patchid = "";
                foreach (XmlNode section in sections)
                {
                    parseXML xmlParser = new parseXML();
                    XmlNodeList options = xmlDoc.SelectNodes(xmlParser.GetXPathToNode(section) + "/node()");
                    foreach (XmlNode option in options)
                    {
                        if (option.Attributes["name"].Value == item.Text)
                        {
                            XmlNodeList choices = xmlDoc.SelectNodes(xmlParser.GetXPathToNode(option) + "/node()");
                            foreach (XmlNode choice in choices)
                            {

                                if (choice.Attributes["name"].Value == item.Tag.ToString())
                                {
                                    patchid = xmlDoc.SelectSingleNode(xmlParser.GetXPathToNode(choice) + "/node()").Attributes["id"].Value;

                                    XmlNodeList patches = xmlDoc.SelectNodes("//wiidisc/patch");
                                    foreach (XmlNode patch in patches)
                                    {
                                        if (patch.Attributes["id"].Value == patchid)
                                        {
                                            {
                                                XmlNodeList folders = xmlDoc.SelectNodes(xmlParser.GetXPathToNode(patch) + "/node()");
                                                foreach (XmlNode folder in folders)
                                                {
                                                    if (folder.Name == "folder")
                                                    {
                                                        string external = folder.Attributes["external"].Value;
                                                        string disc = "";
                                                        try
                                                        {
                                                            disc = folder.Attributes["disc"].Value;
                                                        }
                                                        catch { }

                                                        if (Directory.Exists(Path.GetFileName(gamesPath + "/rii/" + Path.GetFileNameWithoutExtension(isoPath)) + "/DATA/")) {         
                                                            MessageBox.Show(@inputfolder + external, gamesPath + "/rii/" + Path.GetFileName(gamesPath + "/" + Path.GetFileNameWithoutExtension(isoPath)) + "/DATA/files/" + disc);
                                                            CopyDir(@inputfolder + external, gamesPath + "/rii/" + Path.GetFileName(gamesPath + "/" + Path.GetFileNameWithoutExtension(isoPath)) + "/DATA/files/" + disc);

                                                            //worker.RunWorkerAsync();
                                                        }
                                                        else
                                                        {
                                                            CopyDir(@inputfolder + external, gamesPath + "/rii/" + Path.GetFileName(gamesPath + "/" + Path.GetFileNameWithoutExtension(isoPath)) + "/files/" + disc);
                                                        }
                                                    }

                                                    if (folder.Name == "file")
                                                    {
                                                        string external = folder.Attributes["external"].Value;
                                                        string disc = "";

                                                         try
                                                        {
                                                            disc = folder.Attributes["disc"].Value;
                                                        }
                                                         catch { }
                                                         if (!(disc == ""))
                                                         {
                                                             //MessageBox.Show(@inputfolder + external, gamesPath + "/rii/" + Path.GetFileName(gamesPath + "/" + Path.GetFileNameWithoutExtension(isoPath)) + "/DATA/files/" + disc);
                                                             if (Directory.Exists(Path.GetFileName(gamesPath + "/rii/" + Path.GetFileNameWithoutExtension(isoPath)) + "/DATA/"))
                                                             {
                                                                 File.Copy(@inputfolder + external, Path.GetFileName(gamesPath + "/" + Path.GetFileNameWithoutExtension(isoPath)) + "/DATA/files/" + disc);
                                                             }
                                                             else
                                                             {
                                                                 File.Copy(@inputfolder + external, Path.GetFileName(gamesPath + "/" + Path.GetFileNameWithoutExtension(isoPath)) + "/files/" + disc);
                                                             }
                                                             //worker.RunWorkerAsync();
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
            }
        }
        static void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            MessageBox.Show("started");
            
            Process createISO = new Process();
            createISO.StartInfo.FileName = Application.StartupPath + "/WIT/wit.exe";
            createISO.StartInfo.Arguments = "copy \"" + Application.StartupPath + "/ex/\" \"" + Application.StartupPath + "/test.ISO\"";
            createISO.Start();

            createISO.WaitForExit();
            MessageBox.Show("Done.");
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
