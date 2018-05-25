using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeechEnTxt.Classes.Models
{
    public class ThreadTemplate
    {
        public void ReadArtical(string txt)
        {
            var listTxt = txt.Split(Environment.NewLine.ToCharArray());     //(new char[] { '\r', '\n' });
            foreach (var str in listTxt)
            {
            }
        }
    }
}
