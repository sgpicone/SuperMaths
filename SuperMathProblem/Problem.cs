using SuperMathDifficulty;
using SuperMathExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SuperMathProblem
{
    public class Problem : AProblem
    {
        public Problem(Difficulty diff)
        {
            this.Difficulty = diff;
            Create();
        }

        //protected override void GenerateValues()
        //{
        //    int numValues = this.DifficultyScheme.NumberOfValuesDifficulty.ProblemNumberOfValues();
        //    int deviation = ProblemDifficultyExtensions.ProblemNumberOfValuesDeviation(this.DifficultyScheme.NumberOfValuesDifficulty);

        //    numValues += RandomGenerator.Next(-deviation, deviation + 1);
        //    List<long> vals = new List<long>();
        //    for (int i = 0; i < numValues; i++)
        //    {
        //        vals.Add(RandomGenerator.Next(ProblemDifficultyExtensions.ProblemValueLowerBound(this.DifficultyScheme.RangeDifficulty),
        //                                        ProblemDifficultyExtensions.ProblemValueUpperBound(this.DifficultyScheme.RangeDifficulty)));
        //    }
        //    this.Values = vals;
        //}

        //protected override void GenerateOperators()
        //{
        //    int numOperators = Values.Count - 1;
        //    double operatorFrequency;
        //    List<Operator> ops = new List<Operator>(numOperators);
        //    for (int i = 0; i < numOperators; i++)
        //    {
        //        operatorFrequency = RandomGenerator.NextDouble();
        //        ops.Add(ProblemDifficultyExtensions.ProblemOpByDiffAndFreq(this.DifficultyScheme.OperatorDifficulty,operatorFrequency));
        //    }
        //    Operators = ops;
        //}

        public override bool CheckAnswer(double value)
        {
            return true;
            //return this.Answer.VerifyAnswer(value, this.DifficultyScheme.AnswerDeviationDifficulty);
        }
    }
}
