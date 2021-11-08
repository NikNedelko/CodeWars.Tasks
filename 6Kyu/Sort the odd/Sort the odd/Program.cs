using System;
using System.Collections.Generic;

namespace Sort_the_odd
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
            Kata.SortArray(array);
            int[] result = Kata.SortArray(array);
            foreach (var item in result)
            {
                System.Console.WriteLine(item + " ");
            }
            Console.ReadLine();
        }
    }
    // 9, 8, 7, 6, 5, 4, 3, 2, 1, 0
    // 1, 8, 3, 6, 5, 4, 7, 2, 9, 0
    public class Kata
    {
        public static int[] SortArray(int[] array)
        {
            List<int> oddNumbers = new List<int>();
            List<int> positions = new List<int>();
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    oddNumbers.Add(array[i]);
                    positions.Add(i);
                }
            }
            oddNumbers.Sort();
            int count = 0;
            foreach (var item in positions)
            {
                array[item] = oddNumbers[count];
                count++;
            }
            return array;
        }
    }
}
