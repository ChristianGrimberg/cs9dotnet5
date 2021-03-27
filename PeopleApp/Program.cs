using System;
using Packt.Shared;

namespace PeopleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var chris = new Person();
            chris.Name = "Christian Grimberg";
            chris.DateOfBirth = new DateTime(1982,11,2);

            Console.WriteLine
            (
                format: "{0} was born on {1:ddddd, d MMMM yyyy}",
                arg0: chris.Name,
                arg1: chris.DateOfBirth
            );

            var naty = new Person
            {
                Name = "Natalia Carbonell",
                DateOfBirth = new DateTime(1980,03,23)
            };

            Console.WriteLine
            (
                format: "{0} was born on {1:dd MMM yy}",
                arg0: naty.Name,
                arg1: naty.DateOfBirth
            );
        }
    }
}
