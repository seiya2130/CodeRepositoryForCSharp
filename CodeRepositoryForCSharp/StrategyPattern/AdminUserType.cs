using System;
using System.Collections.Generic;
using System.Text;

namespace CodeRepositoryForCSharp.StrategyPattern
{
    class AdminUserType : IUserType
    {
        public List<UserMenu> GetUserMenu()
        {
            return new List<UserMenu> {  
                UserMenu.Admin,
                UserMenu.Setting
            };
        }
    }
}
