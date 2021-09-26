using System;

namespace Is_a_number_prime_
{
    public static class Kata
{
 public static bool IsPrime(int n)
        {
        
            int Deliteli = 0;
   
            if (n<0)
            {
                
                    return false;

            }
            
            if (n > 99999)
            {
                for (int i = 1; i <= 100000; i++)
                {
                    if (n % i == 0)
                    {
                        Deliteli++;
                    }
                  if (Deliteli >=2 && i<100000)
                    {

                        return false;
                    }
                }

                if (Deliteli < 2 && Deliteli > 0)
                {
                    Deliteli++;


                }

                if (Deliteli == 2)
                {

                    return true;
                }
                else
                {
                    return false;
                }
            }
            
            else
            {


                for (int i = 1; i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        Deliteli++;
                    }
                }

                if (Deliteli == 2)
                {

                    return true;
                }
                else
                {
                    return false;
                }
            }
            
        }
    }

class Main
{
    public static void Main(string[] args)
        {
            int value = 116153939;

            bool result =Kata.IsPrime(value);

            Console.WriteLine(result);
            Console.ReadLine();

        }
}



}
