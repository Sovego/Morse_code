using System;
using static Morse_code.Morse_Translator.Morse;

namespace Morse_code
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Select Languages 1 ToEnglish 2 ToMorse 3 ToMorseFromRussian 4 ToMorseFormRussian");
            var i = int.Parse(Console.ReadLine() ?? string.Empty);
            TranslateToMorseFromEnglish(i);
        }
    }
}