using System;

namespace Simple_Pig_Latin
{
    class Program
    {
        static void Main(string[] args)
        {

            Kata.PigItLikePro("Pig latin is cool"); // igPay atinlay siay oolcay
            Kata.PigIt("Hello world !"); // elloHay orldway !
            Kata.PigIt("elloHay orldway !");
        }
    }

    public class Kata
    {
        //second solution
        public static string PigItLikePro(string str)
        {
            var result = "";
            var words = str.Split(" ");
            for (int i = 0; i < words.Length; i++)
            {
                var helper = words[i];
                if (!char.IsPunctuation(helper[0]))
                {
                    result += words[i].Substring(1) + helper[0] + "ay";
                }
                else
                {
                    result += helper;
                }
                if (i + 1 != words.Length)
                {
                    result += " ";
                }
            }
            return result;
        }

        //first solution
        public static string PigIt(string str)
        {
            var result = "";
            var wordFlex = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ' || i + 1 == str.Length)
                {
                    if (i + 1 == str.Length && char.IsPunctuation(str[i]) == false)
                    {
                        wordFlex += str[i];
                    }
                    if (i + 1 == str.Length && char.IsPunctuation(str[i]) == true)
                    {
                        wordFlex += str[i];
                        result += wordFlex;
                        return result;
                    }
                    result += wordFlex.Substring(1) + wordFlex[0] + "ay";
                    wordFlex = "";
                    if (i + 1 != str.Length)
                    {
                        result += " ";
                    }
                    continue;
                }
                wordFlex += str[i];
            }
            return result;
        }
    }
}
