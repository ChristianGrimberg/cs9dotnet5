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

            Console.Write("Press any key combination: ");
            ConsoleKeyInfo key = Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine
            (
                "Key: {0}, Char: {1}, Modifiers: {2}",
                arg0: key.Key,
                arg1: key.KeyChar,
                arg2: key.Modifiers
            );
        }
    }
}
