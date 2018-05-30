using SpeechEnTxt.Classes.DomainClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpeechEnTxt.Classes.Models;
using System.Windows.Forms;
using SpeechEnTxt.Forms;

namespace SpeechEnTxt.Classes.Params
{
    public class ThrTempParam
    {
        public SpeechConfig Config { get; set; }
        public BaseForm InvokeForm { get; set; }
        public ReadingContentPart ReadContent { get; set; }
    }
}
