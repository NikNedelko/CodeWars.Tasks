using System;
using System.Collections.Generic;
namespace Take_a_Number_And_Sum_Its_Digits_Raised_To_The_Consecutive_Powers_And
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            SumDigPower.SumDigPow(1,100);
        }
        
    }

    public class SumDigPower
    {

        public static long[] SumDigPow(long a, long b)
        {
            List<long> preResult = new List<long>();
            for (long i = a; i < b; i++)
            {
                string number = Convert.ToString(i);
                char[] helper = number.ToCharArray();
                double count=1;
                long summ=0;
                for (int y = 0; y < helper.Length; y++)
                {
                    summ+=Convert.ToInt64(Math.Pow(Convert.ToDouble(Convert.ToString(helper[y])), count));
                    count++;
                }
                if (summ==i)
                {
                    preResult.Add(summ);
                }

            }
            long[] result = new long[preResult.Count];
           for (int i = 0; i < preResult.Count; i++)
           {
               result[i]=preResult[i];
           }
            return result;
        }
    }
}
