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
            string tss = "\u73af\u5883";
            string rssd = ((char)int.Parse("73af", System.Globalization.NumberStyles.HexNumber)).ToString();

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
            client.DefaultRequestHeaders.AcceptEncoding.Add(new System.Net.Http.Headers.StringWithQualityHeaderValue("UTF-8"));
            var strRes = client.GetAsync(uri).Result.Content.ReadAsStringAsync().Result;
            List<Cookie> cookies = cookieContainer.GetCookies(uri).Cast<Cookie>().ToList();

            var strResRe = client.GetAsync(uri).Result.Content.ReadAsStringAsync().Result;
            List<Cookie> cookiesRe = cookieContainer.GetCookies(uri).Cast<Cookie>().ToList();

            string msgs = "from=en&to=zh&query=environment&transtype=realtime&simple_means_flag=3&sign=603378.907203&token=0acc583ba7d5580926b8cadf802a6f38&domain=common";
            string token = "";
            //string cookValue = "";
            //client.DefaultRequestHeaders.Add("Cookie", cookValue);

            MultipartFormDataContent content = new MultipartFormDataContent();
            content.Add(new StringContent("en"), "from");
            content.Add(new StringContent("zh"), "to");
            content.Add(new StringContent("environment"), "query");
            content.Add(new StringContent("realtime"), "transtype");
            content.Add(new StringContent("3"), "simple_means_flag");

            content.Add(new StringContent("603378.907203"), "sign");
            content.Add(new StringContent(token), "token");
            content.Add(new StringContent("common"), "domain");
            //content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/x-www-form-urlencoded")
            //{
            //    CharSet = "UTF-8",
            //};

            var tmp = client.PostAsync("https://fanyi.baidu.com/v2transapi?from=en&to=zh"
                , content
                ).Result.Content.ReadAsStringAsync().Result;

            Regex reg = new Regex(@"[\\]+u(\w{4})");
            var rslt = reg.Replace(tmp, delegate (Match m)
            {
                string hexStr = m.Groups[1].Value;
                string charStr = ((char)int.Parse(hexStr, System.Globalization.NumberStyles.HexNumber)).ToString();
                return charStr;
            });

            BaiduSign bs = new BaiduSign();
            //var rslt = bs.GetJsMethd("tryConvert", new object[] { tmp });
            Console.WriteLine(rslt);

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
