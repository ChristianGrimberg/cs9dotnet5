using System;
using static System.Convert;

namespace CastingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            double b = a;

            Console.WriteLine(b);

            double c = 9.8;
            int d = (int)c;

            Console.WriteLine(d); // d is losing the .8 part

            long e = 10;
            int f = (int)e;

            Console.WriteLine($"e is {e:N0} and f is {f:N0}");

            e = long.MaxValue;
            f = (int)e;

            Console.WriteLine($"e is {e:N0} and f is {f:N0}");

            e = 5_000_000_000;
            f = (int)e;

            Console.WriteLine($"e is {e:N0} and f is {f:N0}");

            double g = 9.8;
            int h = ToInt32(g);

            Console.WriteLine($"g es {g} and h is {h}");

            double[] doubleNumbers = new[] {9.49, 9.5, 9.51, 10.49, 10.5, 10.51};

            foreach (double doubleNumber in doubleNumbers)
            {
                Console.WriteLine($"ToInt({doubleNumber}) is {ToInt32(doubleNumber)}");
            }

            foreach (double doubleNumber in doubleNumbers)
            {
                Console.WriteLine
                (
                    format: "Math.Round({0}, 0, MidpointRounding.AwayFromZero) is {1}",
                    arg0: doubleNumber,
                    arg1: Math.Round(value: doubleNumber, digits: 0, mode: MidpointRounding.AwayFromZero)
                );
            }
        }
    }
}
