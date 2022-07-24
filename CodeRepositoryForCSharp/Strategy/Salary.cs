using System;
using System.Collections.Generic;
using System.Text;

namespace CodeRepositoryForCSharp.Strategy
{
    class Salary
    {

        public Salary()
        {

        }

        public double GetSalary(int userId, IWorkStatus workStatus)
        {
            var salary = (double)200_000;

            return workStatus.CalculateSalary(salary);
        }
    }
}

public enum WorkStatus
{
    Full,
    Short,
    Leave
}
