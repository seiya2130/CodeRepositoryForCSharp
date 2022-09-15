using System.Collections.Generic;
using System.Linq;

namespace CodeRepositoryForCSharp
{
    public class Manager
    {
        private readonly IEmployee employee;

        public Manager(IEmployee employee)
        {
            this.employee = employee;
        }

        public List<Employee> GetManagerEmployees()
        {
            return employee.GetEmployees().Where(x => x.No.StartsWith("M")).ToList();
        }
    }
}

