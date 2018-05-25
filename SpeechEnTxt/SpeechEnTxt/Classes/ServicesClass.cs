using SpeechEnTxt.Classes.DomainClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpeechEnTxt.Classes.Models;

namespace SpeechEnTxt.Classes
{
    public class ServicesClass
    {
        private Form InvokeForm;
        private SpeechReadControls spReadCtrl = null;
        private SpeechRecordControls spRecordCtrl = null;
        public ServicesClass(Form form)
        {
            InvokeForm = form;
            spReadCtrl = new DomainClasses.SpeechReadControls();
        }

        public List<InstalledVoice> GetInstalledVoices()
        {
            return spReadCtrl.GetInstalledVoices();
        }

        public void SetSpeachInit(SpeechConfig config)
        {
            spReadCtrl = new SpeechReadControls(config);
            if (config.IsRecordToFile)
            {
                //if (spRecordCtrl != null&&spRecordCtrl.Config.RecordFilePath.Equals(config.RecordFilePath))
                //{
                //    spRecordCtrl.Stop();
                //}
                spRecordCtrl = new DomainClasses.SpeechRecordControls(config);
            }
        }

        public void Read(IReadContent rContentClass)
        {
            var readContents = rContentClass.GetReadingPart();
            switch (readContents.CurrentContentType)
            {
                case Params.EnCurrentContent.Text:
                    break;
                case Params.EnCurrentContent.File:
                    break;
                case Params.EnCurrentContent.NotSelected:
                default:
                    break;
            }
        }

        public void Stop()
        {
            spReadCtrl.Stop();
            spRecordCtrl.Stop();
        }
    }
}
