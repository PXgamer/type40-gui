using System;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic;

namespace Type40_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Check result.
            {
                vars.input = openFileDialog1.FileName;
                textBox1.Text = vars.input;
                vars.filesName = Path.GetFileNameWithoutExtension(vars.input);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Check result.
            {
                vars.output = folderBrowserDialog1.SelectedPath;
                vars.finalName = Regex.Split(vars.filesName, @"([0-9]{4})")[0] + "(" +Regex.Split(vars.filesName, @"([0-9]{4})")[1] + ")";
                vars.finalName = vars.finalName.Replace(".", " ");
                vars.finFilesName = vars.finalName + " [Type40].mp4";
                textBox2.Text = vars.output + @"\" + vars.finFilesName;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string previewMode = (vars.preview === true) ? " --start-at duration:0 --stop-at duration:60" : "";
            string strCmdText = "HandBrakeCLI.exe -i " + '\u0022' +
            vars.input + '\u0022' +
            " -o " + '\u0022' +
            vars.output + @"\" + vars.finFilesName + '\u0022' +
            " -E fdk_faac -A " + '\u0022' + "English" + '\u0022' + " - B 384k --mixdown 6ch -R 48 -e x264 -q 25 -r 23.976 --cfr -x level=4.1:cabac=1:ref=5:analyse=0x133:me=umh:subme=9:chroma-me=1:deadzone-inter=21:deadzone-intra=11:b-adapt=2:rc-lookahead=60:vbv-maxrate=10000:vbv-bufsize=10000:qpmax=69:bframes=4:b-adapt=2:direct=auto:crf-max=51:weightp=2:merange=24:chroma-qp-offset=-1:sync-lookahead=2:psy-rd=1.00,0.15:trellis=2:min-keyint=23:partitions=all" + previewMode;
            
            System.Diagnostics.Process.Start("CMD.exe", strCmdText);
            textBox3.Text = strCmdText;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            vars.preview = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                vars.preview = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                vars.preview = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //IMDB selector
            var imdbId = Interaction.InputBox("IMDB ID:");

            if (!String.IsNullOrEmpty(imdbId))
            {
                //Set JSON URL
                vars.imdbURL = vars.imdbURL + "i=" + imdbId;

                //Download the JSON data from OMDb
                WebClient c = new WebClient();
                var data = c.DownloadString(vars.imdbURL);
                //Console.WriteLine(data);
                JObject o = JObject.Parse(data);

                vars.finalName =  o["Title"] + " (" + o["Year"] + ")";
                vars.finFilesName = vars.finalName + " [Type40].mp4";
                textBox2.Text = vars.output + @"\" + vars.finFilesName;
            }
        }
    }
}
