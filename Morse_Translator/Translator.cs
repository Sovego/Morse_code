using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Morse_translator
{
    public class Morse
    {
        private static Dictionary<string, string> _abc1 = new(36)
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
        private static Dictionary<string, string> _abc2 = new(36)
        {
            ["A"] = "*-",
            ["B"] = "-***",
            ["C"] = "-*-*",
            ["D"] = "-**",
            ["E"] = "*",
            ["F"] = "**-*",
            ["G"] = "--*",
            ["H"] = "****",
            ["I"] = "**",
            ["J"] = "*---",
            ["K"] = "-*-",
            ["L"] = "*-**",
            ["M"] = "--",
            ["N"] = "-*",
            ["O"] = "---",
            ["P"] = "*--*",
            ["Q"] = "--*-",
            ["R"] = "*-*",
            ["S"] = "***",
            ["T"] = "-",
            ["U"] = "**-",
            ["V"] = "***-",
            ["W"] = "*--",
            ["X"] = "-**-",
            ["Y"] = "-*--",
            ["Z"] = "--**",
            ["1"] = "*----",
            ["2"] = "**---",
            ["3"] = "***--",
            ["4"] = "****-",
            ["5"] = "*****",
            ["6"] = "-****",
            ["7"] = "--***",
            ["8"] = "---**",
            ["9"] = "----*",
            ["0"] = "-----"
        };

        private static Dictionary<string, string> _abc3 = new(41)
        {
            ["*-"]="А",
            ["-***"]="Б",
            ["*--"]="В",
            ["--*"]="Г",
            ["-**"]="Д",
            ["*"]="Е",
            ["***-"]="Ж",
            ["--**"]="З",
            ["**"]="И",
            ["-*-*"]="К",
            ["*-**"]="Л",
            ["--"]="М",
            ["-*"]="Н",
            ["---"]="О",
            ["*--*"]="П",
            ["*-*"]="Р",
            ["***"]="С"
        };

        /// <summary>
        /// Translation from English/Russian to Morse or Morse to English/Russian
        /// </summary>
        /// <param name="str">Input text</param>
        /// <returns>Translated text</returns>
        public static string TranslateToMorseFromEnglish(string str, int i)
        {
            
            string outStr = "";
            while (str.Length > 0)
            {
                int j = 0;
                string x = "";
                while (j < str.Length && str[j] != ' ')
                {
                    x += str[j];
                    j++;
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
                else
                    switch (i)
                    {
                        case 1:
                        {
                            try
                            {
                                outStr += _abc1[x];
                            }
                            catch
                            {
                                return "KeyNotFoundException";
                            }
                            break;
                        }
                        case 2: try
                            {
                                outStr += _abc2[x];
                            }
                            catch
                            {
                                return "KeyNotFoundException";
                            }

                            break;
                        case 3:
                            try
                            {
                                outStr += _abc3[x];
                            }
                            catch
                            {
                                return "KeyNotFoundException";
                            } break;
                        case 4:try
                            {
                               // outStr += _abc4[x];
                            }
                            catch
                            {
                                return "KeyNotFoundException";
                            } break;
                    }
                    
            }
            return outStr;
        }

        
    }
}

