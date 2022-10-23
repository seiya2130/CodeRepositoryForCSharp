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
        public List<UserMenu> UserMenuList { get; set; }
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

        public void GetUserMenu()
        {
            UserMenuList =  UserType.GetUserMenu();
        }
    }

    enum UserType
    {
        Normal,
        Admin
    }

    enum UserMenu
    {
        Self,
        Admin,
        Setting
    }

    enum EvaluationMenu
    {
        Request,
        Approve,
        Setting
    }



}
