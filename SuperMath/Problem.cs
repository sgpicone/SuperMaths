using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMath
{
    public class Problem : AProblem
    {
        public Problem(Difficulty AbsoluteDifficulty)
        {
            RandomGenerator = new Random();
            this.Difficulty = AbsoluteDifficulty;
            Create();        
        }

        public Problem(Difficulty numvalsDifficulty, Difficulty rangeDifficulty, Difficulty operatorDifficulty, Difficulty answerDifficulty)
        {
            RandomGenerator = new Random();
            this.NumberOfValuesDifficulty = numvalsDifficulty;
            this.RangeDifficulty = rangeDifficulty;
            this.OperatorDifficulty = operatorDifficulty;
            this.AnswerDifficulty = answerDifficulty;
            Create();
        }

        protected override void GenerateValues()
        {
            int numValues;
            int deviation;
            switch (this.NumberOfValuesDifficulty)
            {
                case Difficulty.EASY:
                    numValues = 2;  deviation = 0;
                    break;
                case Difficulty.NORMAL:
                    numValues = 3;  deviation = 1;
                    break;
                case Difficulty.HARD:
                    numValues = 4;  deviation = 2;
                    break;
                case Difficulty.VERY_HARD:
                    numValues = 6;  deviation = 2;
                    break;
                case Difficulty.IMPOSSIBLE:
                    numValues = 10; deviation = 3;
                    break;
                default:
                    numValues = 2;  deviation = 0;
                    break;
            }

            numValues += RandomGenerator.Next(-deviation, deviation + 1);
            List<long> vals = new List<long>();
            for (int i = 0; i < numValues; i++)
            {
                vals.Add(RandomGenerator.Next(ProblemDifficultyExtensions.ProblemValueLowerBound(this.RangeDifficulty),
                                                ProblemDifficultyExtensions.ProblemValueUpperBound(this.RangeDifficulty)));
            }
            this.Values = vals;
        }

        protected override void GenerateOperators()
        {
            int numOperators = Values.Count - 1;
            double operatorFrequency;
            List<Operator> ops = new List<Operator>(numOperators);
            for (int i = 0; i < numOperators; i++)
            {
                operatorFrequency = RandomGenerator.NextDouble();
                ops.Add(ProblemDifficultyExtensions.ProblemOpByDiffAndFreq(this.OperatorDifficulty,operatorFrequency));
            }
            Operators = ops;
        }

        public override bool CheckAnswer(double value)
        {
            return this.Answer.VerifyAnswer(value, this.AnswerDifficulty);
        }
    }
}
