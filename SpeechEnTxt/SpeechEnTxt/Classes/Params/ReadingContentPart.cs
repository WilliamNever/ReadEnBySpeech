using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeechEnTxt.Classes.Params
{
    public class ReadingContentPart
    {
        public EnCurrentContent CurrentContentType { get; set; }
        public string Text { get; set; }
        public string FileFullName { get; set; }
    }
}
