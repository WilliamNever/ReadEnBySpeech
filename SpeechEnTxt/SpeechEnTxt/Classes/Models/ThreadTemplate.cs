using SpeechEnTxt.Classes.BaseClasses;
using SpeechEnTxt.Classes.DomainClasses;
using SpeechEnTxt.Classes.Params;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Text.RegularExpressions;
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
        private Regex reg;

        public ThreadTemplate(ThrTempParam Controllers)
        {
            rrController = Controllers;
            
            SetSpeachInit(rrController.Config);

            reg = new Regex("@@@[0-9]+@@@");
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
            rrController.InvokeForm.Invoke(rrController.InvokeForm.PopupMessage
                , $"Record Over! - {DateTime.Now.ToString()}", EnShowMessagePlaces.Popup | EnShowMessagePlaces.StatusBar);
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

        private void RWTextWithPause(SpeechBase RWControl, string tmp)
        {
            PromptBuilder pmpt = new PromptBuilder();
            pmpt.AppendText(tmp);
            pmpt = AddBreakPauseInEnd(pmpt);
            RWControl.Read(pmpt);
        }

        private void ReadWriteTxt(SpeechBase RWControl, string[] words)
        {
            string tmp = "";
            int wordPartsIndex, matchIndex;
            MatchCollection matches;
            string[] wordParts;
            Match match;

            foreach (var word in words)
            {
                if (reg.IsMatch(word))
                {
                    wordPartsIndex = 0;
                    matchIndex = 0;
                    matches = reg.Matches(word);
                    wordParts = reg.Split(word);
                    match = matches[matchIndex];

                    if (match.Index > 0)
                    {
                        tmp = wordParts[wordPartsIndex];
                        RWTextWithPause(RWControl, tmp);
                    }
                    wordPartsIndex++;
                    do
                    {
                        var vIndexStr = match.Value.Replace("@", "");
                        int vIndex;
                        if (!int.TryParse(vIndexStr, out vIndex))
                        {
                            vIndex = -1;
                        }
                        if (vIndex > -1 && vIndex < rrController.Config.VoiceAvailableList.Count)
                        {
                            RWControl.SetSelectVoice(rrController.Config.VoiceAvailableList[vIndex]);
                        }
                        if (wordPartsIndex < wordParts.Length)
                        {
                            tmp = wordParts[wordPartsIndex];
                            RWTextWithPause(RWControl, tmp);
                        }
                        else
                            break;

                        if (IsBreakThread) break;

                        wordPartsIndex++;
                        matchIndex++;

                        if (matchIndex < matches.Count)
                        {
                            match = matches[matchIndex];
                        }
                        else
                            break;
                    }
                    while (true);
                    if (IsBreakThread) break;
                }
                else
                {
                    tmp = word;
                    RWTextWithPause(RWControl, tmp);
                }
                if (IsBreakThread) break;
            }
        }

        public void ThrReadFunc()
        {
            string[] words;
            string txt;
            //PromptBuilder pmpt;

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
                    ReadWriteTxt(ReadControl, words);
                    rrController.InvokeForm.Invoke(rrController.InvokeForm.PopupMessage
                        , $"Finish Reading! - {DateTime.Now.ToString()}", EnShowMessagePlaces.StatusBar);
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
                                ReadWriteTxt(ReadControl, words);
                                if (IsBreakThread) break;
                                txt = sr.ReadLine();
                            }
                        }
                    }
                    rrController.InvokeForm.Invoke(rrController.InvokeForm.PopupMessage
                        , $"Finish Reading! - {DateTime.Now.ToString()}", EnShowMessagePlaces.StatusBar);
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
                    ReadWriteTxt(RecordControl, words);
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
                                ReadWriteTxt(RecordControl, words);
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
