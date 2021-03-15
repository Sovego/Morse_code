using System;
using Morse_translator;
namespace Morse_code
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input Morse Code ");
            string str=Console.ReadLine();
            Console.WriteLine(Morse.TranslateFromMorse(str));
            
        }
    }
}
