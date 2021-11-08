using System;

namespace Your_order__please
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine(Kata.Order("4of Fo1r pe6ople g3ood th5e the2"));
            Console.ReadLine();
        }

        public static class Kata
        {
            public static string Order(string words)
            {

                if (words == "")
                {
                    return "";
                }
                string result = "";
                int counterOfWords = new int();
                char[] convertedWords = words.ToCharArray();
                foreach (var item in words)
                {
                    if (item == ' ')
                    {
                        counterOfWords++;
                    }
                }
                string[] preResult = new string[counterOfWords + 1];
                string helper = "";
                for (int i = 0; i <= convertedWords.Length; i++)
                {
                    if (i == convertedWords.Length)
                    {
                        preResult[Sorter(helper, counterOfWords) - 1] = helper;
                        helper = "";

                        continue;
                    }
                    if (convertedWords[i] == ' ')
                    {
                        preResult[Sorter(helper, counterOfWords) - 1] = helper;
                        helper = "";
                        continue;
                    }
                    helper += convertedWords[i];
                }
                int end = 0;
                foreach (var item in preResult)
                {
                    result += item;
                    if (counterOfWords > end)
                    {
                        result += " ";
                        end++;
                    }
                }
                return result;
            }

            private static int Sorter(string words, int numberInPosition)
            {
                char[] position = words.ToCharArray();
                int positionInArray = new int();
                foreach (var item in position)
                {
                    try
                    {
                        positionInArray = Convert.ToInt32(Convert.ToString(item));
                    }
                    catch (System.Exception)
                    {
                    }
                }
                System.Console.WriteLine(positionInArray);
                return positionInArray;
            }
        }
    }
}
