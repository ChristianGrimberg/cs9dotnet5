using System;

namespace ConvertingToString
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 12;
            Console.WriteLine(number.ToString());

            bool boolean = true;
            Console.WriteLine(boolean.ToString());

            DateTime now = DateTime.Now;
            Console.WriteLine(now.ToString());

            object me = new object();
            Console.WriteLine(me.ToString());

            //allocate array of 128 bytes
            byte[] binaryObject = new byte[128];
            //populate array with random bytes
            (new Random()).NextBytes(binaryObject);

            Console.WriteLine("\nBinary Object as bytes:");

            for (int i = 0; i < binaryObject.Length; i++)
            {
                Console.Write($"{binaryObject[i]:X} ");
            }

            Console.WriteLine();

            string encoded = Convert.ToBase64String(binaryObject);

            Console.WriteLine($"\nBinary Object as Base64:\n{encoded}");
        }
    }
}
