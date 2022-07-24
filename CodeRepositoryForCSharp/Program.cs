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
            var employee = new Strategy.Employee(1, WorkStatus.Full);
            employee.DisplaySalary();
        }
    }
}

