using System;

namespace Moving_Zeros_To_The_End
{
    class Program
    {
        static void Main(string[] args)
        {
           Kata.MoveZeroes(new int[] {1, 2, 0, 1, 0, 1, 0, 3, 0, 1});
        }
    }

    public class Kata
    {
        public static int[] MoveZeroes(int[] arr)
        {
            var point = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]==0)
                {
                    point = i;
                    for (int j = i; j < arr.Length; j++)
                    {
                        if (arr[j]!=0)
                        {
                            arr[point] = arr[j];
                            arr[j]=0;
                            break;
                        }
                    }
                }
            }            
            return arr;
        }
    }
}
