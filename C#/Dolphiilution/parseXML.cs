using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Windows.Forms;
using System.IO;

namespace Dolphiilution
{
    class parseXML
    {
        public void XMLparser(string inputxml, DataGridView dgv, Dictionary<int, string> choicePath)
        {
            choicePath.Clear();
            dgv.Rows.Clear();

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(inputxml);

            //string option = xmlDoc.SelectSingleNode("//wiidisc/options/section/option").Attributes["name"].Value;
            //string choice = xmlDoc.SelectSingleNode("//wiidisc/options/section/option/choice").Attributes["name"].Value;
            //string patch = xmlDoc.SelectSingleNode("//wiidisc/options/section/option/choice/patch").Attributes["id"].Value;

            XmlNodeList sections = xmlDoc.SelectNodes("//wiidisc/options/section");
            foreach (XmlNode section in sections)
            {
                string sectionname = section.Attributes["name"].Value;
                XmlNodeList options = xmlDoc.SelectNodes(GetXPathToNode(section) + "/node()");
                int row = -1;
                string choicelist = "";
                foreach (XmlNode option in options)
                {
                    row++;

                    string optionname = option.Attributes["name"].Value;
                    XmlNodeList choices = xmlDoc.SelectNodes(GetXPathToNode(option) + "/node()");
                    foreach (XmlNode choice in choices)
                    {
                        string choicename = choice.Attributes["name"].Value;
                        if (choicelist == "")
                        {
                            choicelist = choicename;
                        }
                        else
                        {
                            choicelist += ";" + choicename;
                        }
                        XmlNode patch = xmlDoc.SelectSingleNode(GetXPathToNode(choice) + "/node()");
                        // {
                        string patchid = patch.Attributes["id"].Value;
                        /*choicePath.Add(choicename, patchid);*/
                        dgv.Rows.Add(sectionname, optionname, choicename, patchid);
                        // }
                    }
                    if (choicelist.Contains("Enabled"))
                    {
                        choicelist = "Enabled;Disabled";
                    }
                    choicePath.Add(row, choicelist);
                    choicelist = "";
                }

            }

            //string choice = node.ChildNodes[0].Attributes["name"].Value;
            //string patch = node.ChildNodes[0].ChildNodes[0].Attributes["id"].Value;
        }
        public void newXMLparser(string inputxml, ListView lvw, List<string> choicelist_, List<string> patchlist_)
        {
            choicelist_.Clear();
            patchlist_.Clear();

            lvw.Items.Clear();

            XmlDocument xmlDoc = new XmlDocument();
            try
            {
                xmlDoc.Load(inputxml);
            }
            catch { }

            //string option = xmlDoc.SelectSingleNode("//wiidisc/options/section/option").Attributes["name"].Value;
            //string choice = xmlDoc.SelectSingleNode("//wiidisc/options/section/option/choice").Attributes["name"].Value;
            //string patch = xmlDoc.SelectSingleNode("//wiidisc/options/section/option/choice/patch").Attributes["id"].Value;

            try { File.Delete(Application.StartupPath + "/temp.txt"); }
            catch { }
            FileStream file2 = File.Open(Application.StartupPath + "/temp.txt", FileMode.Create);
            file2.Close();

            try { File.Delete(Application.StartupPath + "/selected.txt"); }
            catch { }
            FileStream file4 = File.Open(Application.StartupPath + "/selected.txt", FileMode.Create);
            file4.Close();
            XmlNodeList sections = xmlDoc.SelectNodes("//wiidisc/options/section");
            foreach (XmlNode section in sections)
            {
                string sectionname = section.Attributes["name"].Value;
                XmlNodeList options = xmlDoc.SelectNodes(GetXPathToNode(section) + "/node()");
                int row = -1;
                string patchlist = "";
                string choicelist = "";
                string patchid = "";
                foreach (XmlNode option in options)
                {
                    patchlist = "";
                    choicelist = "";
                    patchid = "";
                    row++;

                    string optionname = option.Attributes["name"].Value;
                    XmlNodeList choices = xmlDoc.SelectNodes(GetXPathToNode(option) + "/node()");
                    foreach (XmlNode choice in choices)
                    {
                        string choicename = choice.Attributes["name"].Value;
                        if (choicelist == "")
                        {
                            choicelist = choicename;
                        }
                        else
                        {
                            choicelist += ";" + choicename;
                        }
                        XmlNode patch = xmlDoc.SelectSingleNode(GetXPathToNode(choice) + "/node()");
                        // {
                        patchid = patch.Attributes["id"].Value;
                        if (patchlist == "")
                        {
                            patchlist = patchid;
                        }
                        else
                        {
                            patchlist += ";" + patchid;
                        }
                        /*choicePath.Add(choicename, patchid);*/

                        
                            
                       
                        // }
                    }
                    choicelist += ";Disabled";
                    using (System.IO.StreamWriter file = File.AppendText(@Application.StartupPath + "/temp.txt"))
                    {
                        file.WriteLine(row.ToString() + "|" + sectionname + "|" + optionname + "|" + choicelist + "|" + patchlist);
                    }
                    using (System.IO.StreamWriter file3 = File.AppendText(@Application.StartupPath + "/selected.txt"))
                    {
                        file3.WriteLine(optionname + "|" + choicelist.Split(';')[0] + "|" + patchlist.Split(';')[0]);
                    }
                    choicelist = "";
                    patchlist = "";
                }

            }

            //string choice = node.ChildNodes[0].Attributes["name"].Value;
            //string patch = node.ChildNodes[0].ChildNodes[0].Attributes["id"].Value;

            using (System.IO.StreamReader read = new StreamReader(@Application.StartupPath + "/temp.txt"))
            {
                // Read the file and display it line by line.
                int counter = 0;
                string line;

                System.IO.StreamReader file =
                   new System.IO.StreamReader(Application.StartupPath + "/temp.txt");
                while ((line = file.ReadLine()) != null)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = line.Split('|')[2];
                    item.Tag = line.Split('|')[3].Split(';')[0];
                    lvw.Items.Add(item);
                    counter++;
                }

                file.Close();
            }

        }
        public string GetXPathToNode(XmlNode node)
        {
            StringBuilder builder = new StringBuilder();
            while (node != null)
            {
                switch (node.NodeType)
                {
                    case XmlNodeType.Attribute:
                        builder.Insert(0, "/@" + node.Name);
                        node = ((XmlAttribute)node).OwnerElement;
                        break;
                    case XmlNodeType.Element:
                        int index = FindElementIndex((XmlElement)node);
                        builder.Insert(0, "/" + node.Name + "[" + index + "]");
                        node = node.ParentNode;
                        break;
                    case XmlNodeType.Document:
                        return builder.ToString();
                    default:
                        throw new ArgumentException("Only elements and attributes are supported");
                }
            }
            throw new ArgumentException("Node was not in a document");
        }

