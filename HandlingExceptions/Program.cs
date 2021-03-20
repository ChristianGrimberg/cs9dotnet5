using System;

namespace HandlingExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Before parsing");
            Console.Write("What's your age? ");
            string input = Console.ReadLine();

            try
            {
                int age = int.Parse(input);
                Console.WriteLine($"You are {age} years old.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.GetType()} says {ex.Message}");
            }

            Console.WriteLine("After parsing");
        }
    }
}
