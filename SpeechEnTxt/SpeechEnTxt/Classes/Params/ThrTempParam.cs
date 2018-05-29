using SpeechEnTxt.Classes.DomainClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpeechEnTxt.Classes.Models;

namespace SpeechEnTxt.Classes.Params
{
    public class ThrTempParam
    {
        public SpeechConfig Config { get; internal set; }
        public ReadingContentPart ReadContent { get; internal set; }
    }
}
