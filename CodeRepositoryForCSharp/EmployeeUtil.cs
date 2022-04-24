using System;
using System.Collections.Generic;
using System.Text;

namespace CodeRepositoryForCSharp
{
    class EmployeeUtil : IEmployee
    {
        public List<Employee> GetEmployees() {
            var employeeList = new List<Employee>();

            //DBから従業員を10人取得したと仮定する
            for (int i = 0; i < 10; i++)
            {
                employeeList.Add(new Employee() { No = i });
            }

            return employeeList;
        }
    }
}
