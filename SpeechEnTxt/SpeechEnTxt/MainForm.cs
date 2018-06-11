using SpeechEnTxt.Classes;
using SpeechEnTxt.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpeechEnTxt.Classes.Params;

namespace SpeechEnTxt
{
    public partial class frmMainForm : BaseForm
    {
        private ServicesClass VoiceService;
        public frmMainForm() : base()
        {
            InitializeComponent();
            VoiceService = new Classes.ServicesClass(this);
            this.CtrBoard.SetVoiceServcie(VoiceService, this.rcReadingContents);
        }

        private void frmMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            VoiceService.Exit();
        }

        public override void ShowMessageBox(string Msg, EnShowMessagePlaces Place)
        {
            base.ShowMessageBox(Msg, Place);
            if ((Place & EnShowMessagePlaces.StatusBar) == EnShowMessagePlaces.StatusBar)
            {
                //lblStatus.Text = Msg;
                stbar.Items["lblStatus"].Text = Msg;
            }
        }
    }
}
