using System;
using System.Collections.Generic;
// https://www.codewars.com/kata/52de553ebb55d1fca3000371
namespace Find_the_missing_term_in_an_Arithmetic_Progression
{


    class Kata
    {
        
    
      public static int FindMissing(List<int> list)
  {
    
            int ValueOfList = list[1] - list[0];
            int Search = 0;
            int FirstPosition = list[0];


           if (list.Count<=3)
            {

                if (list[1]-list[0]>list[2]-list[1])
                {
                    int SpecValue = list[2] - list[1];
                    if (list[1] > 1300)
                    {

                        
                        return list[1] - SpecValue;


                    }

                    return list[2] - SpecValue;


                 

                }



                  else if (list[1] < 1300)
                {

                    int SpecValue = list[1] - list[0];
                    return list[2] - SpecValue;


                }

                else if (list[1] > 1300)
                {
                    int SpecValue = list[2] - list[1];
                    return list[1] - SpecValue;
                }

            }



            if (list[1] - list[0] == list[2] - list[1])
            {

                Search += FirstPosition;        


                for (int i = 0; i < list.Count; i++)
                {

                    if (i==0) 
                    {
                        continue;
                    }

                    else
                    {
                        Search += ValueOfList;
                        if (Search != list[i])
                        {
                            return Search;
                        }
                    }
                }

  
            }
            else if (list[4] - list[3] == list[3] - list[2])
            {
                Search += FirstPosition;


                for (int i = 0; i < list.Count; i++)
                {

                    if (i == 0)
                    {
                        continue;
                    }

                    else
                    {
                        Search += ValueOfList;
                        if (Search != list[i])
                        {
                            return Search;
                        }
                    }
                }

            }




            return 0;
  }

    }
    class MainClass
    {
        
    

   public static void Main(string[] args)
        {
            List<int> Numbers = new List<int>{ 1040, 1400, 1580 };

            int result =Kata.FindMissing(Numbers);


            Console.Write(result);
            Console.ReadLine();

        }
    }
}
