using System;
using System.Collections.Generic;
namespace Give_me_a_Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine(Diamond.print(9));
        }
    }

    public class Diamond
    {
        const string space = " ";
        const string star = "*";
        const string newStr = "\n";

        public static string print(int n)
        {
            if (n == 0 || n < 0 || n % 2 == 0)
            {
                return null;
            }
            string result = "";
            string[] helper = new string[(n + 1) / 2];
            string printer = "";
            int starCounter = 0;
            int spaceCounter = 0;
            List<string> stroki = new List<string>();
            for (int i = n; i > 0; i--)
            {
                printer += star;
            }
            printer += newStr;
            starCounter = n - 2;
            spaceCounter += 1;
            stroki.Add(printer);
            printer = "";
            for (; starCounter >= 1; starCounter -= 2, spaceCounter += 1)
            {
                for (int y = 0; y < spaceCounter; y++)
                {
                    printer += space;
                }
                for (int z = 0; z < starCounter; z++)
                {
                    printer += star;
                }
                printer += newStr;
                stroki.Add(printer);
                printer = "";
            }
            for (int i = (n + 1) / 2; i > 0; i--)
            {
                result += stroki[i - 1];
            }
            for (int i = 1; i < stroki.Count; i++)
            {

                result += stroki[i];
            }

            return result;
        }
    }
}
