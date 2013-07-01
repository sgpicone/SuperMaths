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

        public bool VerifyAnswer(double val)
        {
            return (val == Value);
        }

        public override string ToString()
        {
            return Value.ToString();
        }

    }
}
