using System.Collections.Generic;

namespace CodeRepositoryForCSharp
{
    class Manager
    {
        private readonly IEmployee employee;

        public Manager(IEmployee employee)
        {
            this.employee = employee;
        }

        public List<Employee> GetStaff()
        {
            var employeeList = employee.GetEmployees();

            //Managerが確認したい社員のみにする。(ここでは仮にリストの1～5番目の社員とする)
            var staff = employeeList.GetRange(1,5);
            return staff;
        }
    }
}

