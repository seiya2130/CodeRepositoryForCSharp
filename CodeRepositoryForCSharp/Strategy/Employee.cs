using System;
using System.Collections.Generic;
using System.Text;

namespace CodeRepositoryForCSharp.Strategy
{
    class Employee
    {
        private int Id;
        private WorkStatus WorkStatus;
        private Salary Salary;

        public Employee(int id, WorkStatus workStatus)
        {
            Id = id;
            WorkStatus = workStatus;
            Salary = new Salary();
        }

        public void DisplaySalary()
        {
            var salary = Salary.GetSalary(Id, WorkStatus);
            Console.WriteLine(salary);
        }
    }
}
