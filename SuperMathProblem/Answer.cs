using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperMathDifficulty;
using SuperMathExtensions;

namespace SuperMathProblem
{
    public class Answer
    {
        private AProblem _Problem;
        public AProblem Problem
        {
            get { return _Problem; }
            private set { _Problem = value; }
        }

        private double _Value;
        public double Value
        {
            get { return _Value; }
            private set { _Value = value;  }
        }

        public Answer(AProblem problem)
        {
            Problem = problem;
            Value = Calculate.CalcDouble(this.Problem.Values, this.Problem.Operators);
        }

        public bool VerifyAnswer(double val, Difficulty diff)
        {
            double dev = ProblemDifficultyExtensions.ProblemAnswerDeviationAllowed(diff);
            double lowBound = this.Value-(this.Value*dev);
            double hiBound = this.Value+(this.Value*dev);

            return (val >= lowBound && val <= hiBound);
        }

        public override string ToString()
        {
            return Value.ToString();
        }

    }
}
