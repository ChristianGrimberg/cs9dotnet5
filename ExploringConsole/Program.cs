using System;

namespace ExploringConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfApples = 12;
            decimal pricePerApple = 0.35M;

            Console.WriteLine
            (
                format: "{0} apples costs {1:C}",
                arg0: numberOfApples,
                arg1: pricePerApple * numberOfApples
            );

            string positionArgumentsFormating = string.Format
            (
                format: "{0} apples costs {1:C}",
                arg0: numberOfApples,
                arg1: pricePerApple * numberOfApples
            );
            Console.WriteLine(positionArgumentsFormating);

            Console.WriteLine($"{numberOfApples} apples costs {pricePerApple * numberOfApples:C}");

            string interpolatedFormating = string.Format($"{numberOfApples} apples costs {pricePerApple * numberOfApples:C}");
            Console.WriteLine(interpolatedFormating);
        }
    }
}
