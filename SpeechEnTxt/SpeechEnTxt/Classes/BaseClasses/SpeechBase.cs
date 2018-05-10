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
        private SpeechSynthesizer ss;

        private SpeechConfig sConfig;

        public SpeechBase()
        {
            ss = new SpeechSynthesizer();
        }

        public SpeechBase(SpeechConfig config):this()
        {
            SetSpeachInit(sConfig);
        }

        public void SetSpeachInit(SpeechConfig Config)
        {
            sConfig = Config;
            ss.SelectVoice(sConfig.VoiceName);
            ss.Rate = sConfig.Rate;
        }

        public virtual void ReadLine(string Txt)
        {
            ss.Speak(Txt);
        }

        public virtual List<InstalledVoice> GetInstalledVoices()
        {
            return ss.GetInstalledVoices()?.ToList();
        }
    }
}
