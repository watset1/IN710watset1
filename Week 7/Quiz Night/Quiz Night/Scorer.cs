using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_Night
{
    public static class Scorer
    {
        static int computedScore;

        public static int AdultScore(int correct, int incorrect)
        {
            computedScore = (correct * 10) - incorrect;
            return computedScore;
        }

        public static int ChildScore(int correct, int incorrect)
        {
            computedScore = correct * 15;
            return computedScore;
        }
    }
}
