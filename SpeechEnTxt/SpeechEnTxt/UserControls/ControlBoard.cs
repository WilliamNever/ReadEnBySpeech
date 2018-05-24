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

namespace SpeechEnTxt.UserControls
{
    public partial class ControlBoard : UserControl
    {
        private ServicesClass VServcie;
        public ControlBoard()
        {
            InitializeComponent();
        }
        public void SetVoiceServcie(ServicesClass VoiceService)
        {
            VServcie = VoiceService;
        }
        public ControlBoard(ServicesClass VoiceService) :this()
        {
            SetVoiceServcie(VoiceService);
        }

        private void ControlBoard_Load(object sender, EventArgs e)
        {
            cmbVoices.DataSource = VServcie.GetInstalledVoices()?
                .Select(x => new { Name = x.VoiceInfo.Name }).ToList();
            cmbVoices.DisplayMember = "Name";

            ShowSpeed(this.tbSpeed);
            ShowVolume(this.tbVolume);
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
    }
}
