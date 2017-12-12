using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GoldenQuiz
{
    class Program
    {
        static void Main(string[] args)
        {

            SpeechSynthesizer synth = new SpeechSynthesizer();

            Console.WriteLine("Hi!\n" +
                               "What's your name?");
            string inputName = Console.ReadLine();

            Console.Clear();
            Console.WriteLine($"Glad to meet you, {inputName}.");
            Thread.Sleep(1000);
            Console.WriteLine("\nChoose a level.\n" +
                "1: Rose - Easy (Also could be called Blanche)\n" +
                "2: Dorothy - Hard\n" +
                "3: Sophia - Sassy\n");

            //Get Value User Provided
            int inputLevel = Int32.Parse(Console.ReadLine());
        }
    }
}
