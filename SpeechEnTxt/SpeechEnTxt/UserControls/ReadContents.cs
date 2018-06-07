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

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInfors.Text = "";
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            txtInfors.Text = @"
                You can Use the tool with marked invoice in text, like this:
                @@@1@@@Hello World!@@@0@@@Hello World!
                Ps: the 0, 1 are the index in the voice list. the first index is 0.
                If your list include more than 1 item. You can click read button to test.:)
                ";
        }
    }
}
