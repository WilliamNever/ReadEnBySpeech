using SpeechEnTxt.Classes.BaseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpeechEnTxt.Classes.Models;
using System.Threading;
using System.Speech.Synthesis;

namespace SpeechEnTxt.Classes.DomainClasses
{
    public class SpeechReadControls : SpeechBase
    {
        protected AutoResetEvent AutoHandler = null;
        public SpeechReadControls():base()
        {

        }
        public SpeechReadControls(SpeechConfig config) : base(config)
        {
        }
        public override void SetSpeachInit(SpeechConfig Config)
        {
            ClassIDName = "Read";

            base.SetSpeachInit(Config);
            ss.SetOutputToDefaultAudioDevice();
            AutoHandler = new AutoResetEvent(false);
            ss.SpeakCompleted += new EventHandler<System.Speech.Synthesis.SpeakCompletedEventArgs>(FinishedEvent);
        }

        private void FinishedEvent(object sender, SpeakCompletedEventArgs e)
        {
            AutoHandler?.Set();
        }
        public override void Read(string Txt)
        {
            base.Read(Txt);
            AutoHandler?.WaitOne();
        }
        public override void Stop()
        {
            AutoHandler?.Set();
            base.Stop();
        }
        public override void Exit()
        {
            AutoHandler?.Set();
            base.Exit();
            ss.Dispose();
        }
    }

    public class SpeechRecordControls : SpeechBase
    {
        protected AutoResetEvent AutoHandler = null;
        public SpeechRecordControls():base()
        {
        }
        public SpeechRecordControls(SpeechConfig config) : base(config)
        {
        }

        public override void SetSpeachInit(SpeechConfig Config)
        {
            ClassIDName = "Record";
            base.SetSpeachInit(Config);
            ss.SetOutputToWaveFile(sConfig.RecordFilePath);
            AutoHandler = new AutoResetEvent(false);
            ss.SpeakCompleted += new EventHandler<System.Speech.Synthesis.SpeakCompletedEventArgs>(FinishedEvent);
        }
        private void FinishedEvent(object sender, SpeakCompletedEventArgs e)
        {
            AutoHandler?.Set();
        }
        public override void Read(string Txt)
        {
            base.Read(Txt);
            AutoHandler?.WaitOne();
        }
        public override void Stop()
        {
            base.Stop();
            ss.Dispose();
            HasDisposed = true;
        }
    }
}
