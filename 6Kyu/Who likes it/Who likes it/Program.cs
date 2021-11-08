using System;

namespace Who_likes_it
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[]{"Alex", "Jacob", "Mark", "Max"};
            string[] names2 = new string[]{"Jacob", "Alex"};
            string[] names3 = new string[]{"Peter"};
            string[] names4 = new string[0]{};
            System.Console.WriteLine(Kata.Likes(names));
            System.Console.WriteLine(Kata.Likes(names2));
            System.Console.WriteLine(Kata.Likes(names3));
            System.Console.WriteLine(Kata.Likes(names4));
            Console.ReadLine();
        }
    }

    public static class Kata
    {
        public static string Likes(string[] names)
        {
            if (names.Length==0)
            {
                return "no one likes this";
            }
            if (names.Length==2)
            {
                return $"{names[0]} and {names[1]} like this";
            }
            if (names.Length==3)
            {
                return $"{names[0]}, {names[1]} and {names[2]} like this";
            }
            if (names.Length>3)
            {
               return $"{names[0]}, {names[1]} and {names.Length-2} others like this";
            }

            return $"{names[0]} likes this";
        }
    }
}
