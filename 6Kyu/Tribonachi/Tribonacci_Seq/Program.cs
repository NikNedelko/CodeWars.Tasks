using System;
using System.Collections.Immutable;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tribonacci_Seq
{
    public class Xbonacci
{
  public double[] Tribonacci(double[] signature, int n)
  {
       double[] exportArr = new double[n];
           if (exportArr.Length<3)
      {
          for (int y = 0; y < n; y++)
          {
              exportArr[y]+=signature[y];
          }
            return exportArr;
      }
      exportArr[0]= signature[0];
      exportArr[1]= signature[1];
      exportArr[2]= signature[2];
      for (int i = 3; i < exportArr.Length; i++)
      {
          exportArr[i] += exportArr[i-1] + exportArr[i-2] + exportArr[i-3];
          for (int ex = 0; ex < exportArr.Length; ex++)
          {
              System.Console.Write(exportArr[ex] + ",");
          }
          System.Console.WriteLine(" ");
      }
    System.Console.WriteLine("passed");
    return exportArr;
  }
}
    class Program
    {

        static void Main(string[] args)
        {
           double[] arr = new double[] {19,1,3}; //put your numbers here
           int howMany =2; // how large array u need
           Xbonacci xbonacci = new Xbonacci();
           double[] result = xbonacci.Tribonacci(arr,howMany);

             for (int eex = 0; eex < result.Length; eex++)
          {
              System.Console.WriteLine(result[eex]);
          }
            System.Console.ReadLine();
        }
    }
}
