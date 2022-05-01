using CodeRepositoryForCSharp;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Test
{
    public class ManagerTest
    {
        private class MockEmployee : IEmployee
        {
            public List<Employee> GetEmployees()
            {
                var employeeMock = new List<Employee>();

                for (int i = 0; i < 10; i++)
                {
                    employeeMock.Add(new Employee() { No = i });
                }

                return employeeMock;
            }
        }

        [Test]
        public void GetStaffTest()
        {
            var manager = new Manager(new MockEmployee());

            Assert.AreEqual(manager.GetStaff().Count, 5);

        }
    }
}