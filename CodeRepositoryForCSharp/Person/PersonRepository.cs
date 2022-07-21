using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeRepositoryForCSharp.Person
{
    class PersonRepository
    {
        public IPerson GetPerson(int id)
        {
            var persons = new List<Person>
            {
                //new Person(id: 1, name: "Bob")
            };

            IPerson person = persons.Find(x => x.Id == id);

            if (person == null)
            {
                person = new NullPerson();
            }

            return person;
        }

    }
}
