using System;

namespace ParsingStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse("38");
            DateTime birthday = DateTime.Parse("2 November 1982");

            Console.WriteLine($"I was born {age} years ago.");
            Console.WriteLine($"My birthday is {birthday}.");
            Console.WriteLine($"My birthday is {birthday:D}.");

            Console.WriteLine("\nHow many eggs are there?");
            int count;
            string input = Console.ReadLine();

            if(int.TryParse(input, out count))
            {
                Console.WriteLine($"There are {count} eggs.");
            }
            else
            {
                Console.WriteLine("I could not parse the input.");
            }
        }
    }
}
