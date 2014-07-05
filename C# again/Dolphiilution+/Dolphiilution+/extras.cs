using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Dolphiilution_
{
    class extras
    {
        public void getboxart(string hexid, PictureBox pbxBoxart, PictureBox pbxRegion)
        {
            if (hexid == "")
            {
                pbxBoxart.Image = null;
                pbxRegion.Image = null;
            }
            else
            {
                pbxBoxart.Load("http://www.wiiboxart.com/artwork/cover/" + hexid.Replace(System.Environment.NewLine, "") + ".png");
                switch (hexid[3].ToString())
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
    }
}
