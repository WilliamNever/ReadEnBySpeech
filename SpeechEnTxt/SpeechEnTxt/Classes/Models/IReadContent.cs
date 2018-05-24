using SpeechEnTxt.Classes.Params;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeechEnTxt.Classes.Models
{
    public interface IReadContent
    {
        EnCurrentContent GetCurrentContentType { get; }
        ReadingContentPart GetReadingPart();
    }
}
