using SpeechEnTxt.Classes.DomainClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpeechEnTxt.Classes.Models;
using SpeechEnTxt.Classes.Params;
using SpeechEnTxt.Forms;

namespace SpeechEnTxt.Classes
{
    public class ServicesClass
    {
        private BaseForm InvokeForm;
        private SpeechReadControls spCtrl = null;
        private ThreadTemplate thrRun = null;
        public ServicesClass(BaseForm form)
        {
            InvokeForm = form;
            spCtrl = new DomainClasses.SpeechReadControls();
        }

        public List<InstalledVoice> GetInstalledVoices()
        {
            return spCtrl.GetInstalledVoices();
        }

        public void Exit()
        {
            thrRun?.Exit();
        }

        public void Read(IReadContent rContentClass, SpeechConfig config)
        {
            var readContents = rContentClass.GetReadingPart();
            switch (readContents.CurrentContentType)
            {
                case Params.EnCurrentContent.Text:
                case Params.EnCurrentContent.File:
                    var tmpParam = new ThrTempParam
                    {
                        Config = config,
                        ReadContent = readContents,
                        InvokeForm = InvokeForm,
                    };
                    Exit();
                    thrRun = new ThreadTemplate(tmpParam);
                    thrRun.Read();
                    break;
                case Params.EnCurrentContent.NotSelected:
                default:
                    break;
            }
        }

        public void Stop()
        {
            if (thrRun != null)
            {
                thrRun.Stop();
            }
        }

        public void PauseOrResume(bool isPause)
        {
            if (isPause)
                thrRun?.Pause();
            else
                thrRun?.Resume();
        }
        public void SetVolume(int volume)
        {
            thrRun?.SetVolume(volume);
        }
        public void SetRate(int Rate)
        {
            thrRun?.SetRate(Rate);
        }
    }
}
