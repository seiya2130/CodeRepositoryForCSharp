using CodeRepositoryForCSharp;
using Moq;
using NUnit.Framework;
using NUnitTestProject;
using System;
using System.Collections.Generic;

namespace Test
{
    public class ManagerTest
    {
        [Test]
        public void GetStaffTest()
        {
            IEmployee employeeMock = new MockEmployee();
            var manager = new Manager(employeeMock);

            Assert.AreEqual(manager.GetStaff().Count, 5);

        }
    }
}