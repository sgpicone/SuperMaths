using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMath
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

        public override string ToString()
        {
            return Value.ToString();
        }

    }
}
