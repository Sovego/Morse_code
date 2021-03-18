using System;
using Morse_translator;
namespace Morse_code
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Hello world ");
           string str;
           Console.WriteLine("Input text ");
           str=Console.ReadLine();
           Console.WriteLine("Select Languages 1 ToEnglish 2 ToMorse");
           int i=int.Parse(Console.ReadLine());
           Console.WriteLine(Morse.TranslateToMorseFromEnglish(str,i));
        }
    }
}
