using SpeechEnTxt.Classes.BaseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpeechEnTxt.Classes.Models;

namespace SpeechEnTxt.Classes.DomainClasses
{
    public class SpeechReadControls : SpeechBase
    {
        public SpeechReadControls():base()
        {

        }
        public SpeechReadControls(SpeechConfig config) : base(config)
        {
        }
        public override void SetSpeachInit(SpeechConfig Config)
        {
            base.SetSpeachInit(Config);
            ss.SetOutputToDefaultAudioDevice();
        }
    }

    public class SpeechRecordControls : SpeechBase
    {
        public SpeechRecordControls():base()
        {
        }
        public SpeechRecordControls(SpeechConfig config) : base(config)
        {
        }

        public override void SetSpeachInit(SpeechConfig Config)
        {
            base.SetSpeachInit(Config);
            ss.SetOutputToWaveFile(sConfig.RecordFilePath);
        }
    }
}
