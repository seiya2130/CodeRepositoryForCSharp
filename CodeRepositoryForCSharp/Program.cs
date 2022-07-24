using System;
using System.Collections.Generic;
using System.Threading.Channels;
using CodeRepositoryForCSharp.Person;
using CodeRepositoryForCSharp.Strategy;
using Microsoft.Extensions.DependencyInjection;

namespace CodeRepositoryForCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var employeeDic = new Dictionary<int, IWorkStatus>()
            {
                { 1, new Full() },
                { 2, new Short() },
                { 3, new Leave() },
            };

            foreach (var employee in employeeDic)
            {
                var e = new Strategy.Employee(employee.Key, employee.Value);
                e.DisplaySalary();
            }
        }
    }
}

