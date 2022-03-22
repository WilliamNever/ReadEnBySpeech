using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestWinForm
{
    public partial class MainForm : Form
    {
        private const string defUrl = "https://fanyi.baidu.com/#auto/zh/";
        public MainForm()
        {
            InitializeComponent();
            wbBrwser.Navigated += WbBrwser_Navigated;
        }

        private void WbBrwser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            //var jsStr = wbBrwser.Document.InvokeScript("window['common']");

            var doc = wbBrwser.Document;
            //HtmlElement ele = doc.CreateElement("script");
            //ele.SetAttribute("type", "text/javascript");
            //ele.SetAttribute("text", "function showAppVersion (){ if(typeof window['common']!='undefined') return window['common'] ; }");
            //doc.Body.AppendChild(ele);

            //var jscriptObj = doc.InvokeScript("showAppVersion ");

            var vdoc = doc.GetElementsByTagName("script");//.DomDocument;

        }

        private void btnFuncTest1_Click(object sender, EventArgs e)
        {
            this.wbBrwser.Navigate(defUrl);
        }
    }
}
