using System;
using System.Collections.Generic;
using System.Text;

namespace CodeRepositoryForCSharp.TemplateMethod
{
    public abstract class Character
    {
        public abstract string Name { get; }
        public abstract int AttackPoint { get; }
        public void Attack()
        {
            Console.WriteLine($"{Name}のこうげき！");
            Console.WriteLine($"あいてモンスターに{AttackPoint}のダメージ");
        }
    }
}
