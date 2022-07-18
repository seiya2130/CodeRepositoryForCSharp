using System;
using System.Collections.Generic;
using System.Text;

namespace CodeRepositoryForCSharp.Person
{
    class NullPerson : IPerson
    {
        const string NULL_VALUE = "";

        public string GetFullName()
        {
            return NULL_VALUE;
        }
    }
}
