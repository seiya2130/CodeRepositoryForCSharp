using System;
using System.Collections.Generic;
using System.Text;

namespace CodeRepositoryForCSharp.TemplateMethod
{
    public class Warrior : Character, IAttackCommand
    {
        public override string Name => "戦士";
        public override int AttackPoint => 100;
    }
}
