using System;
using System.Collections.Generic;
using System.Threading.Channels;
using CodeRepositoryForCSharp.Person;
using CodeRepositoryForCSharp.Strategy;
using CodeRepositoryForCSharp.TemplateMethod;
using Microsoft.Extensions.DependencyInjection;

namespace CodeRepositoryForCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            IAttackCommand warrior = new Warrior();
            IAttackCommand wizard = new Wizard();

            var warriorCommand = new Command(warrior);
            var wizardCommand = new Command(wizard);

            warriorCommand.Attack();
            wizardCommand.Attack();
        }
    }
}
