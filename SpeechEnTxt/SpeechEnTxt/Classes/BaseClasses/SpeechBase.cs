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
        protected bool HasDisposed;

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
            SetSelectVoice(sConfig.VoiceName);
            ss.Rate = sConfig.Rate;
            ss.Volume = sConfig.Volume;
        }

        public virtual void SetSelectVoice(string VoiceName)
        {
            ss.SelectVoice(VoiceName);
        }

        public virtual void Read(PromptBuilder pmpt)
        {
            ss.SpeakAsync(pmpt);
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
            if (!HasDisposed)
            {
                ss.SpeakAsyncCancelAll();
            }
        }
        public virtual void Exit()
        {
            if (!HasDisposed)
            {
                Stop();
            }
        }
        protected string ClassIDName;

        public List<PromptBreak> GetSpeechPauses()
        {
            var itValue = Enum.GetValues(typeof(PromptBreak)).OfType<PromptBreak>().ToList();
            return itValue;
        }
    }
}
