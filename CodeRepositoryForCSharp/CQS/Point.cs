using System;
using System.Collections.Generic;
using System.Text;

namespace CodeRepositoryForCSharp.CQS
{
    class Point
    {
        int ThanksPoint { get; set; }
        int ProfessionalPoint { get; set; }
        int SupportPoint { get; set; }

        int TotalPoint { get; set; }

        public int GetTotalPoint()
        {
            return TotalPoint;
        }

        public void SumTotalPoint()
        {
            TotalPoint = ThanksPoint + ProfessionalPoint + SupportPoint;
        }
    }
}