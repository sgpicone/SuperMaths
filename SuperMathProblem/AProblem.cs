using SuperMathDifficulty;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMathProblem
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

        private int _Points;
        public int Points
        {
            get { return _Points; }
            protected set { _Points = value; }
        }

        private Difficulty _Difficulty;
        public Difficulty Difficulty
        {
            get { return _Difficulty; }
            protected set { _Difficulty = value; }
        }

        //private DifficultyScheme _DifficultyScheme;
        //public DifficultyScheme DifficultyScheme
        //{
        //    get { return _DifficultyScheme; }
        //    protected set
        //    {
        //        _DifficultyScheme = value;
        //    }
        //}

        //private DifficultyScheme _DifficultyScheme;
        //public DifficultyScheme DifficultyScheme
        //{
        //    get { return _DifficultyScheme; }
        //    protected set
        //    {
        //        _DifficultyScheme = value;
        //        _OperatorDifficulty = value;
        //        _RangeDifficulty = value;
        //        _AnswerDeviationDifficulty = value;
        //        _NumberOfValuesDifficulty = value;
        //    }
        //}

        ///// <summary>
        ///// The difficulty that determines what operators
        ///// are used in the problem; e.g., on easy, only addition
        ///// and subtraction are used; on impossible, addition, subtraction,
        ///// multiplication and division are all distributed evenly 
        ///// through the problem
        ///// </summary>
        //private Difficulty _OperatorDifficulty;
        //public Difficulty OperatorDifficulty
        //{
        //    get { return _OperatorDifficulty; }
        //    protected set { _OperatorDifficulty = value; }
        //}

        ///// <summary>
        ///// The difficulty that determines the range of values
        ///// that can be used in the problem; e.g., on easy, only
        ///// numbers between 0 and 100 are used to create the problem.
        ///// </summary>
        //private Difficulty _RangeDifficulty;
        //public Difficulty RangeDifficulty
        //{
        //    get { return _RangeDifficulty; }
        //    protected set { _RangeDifficulty = value; }
        //}

        ///// <summary>
        ///// The allowed deviation from the answer; e.g., on hard, answers within
        ///// 1.1% of the exact answer are accepted
        ///// </summary>
        //private Difficulty _AnswerDeviationDifficulty;
        //public Difficulty AnswerDeviationDifficulty
        //{
        //    get { return _AnswerDeviationDifficulty; }
        //    protected set { _AnswerDeviationDifficulty = value; }
        //}

        ///// <summary>
        ///// The difficulty that determines the number of values used in the problem.
        ///// Ranges from 2 to 13.
        ///// </summary>
        //private Difficulty _NumberOfValuesDifficulty;
        //public Difficulty NumberOfValuesDifficulty
        //{
        //    get { return _NumberOfValuesDifficulty; }
        //    protected set { _NumberOfValuesDifficulty = value; }
        //}

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

        /// <summary>
        /// Verifies that the generated problem's answer falls between the accepted
        /// range of answers for this problem's difficulty.
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            return (this.Answer.Value == Calculate.INVALID_ANSWER) ? false : 
                (this.Answer.Value >= ProblemDifficultyExtensions.ProblemAnswerLowerBound(this.DifficultyScheme.AnswerRangeDifficulty) &&
               this.Answer.Value <= ProblemDifficultyExtensions.ProblemAnswerUpperBound(this.DifficultyScheme.AnswerRangeDifficulty));
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
