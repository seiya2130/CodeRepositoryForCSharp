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

    class Manager
    {
        private readonly Employee employee = new Employee();

        public List<Employee> GetStaff()
        {
            return employee.GetEmployees();
        }
    }

    class Employee
    {
        public List<Employee>GetEmployees()
        {
            var employeeList = new List<Employee>();

            //DBから従業員を取得したと仮定する

            return employeeList;
        }
    }
}

