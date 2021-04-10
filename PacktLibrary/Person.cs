using System;
using System.Collections.Generic;

namespace Packt.Shared
{
    /// <summary>
    /// A Person model
    /// </summary>
    public class Person : Object
    {
        // Fields
        public string Name;
        public DateTime DateOfBirth;
        public WondersOfTheAncientWorld FavoriteAncientWonder;
        public WondersOfTheAncientWorld BucketList;
        public List<Person> Children = new List<Person>();
        public const string Species = "Homo Sapien";
    }
}
