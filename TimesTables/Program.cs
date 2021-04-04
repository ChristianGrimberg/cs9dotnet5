using System;

namespace TimesTables
{
    class Program
    {
        static void Main(string[] args)
        {
            RunsTimeTable();
        }

        static void TimesTable(byte number)
        {
            Console.WriteLine($"This is the {number} times table:");

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{number} x {i} = {number * i}");
            }

            Console.WriteLine();
        }

        static void RunsTimeTable()
        {
            bool isNumber;

            do
            {
                Console.Write("Enter a number between 0 and 255: ");
                isNumber = byte.TryParse(Console.ReadLine(), out byte number);

                if(isNumber)
                {
                    TimesTable(number);
                }
                else
                {
                    Console.WriteLine("You did not enter a valid number!");
                }
            } while (!isNumber);
        }
    }
}
