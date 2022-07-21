using System;
using System.Collections.Generic;
using System.Text;

namespace CodeRepositoryForCSharp.Person
{
    class Person : IPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Person(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public void Greeting()
        {
            Console.WriteLine($"Hello, I'm {Name}");
        }
    }
}
