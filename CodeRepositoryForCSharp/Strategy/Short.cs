using System;
using System.Collections.Generic;
using System.Text;

namespace CodeRepositoryForCSharp.Strategy
{
    class Short : IWorkStatus
    {
        public double CalculateSalary(double salary)
        {
            return salary * 0.8;
        }
    }
}
