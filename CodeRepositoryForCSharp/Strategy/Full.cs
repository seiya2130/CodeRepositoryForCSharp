using System;
using System.Collections.Generic;
using System.Text;

namespace CodeRepositoryForCSharp.Strategy
{
    class Full : IWorkStatus
    {
        public double CalculateSalary(double salary)
        {
            return salary;
        }
    }
}
