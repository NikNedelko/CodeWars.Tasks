using System;
using System.Collections.Generic;
namespace Multiples_of_3_or_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = Kata.Solution(10);
            Console.WriteLine(result);
            Console.ReadLine();

        }

    }
    public static class Kata
    {
        private const int five = 5;
        private const int three = 3;
        public static int Solution(int value)
        {
            List<int> Numbers = new List<int>();
            bool numerInArray = false;
            for (int i = 0; i <= value; i++)
            {
                if (i % three == 0)
                {
                    foreach (var item in Numbers)
                    {
                        if (item == i)
                        {
                            numerInArray = true;
                            break;
                        }
                    }
                    Numbers.Add(i);
                }
                if (i % five == 0)
                {
                    foreach (var item in Numbers)
                    {
                        if (item == i)
                        {
                            numerInArray = true;
                        }
                    }
                    if (numerInArray == false)
                    {
                        Numbers.Add(i);
                    }
                    numerInArray = false;
                }
            }
            int result = new int();
            Numbers.Remove(value);
            foreach (var item in Numbers)
            {
                result += item;
            }
            return result;
        }
    }
}
