using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMath
{
    public abstract class AProblem
    {
        protected const int MAX_OPERATORS = 4;
        protected Random RandomGenerator;

        private List<long> _Values;
        public List<long> Values
        {
            get { return _Values; }
            protected set { _Values = value; }
        }

        private List<Operator> _Operators;
        public List<Operator> Operators
        {
            get { return _Operators; }
            protected set { _Operators = value; }
        }

        private Answer _Answer;
        public Answer Answer
        {
            get { return _Answer; }
            protected set { _Answer = value; }
        }

        private Difficulty _Difficulty;
        public Difficulty Difficulty
        {
            get { return _Difficulty; }
            protected set { _Difficulty = value; }
        }

        protected abstract void GenerateValues();
        protected abstract void GenerateOperators();
        public abstract bool Validate();

        public override string ToString()
        {
            string result = Values[0].ToString();
            for (int i = 0; i < Operators.Count; i++)
            {
                result += String.Format(" {0} {1}", OperatorExtensions.OperatorToString(Operators[i]), Values[i + 1].ToString());
            }
            return result;
        }
    }
}
