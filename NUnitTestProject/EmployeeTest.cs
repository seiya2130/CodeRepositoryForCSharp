using CodeRepositoryForCSharp;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProject
{
    class EmployeeTest
    {
        [Test]
        public void GetEmployeesTest()
        {
            Moq.Mock<IEmployee> moq = new Moq.Mock<IEmployee>();
            var mockEmployeeList = new List<Employee>()
            {
                new Employee(),
            };

            moq.Setup(x => x.GetEmployees()).Returns(mockEmployeeList);


        }
    }
}
