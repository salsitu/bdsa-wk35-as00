using System;

namespace MyApp
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Type a year:");
            string input = Console.ReadLine();
            int parsed;
            
            try
            {
                 parsed = int.Parse(input);
            }
            catch (System.FormatException)
            {
                Console.WriteLine("You need to enter a number, quitting!");
                return;
            }

            if (parsed < 1582)
            {
                Console.WriteLine("Cannot handle years below 1582, quitting!");
                return;
            }
            
            if (isLeapYear(parsed))
            {
                Console.WriteLine("yay");
            }
            else
            {
                Console.WriteLine("nay");
            }
        }

        public static bool isLeapYear(int year)
        {
            return year % 400 == 0 || (year % 4 == 0 && year % 100 != 0);
        }
    }
}
