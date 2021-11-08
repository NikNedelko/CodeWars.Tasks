using System;

namespace Sum_of_Digits___Digital_Root
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = Number.DigitalRoot(8);
            System.Console.WriteLine(result);
            Console.ReadLine();
        }
    }

    class Number
    {
        public static int DigitalRoot(long n)
        {
            string bufer = Convert.ToString(n);
            Char[] convertedNumber = bufer.ToCharArray();
            int isReadyForREturn = Converter(convertedNumber);
            while (isReadyForREturn >= 10)
            {
                isReadyForREturn = Converter(convertedNumber = Convert.ToString(isReadyForREturn).ToCharArray());
            }
            return isReadyForREturn;
        }

        private static int Converter(char[] numbers)
        {
            int forReturn = new int();
            foreach (var item in numbers)
            {
                forReturn += Convert.ToInt32(Convert.ToString(item));
            }
            return forReturn;
        }
    }
}
