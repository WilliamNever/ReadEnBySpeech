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
        private Thread ThrRead;
        //, ThrRecord;

        private SpeechReadControls ReadControl;
        private SpeechRecordControls RecordControl;

        private bool IsBreakThread = false;

        public ThreadTemplate(ThrTempParam Controllers)
        {
            rrController = Controllers;

            SetSpeachInit(rrController.Config);
        }

        public void Exit()
        {
            IsBreakThread = true;
            ReadControl?.Exit();
            RecordControl?.Exit();
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
            IsBreakThread = true;
            ReadControl?.Stop();
            RecordControl?.Stop();
        }

        public void Read()
        {
            IsBreakThread = false;
            if (rrController.Config.IsRead)
            {
                ThrRead = new Thread(new ThreadStart(ThrReadFunc));
                ThrRead.Start();
            }
            //if (rrController.Config.IsRecordToFile)
            //{
            //    ThrRecord = new Thread(new ThreadStart(ThrRecordFunc));
            //    ThrRecord.Start();
            //}
        }

        public void ThrReadFunc()
        {
            string[] words;
            string txt;

            switch (rrController.ReadContent.CurrentContentType)
            {
                case EnCurrentContent.Text:
                    txt = rrController.ReadContent.Text;
                    if (rrController.Config.ReadByLine)
                    {
                        words = txt.Split(Environment.NewLine.ToCharArray());
                    }
                    else
                    {
                        words = txt.Split(' ');
                    }
                    foreach (var word in words)
                    {
                        ReadControl.Read(word);
                        if (IsBreakThread) break;
                    }
                    break;
                case EnCurrentContent.File:
                    break;
                default:
                    break;
            }
        }
        //public void ThrRecordFunc()
        //{
        //}

        public void Pause()
        {
            ReadControl?.Pause();
        }

        public void Resume()
        {
            ReadControl?.Resume();
        }
    }
}
