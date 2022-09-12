using System;
using System.Collections.Generic;
using System.Text;

namespace CodeRepositoryForCSharp.StrategyPattern
{
    class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public UserType UserType { get; set; }
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
            switch (UserType)
            {
                case UserType.Normal:
                    SkillMenuList.Add(SkillMenu.Self);
                    break;
                case UserType.Admin:
                    SkillMenuList.Add(SkillMenu.Analysis);
                    SkillMenuList.Add(SkillMenu.Setting);
                    break;
            }
        }
        public void GetEvaluationMenu()
        {
            switch (UserType)
            {
                case UserType.Normal:
                    EvaluationMenuList.Add(EvaluationMenu.Request);
                    break;
                case UserType.Admin:
                    EvaluationMenuList.Add(EvaluationMenu.Setting);
                    break;
            }
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
