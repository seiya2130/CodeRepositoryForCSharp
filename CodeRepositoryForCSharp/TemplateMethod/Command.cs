using System;
using System.Collections.Generic;
using System.Text;

namespace CodeRepositoryForCSharp.TemplateMethod
{
    public class Command
    {
        private IAttackCommand attackCommand;

        public Command(IAttackCommand attackCommand)
        {
            this.attackCommand = attackCommand;
        }

        public void Attack()
        {
            attackCommand.Attack();
        }
    }
}
