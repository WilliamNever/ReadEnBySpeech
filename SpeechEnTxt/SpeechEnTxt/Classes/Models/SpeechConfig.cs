using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public int WordInterval { get; internal set; }

        public SpeechConfig()
        {
            IsRecordToFile = false;
            IsRead = true;
        }
    }
}
