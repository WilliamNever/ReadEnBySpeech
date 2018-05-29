using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Speech.Synthesis;
using SpeechEnTxt.Classes.Models;

namespace SpeechEnTxt.Classes.BaseClasses
{
    public abstract class SpeechBase
    {
        protected SpeechSynthesizer ss;

        protected SpeechConfig sConfig;
        private bool HasDisposed;

        public SpeechConfig Config { get { return sConfig; } }

        public SpeechBase()
        {
            ss = new SpeechSynthesizer();
            HasDisposed = false;
        }

        public SpeechBase(SpeechConfig config):this()
        {
            sConfig = config;
            SetSpeachInit(sConfig);
        }

        public virtual void SetSpeachInit(SpeechConfig Config)
        {
            sConfig = Config;
            ss.SelectVoice(sConfig.VoiceName);
            ss.Rate = sConfig.Rate;
            ss.Volume = sConfig.Volume;
        }

        public virtual void Read(string Txt)
        {
            ss.SpeakAsync(Txt);
        }

        public virtual void Pause()
        {
            ss.Pause();
        }

        public virtual void Resume()
        {
            ss.Resume();
        }

        public virtual List<InstalledVoice> GetInstalledVoices()
        {
            return ss.GetInstalledVoices()?.ToList();
        }

        public virtual void Stop()
        {
            ss.SpeakAsyncCancelAll();
            ss.Dispose();
            HasDisposed = true;
        }
        public void Exit()
        {
            if (!HasDisposed)
            {
                Stop();
            }
        }
    }
}
