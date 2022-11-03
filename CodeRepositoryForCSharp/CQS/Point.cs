using System;
using System.Collections.Generic;
using System.Text;

namespace CodeRepositoryForCSharp.CQS
{
    class Point
    {
        int NormalPoint { get; set; }
        int EventPoint { get; set; }
        int SeasonPoint { get; set; }

        int TotalPoint { get; set; }

        public int GetTotalPoint()
        {
            return TotalPoint;
        }

        public void SumTotalPoint()
        {
            TotalPoint = NormalPoint + EventPoint + SeasonPoint;
        }
    }
}