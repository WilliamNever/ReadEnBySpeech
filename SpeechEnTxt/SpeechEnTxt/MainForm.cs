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

namespace SpeechEnTxt
{
    public partial class frmMainForm : BaseForm
    {
        private ServicesClass VoiceService;
        public frmMainForm()
        {
            InitializeComponent();
            VoiceService = new Classes.ServicesClass(this);
        }
    }
}
