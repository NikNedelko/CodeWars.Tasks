using System;

namespace Split_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SplitString.Solution("abc"));

            Console.WriteLine(SplitString.Solution("abcdef"));

        }
    }

    public class SplitString
    {
        public static string[] Solution(string str)
        {
            char[] convertedStr = str.ToCharArray();
            if (convertedStr.Length % 2 == 0)
            {
                string[] result = new string[convertedStr.Length / 2];
                for (int i = 0, y = 1, z = 0; z < result.Length; i += 2, y += 2, z++)
                {
                    result[z] = Convert.ToString(convertedStr[i]) + Convert.ToString(convertedStr[y]);
                }
                return result;
            }
            else
            {
                string[] result = new string[(convertedStr.Length + 1) / 2];
                for (int i = 0, y = 1, z = 0; z < result.Length; i += 2, y += 2, z++)
                {
                    try
                    {
                        result[z] = Convert.ToString(convertedStr[i]) + Convert.ToString(convertedStr[y]);
                    }
                    catch 
                    {
                        result[z] = Convert.ToString(convertedStr[i]) + "_";
                    }
                }
                return result;
            }
        }
    }
}
