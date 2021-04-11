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

            var bob = new Person();
            bob.Name = "Bob Smith";
            bob.BucketList = WondersOfTheAncientWorld.ColossusOfRhodes | WondersOfTheAncientWorld.GreatPyramidOfGiza;
            bob.Children.Add(new Person { Name = "Alfred" });
            bob.Children.Add(new Person { Name = "Zoe" });

            Console.WriteLine($"{bob.Name}'s bucket list is {bob.BucketList}.");
            Console.WriteLine($"{bob.Name} has {bob.Children.Count} children:");
            foreach (var children in bob.Children)
            {
                Console.WriteLine($"    {children.Name}");
            }

            BankAccount.InterestRate = 0.012M; // store a shared value

            var jonesAccount = new BankAccount();
            jonesAccount.AccountName = "Mrs. Jones";
            jonesAccount.Balance = 2400;
            Console.WriteLine
            (
                format: "{0} earned {1:C} interest.",
                arg0: jonesAccount.AccountName,
                arg1: jonesAccount.Balance * BankAccount.InterestRate
            );

            var gerrierAccount = new BankAccount();
            gerrierAccount.AccountName = "Mrs. Gerrier";
            gerrierAccount.Balance = 98;
            Console.WriteLine
            (
                format: "{0} earned {1:C} interest.",
                arg0: gerrierAccount.AccountName,
                arg1: gerrierAccount.Balance * BankAccount.InterestRate
            );

            Console.WriteLine($"{bob.Name} is a {Person.Species}");
            Console.WriteLine($"{bob.Name} was born on {bob.HomePlanet}");

            var blankPerson = new Person();

            Console.WriteLine
            (
                format: "{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}.",
                arg0: blankPerson.Name,
                arg1: blankPerson.HomePlanet,
                arg2: blankPerson.Instantiated
            );

            var gunny = new Person("Gunny", "Mars");

            Console.WriteLine
            (
                format: "{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}.",
                arg0: gunny.Name,
                arg1: gunny.HomePlanet,
                arg2: gunny.Instantiated
            );

            naty.WriteToConsole();
            Console.WriteLine(naty.GetOrigin());
        }
    }
}
