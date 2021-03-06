﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Diagnostics;

namespace Dolphiilution_
{
    class parseXML
    {
        // HOW XML PARSING WORKS IN DOLPHIILUTION
        // OVERLY HARD XML PARSING ALERT
        //
        // This is a little difficult to understand maybe, and also probably not efficient, but this is the only way I found to do this, dealing
        // with .NET's limitations (and my lack of knowledge).
        //
        // I'll use MrBean's obsolete Riivolution XML as an example. Because manipulating normal text files is easier than using XML's, the goal is to convert
        //  <options>
            
        
        //    <section name="CTGP Settings">
        
        //      <option id="CTs" name="CTGP Revolution" default="1">
        //        <choice name="Enabled!">
        //          <patch id="CTsFTW" />
        //        </choice>
        //      </option>
        
        
        //      <option id="music_disable" name="Remove Game Music?" default="0">
        //        <choice name="Remove Track Music">
        //          <patch id="track_disable" />
        //        </choice>
        //        <choice name="Remove Replay Music">
        //          <patch id="replay_disable" />
        //        </choice>
        //        <choice name="Remove Both Track/Replay Music">
        //          <patch id="all_disable" />
        //        </choice>
        //      </option>
        
        
        
        
        //      <option id="any_alteration" name="'My Stuff' folder" default="1">
        //        <choice name="Enabled">
        //          <patch id="any_alteration_patch" />
        //        </choice>
        //      </option>
        
        //      <option id="cv_fix" name="Chomp Valley Texture Fix" default="1">
        //        <choice name="Enabled">
        //          <patch id="cvfix" />
        //        </choice>
        //      </option>
        
        //      <option name="Save to SD card?" default="1">
        //    <choice name="Enabled">
        //       <patch id="redirectsave" /> 
        //    </choice>
        //      </option>
        
