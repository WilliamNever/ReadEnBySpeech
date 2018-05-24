using SpeechEnTxt.Classes.DomainClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpeechEnTxt.Classes
{
    public class ServicesClass
    {
        private Form InvokeForm;
        private SpeechControls spCtrl;
        public ServicesClass(Form form)
        {
            InvokeForm = form;
            spCtrl = new DomainClasses.SpeechControls();
        }

        public List<InstalledVoice> GetInstalledVoices()
        {
            return spCtrl.GetInstalledVoices();
        }
    }
}