        static int FindElementIndex(XmlElement element)
        {
            XmlNode parentNode = element.ParentNode;
            if (parentNode is XmlDocument)
            {
                return 1;
            }
            XmlElement parent = (XmlElement)parentNode;
            int index = 1;
            foreach (XmlNode candidate in parent.ChildNodes)
            {
                if (candidate is XmlElement && candidate.Name == element.Name)
                {
                    if (candidate == element)
                    {
                        return index;
                    }
                    index++;
                }
            }
            throw new ArgumentException("Couldn't find element within parent");
        }
        public void getInformation(ListView lvw, ComboBox cbx, TextBox txt, List<string> choicelist, List<string> patchlist)
        {

            using (System.IO.StreamReader read = new StreamReader(@Application.StartupPath + "/temp.txt"))
            {
                // Read the file and display it line by line.
                int counter = 0;
                string line;

                System.IO.StreamReader file =
                   new System.IO.StreamReader(Application.StartupPath + "/temp.txt");
                while ((line = file.ReadLine()) != null)
                {
                    if (lvw.SelectedItems.Count > 0)
                    {
                        cbx.Text = lvw.SelectedItems[0].Tag.ToString();
                        if (line.Contains(lvw.SelectedItems[0].Text))
                        {
                            cbx.DataSource = null;
                            cbx.DataBindings.Clear();

                            string[] input = line.Split('|');
                            string[] choicearray = input[3].Split(';');
                            choicelist.Clear();
                            foreach (string choice in choicearray)
                            {
                                choicelist.Add(choice);
                            }

                            string[] patcharray = input[4].Split(';');
                            patchlist.Clear();
                            foreach (string patch in patcharray)
                            {
                                patchlist.Add(patch);
                            }
                            txt.Text = patchlist[0];

                            cbx.DataSource = choicelist;
                            cbx.Text = lvw.SelectedItems[0].Tag.ToString();


                        }
                    }
                    counter++;
                }

                file.Close();
            }
        }
        public void getPatchFromCombobox(ComboBox cbx, TextBox txt, List<string> patchlist, ListView lvw)
        {

            if (lvw.SelectedItems.Count > 0)
            {
                lvw.SelectedItems[0].Tag = cbx.Text;
                try{
                    txt.Text = patchlist[cbx.SelectedIndex];

                }
                catch (Exception ex)
                {
                    if (ex.ToString().Contains("ArgumentOutOfRangeException"))
                    {
                        txt.Text = "";
                    }
                }

            }
        }
    }
}