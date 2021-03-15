using System.Collections.Generic;

namespace Morse_translator
{
    public class Morse
    {

        /// <summary>
        /// Translation from Morse code into English
        /// </summary>
        /// <param name="str">morse string</param>
        /// <returns>Translated meaning</returns>
        public static string TranslateFromMorse(string str)

        {
            Dictionary<string, string> _abc = new(36)
            {
                ["*-"] = "A",
                ["-***"] = "B",
                ["-*-*"] = "C",
                ["-**"] = "D",
                ["*"] = "E",
                ["**-*"] = "F",
                ["--*"] = "G",
                ["****"] = "H",
                ["**"] = "I",
                ["*---"] = "J",
                ["-*-"] = "K",
                ["*-**"] = "L",
                ["--"] = "M",
                ["-*"] = "N",
                ["---"] = "O",
                ["*--*"] = "P",
                ["--*-"] = "Q",
                ["*-*"] = "R",
                ["***"] = "S",
                ["-"] = "T",
                ["**-"] = "U",
                ["***-"] = "V",
                ["*--"] = "W",
                ["-**-"] = "X",
                ["-*--"] = "Y",
                ["--**"] = "Z",
                ["*----"] = "1",
                ["**---"] = "2",
                ["***--"] = "3",
                ["****-"] = "4",
                ["*****"] = "5",
                ["-****"] = "6",
                ["--***"] = "7",
                ["---**"] = "8",
                ["----*"] = "9",
                ["-----"] = "0"
            };
            string outStr = "";
            while (str.Length > 0)
            {
                int i = 0;
                int j = i;
                string x = "";

                {
                    while (j < str.Length && str[j] != ' ')
                    {
                        x += str[j];
                        j++;
                    }
                }
                if (str[0] == ' ')
                {
                    x += "1";
                }
                str = str.Remove(0, x.Length);
                if (x == "1")
                {
                    outStr += " ";
                }
                else outStr += _abc[x];
                i++;
            }

            return outStr;

        }
    }
}

