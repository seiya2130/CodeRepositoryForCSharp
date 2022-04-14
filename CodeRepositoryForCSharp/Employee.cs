using System.Collections.Generic;

namespace CodeRepositoryForCSharp
{
    class Employee : IEmployee
    {
        public List<Employee>GetEmployees()
        {
            var employeeList = new List<Employee>();

            //DBから従業員を取得したと仮定する

            return employeeList;
        }
    }
}

