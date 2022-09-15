using CodeRepositoryForCSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProject
{
    class MockEmployee : IEmployee
    {
        public List<Employee> GetEmployees()
        {
            var employeeMock = new List<Employee>();

            for (int i = 0; i < 10; i++)
            {
                employeeMock.Add(new Employee() { No = "M" + i });
            }

            return employeeMock;
        }
    }
}

public class MockEmployee : IEmployee
{
    public List<Employee> GetEmployees()
    {
        var employeeMock = new List<Employee>();

        for (int i = 0; i < 10; i++)
        {
            employeeMock.Add(new Employee() { No = "M" + i });
        }

        return employeeMock;
    }
}