using System;
using System.Collections.Generic;
using System.Text;

namespace CodeRepositoryForCSharp.TemplateMethod
{
    public class Wizard : Character, IAttackCommand
    {
        public override string Name => "魔法使い";
        public override int AttackPoint => 50;
    }
}
