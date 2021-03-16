using System;

namespace GettingTextInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type your First Name and press ENTER: ");
            string firstName = Console.ReadLine();
            Console.Write("Type your Age and press ENTER: ");
            string age = Console.ReadLine();

            Console.WriteLine($"Hello {firstName}, you look good for {age}.");
        }
    }
}
