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
            protected set { 
                _Difficulty = value;
                _OperatorDifficulty = value;
                _RangeDifficulty = value;
                _AnswerDifficulty = value;
                _NumberOfValuesDifficulty = value;
            }
        }

        private Difficulty _OperatorDifficulty;
        public Difficulty OperatorDifficulty
        {
            get { return _OperatorDifficulty; }
            protected set { _OperatorDifficulty = value; }
        }

        private Difficulty _RangeDifficulty;
        public Difficulty RangeDifficulty
        {
            get { return _RangeDifficulty; }
            protected set { _RangeDifficulty = value; }
        }

        private Difficulty _AnswerDifficulty;
        public Difficulty AnswerDifficulty
        {
            get { return _AnswerDifficulty; }
            protected set { _AnswerDifficulty = value; }
        }

        private Difficulty _NumberOfValuesDifficulty;
        public Difficulty NumberOfValuesDifficulty
        {
            get { return _NumberOfValuesDifficulty; }
            protected set { _NumberOfValuesDifficulty = value; }
        }

        public void Create()
        {
            do
            {
                GenerateValues();
                GenerateOperators();
                this.Answer = new Answer(this);
            } while (!Validate());
        }

        protected abstract void GenerateValues();
        protected abstract void GenerateOperators();
        public abstract bool CheckAnswer(double value);

        public bool Validate()
        {
            return (this.Answer.Value == Calculate.INVALID_ANSWER) ? false : 
                (this.Answer.Value >= ProblemDifficultyExtensions.ProblemAnswerLowerBound(this.Difficulty) &&
               this.Answer.Value <= ProblemDifficultyExtensions.ProblemAnswerUpperBound(this.Difficulty));
        }

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
