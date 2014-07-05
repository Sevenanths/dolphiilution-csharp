using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Dolphiilution_
{
    public partial class homeScreen : Form
    {
        public string apppath = Application.StartupPath;
        public homeScreen()
        {
            InitializeComponent();
        }

        private void btnLastPlayed_Click(object sender, EventArgs e)
        {
            string lastplayed = apppath + "/settings/lastplayed";
        }

        private void btnPatchWiiGames_Click(object sender, EventArgs e)
        {
            dolphiiMain patchWiiGames = new dolphiiMain();
            patchWiiGames.Show();
            this.Hide();
        }
    }
}
