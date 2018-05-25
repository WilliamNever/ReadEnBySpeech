using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            TestToSound(args);

            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("Any key to exit......");
            Console.ReadKey();
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

            
            foreach (var itm in voices)
            {
                Console.WriteLine(itm.VoiceInfo.Name);
            }
        }
    }
}
