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
        public List<PromptBreak> GetSpeechPauses()
        {
            return spCtrl.GetSpeechPauses();
        }

        public void Exit()
        {
            thrRun?.Exit();
        }

        public void Read(IReadContent rContentClass, SpeechConfig config)
        {
            InvokeForm.ShowMessageBox($"Prepare for Reading! - {DateTime.Now.ToString()}", EnShowMessagePlaces.StatusBar);
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
                    InvokeForm.ShowMessageBox($"Reading Now! - {DateTime.Now.ToString()}", EnShowMessagePlaces.StatusBar);
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
            InvokeForm.ShowMessageBox($"Stop Reading! - {DateTime.Now.ToString()}", EnShowMessagePlaces.StatusBar);
        }

        public void PauseOrResume(bool isPause)
        {
            if (isPause)
            {
                thrRun?.Pause();
                InvokeForm.ShowMessageBox($"Pause! - {DateTime.Now.ToString()}", EnShowMessagePlaces.StatusBar);
            }
            else
            {
                thrRun?.Resume();
                InvokeForm.ShowMessageBox($"Resume - {DateTime.Now.ToString()}", EnShowMessagePlaces.StatusBar);
            }
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
