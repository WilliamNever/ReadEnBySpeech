using SpeechEnTxt.Classes.DomainClasses;
using SpeechEnTxt.Classes.Params;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SpeechEnTxt.Classes.Models
{
    public class ThreadTemplate
    {
        private ThrTempParam rrController;
        private Thread ThrRead, ThrRecord;

        private SpeechReadControls ReadControl;
        private SpeechRecordControls RecordControl;


        private AutoResetEvent autoSet;
        private bool IsPause, IsExistThread;
        public ThreadTemplate(ThrTempParam Controllers)
        {
            rrController = Controllers;
            autoSet = new AutoResetEvent(false);
            IsPause = false;
            IsExistThread = false;

            SetSpeachInit(rrController.Config);
        }

        private void SetSpeachInit(SpeechConfig config)
        {
            if (config.IsRead)
            {
                ReadControl = new SpeechReadControls(config);
            }
            if (config.IsRecordToFile)
            {
                RecordControl = new DomainClasses.SpeechRecordControls(config);
            }
        }

        public void Stop()
        {
            IsExistThread = true;

            ReadControl?.Stop();
            RecordControl?.Stop();
        }

        public void Read()
        {
            if (rrController.Config.IsRead)
            {

            }
            if (rrController.Config.IsRecordToFile)
            {
            }
        }

        public void ThrReadFunc()
        { }
        public void ThrRecordFunc()
        { }

        private void ReadArtical(string txt)
        {
            var listTxt = txt.Split(Environment.NewLine.ToCharArray());     //(new char[] { '\r', '\n' });
            foreach (var str in listTxt)
            {
            }
        }

        public void Pause()
        {
            IsPause = true;
            ReadControl?.Pause();
        }

        public void Resume()
        {
            IsPause = false;
            autoSet.Set();
            ReadControl?.Resume();
        }
    }
}
