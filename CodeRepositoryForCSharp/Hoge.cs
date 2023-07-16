using System;
using System.Collections.Generic;
using System.Text;

namespace CodeRepositoryForCSharp
{
    class Hoge
    {
        private IFuga fuga;

        public Hoge(IFuga fuga)
        {
            this.fuga = fuga;
        }

        public void Func()
        {
            this.fuga.Func();
        }
    }
}
