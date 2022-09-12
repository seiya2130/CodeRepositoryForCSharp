using System;
using System.Collections.Generic;
using System.Text;

namespace CodeRepositoryForCSharp.StrategyPattern
{
    class AdminUserType : IUserType
    {
        public List<SkillMenu> GetSkillMenu()
        {
            return new List<SkillMenu> { 
                SkillMenu.Self, 
                SkillMenu.Analysis, 
                SkillMenu.Setting 
            };
        }
    }
}
