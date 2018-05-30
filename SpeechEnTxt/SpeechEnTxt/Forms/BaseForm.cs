using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpeechEnTxt.Forms
{
    public delegate void ShowMessage(string msg);
    public partial class BaseForm : Form
    {
        public ShowMessage PopupMessage;
        public BaseForm()
        {
            InitializeComponent();
            PopupMessage = new ShowMessage(ShowMessageBox);
        }

        public void ShowMessageBox(string Msg)
        {
            MessageBox.Show(this, Msg);
        }
    }
}
