using System;

namespace WeIrD_StRiNg_CaSe
{
    public class Kata
{
  public static string ToWeirdCase(string s)
  {
    char[] Slovo = s.ToCharArray();




                for (int i = 0; i < s.Length; i += 2)
                {


                    if (Slovo[i] != ' ')
                    {

                        if (s.Length - i == 1)
                        {

                        Slovo[i] = char.ToUpper(Slovo[i]);

                        }

                        else
                        {

                        Slovo[i] = char.ToUpper(Slovo[i]);

                        Slovo[i + 1] = char.ToLower(Slovo[i + 1]);


                        }
                    }


                    else
                    {
                        i -= 1;
                    }
                }
                return new string(Slovo); ;
  }
}

class MainClass
{
    public static void Main(string[] args)
        {
            string inp = "Weird string case";

            string result =Kata.ToWeirdCase(inp);

            Console.WriteLine(result);
            Console.ReadLine();
        }
}
}
