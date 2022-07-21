using System;
using System.Threading.Channels;
using CodeRepositoryForCSharp.Person;
using Microsoft.Extensions.DependencyInjection;

namespace CodeRepositoryForCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new PersonRepository().GetPerson(1);
            person.Greeting();
        }
    }
}

