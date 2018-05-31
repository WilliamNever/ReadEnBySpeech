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
        private SpeechConfig config;
        private bool isPause = false;
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

        private void ShowVolume(int num)
        {
            lbVolume.Text = $"{num}";
            VServcie?.SetVolume(num);
        }

        private void ShowSpeed(int num)
        {
            lblSpeed.Text = $"{num}";
            VServcie?.SetRate(num);
        }

        #endregion

        #region Events functions

        private void ControlBoard_Load(object sender, EventArgs e)
        {
            cmbVoices.DataSource = VServcie?.GetInstalledVoices()?
                .Select(x => new { Name = x.VoiceInfo.Name }).ToList();
            cmbVoices.DisplayMember = "Name";
            cmbVoices.ValueMember = "Name";
            if (cmbVoices.Items.Count > 0)
            {
                cmbVoices.SelectedIndex = 0;
            }

            ShowSpeed(tbSpeed.Value);
            ShowVolume(tbVolume.Value);
            this.lnkPath.Enabled = false;
        }

        private void tbSpeedAndVolume_Scroll(object sender, EventArgs e)
        {
            var trackBar = sender as TrackBar;
            if (trackBar != null)
            {
                if (trackBar.Name.Equals("tbSpeed"))
                {
                    ShowSpeed(trackBar.Value);
                }
                if (trackBar.Name.Equals("tbVolume"))
                {
                    ShowVolume(trackBar.Value);
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
                sfd.Title = "Save to File";
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

        private void btnRead_Click(object sender, EventArgs e)
        {
            config = new SpeechConfig
            {
                IsRead = cbkRead.Checked,
                IsRecordToFile = cbkRecord.Checked,
                Rate = tbSpeed.Value,
                RecordFilePath = lnkPath.Text,
                VoiceName = cmbVoices.SelectedValue.ToString().Trim(),
                Volume = tbVolume.Value,
                ReadByLine = rbtnLine.Checked
            };
            var rcc = RContentClass.GetReadingPart();
            if (rcc.CurrentContentType == Classes.Params.EnCurrentContent.File
                && string.IsNullOrEmpty(rcc.FileFullName?.Trim())
                && !System.IO.File.Exists(rcc.FileFullName)
                )
            {
                MessageBox.Show(this, "Error: File does not exist or file name is empty.");
                return;
            }
            VServcie.Read(RContentClass, config);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            VServcie.Stop();
            isPause = false;
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            isPause = !isPause;
            VServcie.PauseOrResume(isPause);
        }
    }
}
