using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeRepositoryForCSharp.Person
{
    class UserRepository
    {
        public IUser GetUser(int id)
        {
            
            var userList = new List<User>() {
                new User(1, "Bob"),
                new User(2, "John"),
                new User(3, "Mary")
            };

            IUser user = userList.Find(x=> x.Id == 4);

            if (user == null)
            {
                user = new NullUser();
            }

            return user;
        }

    }
}
