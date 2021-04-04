using System;

namespace AnonymousTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Anonymous Types
            var location = new { Country = "Argentina", State = "Buenos Aires"}; // Read-Only Properties

            var person = new
            {
                Name = "Christian",
                LastName = "Grimberg",
                Location = location
            };

            var persons = new[]
            {
                new { Name = "Natalia", LastName = "Carbonell", Location = location},
                new { Name = "Alma", LastName = "Grimberg", Location = location},
                person
            };

            foreach (var p in persons)
            {
                Console.WriteLine($"{p.Name} {p.LastName} lives {location.Country} country in the state of {location.State}.");   
            }
            #endregion
        }
    }
}
