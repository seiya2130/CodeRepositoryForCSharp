using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using CodeRepositoryForCSharp;
using NUnit.Framework;
using Moq;
using CodeRepositoryForCSharp.TemplateMethod;

namespace NUnitTestProject
{
     public class CommandTest
    {

        [Test]
        public void AttackTest()
        {
            var mock = new Mock<IAttackCommand>();
            mock.Setup(x => x.Attack()).Callback(() => Console.WriteLine("テストのこうげき！"));

            var command = new Command(mock.Object);
            command.Attack();

            mock.Verify(x => x.Attack(), Times.Once);
        }
    }
}
