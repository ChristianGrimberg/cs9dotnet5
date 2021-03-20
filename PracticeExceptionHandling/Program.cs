using System;

namespace PracticeExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number between 0 and 255: ");
            string input1 = Console.ReadLine();
            Console.Write("Enter another number between 0 and 255: ");
            string input2 = Console.ReadLine();

            try
            {
                byte number1 = byte.Parse(input1);
                byte number2 = byte.Parse(input2);
                Console.WriteLine($"{number1} divided by {number2} is {number1/number2}");
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Input string was not in a correct format.");
            }
            catch (System.OverflowException)
            {
                Console.WriteLine("Input number is not in range.");
            }
            catch (System.DivideByZeroException)
            {
                Console.WriteLine("Can't divided by zero.");
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }
    }
}
