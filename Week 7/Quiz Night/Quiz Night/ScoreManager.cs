using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_Night
{
    public class ScoreManager
    {
        public delegate int ScoreDelegate(int correct, int incorrect);
        ScoreDelegate scoreComputer;
 
        public ScoreManager() { }

        public void selectScoreComputer(int teamType)
        {
            switch (teamType)
            {
                case 0:
                    scoreComputer = new ScoreDelegate(Scorer.AdultScore);
                    break;
                case 1:
                    scoreComputer = new ScoreDelegate(Scorer.ChildScore);
                    break;
            }
        }

        public String computeScore(int correct, int incorrect)
        {
            int score = scoreComputer(correct, incorrect);
            String computedScore = score.ToString();
            return computedScore;
        }


    }


}
