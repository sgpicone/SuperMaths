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
        protected const int MIN_VALUES = 2;
        protected Random RandomGenerator = new Random(); 

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

        public void Create()
        {
            do
            {
                GenerateValues();
                GenerateOperators();
                this.Answer = new Answer(this);
            } while (!Validate());
        }

        protected void GetNumValues()
        {
            int possibleNumValPoints = Points / 5;
            int maxNumVals = (possibleNumValPoints / 10 + 1) < MIN_VALUES ? MIN_VALUES + 2 : (possibleNumValPoints / 10 + 1);
            int numVals = RandomGenerator.Next(MIN_VALUES, maxNumVals);
            int pointsFromNumVals = numVals * 5;
            Points -= pointsFromNumVals;
            Values = new List<long>(numVals);
            Operators = new List<Operator>(numVals - 1);
        }

        protected void GenerateOperators()
        {
            int maxAllowedOpPoints
        }
        
        protected void GenerateValues()
        {

        }
        
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
