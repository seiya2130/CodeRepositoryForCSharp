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
            ISample1 sample1 = new ISample1();
            sample1.Func();
        }
    }

    interface ISample1
    {
        public void Func();
    }

    class Sample1 : ISample1
    {
        public void Func()
        {
            Console.WriteLine("Sample1");
        }
    }
}
