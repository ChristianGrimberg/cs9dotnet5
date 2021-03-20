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
            catch (OverflowException)
            {
                Console.WriteLine("Your age is a valid number format but it's either too big or small.");
            }
            catch (FormatException)
            {
                Console.WriteLine("The age you entered is not a valid number format.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.GetType()} says {ex.Message}");
            }

            Console.WriteLine("After parsing");
            
            try
            {
                checked
                {
                    int x = int.MaxValue - 1;
                    Console.WriteLine($"\nInitial value: {x}");
                    x++;
                    Console.WriteLine($"After incrementing: {x}");
                    x++;
                    Console.WriteLine($"After incrementing: {x}");
                    x++;
                    Console.WriteLine($"After incrementing: {x}");
                }

                unchecked
                {
                    int x = int.MaxValue + 1;
                    Console.WriteLine($"\nInitial value: {x}");
                    x++;
                    Console.WriteLine($"After incrementing: {x}");
                    x++;
                    Console.WriteLine($"After incrementing: {x}");
                    x++;
                    Console.WriteLine($"After incrementing: {x}");
                }
            }
            catch (System.OverflowException)
            {
                Console.WriteLine("The code overflowed but I caught the exception.");
            }
        }
    }
}
