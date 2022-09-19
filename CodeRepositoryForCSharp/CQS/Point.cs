using System;
using System.Collections.Generic;
using System.Text;

namespace CodeRepositoryForCSharp.CQS
{
    class Point
    {
        int ThanksPoint { get; set; }

        public int AddThanksPoint(int addPoint)
        {
            ThanksPoint += addPoint;
            return  ThanksPoint;
        }
    }
}
