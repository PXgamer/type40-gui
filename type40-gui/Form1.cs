using System;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace pxgamer.Type40
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Vars.Preview = false;
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            DialogResult result = FileDialog.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Check result.
            {
                Vars.Input = FileDialog.FileName;
                SourceInput.Text = Vars.Input;
                Vars.FilesName = Path.GetFileNameWithoutExtension(Vars.Input);
            }
        }

        private void SourceButton_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Check result.
            {
                Vars.Output = folderBrowserDialog1.SelectedPath;
                Vars.FinalName = Regex.Split(Vars.FilesName, @"([0-9]{4})")[0] + "(" +
                                 Regex.Split(Vars.FilesName, @"([0-9]{4})")[1] + ")";
                Vars.FinalName = Vars.FinalName.Replace(".", " ");
                Vars.FinFilesName = Vars.FinalName + " [Type40].mp4";
                OutputInput.Text = Vars.Output + @"\" + Vars.FinFilesName;
            }
        }

        private void EncodeButton_Click(object sender, EventArgs e)
        {
            string previewMode = Vars.Preview ? " --start-at duration:0 --stop-at duration:60" : "";
            string strCmdText = "HandBrakeCLI.exe -i " + '\u0022' +
                                Vars.Input + '\u0022' +
                                " -o " + '\u0022' +
                                Vars.Output + @"\" + Vars.FinFilesName + '\u0022' +
                                " -E fdk_faac -A " + '\u0022' + "English" + '\u0022' +
                                " - B 384k --mixdown 6ch -R 48 -e x264 -q 25 -r 23.976 --cfr -x level=4.1:cabac=1:ref=5:analyse=0x133:me=umh:subme=9:chroma-me=1:deadzone-inter=21:deadzone-intra=11:b-adapt=2:rc-lookahead=60:vbv-maxrate=10000:vbv-bufsize=10000:qpmax=69:bframes=4:b-adapt=2:direct=auto:crf-max=51:weightp=2:merange=24:chroma-qp-offset=-1:sync-lookahead=2:psy-rd=1.00,0.15:trellis=2:min-keyint=23:partitions=all" +
                                previewMode;

            System.Diagnostics.Process.Start("CMD.exe", strCmdText);
            OutputCommand.Text = strCmdText;
        }

        private void FullMode_CheckedChanged(object sender, EventArgs e)
        {
            if (FullMode.Checked)
            {
                Vars.Preview = false;
            }
        }

        private void PreviewMode_CheckedChanged(object sender, EventArgs e)
        {
            if (PreviewMode.Checked)
            {
                Vars.Preview = true;
            }
        }
    }
}
