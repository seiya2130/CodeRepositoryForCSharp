using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace CodeRepositoryForCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = Enumerable.Range(0, 5).Select(x => DisplayEvenNum(x));

            foreach (var n in a);
            foreach (var n in a);
        }

        static int DisplayEvenNum(int n)
        {
            if(n % 2 == 0)
            {
                Console.Write($"{n}");
            }

            return n;
        }
    }
}

