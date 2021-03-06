﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpeechEnTxt.Classes.Models
{
    public class SpeechConfig
    {
        public int Rate { get; set; }
        public string VoiceName { get; set; }
        public int Volume { get; set; }
        public bool IsRead { get; set; }
        public bool IsRecordToFile { get; set; }
        public string RecordFilePath { get; set; }
        //public int WordInterval { get; set; }
        public bool ReadByLine { get; set; }
        public PromptBreak BreakType { get; set; }
        public int PauseTimes { get; set; }
        public List<string> VoiceAvailableList { get; set; }

        public SpeechConfig()
        {
            IsRecordToFile = false;
            IsRead = true;
        }
    }
}
