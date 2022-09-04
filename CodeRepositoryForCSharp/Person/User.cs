using System;
using System.Collections.Generic;
using System.Text;

namespace CodeRepositoryForCSharp.Person
{
    class User : IUser
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public User(int id, string name)
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
