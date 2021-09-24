using System;
using System.Collections.Generic;

namespace HiNumbers
{
    class Kata{

     static List<int> repeatedNumbers = new List<int>();
     public static int HighestRank (int[] arr){
         int counter = new int();
         int isRepeated = new int();
         bool ifValueWasRepeated= new bool();
         int result = new int();
         int counterOfNUMBER = new int();
         Array.Sort(arr);
         for (int i = 0; i < arr.Length; i++)
         {
             ifValueWasRepeated = valueWasRepeated(arr[i]);
             if (ifValueWasRepeated == true)
             {
                continue; 
             }
          for (int y = 0; y < arr.Length; y++)
          {
              if(arr[i]==arr[y]){
                  if (isRepeated == 0)
                  {
                      isRepeated++;
                  }
                  counter++;
                  continue;  
              }
              else
              {
                  continue;
              }
          }
          //Console.WriteLine(array[i]+ " was repeated = " + counter);
          if (counter>counterOfNUMBER)
          {
              result = arr[i];
              counterOfNUMBER = 0;
              counterOfNUMBER += counter;
              counter=0;
              isRepeated=0;
              continue;
          }
          
             
              if (counterOfNUMBER == counter)
              {
                  if (result>arr[i])
                  {
                     counterOfNUMBER = 0;
                     counterOfNUMBER += counter;
                     counter=0;
                     isRepeated=0; 
                     continue;
                  }
              
              else{
                  result = arr[i];
                  counterOfNUMBER = 0;
                  counterOfNUMBER += counter;
                  counter=0;
                  isRepeated=0;
                  continue;
              }
              }
              counter=0;
              isRepeated=0; 
              
               
         }
       
         repeatedNumbers.Clear();   
         return result;
    }
    static bool valueWasRepeated(int value){
        foreach (int item in repeatedNumbers)
        {
            if (value!=item)
            {
            }
            else
            {
                return true;
            }
        }
        repeatedNumbers.Add(value);
        return false;
    }
}

//////////////////
    class Program
    {
        static void Main(string[] args)
        {
            var firstArr = new int[] { 12,10,8,12,7,6,4,10,12 };
            var secArr = new int[] { 12,10,8,12,7,6,4,10,10 };
            int firstResult = Kata.HighestRank(firstArr);
           
            System.Console.WriteLine(firstResult);

            if(firstResult==10){
                Console.WriteLine("Mission complete");
            }
            else{
                System.Console.WriteLine("переделывай");
            }

            int secondResult = Kata.HighestRank(secArr);

              System.Console.WriteLine(secondResult);
            if(secondResult==10){
                Console.WriteLine("Mission complete");
            }
            else{
                System.Console.WriteLine("переделывай");
            } 
        }
    }
}
