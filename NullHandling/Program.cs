#nullable enable
using System;

namespace NullHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            int thisCannotBeNull = 4;
            //thisCannotBeNull = null;
            int? thisCouldBeNull = null;

            Console.WriteLine(thisCouldBeNull);
            Console.WriteLine(thisCouldBeNull.GetValueOrDefault());
            thisCouldBeNull = 7;
            Console.WriteLine(thisCouldBeNull);
            Console.WriteLine(thisCouldBeNull.GetValueOrDefault());

            if(thisCouldBeNull != null)
            {
                //int? length = thisCouldBeNull?.Length;
            }
            
            var address = new Address();
            address.Building = null;
            address.Street = null;
            address.City = "London";
            address.Region = null;
        }
    }

    class Address
    {
        public string? Building { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
    }
}
