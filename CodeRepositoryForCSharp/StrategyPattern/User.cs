using System;
using System.Collections.Generic;
using System.Text;

namespace CodeRepositoryForCSharp.StrategyPattern
{
    class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IUserType UserType { get; set; }
        public List<SkillMenu> SkillMenuList { get; set; }
        public List<EvaluationMenu> EvaluationMenuList { get; set; }

        public User(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public void Greeting()
        {
            Console.WriteLine($"Hello, I'm {Name}");
        }

        public void GetSkillMenu()
        {
            SkillMenuList =  UserType.GetSkillMenu();
        }
    }

    enum UserType
    {
        Normal,
        Admin
    }

    enum SkillMenu
    {
        Self,
        Analysis,
        Setting
    }

    enum EvaluationMenu
    {
        Request,
        Approve,
        Setting
    }



}
