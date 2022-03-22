using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Speech.Synthesis;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestConsole.Utilities;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestToSound(args);
            //string aaa = "aaabbbccc";

            //Regex reg = new Regex("ccc");
            //var tst = reg.Split(aaa);
            //Console.WriteLine(Environment.NewLine);

            TestJsInvoke();

            Console.WriteLine("Any key to exit......");
            Console.ReadKey();
        }

        private static void TestJsInvoke()
        {
            //HttpWebRequest httpWeb = new WebClient();
            //var wc = new WebClient();
            //wc.Encoding = Encoding.UTF8;
            //var str = wc.DownloadString("https://fanyi.baidu.com/#auto/zh/");

            HttpWebRequest httpWebRequest;
            httpWebRequest = (HttpWebRequest)WebRequest.Create("https://fanyi.baidu.com/#auto/zh/");
            httpWebRequest.Headers.Add("Cookie", "BAIDUID=AC87012B7D592EDFDA637683B069D996:FG=1");//BAIDUID=50FD4FD823C5B23F619A393FB32B7123:FG=1
            var response = httpWebRequest.GetResponse();
            
            StreamReader streamReader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
            //string str = new Regex("[\\n]").Replace(this.txtUri.Text.Trim() + "\r\n\r\n" + streamReader.ReadToEnd(), "\r\n");
            var str = streamReader.ReadToEnd();
            string cookie = response.Headers.Get("Set-Cookie");
            streamReader.Close();

            StringBuilder sb_cookie = new StringBuilder();
            var url = "https://fanyi.baidu.com/#auto/zh/";
            CookieContainer cookieContainer = new CookieContainer();
            var uri = new Uri(url);
            var handler = new HttpClientHandler() { UseCookies = true };
            handler.CookieContainer = cookieContainer;
            HttpClient client = new HttpClient(handler);//
            var strRes = client.GetAsync(uri).Result.Content.ReadAsStringAsync().Result;
            List<Cookie> cookies = cookieContainer.GetCookies(uri).Cast<Cookie>().ToList();

            var strResRe = client.GetAsync(uri).Result.Content.ReadAsStringAsync().Result;
            List<Cookie> cookiesRe = cookieContainer.GetCookies(uri).Cast<Cookie>().ToList();

            BaiduSign bs = new BaiduSign();
            var ss = bs.GetJsMethd("exx", new object[] { "methodName" });
        }

        public static void TestToSound(string[] args)
        {
            SpeechSynthesizer ss = new SpeechSynthesizer();
            ss.SelectVoice("Microsoft Zira Desktop");
            Console.WriteLine(ss.Voice.Name);
            ss.Rate = 0;//-10 - 10
            ss.Volume = 80;//0 - 100
            var voices = ss.GetInstalledVoices().ToList();
            //ss.SetOutputToWaveFile("here.wav");
            ss.Speak(@"
                monkey tiger kiwi
            ");
            ss.Speak(@"
                monkey tiger kiwi
            ");

            foreach (var itm in voices)
            {
                Console.WriteLine(itm.VoiceInfo.Name);
            }
        }
    }
}
