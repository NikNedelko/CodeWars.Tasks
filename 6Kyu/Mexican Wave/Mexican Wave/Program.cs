using System;
using System.Collections.Generic;
namespace Mexican_Wave
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Kata.Wave("two words");
        }
    }
    class Kata
    {
        public static List<string> Wave(string str)
        {
            List<string> returnWave = new List<string>();
            char[] arrOfSumb = str.ToCharArray();
            string helper = "";
            for (int i = 0; i < arrOfSumb.Length; i++)
            {
                if (arrOfSumb[i]==' ')
                {
                    continue;
                }
                for (int y = 0; y < arrOfSumb.Length; y++)
                {
                    if (y==i)
                    {
                        helper+= char.ToUpper(arrOfSumb[i]);
                        continue;
                    }
                    helper+=arrOfSumb[y];
                }
                returnWave.Add(helper);
                helper="";
            }
            return returnWave;
        }
    }

}
