using SpeechEnTxt.Classes.Params;
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
    public delegate void ShowMessage(string msg, EnShowMessagePlaces Place);
    public partial class BaseForm : Form
    {
        public ShowMessage PopupMessage;
        public BaseForm()
        {
            InitializeComponent();
            PopupMessage = new ShowMessage(ShowMessageBox);
        }

        public virtual void ShowMessageBox(string Msg, EnShowMessagePlaces Place)
        {
            if ((Place & EnShowMessagePlaces.Popup) == EnShowMessagePlaces.Popup)
            {
                MessageBox.Show(this, Msg);
            }
        }
    }
}
