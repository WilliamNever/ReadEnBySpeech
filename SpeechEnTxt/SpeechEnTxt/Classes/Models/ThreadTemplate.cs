﻿using SpeechEnTxt.Classes.DomainClasses;
using SpeechEnTxt.Classes.Params;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Speech.Synthesis;
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

        private bool IsBreakThread = false;

        //private StreamReader sr;
        //private FileStream fs;

        public ThreadTemplate(ThrTempParam Controllers)
        {
            rrController = Controllers;
            //sr = null;
            //fs = null;
            
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
        public void OverRec()
        {
            RecordControl?.Stop();
            rrController.InvokeForm.Invoke(rrController.InvokeForm.PopupMessage, "Record Over!");
        }

        public void Read()
        {
            IsBreakThread = false;

            //rrController.ReadContent.Text = Novel;

            if (rrController.Config.IsRead)
            {
                ThrRead = new Thread(new ThreadStart(ThrReadFunc));
                ThrRead.Start();
            }
            if (rrController.Config.IsRecordToFile)
            {
                ThrRecord = new Thread(new ThreadStart(ThrRecordFunc));
                ThrRecord.Start();
            }
        }

        public void ThrReadFunc()
        {
            string[] words;
            string txt;
            PromptBuilder pmpt;

            switch (rrController.ReadContent.CurrentContentType)
            {
                case EnCurrentContent.Text:
                    #region TEXT Part
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
                        pmpt = new PromptBuilder();
                        pmpt.AppendText(word);
                        pmpt = AddBreakPauseInEnd(pmpt);
                        ReadControl.Read(pmpt);
                        if (IsBreakThread) break;
                    }
                    break;
                #endregion
                case EnCurrentContent.File:
                    #region File Part
                    using (var fs = new FileStream(rrController.ReadContent.FileFullName, FileMode.Open, FileAccess.Read, FileShare.Read))
                    {
                        using (var sr = new StreamReader(fs))
                        {
                            txt = sr.ReadLine();
                            while (txt != null)
                            {
                                words = new string[] { txt };
                                if (!rrController.Config.ReadByLine)
                                {
                                    words = txt.Split(' ');
                                }
                                if (IsBreakThread) break;
                                foreach (var word in words)
                                {
                                    pmpt = new PromptBuilder();
                                    pmpt.AppendText(word);
                                    pmpt = AddBreakPauseInEnd(pmpt);
                                    ReadControl.Read(pmpt);
                                    if (IsBreakThread) break;
                                }
                                if (IsBreakThread) break;
                                txt = sr.ReadLine();
                            }
                        }
                    }
                    break;
                    #endregion
                default:
                    break;
            }
        }
        public void ThrRecordFunc()
        {
            string[] words;
            string txt;
            PromptBuilder pmpt;

            switch (rrController.ReadContent.CurrentContentType)
            {
                case EnCurrentContent.Text:
                    #region Text Part
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
                        pmpt = new PromptBuilder();
                        pmpt.AppendText(word);
                        pmpt = AddBreakPauseInEnd(pmpt);
                        RecordControl.Read(pmpt);
                        if (IsBreakThread) break;
                    }
                    OverRec();
                    break;
                    #endregion
                case EnCurrentContent.File:
                    #region File Part
                    using (var fs = new FileStream(rrController.ReadContent.FileFullName, FileMode.Open, FileAccess.Read, FileShare.Read))
                    {
                        using (var sr = new StreamReader(fs))
                        {
                            txt = sr.ReadLine();
                            while (txt != null)
                            {
                                words = new string[] { txt };
                                if (!rrController.Config.ReadByLine)
                                {
                                    words = txt.Split(' ');
                                }
                                if (IsBreakThread) break;
                                foreach (var word in words)
                                {
                                    pmpt = new PromptBuilder();
                                    pmpt.AppendText(word);
                                    pmpt = AddBreakPauseInEnd(pmpt);
                                    RecordControl.Read(pmpt);
                                    if (IsBreakThread) break;
                                }
                                if (IsBreakThread) break;
                                txt = sr.ReadLine();
                            }
                        }
                    }
                    OverRec();
                    break;
                    #endregion
                default:
                    break;
            }
        }

        private PromptBuilder AddBreakPauseInEnd(PromptBuilder pmpt)
        {
            if (rrController.Config.BreakType != PromptBreak.None && rrController.Config.PauseTimes > 0)
            {
                for (int i = 0; i < rrController.Config.PauseTimes; i++)
                {
                    pmpt.AppendBreak(rrController.Config.BreakType);
                }
            }
            return pmpt;
        }

        public void Pause()
        {
            ReadControl?.Pause();
        }

        public void Resume()
        {
            ReadControl?.Resume();
        }

        public void SetVolume(int volume)
        {
            ReadControl?.SetVolume(volume);
        }
        public void SetRate(int Rate)
        {
            ReadControl?.SetRate(Rate);
        }
    }
}
