using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Dolphiilution
{
    public partial class dolBrew : Form
    {
        private dolphinMain main;
        
        public dolBrew(dolphinMain main)
        {
            this.main = main;
            InitializeComponent();
        }
        private void dolBrew_Load(object sender, EventArgs e)
        {
            string dollocation = "";
            string dvdroot = "";
            string apploader = "";
            
            if (File.Exists(main.gamesPath + "/rii/" + System.IO.Path.GetFileName(main.gamesPath + "/" + System.IO.Path.GetFileNameWithoutExtension(main.isoPath)) + "/DATA/sys/main.dol"))
            {
                System.IO.File.Copy(main.gamesPath + "/rii/" + System.IO.Path.GetFileName(main.gamesPath + "/" + System.IO.Path.GetFileNameWithoutExtension(main.isoPath)) + "/DATA/sys/main.dol", main.gamesPath + "/rii/" + System.IO.Path.GetFileName(main.gamesPath + "/" + System.IO.Path.GetFileNameWithoutExtension(main.isoPath)) + "/DATA/files/main.dol", true);
                System.IO.File.Copy(main.gamesPath + "/rii/" + System.IO.Path.GetFileName(main.gamesPath + "/" + System.IO.Path.GetFileNameWithoutExtension(main.isoPath)) + "/DATA/sys/apploader.img", main.gamesPath + "/rii/" + System.IO.Path.GetFileName(main.gamesPath + "/" + System.IO.Path.GetFileNameWithoutExtension(main.isoPath)) + "/DATA/files/apploader.img", true);

                dollocation = main.gamesPath + "/rii/" + System.IO.Path.GetFileName(main.gamesPath + "/" + System.IO.Path.GetFileNameWithoutExtension(main.isoPath)) + "/DATA/files/main.dol";
                dvdroot = main.gamesPath + "/rii/" + System.IO.Path.GetFileName(main.gamesPath + "/" + System.IO.Path.GetFileNameWithoutExtension(main.isoPath)) + "/DATA/files";
                apploader = main.gamesPath + "/rii/" + System.IO.Path.GetFileName(main.gamesPath + "/" + System.IO.Path.GetFileNameWithoutExtension(main.isoPath)) + "/DATA/files/apploader.img";
            }
            else
            {
                System.IO.File.Copy(main.gamesPath + "/rii/" + System.IO.Path.GetFileName(main.gamesPath + "/" + System.IO.Path.GetFileNameWithoutExtension(main.isoPath)) + "/sys/main.dol", main.gamesPath + "/rii/" + System.IO.Path.GetFileName(main.gamesPath + "/" + System.IO.Path.GetFileNameWithoutExtension(main.isoPath)) + "/files/main.dol", true);
                System.IO.File.Copy(main.gamesPath + "/rii/" + System.IO.Path.GetFileName(main.gamesPath + "/" + System.IO.Path.GetFileNameWithoutExtension(main.isoPath)) + "/sys/apploader.img", main.gamesPath + "/rii/" + System.IO.Path.GetFileName(main.gamesPath + "/" + System.IO.Path.GetFileNameWithoutExtension(main.isoPath)) + "/files/apploader.img", true);

                 dollocation = main.gamesPath + "/rii/" + System.IO.Path.GetFileName(main.gamesPath + "/" + System.IO.Path.GetFileNameWithoutExtension(main.isoPath)) + "/files/main.dol";
                 dvdroot = main.gamesPath + "/rii/" + System.IO.Path.GetFileName(main.gamesPath + "/" + System.IO.Path.GetFileNameWithoutExtension(main.isoPath)) + "/files";
                 apploader = main.gamesPath + "/rii/" + System.IO.Path.GetFileName(main.gamesPath + "/" + System.IO.Path.GetFileNameWithoutExtension(main.isoPath)) + "/files/apploader.img";
            }
         

            dolPatcher idontknowwhyicalleditdolpatcherbecauseonedoesntpatchdolslol = new dolPatcher();
            idontknowwhyicalleditdolpatcherbecauseonedoesntpatchdolslol.patchDol(System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/Dolphin Emulator", main.isoPath, dvdroot, apploader, dollocation, main.dolphinPath);
        }
    }
}
