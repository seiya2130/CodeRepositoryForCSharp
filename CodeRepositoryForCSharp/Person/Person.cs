using System;
using System.Collections.Generic;
using System.Text;

namespace CodeRepositoryForCSharp.Person
{
    class Person : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
