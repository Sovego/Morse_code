using System;
using System.Collections.Generic;
using System.IO;

namespace Morse_code.Morse_Translator
{
    public class Morse
    {
        private static readonly Dictionary<string, string> _abc1 = new(36)
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

        private static readonly Dictionary<string, string> _abc2 = new(36)
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

        private static readonly Dictionary<string, string> _abc3 = new(41)
        {
            ["*-"] = "А",
            ["-***"] = "Б",
            ["*--"] = "В",
            ["--*"] = "Г",
            ["-**"] = "Д",
            ["*"] = "Е",
            ["***-"] = "Ж",
            ["--**"] = "З",
            ["**"] = "И",
            ["-*-*"] = "К",
            ["*-**"] = "Л",
            ["--"] = "М",
            ["-*"] = "Н",
            ["---"] = "О",
            ["*--*"] = "П",
            ["*-*"] = "Р",
            ["***"] = "С",
            ["-"] = "Т",
            ["**-"] = "У",
            ["**-*"] = "Ф",
            ["****"] = "Х",
            ["-*-*"] = "Ц",
            ["---*"] = "Ч",
            ["----"] = "Ш",
            ["--*-"] = "Щ",
            ["*--*-*"] = "Ъ",
            ["-*--"] = "Ы",
            ["-**-"] = "Ь",
            ["***-***"] = "Э",
            ["**--"] = "Ю",
            ["*-*-"] = "Я",
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

        private static readonly Dictionary<string, string> _abc4 = new(41)
        {
            ["А"] = "*-",
            ["Б"] = "-***",
            ["В"] = "*--",
            ["Г"] = "--*",
            ["Д"] = "-**",
            ["Е"] = "*",
            ["Ж"] = "***-",
            ["З"] = "--**",
            ["И"] = "**",
            ["К"] = "-*-*",
            ["Л"] = "*-**",
            ["М"] = "--",
            ["Н"] = "-*",
            ["О"] = "---",
            ["П"] = "*--*",
            ["Р"] = "*-*",
            ["С"] = "***",
            ["Т"] = "-",
            ["У"] = "**-",
            ["Ф"] = "**-*",
            ["Х"] = "****",
            ["Ц"] = "-*-*",
            ["Ч"] = "---*",
            ["Ш"] = "----",
            ["Щ"] = "--*-",
            ["Ъ"] = "*--*-*",
            ["Ы"] = "-*--",
            ["Ь"] = "-**-",
            ["Э"] = "***-***",
            ["Ю"] = "**--",
            ["Я"] = "*-*-",
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


        /// <summary>
        ///     Translation from English/Russian to Morse or Morse to English/Russian
        /// </summary>
        /// <param name="instrInput text
        /// 
        /// </param>
        /// <returns>Translated text</returns>
        public static void TranslateToMorseFromEnglish(int i)
        {
            var instr = "";
            using (var fReader = new StreamReader("./read.txt"))
            {
                while (!fReader.EndOfStream)
                    instr += Convert.ToChar(fReader.Read());
            }

            Console.WriteLine(instr);
            var outStr = "";
            while (instr.Length > 0)
            {
                var j = 0;
                var x = "";
                while (j < instr.Length && instr[j] != ' ')
                {
                    x += instr[j];
                    j++;
                }

                if (instr[0] == ' ') x += "1";
                instr = instr.Remove(0, x.Length);
                if (x == "1")
                    outStr += " ";
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
                                outStr += x;
                            }

                            break;
                        }
                        case 2:
                            try
                            {
                                outStr += _abc2[x];
                            }
                            catch
                            {
                                outStr += x;
                            }

                            break;
                        case 3:
                            try
                            {
                                outStr += _abc3[x];
                            }
                            catch
                            {
                                outStr += x;
                            }

                            break;
                        case 4:
                            try
                            {
                                outStr += _abc4[x];
                            }
                            catch
                            {
                                outStr += x;
                            }


                            break;
                    }
            }


            using (var fWriter = new StreamWriter("./output.txt", false))
            {
                fWriter.Write(outStr);
            }
        }
    }
}