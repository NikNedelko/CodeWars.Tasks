using System;
// https://www.codewars.com/kata/5848565e273af816fb000449
namespace Encrypt_this
{
    public class Kata
    {
       public static string EncryptThis( string input)
        {
            char[] redesign = input.ToCharArray();
            string forReturn= "";
            string convertHelper="";
            int counterForStop = redesign.Length-1;
            int counter=0;
            for (int i = 0; i < redesign.Length; i++)
            {
                convertHelper+= redesign[i];
                counter++;
              if(redesign[i]==' ' || i == counterForStop)
              {
                  forReturn+= PartOfText(convertHelper, counter, counterForStop+1);
                  
                  convertHelper="";
              }
                
            }
            return forReturn;
        }
      
      public static string PartOfText(string TextForRedesign, int counter, int counterForStop){
        
        char[] charOfPart = TextForRedesign.ToCharArray();
        string returnOfPart="";
        int helperForFIrstWord=0;
        int firstCounter = 0;
          if (charOfPart.Length-1 ==0)
          {
              returnOfPart+=Convert.ToString(helperForFIrstWord = Convert.ToInt32(charOfPart[0]));
              return returnOfPart;
          }
          
          if (charOfPart.Length==2)
          {
              
              returnOfPart+=Convert.ToString(helperForFIrstWord = Convert.ToInt32(charOfPart[0]));
              returnOfPart+=Convert.ToString(charOfPart[1]);
              return returnOfPart;
          }
           if (charOfPart.Length==3)
          {
              if (charOfPart[2]!=' ')
              {
              returnOfPart+=Convert.ToString(helperForFIrstWord = Convert.ToInt32(charOfPart[0]));
              returnOfPart+=Convert.ToString(charOfPart[2]);
              returnOfPart+=Convert.ToString(charOfPart[1]);
              return returnOfPart;
              }
              returnOfPart+=Convert.ToString(helperForFIrstWord = Convert.ToInt32(charOfPart[0]));
              returnOfPart+=Convert.ToString(charOfPart[1]);
              returnOfPart+=Convert.ToString(charOfPart[2]);
              return returnOfPart;
          }
            char[] helperChar = new char[charOfPart.Length];

         for (int i = 0, x=0; i <charOfPart.Length ; i++, x++)
         {
             helperChar[x]+= charOfPart[i]; 
         }
         if (counterForStop == counter)
         {
             charOfPart[1] = charOfPart[charOfPart.Length-1];
          charOfPart[charOfPart.Length-1] = helperChar[1];
          returnOfPart += Convert.ToString(helperForFIrstWord = Convert.ToInt32(charOfPart[0]));
           for (int i = 1; i < charOfPart.Length; i++)
          {
              returnOfPart+= charOfPart[i];
          }
          return returnOfPart;
         }
          
          charOfPart[1] = charOfPart[charOfPart.Length-2];
          charOfPart[charOfPart.Length-2] = helperChar[1];
          returnOfPart += Convert.ToString(helperForFIrstWord = Convert.ToInt32(charOfPart[0]));

          for (int i = 1; i < charOfPart.Length; i++)
          {
              returnOfPart+= charOfPart[i];
          }

        return returnOfPart;

        }
    }
}
