using System;
namespace Does_my_number_look_big_in_this
{
    class Program
    {
        static void Main(string[] args)
        {
            
            System.Console.WriteLine(Kata.Narcissistic(1652));
            System.Console.ReadLine();
        }
    }

    public class Kata
    {
        public static bool Narcissistic(int value)
        {
            //bool isThatNarcis = new bool();
            char[] converter = Convert.ToString(value).ToCharArray();
            double sum = new double();
            for (int i = 1; i < 10; i++)
            {

                for (int y = 0; y < converter.Length; y++)
                {
                    sum+=Math.Pow(Convert.ToDouble(Convert.ToString(converter[y])),i);
                }
                if (value == sum)
                {
                    return true;
                }
                sum = 0;
            }
            return false;
        }
    }
}
