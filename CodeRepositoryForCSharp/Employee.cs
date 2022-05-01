using System.Collections.Generic;

namespace CodeRepositoryForCSharp
{
    public class Employee : IEmployee
    {
        public int No;
        public List<Employee>GetEmployees()
        {
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

