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
            chris.FavoriteAncientWonder = WondersOfTheAncientWorld.StatueOfZeusAtOlympia;

            Console.WriteLine
            (
                format: "{0} was born on {1:ddddd, d MMMM yyyy}",
                arg0: chris.Name,
                arg1: chris.DateOfBirth
            );

            Console.WriteLine
            (
                format: "{0}'s favorite world is {1}. It's integer is {2}",
                arg0: chris.Name,
                arg1: chris.FavoriteAncientWonder,
                arg2: (int)chris.FavoriteAncientWonder
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
