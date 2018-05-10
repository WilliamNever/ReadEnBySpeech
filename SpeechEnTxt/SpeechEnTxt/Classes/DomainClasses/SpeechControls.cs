using SpeechEnTxt.Classes.BaseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpeechEnTxt.Classes.Models;

namespace SpeechEnTxt.Classes.DomainClasses
{
    public class SpeechControls : SpeechBase
    {
        public SpeechControls() : base()
        {

        }
        public SpeechControls(SpeechConfig config) : base(config)
        {
        }

        public void ReadArtical(string txt)
        {
            var listTxt = txt.Split(new char[] { '\r', '\n' });
            foreach (var str in listTxt)
            {
                ReadLine(str);
            }
        }
    }
}