        //     <option id="fonts" name="Special Fonts" default="0">
        //        <choice name="'Chalky'">
        //          <patch id="font_chalky" />
        //        </choice>
        //    <choice name="'Outline'">
        //          <patch id="font_outline" />
        //        </choice>
        //    <choice name="'MV Boli'">
        //          <patch id="font_boli" />
        //        </choice>
        //      </option>
        //   </section>    
        //  </options>
        //
        // to
        //
        // 0|CTGP Settings|CTGP Revolution|Enabled!;Disabled|CTsFTW
        // 1|CTGP Settings|Remove Game Music?|Remove Track Music;Remove Replay Music;Remove Both Track/Replay Music;Disabled|track_disable;replay_disable;all_disable
        // 2|CTGP Settings|'My Stuff' folder|Enabled;Disabled|any_alteration_patch
        // 3|CTGP Settings|Chomp Valley Texture Fix|Enabled;Disabled|cvfix
        // 4|CTGP Settings|Save to SD card?|Enabled;Disabled|redirectsave
        // 5|CTGP Settings|Special Fonts|'Chalky';'Outline';'MV Boli';Disabled|font_chalky;font_outline;font_boli
        //
        // Much easier to parse, right?
        // Indeed. But that's not all.
        // The file up above is /configurations/$xmlname.txt". Your choices are not saved in the xml, but in a seperate folder. This was a convenient side effect.
        // I figured out this system a few months ago and I have no idea how I did it. I find it quite genius now lol.
        // Anyway, I'll try to explain as well as possible how this all works. Some parts I didn't understand myself :')
        // EXAMPLES:  SD:\riivolution\mkwiiriivoslottest, /configurations/mkwiiriivoslottest.txt
        public void checkIfConfigExists(string inputxml, string activexmlname, ListView lvw, List<string> choicelist, List<string> patchlist)
        {
            string apppath = Application.StartupPath; // Can't I just put this shit on top?
            if (File.Exists(apppath + activexmlname)) // If you have used this XML earlier, we ask the user is he/she wants to load previous settings, as changes are saved automagically
            {
                if (MessageBox.Show("It looks like you have used this XML earlier. Would you like to load the settings you used earlier? Warning: if you select no, all previous settings will be erased!", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    generateXML(inputxml, activexmlname, lvw, choicelist, patchlist); // rebuild the xml entirely and overwrite all choices
                }
                else
                {
                    loadConfigToListView(lvw, activexmlname, choicelist, patchlist); // just load the xml from the existing configuration files
                }
            }
            else
            {
                generateXML(inputxml, activexmlname, lvw, choicelist, patchlist); // rebuild the xml entirely and overwrite all choices (there isn't a parsed version saved yet)
            }
        }
        public void generateXML(string inputxml, string activexmlname, ListView lvw, List<string> choiceliststring, List<string> patchliststring)
        {
            string apppath = Application.StartupPath;
            lvw.Items.Clear(); // clear the listview

            XmlDocument xmlDoc = new XmlDocument(); // create the xml document
            xmlDoc.Load(inputxml); // load it

            System.IO.File.Create(apppath + activexmlname).Dispose(); // reset both files

            XmlNodeList sections = xmlDoc.SelectNodes("//wiidisc/options/section"); // my way of parsing XML's is actually a little stupid. Sorry! :(
            foreach (XmlNode section in sections) // select each node 
            {
                string sectionname = section.Attributes["name"].Value; // get the name of the section
                XmlNodeList options = xmlDoc.SelectNodes(GetXPathToNode(section) + "/node()");
                int row = -1;
                string patchlist = ""; // create a list of patches
                string choicelist = ""; // choices
                string patchid = ""; // patch id's
                foreach (XmlNode option in options)
                {
                    patchlist = ""; // choices, patches and patchid's are reset with every option (as they should)
                    choicelist = "";
                    patchid = "";
                    row++;

                    string optionname = option.Attributes["name"].Value; // get the name of the options
                    XmlNodeList choices = xmlDoc.SelectNodes(GetXPathToNode(option) + "/node()"); // select the next set of nodes (choices)
                    foreach (XmlNode choice in choices) // foreach choice
                    {
                        string choicename = choice.Attributes["name"].Value; // fetch name, add it to a list of choices
                        if (choicelist == "") // when the list of choices is empty, initialize it and put the first choice in
                        {
                            choicelist = "Disabled;" + choicename;
                        }
                        else // if not, just add another choice
                        {
                            choicelist += ";" + choicename;
                        }
                        XmlNode patch = xmlDoc.SelectSingleNode(GetXPathToNode(choice) + "/node()"); // select the next set of nodes (patches)
                        // {
                        patchid = patch.Attributes["id"].Value; // same story as above
                        if (patchlist == "")
                        {
                            patchlist = ";" + patchid;
                        }
                        else
                        {
                            patchlist += ";" + patchid;
                        }
                    }
                    //choicelist += ";Disabled"; originally, disabled was last, but this was inconvenient because it should be loading first in the combobox
                    using (System.IO.StreamWriter file = File.AppendText(@Application.StartupPath + activexmlname))
                    {
                        file.WriteLine(row.ToString() + "|" + sectionname + "|" + optionname + "|" + choicelist + "|" + patchlist); // write the entire line to the file
                    }
                    //choicelist = ""; I don't think this is necessary but it was in originally so this may be an old piece of code
                    //patchlist = "";
                }

            }

            loadConfigToListView(lvw, activexmlname, choiceliststring, patchliststring); // fire the next event, loading everything into the listview
        }
        public void loadConfigToListView(ListView lvw, string activexmlname, List<string> choicelist, List<string> patchlist)
        {
            lvw.Items.Clear();

            using (System.IO.StreamReader read = new StreamReader(@Application.StartupPath + activexmlname))
            {
                // Read the file and display it line by line.
                int counter = 0;
                string line;

                System.IO.StreamReader file =
                   new System.IO.StreamReader(Application.StartupPath + activexmlname);
                while ((line = file.ReadLine()) != null)
                {
                    ListViewItem item = new ListViewItem(); // create a new listviewitem
                    item.Text = line.Split('|')[2]; // get the third item in the split, which is the name in this case
                    item.Tag = line.Split('|')[1]; // get the second item in the split, which is the section name
                    lvw.Items.Add(item); // add it to the listview
                    counter++;
                }

                file.Close();
            }
        }
        public void populateChoices(ListView lvw, ComboBox cbx, List<string> choices, string activexmlname) // originally populating patches and writing choices were a different event but they were merged,
                                                                                                            //that's why the structure of this event may be a little weird
        {
            string apppath = Application.StartupPath;
            if (lvw.SelectedItems.Count > 0)
            {
                string[] tempLines = File.ReadAllLines(apppath + activexmlname); // the lines are read
                string line = tempLines[lvw.SelectedIndices[0]]; // the selected listviewitem's index corresponds with the right line in the text file
                // 1|CTGP Settings|Remove Game Music?|Remove Replay Music;Remove Track Music;Remove Both Track/Replay Music;Disabled|replay_disable;track_disable;all_disable; (for example)
                //choices = null; // resetting the array
                choices = line.Split('|')[3].Split(';').ToList(); // an array is made with the fourth piece of the line of the text file and again split (Remove Replay Music;Remove Track Music;Remove Both Track/Replay Music;Disabled)
                cbx.DataSource = choices; // the datasource is set
            }
        }
        public void populatePatches(ListView lvw, ComboBox cbx, TextBox txt, List<string> choices, List<string> patches, string activexmlname)
        {
            string apppath = Application.StartupPath;
            if (lvw.SelectedItems.Count > 0)
            {
                if (!(cbx.Text == ""))
            {
                string[] tempLines = File.ReadAllLines(apppath + activexmlname); // again reading lines
                string line = tempLines[lvw.SelectedIndices[0]]; // again picking the right line
                //patches = null; // again resetting the array
                patches = line.Split('|')[4].Split(';').ToList(); // again getting the right part and splitting it
                txt.Text = patches[cbx.SelectedIndex]; // since the right patch corresponds with the index of the combobox and the right place in the array, this works
              

                string newChoiceList; // create a new "list" to change the order of the patches, I tried shifting around in lists but this way a million times easier
                newChoiceList = cbx.Text + ";"; // initialize the first item
                foreach (var item in cbx.Items) // I would use the other list but it didn't work for some reason so I'm using the listbox items as they're the same
                {
                    if (!(item.ToString() == cbx.Text)) // make sure we don't add the selected item twice!
                    {
                        newChoiceList += item.ToString() + ";"; // add it to the list, as well as my favourite espace character
                    }
                }
                string newPatchList; // basicly the same for the patches, but for some reason the list did work here
                newPatchList = txt.Text + ";";
                foreach (string patch in patches)
                {
                    if (!(patch == txt.Text))
                    {
                        newPatchList += patch + ";";
                    }
                }
                //foreach (string patch in newPatchList)
                //{
                //    Debug.WriteLine(patch);
                //}
                // write back everything to the right line so next time it's loaded, the picked choice will be on top in the listbox, as well making it easier to find which item is selected in the patch sequence (so much win in one line of code!)
                tempLines[lvw.SelectedIndices[0]] = lvw.SelectedIndices[0].ToString() + "|" + lvw.SelectedItems[0].Tag + "|" + lvw.SelectedItems[0].Text + "|" + newChoiceList.Remove(newChoiceList.Length - 1) + "|" + newPatchList.Remove(newPatchList.Length - 1);
                //MessageBox.Show(tempLines[lvw.SelectedIndices[0]]);
                File.WriteAllLines(apppath + activexmlname, tempLines);
            }
           }
        }
        // this is the broken code, I decided to let it in. Dunno why but I'd find it a waste to delete this.
        //public void populateChoicesAndPatchID2(ListView lvw, ComboBox cbx, List<string> choicelist, List<string> patchlist)
        //{
        //    // REWORKED VERSION _ SHOULD BE MORE STABLE
        //    // UPDATE: IT IS NOT
        //    // POPULATING THE CHOICES
        //    //
        //    string apppath = Application.StartupPath;
        //    // first, let's see if something is clicked. When a user selects a new item in a listview, the listview first DESELECTS the current item,
        //    // firing a indexchanged event, then selects the new item. This event will ALSO go off when nothing is selected, resulting in an exception.
        //    // That's .NET for ya. So let's first check if there is something clicked.
        //    if (lvw.SelectedItems.Count > 0)
        //    {
        //        // then, we generate the list of choices a user can make
        //        string[] allTempLines = File.ReadAllLines(@apppath + "/temp.txt"); // first, let's read all lines of temp.txt
        //        // we want to get the same line as the index in the listview (that's why I added the index numbers in the file to make it easier to understand)
        //        string line = string.Empty;
        //        if (allTempLines.Length >= lvw.SelectedIndices[0])
        //        {
        //            line = allTempLines[lvw.SelectedIndices[0]];
        //            // MessageBox.Show(line);
        //            //
        //            // clearing the Combobox and its datasoruce so we're sure nothing remains
        //            cbx.DataSource = null;
        //            cbx.DataBindings.Clear();
        //            choicelist.Clear();
        //            patchlist.Clear();
        //            // now, let's get the choices out of the line
        //            // EXAMPLE:
        //            // 1|CTGP Settings|Remove Game Music?|Remove Track Music;Remove Replay Music;Remove Both Track/Replay Music;Disabled|track_disable;replay_disable;all_disable
        //            // what we want:
        //            // Remove Track Music;Remove Replay Music;Remove Both Track/Replay Music;Disabled
        //            // we split the line in parts, the first seperator is '|' in this case
        //            // we then split the fourth part (third index) in parts with the seperator ';'
        //            string[] choices = line.Split('|')[3].Split(';');
        //            foreach (string choice in choices)
        //            {
        //                choicelist.Add(choice);
        //            }
        //            cbx.DataSource = choicelist;
        //            // now, let's get the patches out of the line
        //            // EXAMPLE:
        //            // 1|CTGP Settings|Remove Game Music?|Remove Track Music;Remove Replay Music;Remove Both Track/Replay Music;Disabled|track_disable;replay_disable;all_disable
        //            // what we want:
        //            // track_disable;replay_disable;all_disable
        //            // we split the line in parts, the first seperator is '|' in this case
        //            // we then split the fifth part (fourth index) in parts with the seperator ';'
        //            string[] patches = line.Split('|')[4].Split(';');
        //            foreach (string patch in patches)
        //            {
        //                patchlist.Add(patch);
        //            }

        //            //
        //            // GETTING THE SELECTED CHOICE
        //            // bullshit alert down here
        //            // The selected choices are stored in /selected.txt. The selected.txt of the temp.txt we saw earlier, would look like this:
        //            //
        //            // CTGP Revolution|Enabled!|CTsFTW
        //            // Remove Game Music?|Remove Track Music|track_disable
        //            // 'My Stuff' folder|Enabled|any_alteration_patch
        //            // Chomp Valley Texture Fix|Enabled|cvfix
        //            // Save to SD card?|Enabled|redirectsave
        //            // Special Fonts|'Chalky'|font_chalky
        //            //
        //            // As you can see, we only have one item written here. The choice (index 1) and patch (index 2) will be changed accordingly whenever
        //            // a user selects a new option in the ComboBox. In this case we're just reading an earlier choice.
        //            //string[] allSelectedLines = File.ReadAllLines(@apppath + "/selected.txt"); // first, let's read all lines of selected.txt
        //            //string selectedline = string.Empty; // empty string creation
        //            //if (allSelectedLines.Length >= lvw.SelectedIndices[0]) // we want the n'th line which again corresponds with the listview index
        //            //{
        //            //    selectedline = allSelectedLines[lvw.SelectedIndices[0]];
        //            //    string selectedchoice = selectedline.Split('|')[1]; // we only have to split once since there's only one thing to read now
        //            //    // MessageBox.Show(selectedchoice); //debug
        //            //    cbx.Text = selectedchoice; // we display the selected choice in the combobox so the user knows what's been selected
        //            //}
        //        }
        //    }
        //}
        //public void getPatch(ListView lvw, ComboBox cbx, TextBox txt, List<string> patchlist)
        //{
        //    // of course we must also write such a choice back to the file. First, we have to tell if something is selected, for reasons explained before
        //    if (lvw.SelectedItems.Count > 0)
        //    {
        //        lvw.SelectedItems[0].Tag = cbx.Text;
        //        try
        //        {
        //            txt.Text = patchlist[cbx.SelectedIndex]; // because I couldn't find a different way to do this, the index of in the combobox corresponds
        //                                                     // to the right patchid in the patch list we created earlier
        //        }
        //        catch (Exception ex)                         // but yes, in case of disabled, there is no patch id, in which case there is an exception, which
        //                                                     // is catched here
        //        {
        //            if (ex.ToString().Contains("ArgumentOutOfRangeException"))
        //            {
        //                txt.Text = "";                       // the patchid is blank in this case
        //            }
        //        }
        //    }
        //}
        //public void getPatchAndWriteBack(ListView lvw, ComboBox cbx, TextBox txt, List<string> patchlist)
        //{
        //    // of course we must also write such a choice back to the file. First, we have to tell if something is selected, for reasons explained before
        //    if (lvw.SelectedItems.Count > 0)
        //    {
        //        lvw.SelectedItems[0].Tag = cbx.Text;
        //        try
        //        {
        //            txt.Text = patchlist[cbx.SelectedIndex]; // because I couldn't find a different way to do this, the index of in the combobox corresponds
        //            // to the right patchid in the patch list we created earlier
        //        }
        //        catch (Exception ex)                         // but yes, in case of disabled, there is no patch id, in which case there is an exception, which
        //        // is catched here
        //        {
        //            if (ex.ToString().Contains("ArgumentOutOfRangeException"))
        //            {
        //                txt.Text = "";                       // the patchid is blank in this case
        //            }
        //        }

        //        writeBack(lvw, cbx, txt);
        //    }
        //}
        //public void writeBack(ListView lvw, ComboBox cbx, TextBox txt)
        //{
        //    if (!(cbx.Text == ""))
        //    {
        //        if (!(txt.Text == "") || cbx.Text == "Disabled")
        //        {
        //            // now, it's time to write back the selected choice
        //            string apppath = Application.StartupPath;
        //            string[] allSelectedLines = File.ReadAllLines(@apppath + "/selected.txt"); // first, let's read all lines of selected.txt
        //            // let's rewrite the specific line which AGAIN corresponds to the index in the ListView (this is starting getting old already isn't it?)
        //            allSelectedLines[lvw.SelectedIndices[0]] = lvw.SelectedItems[0].Text + "|" + cbx.Text + "|" + txt.Text;
        //            //MessageBox.Show(lvw.SelectedItems[0].Text + "|" + cbx.SelectedItem.ToString() + "|" + txt.Text);
        //            File.WriteAllLines(apppath + "/selected.txt", allSelectedLines);
        //            lvw.SelectedItems[0].Tag = cbx.Text;
        //        }
        //    }
        //}

        // got this of the web it works but I have no idea how it works oops
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
    }
}
