using System;
using System.Collections.Generic;

namespace Snail
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[,]
            {
            {1, 2,  3,  4},
            {5, 6,  7,  8},
            {9, 10, 11, 12},
            {13,14, 15, 16}
            };

            int[][] arrayTwo =
      {
           new []{39,408,571,449,378,445,49,296,36,246,259,785,606,855,9,575,172,996,110,863},
           new []{589,916,911,895,413,65,507,314,358,460,814,49,667,505,285,544,913,35,266,214},
           new []{415,675,286,700,61,797,653,614,531,547,600,861,894,799,58,124,498,676,37,314},
           new []{938,736,939,577,433,211,119,102,571,466,663,138,730,896,449,915,630,211,835,616},
           new []{413,894,784,811,860,953,155,868,448,162,46,237,998,952,276,680,737,709,267,850},
           new []{679,551,43,65,885,463,132,999,351,143,494,288,842,422,902,45,953,128,718,480},
           new []{56,251,655,410,421,426,140,778,620,770,178,921,944,985,937,862,851,719,926,398},
           new []{822,157,518,305,668,758,396,577,51,232,728,609,992,787,795,429,897,634,645,460},
           new []{323,354,379,582,966,573,344,857,485,40,195,234,202,320,659,899,734,350,742,663},
           new []{30,564,728,389,43,569,930,157,191,509,966,217,75,467,76,469,779,937,340,96},
           new []{415,539,92,11,37,494,407,673,129,  896,696,547,893,982,430,759,626,990,539,397},
           new []{644,187,667,977,75,978,160,736,245,191,121,797,11,646,249,492,473,717,352,550},
           new []{163,258,29,295,813,420,325,93,37,317,843,789,398,943,453,228,873,115,937,60},
           new []{334,672,428,938,775,899,536,247,734,939,287,910,639,990,235,386,159,372,164,656},
           new []{653,68,700,929,349,333,400,69,194,22,619,358,780,293,216,491,830,91,521,915},
           new []{884,79,360,98,31,934,150,408,708,67,69,501,951,282,407,267,972,500,590,443},
           new []{499,468,54,712,320,929,130,347,775,744,556,68,852,250,772,575,708,602,898,415},
           new []{183,993,361,127,953,119,408,498,886,950,519,331,501,79,416,416,26,648,779,103},
           new []{804,804,634,965,511,1,650,702,511,832,559,371,602,175,260,507,107,928,760,202},
           new []{522,632,461,825,225,226,568,773,834,356,550,61,824,796,612,380,359,397,616,952}

       };
            int[][] arrayThree ={
           new[]{1,2,3,4,5},
           new[]{6,7,8,9,10},
           new[]{11,12,13,14,15},
           new[]{16,17,18,19,20},
           new[]{21,22,23,24,25}
       };
            int[][] array4 = { };
            int[][] array5 = {
                new[]{1}
            };
            SnailSolution.Snail(array4);
            SnailSolution.Snail(array5);
            SnailSolution.Snail(arrayThree);
            SnailSolution.Snail(arrayTwo);
            System.Console.ReadLine();
        }
    }

    public class SnailSolution
    {
        public static List<int> height = new List<int>();
        public static List<int> width = new List<int>();
        public static bool needChek = new bool();
        public static int counter = 0;
        public static int[] Snail(int[][] array)
        {
            int[,] newArray = new int[array.Length, array.Length];
            int[] result = new int[newArray.Length];
            int helper = 0;
            
            if (array.Length < 2)
            {
                try
                {
                    System.Console.WriteLine(array[0][0]);
                }
                catch (System.Exception)
                {
                    int[] emptyArr = { };
                    return emptyArr;
                }

            }
            
            for (int i = 0, j = 0, k = 0; i < array.Length * array.Length; i++, k++)
            {

                if (helper == array.Length)
                {
                    k = -1;
                    j++;
                    helper = 0;
                    i -= 1;
                    continue;
                }
                newArray[j, k] = array[j][k];
                helper++;
            }

            int x = 0, y = 0;
            RightUpWidth(newArray, ref result, x, y);
            height.Clear();
            width.Clear();
            needChek = false;
            counter = 0;
            foreach (var item in result)
            {
                System.Console.WriteLine(result[item]);
            }
            return result;
        }

        public static int[] RightUpWidth(int[,] arr, ref int[] returArr, int x, int y)
        {
            for (; x < arr.GetLength(0); x++)
            {

                if (returArr.Length == counter)
                {
                    return returArr;
                }

                if (needChek == true)
                {
                    for (int i = 0; i < height.Count; i++)
                    {
                        if (height[i] == y && width[i] == x)
                        {
                            return DownHeight(arr, ref returArr, x - 1, y + 1);
                        }
                    }
                }
                returArr[counter] = arr[y, x];
                height.Add(y);
                width.Add(x);
                counter++;
            }

            return DownHeight(arr, ref returArr, x - 1, y + 1);
        }
        public static int[] DownHeight(int[,] arr, ref int[] returArr, int x, int y)
        {
            for (; y < arr.GetLength(1); y++)
            {
                if (returArr.Length == counter)
                {
                    return returArr;
                }

                if (needChek == true)
                {
                    for (int i = 0; i < height.Count; i++)
                    {
                        if (height[i] == y && width[i] == x)
                        {
                            return LeftDownWidth(arr, ref returArr, x - 1, y - 1);
                        }
                    }
                }

                returArr[counter] = arr[y, x];
                height.Add(y);
                width.Add(x);
                counter++;
            }
            return LeftDownWidth(arr, ref returArr, x - 1, y - 1);
        }
        public static int[] LeftDownWidth(int[,] arr, ref int[] returArr, int x, int y)
        {
            for (; x >= 0; x--)
            {
                if (returArr.Length == counter)
                {
                    return returArr;
                }

                if (needChek == true)
                {
                    for (int i = 0; i < height.Count; i++)
                    {
                        if (height[i] == y && width[i] == x)
                        {
                            return UpHeight(arr, ref returArr, x + 1, y - 1);
                        }
                    }
                }

                returArr[counter] = arr[y, x];
                height.Add(y);
                width.Add(x);
                counter++;
            }
            needChek = true;
            return UpHeight(arr, ref returArr, x + 1, y - 1);
        }
        public static int[] UpHeight(int[,] arr, ref int[] returArr, int x, int y)
        {
            for (; y >= 0; y--)
            {
                if (returArr.Length == counter)
                {
                    return returArr;
                }

                if (needChek == true)
                {
                    for (int i = 0; i < height.Count; i++)
                    {
                        if (height[i] == y && width[i] == x)
                        {
                            return RightUpWidth(arr, ref returArr, x + 1, y + 1);
                        }
                    }
                }
                returArr[counter] = arr[y, x];
                height.Add(y);
                width.Add(x);
                counter++;
            }
            return RightUpWidth(arr, ref returArr, x, y);

        }
    }
}
