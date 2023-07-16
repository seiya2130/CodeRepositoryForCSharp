using System.Collections.Generic;

namespace CodeRepositoryForCSharp
{
    public class Employee : IEmployee
    {
        public string No;

        public List<Employee>GetEmployees()
        {
            var employeeList = new List<Employee>();

            //DBから従業員を10人取得したと仮定

            return employeeList;
        }
    }
}

