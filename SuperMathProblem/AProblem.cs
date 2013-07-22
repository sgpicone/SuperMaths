using SuperMathDifficulty;
using SuperMathExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SuperMathProblem
{
    //NO COMMENTS.
    public abstract class AProblem
    {
        protected const int MIN_VALUES = 2;
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

        private int _BasePoints;
        protected int BasePoints
        {
            get { return _BasePoints; }
            set { _BasePoints = value; }
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
            GetBasePoints();
            Points = BasePoints;
            do
            {
                GetNumValues();
                GenerateOperators();
                GenerateValues();
                this.Answer = new Answer(this);
            } while (!Validate());
        }

        protected void GetBasePoints()
        {
            int bas = this.Difficulty.ProblemPointBase();
            int dev = this.Difficulty.ProblemPointDeviation();
            BasePoints = RandomGenerator.Next(bas - 50, bas + dev); //todo FIX THIS. should always be -50 and + dev*some number; probably change ProbPtDev() to ret. a multiplier, not a dev.
        }

        protected void GetNumValues()
        {
            int possibleNumValPoints = BasePoints / 5;
            int maxNumVals = (possibleNumValPoints / 10 + 1) < MIN_VALUES ? MIN_VALUES + 2 : (possibleNumValPoints / 10 + 1);
            int numVals = RandomGenerator.Next(MIN_VALUES, maxNumVals);
            int pointsFromNumVals = numVals * 5;
            Points -= pointsFromNumVals;
            Values = new List<long>(numVals);
            Operators = new List<Operator>(numVals - 1);
        }

        protected void GenerateOperators()
        {
            int maxAllowedOpPoints = BasePoints / 5;
            int opValue;
            Operator op;
            for (int i = 0; i < Operators.Capacity; i++)
            {
                opValue = RandomGenerator.Next(maxAllowedOpPoints);
                op = (opValue < 20) ? Operator.PLUS : (opValue < 40) ? Operator.MINUS : (opValue < 80) ? Operator.MULT : Operator.DIV;
                Points -= opValue;
                maxAllowedOpPoints -= opValue / 2;
                Operators.Add(op);
                //Thread.Sleep(50);
            }
        }

        protected void GenerateValues()
        {
            int maxAllowedValPoints = BasePoints / 5;
            int maxAllowedValue = this.Difficulty.ProblemMaxValue();
            int value;
            int pointsRemoved;
            for (int i = 0; i < Values.Capacity; i++)
            {
                if (i < Operators.Count && Operators[i] == Operator.DIV)
                {
                    int divisor = RandomGenerator.Next(2, maxAllowedValue / 10);
                    //Thread.Sleep(50);
                    int tempQuot = RandomGenerator.Next(2, maxAllowedValue / 10);
                    int dividend = divisor * tempQuot;
                    Values.Add(dividend);
                    Values.Add(divisor);
                    i++;
                    pointsRemoved = Math.Abs(dividend / 10) + Math.Abs(divisor / 10); 
                    Points -= pointsRemoved;
                    maxAllowedValue -= pointsRemoved;
                }
                else if ((i < Operators.Count && Operators[i] == Operator.MULT) || ((i > 0 && i < Operators.Capacity) && Operators[i - 1] == Operator.MULT))
                {
                    int multiplicand = RandomGenerator.Next(2, maxAllowedValue / 8);
                    //Thread.Sleep(50);
                    int multiplier = RandomGenerator.Next(2, maxAllowedValue / 8);
                    Values.Add(multiplicand);
                    Values.Add(multiplier);
                    i++;
                    pointsRemoved = Math.Abs(multiplicand / 10) + Math.Abs(multiplier / 10);
                    Points -= pointsRemoved;
                    maxAllowedValue -= pointsRemoved;
                }
                else
                {
                    value = RandomGenerator.Next(maxAllowedValue);
                    pointsRemoved = Math.Abs(value / 10);
                    Values.Add(value);
                    maxAllowedValue -= pointsRemoved;
                }
                //Thread.Sleep(50);
            }
        }

        public abstract bool CheckAnswer(double value);

        public int PossiblePointEarnings()
        {
            return BasePoints - Points;
        }

        /// <summary>
        /// Verifies that the generated problem's answer falls between the accepted
        /// range of answers for this problem's difficulty.
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            return (this.Answer.Value == Calculate.INVALID_ANSWER) ? false : 
                (this.Answer.Value >= this.Difficulty.ProblemAnswerLowerBound() &&
               this.Answer.Value <= this.Difficulty.ProblemAnswerUpperBound());
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
