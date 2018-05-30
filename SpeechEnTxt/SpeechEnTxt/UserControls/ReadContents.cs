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
using SpeechEnTxt.Classes.Models;

namespace SpeechEnTxt.UserControls
{
    public partial class ReadContents : UserControl, IReadContent
    {
        public ReadContents()
        {
            InitializeComponent();
        }

        EnCurrentContent IReadContent.GetCurrentContentType
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

        ReadingContentPart IReadContent.GetReadingPart()
        {
            return new ReadingContentPart
            {
                CurrentContentType = ((IReadContent)this).GetCurrentContentType,
                Text = this.txtInfors.Text,
                FileFullName = txtFilePath.Text
            };
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            if (opf.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = opf.FileName;
            }
        }
    }
}
