using System.Collections.Generic;
using System.Linq;

namespace CodeRepositoryForCSharp
{
    public class Manager
    {
        private IEmployee employee;

        public Manager(IEmployee employee)
        {
            this.employee = employee;
        }

        public List<Employee> GetManagerEmployees()
        {
            return this.employee.GetEmployees().Take(5).ToList();
        }
    }
}

