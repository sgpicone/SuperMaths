using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperMathDifficulty;
using SuperMathProblem;
using SuperMathExtensions;


namespace SuperMathStage
{
    public class Stage : AStage
    {
        public Stage(Difficulty diff)
        {
            this.Difficulty = diff;
            PrepareStage();
        }

        public Stage(Difficulty timeDiff, Difficulty numProbsDiff, Difficulty distDiff)
        {
            this.NumberOfProblemsDifficulty = numProbsDiff;
            this.TimeDifficulty = timeDiff;
            this.DistractionsDifficulty = distDiff;
            PrepareStage();
        }

        public override void PrepareStage()
        {
            this.Answers = new List<double>(NumberOfProblemsDifficulty.StageNumberProblemsDifficulty());
            this.Problems = new List<AProblem>(NumberOfProblemsDifficulty.StageNumberProblemsDifficulty());
            this.TimeLimit = this.TimeDifficulty.StageTimeDifficulty();
            for (int i = 0; i < this.Problems.Capacity; i++)
            {
                Problems.Add(new Problem(this.NumberOfProblemsDifficulty));
            }
        }

        public override bool CheckAnswers()
        {
            bool succeed = true;
            for(int i = 0; i < Problems.Count; i++)
            {
                if (!Problems[i].CheckAnswer(Answers[i]))
                    succeed = false;
                else
                    PointsAwarded += Problems[i].Points;
            }
            return succeed;
        }

        public override int getPoints()
        {
            return PointsAwarded;
        }

        public override string ToString()
        {
            string result = "";
            int totalPoints = 0;
 	        foreach(Problem p in Problems)
            {
                result += p.ToString() + " = " + p.Answer + "\n";
                totalPoints += p.Points;
            }
            result += totalPoints + " points.\n";
            result += this.TimeLimit + " seconds to complete.\n";
            return result;
        }           
    }
}
