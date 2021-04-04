using System;

namespace TupleTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Tuple Types
            var provider1 = (Name:"Microsoft", Product:"Azure");
            (string Name, string Product) provider2 = ("Amazon", "AWS");

            Console.WriteLine($"The cloud is {provider1.Name} {provider1.Product}.");
            Console.WriteLine($"The cloud is {provider2.Name} {provider2.Product}.");
            #endregion
        }
    }
}
