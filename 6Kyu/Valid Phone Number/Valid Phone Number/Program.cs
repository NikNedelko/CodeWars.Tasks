using System;
using System.Text.RegularExpressions;
// https://www.codewars.com/kata/525f47c79f2f25a4db000025
namespace Valid_Phone_Number
{
    public static class Kata
{
  public static bool ValidPhoneNumber(string phoneNumber)
  {
     string pattern = @"^(\(\d{3}\)\s\d{3}\-\d{4})$";

            Regex regex = new Regex(pattern);

            if (Regex.IsMatch(phoneNumber, pattern, RegexOptions.IgnoreCase))
            {
                return true;
            }
            else
            {
                return false;
            }
  }
}
    class Program
    {
        static void Main(string[] args)
        {
            string number = "(123) 456-7890";
            Kata.ValidPhoneNumber(number);
        }
    }
}
