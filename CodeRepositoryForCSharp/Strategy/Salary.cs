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

        public double GetSalary(int userId, WorkStatus workStatus)
        {
            var salary = (double)200_000;

            switch (workStatus)
            {
                case WorkStatus.Full:
                    break;
                case WorkStatus.Short:
                    salary = salary * 0.8;
                    break;
                case WorkStatus.Leave:
                    salary = salary * 0.6;
                    break;
            }

            return salary;
        }
    }
}

public enum WorkStatus
{
    Full,
    Short,
    Leave
}
