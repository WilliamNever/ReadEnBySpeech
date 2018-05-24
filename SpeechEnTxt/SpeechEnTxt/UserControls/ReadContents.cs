using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpeechEnTxt.Classes.Params;

namespace SpeechEnTxt.UserControls
{
    public partial class ReadContents : UserControl
    {
        public ReadContents()
        {
            InitializeComponent();
        }

        public EnCurrentContent GetCurrentContentType
        {
            get
            {
                var rValue = EnCurrentContent.NotSelected;
                switch (this.tabReadContents.SelectedTab.Name)
                {
                    case "tpWords":
                        rValue = EnCurrentContent.Text;
                        break;
                    case "tpFile":
                        rValue = EnCurrentContent.File;
                        break;
                }
                return rValue;
            }
        }

        public ReadingContentPart GetReadingPart()
        {
            ReadingContentPart rValue = new ReadingContentPart();
            return rValue;
        }
    }
}
