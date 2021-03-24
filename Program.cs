using System;
using Morse_code.Morse_Translator;

namespace Morse_code
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello world ");
            string str;
            Console.WriteLine("Input text ");
            str = Console.ReadLine();
            Console.WriteLine("Select Languages 1 ToEnglish 2 ToMorse");
            var i = int.Parse(Console.ReadLine());
            Morse.TranslateToMorseFromEnglish(i);
            //Console.WriteLine(Morse.TranslateToMorseFromEnglish(i));
        }
    }
}