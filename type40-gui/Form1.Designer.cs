using System.Drawing;

namespace pxgamer.Type40
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BrowseButton = new System.Windows.Forms.Button();
            this.SourceLabel = new System.Windows.Forms.Label();
            this.SourceInput = new System.Windows.Forms.TextBox();
            this.OutputInput = new System.Windows.Forms.TextBox();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.SourceBrowse = new System.Windows.Forms.Button();
            this.FileDialog = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.EncodeButton = new System.Windows.Forms.Button();
            this.FullMode = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PreviewMode = new System.Windows.Forms.RadioButton();
            this.OutputCommand = new System.Windows.Forms.TextBox();
            this.LogoImage = new System.Windows.Forms.PictureBox();
            this.BuildStatus = new System.Windows.Forms.WebBrowser();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoImage)).BeginInit();
            this.SuspendLayout();
            //
            // button1
            //
            this.BrowseButton.Location = new System.Drawing.Point(509, 7);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(75, 23);
            this.BrowseButton.TabIndex = 0;
            this.BrowseButton.Text = "Browse...";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            //
            // label1
            //
            this.SourceLabel.AutoSize = true;
            this.SourceLabel.Location = new System.Drawing.Point(13, 12);
            this.SourceLabel.Name = "SourceLabel";
            this.SourceLabel.Size = new System.Drawing.Size(44, 13);
            this.SourceLabel.TabIndex = 1;
            this.SourceLabel.Text = "Source:";
            //
            // textBox1
            //
            this.SourceInput.Location = new System.Drawing.Point(63, 9);
            this.SourceInput.Name = "SourceInput";
            this.SourceInput.Size = new System.Drawing.Size(440, 20);
            this.SourceInput.TabIndex = 2;
            //
            // textBox2
            //
            this.OutputInput.Location = new System.Drawing.Point(63, 35);
            this.OutputInput.Name = "OutputInput";
            this.OutputInput.Size = new System.Drawing.Size(440, 20);
            this.OutputInput.TabIndex = 5;
            //
            // label2
            //
            this.OutputLabel.AutoSize = true;
            this.OutputLabel.Location = new System.Drawing.Point(13, 38);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(42, 13);
            this.OutputLabel.TabIndex = 4;
            this.OutputLabel.Text = "Output:";
            //
            // button2
            //
            this.SourceBrowse.Location = new System.Drawing.Point(509, 33);
            this.SourceBrowse.Name = "SourceBrowse";
            this.SourceBrowse.Size = new System.Drawing.Size(75, 23);
            this.SourceBrowse.TabIndex = 3;
            this.SourceBrowse.Text = "Browse...";
            this.SourceBrowse.UseVisualStyleBackColor = true;
            this.SourceBrowse.Click += new System.EventHandler(this.SourceButton_Click);
            //
            // openFileDialog1
            //
            this.FileDialog.FileName = "openFileDialog1";
            //
            // button3
            //
            this.EncodeButton.Location = new System.Drawing.Point(13, 146);
            this.EncodeButton.Name = "EncodeButton";
            this.EncodeButton.Size = new System.Drawing.Size(571, 23);
            this.EncodeButton.TabIndex = 6;
            this.EncodeButton.Text = "Encode...";
            this.EncodeButton.UseVisualStyleBackColor = true;
            this.EncodeButton.Click += new System.EventHandler(this.EncodeButton_Click);
            //
            // radioButton1
            //
            this.FullMode.AutoSize = true;
            this.FullMode.Checked = true;
            this.FullMode.Location = new System.Drawing.Point(6, 19);
            this.FullMode.Name = "FullMode";
            this.FullMode.Size = new System.Drawing.Size(71, 17);
            this.FullMode.TabIndex = 8;
            this.FullMode.TabStop = true;
            this.FullMode.Text = "Full Mode";
            this.FullMode.UseVisualStyleBackColor = true;
            this.FullMode.CheckedChanged += new System.EventHandler(this.FullMode_CheckedChanged);
            //
            // groupBox1
            //
            this.groupBox1.Controls.Add(this.BuildStatus);
            this.groupBox1.Controls.Add(this.PreviewMode);
            this.groupBox1.Controls.Add(this.FullMode);
            this.groupBox1.Location = new System.Drawing.Point(16, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(568, 46);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "More Options";
            //
            // radioButton2
            //
            this.PreviewMode.AutoSize = true;
            this.PreviewMode.Location = new System.Drawing.Point(97, 19);
            this.PreviewMode.Name = "PreviewMode";
            this.PreviewMode.Size = new System.Drawing.Size(113, 17);
            this.PreviewMode.TabIndex = 9;
            this.PreviewMode.Text = "Preview - 1 Minute";
            this.PreviewMode.UseVisualStyleBackColor = true;
            this.PreviewMode.CheckedChanged += new System.EventHandler(this.PreviewMode_CheckedChanged);
            //
            // textBox3
            //
            this.OutputCommand.Location = new System.Drawing.Point(16, 307);
            this.OutputCommand.MaxLength = 99999999;
            this.OutputCommand.Name = "OutputCommand";
            this.OutputCommand.Size = new System.Drawing.Size(568, 20);
            this.OutputCommand.TabIndex = 10;
            //
            // pictureBox1
            //
            this.LogoImage.Image = global::pxgamer.Type40.Properties.Resources.logo;
            this.LogoImage.Location = new System.Drawing.Point(16, 175);
            this.LogoImage.Name = "LogoImage";
            this.LogoImage.Size = new System.Drawing.Size(568, 125);
            this.LogoImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.LogoImage.TabIndex = 7;
            this.LogoImage.TabStop = false;
            //
            // webBrowser1
            //
            this.BuildStatus.AllowNavigation = false;
            this.BuildStatus.AllowWebBrowserDrop = false;
            this.BuildStatus.IsWebBrowserContextMenuEnabled = false;
            this.BuildStatus.Location = new System.Drawing.Point(462, 16);
            this.BuildStatus.MinimumSize = new System.Drawing.Size(20, 20);
            this.BuildStatus.MaximumSize = new System.Drawing.Size(88, 20);
            this.BuildStatus.Name = "BuildStatus";
            this.BuildStatus.ScriptErrorsSuppressed = true;
            this.BuildStatus.ScrollBarsEnabled = false;
            this.BuildStatus.AutoSize = true;
            this.BuildStatus.TabIndex = 10;
            this.BuildStatus.Url = new System.Uri(
                "https://img.shields.io/travis/pxgamer/type40-gui/master.svg?style=flat-square",
                System.UriKind.Absolute
            );
            this.BuildStatus.WebBrowserShortcutsEnabled = false;
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 332);

            this.Controls.Add(this.OutputCommand);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LogoImage);
            this.Controls.Add(this.EncodeButton);
            this.Controls.Add(this.OutputInput);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.SourceBrowse);
            this.Controls.Add(this.SourceInput);
            this.Controls.Add(this.SourceLabel);
            this.Controls.Add(this.BrowseButton);

            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Type40 GUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.Label SourceLabel;
        private System.Windows.Forms.TextBox SourceInput;
        private System.Windows.Forms.TextBox OutputInput;
        private System.Windows.Forms.Label OutputLabel;
        private System.Windows.Forms.Button SourceBrowse;
        private System.Windows.Forms.OpenFileDialog FileDialog;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button EncodeButton;
        private System.Windows.Forms.PictureBox LogoImage;
        private System.Windows.Forms.RadioButton FullMode;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton PreviewMode;
        private System.Windows.Forms.TextBox OutputCommand;
        private System.Windows.Forms.WebBrowser BuildStatus;
    }
}

