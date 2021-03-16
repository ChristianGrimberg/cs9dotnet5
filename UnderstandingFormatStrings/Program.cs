using System;

namespace UnderstandingFormatStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string applesText = "Apples";
            int applesCount = 1234;
            string bananasText = "Bananas";
            int bananasCount = 56789;
            
            Console.WriteLine
            (
                format: "{0,-8} {1,6:N0}",
                arg0: "Name",
                arg1: "Count"
            );
            
            Console.WriteLine
            (
                format: "{0,-8} {1,6:N0}",
                arg0: applesText,
                arg1: applesCount
            );
            
            Console.WriteLine
            (
                format: "{0,-8} {1,6:N0}",
                arg0: bananasText,
                arg1: bananasCount
            );
        }
    }
}
