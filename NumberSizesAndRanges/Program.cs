using System;

namespace NumberSizesAndRanges
{
    class Program
    {
        static void Main(string[] args)
        {
            // Header
            Console.WriteLine(new String('-',101));
            Console.WriteLine
            (
                format: "{0,-10} {1,18} {2,35} {3,35}",
                "Type",
                "Byte(s) of memory",
                "Min",
                "Max"
            );
            Console.WriteLine(new String('-',101));

            // Records
            Console.WriteLine
            (
                format: "{0,-10} {1,18} {2,35} {3,35}",
                "sbyte",
                sizeof(sbyte),
                sbyte.MinValue,
                sbyte.MaxValue
            );
            Console.WriteLine
            (
                format: "{0,-10} {1,18} {2,35} {3,35}",
                "byte",
                sizeof(byte),
                byte.MinValue,
                byte.MaxValue
            );
            Console.WriteLine
            (
                format: "{0,-10} {1,18} {2,35} {3,35}",
                "short",
                sizeof(short),
                short.MinValue,
                short.MaxValue
            );
            Console.WriteLine
            (
                format: "{0,-10} {1,18} {2,35} {3,35}",
                "ushort",
                sizeof(ushort),
                ushort.MinValue,
                ushort.MaxValue
            );
            Console.WriteLine
            (
                format: "{0,-10} {1,18} {2,35} {3,35}",
                "int",
                sizeof(int),
                int.MinValue,
                int.MaxValue
            );
            Console.WriteLine
            (
                format: "{0,-10} {1,18} {2,35} {3,35}",
                "uint",
                sizeof(uint),
                uint.MinValue,
                uint.MaxValue
            );
            Console.WriteLine
            (
                format: "{0,-10} {1,18} {2,35} {3,35}",
                "long",
                sizeof(long),
                long.MinValue,
                long.MaxValue
            );
            Console.WriteLine
            (
                format: "{0,-10} {1,18} {2,35} {3,35}",
                "ulong",
                sizeof(ulong),
                ulong.MinValue,
                ulong.MaxValue
            );
            Console.WriteLine
            (
                format: "{0,-10} {1,18} {2,35} {3,35}",
                "float",
                sizeof(float),
                float.MinValue,
                float.MaxValue
            );
            Console.WriteLine
            (
                format: "{0,-10} {1,18} {2,35} {3,35}",
                "double",
                sizeof(double),
                double.MinValue,
                double.MaxValue
            );
            Console.WriteLine
            (
                format: "{0,-10} {1,18} {2,35} {3,35}",
                "decimal",
                sizeof(decimal),
                decimal.MinValue,
                decimal.MaxValue
            );
        }
    }
}
