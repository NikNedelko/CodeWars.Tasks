using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
namespace Detect_Pangram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.IsPangram("A pangram is a sentence that contains every single letter of the alphabet at least once."));
            System.Console.ReadLine();
        }
    }

    public static class Kata
    {
        public static bool IsPangram(string str)
        {
            str = Regex.Replace(str, "[0-9]", "", RegexOptions.IgnoreCase);
            str = str.Replace(", ", " ");
            str = str.Replace(". ", " ");
            str = str.Replace(".", "");
            str = str.Replace(",", "");
            str = str.Replace(")", "");
            str = str.Replace("(", "");
            str = str.Replace("!", "");
            str = str.Replace("?", "");

            //str = str.Replace(" ", "");
            char[] result = str.ToCharArray();
            List<char> isRepeated = new List<char>();
            bool IsPangram = new bool();
            string helper = "";
            for (int i = 0; i < result.Length; i++)
            {
                if (i == result.Length-1)
                {
                    IsPangram = panagramDetecter(helper);
                    if (IsPangram == false)
                    {
                        return false;
                    }
                    helper = "";
                    continue;
                }

                if (result[i] == ' ')
                {
                    IsPangram = panagramDetecter(helper);
                    helper = "";
                    continue;
                }
                helper += Convert.ToString(result[i]);

            }
            /*
            foreach (var item in result)
            {
                if (isRepeated.Contains(item))
                {
                    return false;
                }
                isRepeated.Add(item);
            }
            */

            return IsPangram;
        }

        private static bool panagramDetecter(string str)
        {
            List<char> symbols = new List<char>();
            char[] exportedSymbols = str.ToCharArray();
            for (int i = 0; i < exportedSymbols.Length; i++)
            {
                if (symbols.Contains(exportedSymbols[i]))
                {
                    return false;
                    
                }
                symbols.Add(exportedSymbols[i]);
            }


            return true;
        }
    }
}
