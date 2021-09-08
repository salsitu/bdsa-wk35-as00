using System;

namespace MyApp
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Type a year:");
            string input = Console.ReadLine();
            
            if (isLeapYear(int.Parse(input)))
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
            return (year % 4 == 0 && year % 100 != 0) || year % 400 == 0;
        }
    }
}
