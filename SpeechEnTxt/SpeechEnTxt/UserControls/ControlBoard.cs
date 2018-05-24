using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpeechEnTxt.Classes;
using SpeechEnTxt.Classes.Models;

namespace SpeechEnTxt.UserControls
{
    public partial class ControlBoard : UserControl
    {
        private ServicesClass VServcie;
        private IReadContent RContentClass;
        public ControlBoard()
        {
            InitializeComponent();
        }
        public void SetVoiceServcie(ServicesClass VoiceService, IReadContent ReadContentClass)
        {
            VServcie = VoiceService;
            RContentClass = ReadContentClass;
        }

        //public ControlBoard(ServicesClass VoiceService, IReadContent ReadContentClass) : this()
        //{
        //    SetVoiceServcie(VoiceService,ReadContentClass);
        //}

        #region Basic Function

        private void ShowVolume(TrackBar trackBar)
        {
            lbVolume.Text = $"{trackBar.Value}";
        }

        private void ShowSpeed(TrackBar trackBar)
        {
            lblSpeed.Text = $"{trackBar.Value}";
        }

        #endregion

        #region Events functions

        private void ControlBoard_Load(object sender, EventArgs e)
        {
            cmbVoices.DataSource = VServcie?.GetInstalledVoices()?
                .Select(x => new { Name = x.VoiceInfo.Name }).ToList();
            cmbVoices.DisplayMember = "Name";

            ShowSpeed(this.tbSpeed);
            ShowVolume(this.tbVolume);
            this.lnkPath.Enabled = false;
        }

        private void tbSpeedAndVolume_Scroll(object sender, EventArgs e)
        {
            var trackBar = sender as TrackBar;
            if (trackBar != null)
            {
                if (trackBar.Name.Equals("tbSpeed"))
                {
                    ShowSpeed(trackBar);
                }
                if (trackBar.Name.Equals("tbVolume"))
                {
                    ShowVolume(trackBar);
                }
            }
        }

        private void lnkPath_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string fileFullName = lnkPath.Text;
            string path = "";
            int index = fileFullName.LastIndexOf("\\");
            if (index > -1)
            {
                path = fileFullName.Substring(0, index + 1);
            }
            System.Diagnostics.Process.Start("Explorer.exe", path);
        }

        private void cbkRecord_CheckedChanged(object sender, EventArgs e)
        {
            if (cbkRecord.Checked)
            {
                string fileFullName = lnkPath.Text;
                string path = "", fileName = "";
                int index = fileFullName.LastIndexOf("\\");
                if (index > -1)
                {
                    path = fileFullName.Substring(0, index + 1);
                    fileName = fileFullName.Substring(index + 1);
                }

                SaveFileDialog sfd = new SaveFileDialog();
                sfd.InitialDirectory = path;
                sfd.OverwritePrompt = true;
                sfd.FileName = fileName;
                sfd.CheckPathExists = true;
                sfd.Filter = "Sound File(*.wav)|*.wav";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    lnkPath.Text = sfd.FileName;
                    lnkPath.Enabled = true;
                }
                else
                {
                    cbkRecord.Checked = false;
                }
            }
            else
            {
                lnkPath.Enabled = !string.IsNullOrEmpty(lnkPath.Text);
            }
        }

        #endregion
    }
}
