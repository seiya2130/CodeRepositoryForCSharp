using System;
using System.Collections.Generic;
using System.Text;

namespace CodeRepositoryForCSharp.Strategy
{
    class Leave : IWorkStatus
    {
        public double CalculateSalary(double salary)
        {
            return salary * 0.6;
        }
    }
}
