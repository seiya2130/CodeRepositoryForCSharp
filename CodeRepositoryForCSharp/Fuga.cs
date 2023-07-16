using System;
using System.Collections.Generic;
using System.Text;

namespace CodeRepositoryForCSharp
{
    class Fuga : IFuga
    {
        public void Func()
        {
            Console.WriteLine("Fuga Func");
        }
    }

    interface IFuga
    {
        public void Func();
    }
}
