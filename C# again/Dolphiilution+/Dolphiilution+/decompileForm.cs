using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Dolphiilution_
{
    public partial class decompileForm : Form
    {
        public decompileForm()
        {
            InitializeComponent();
        }

        private void btnMusic_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://youtu.be/_apb7EcsWgc?t=5s");
        }
    }
}
