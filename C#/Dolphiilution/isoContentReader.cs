using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;

namespace Dolphiilution
{
    class isoContentReader
    {
        public string readContents(string isoPath)
        {
            string output = string.Empty;
            string error = string.Empty;

            Process wit = new Process();
            wit.StartInfo.FileName = Application.StartupPath + "/WIT/wit.exe";
            wit.StartInfo.Arguments = "files " + "\"" + isoPath + "\"";
            wit.StartInfo.RedirectStandardError = true;
            wit.StartInfo.RedirectStandardOutput = true;
            wit.StartInfo.UseShellExecute = false;
            wit.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            wit.StartInfo.CreateNoWindow = true;
            wit.Start();

            using (StreamReader streamReader = wit.StandardOutput)
            {
                output = streamReader.ReadToEnd();
                return output;
            }
        }
    }
}
