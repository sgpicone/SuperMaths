using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMath
{
    class Problem : IProblem
    {
        private Random RandomGenerator;
        private List<long> _Values;
        public List<long> Values
        {
            get { return _Values; }
        }

        private List<Operator> _Operators;
        public List<Operator> Operators
        {
            get { return _Operators; }
        }

        private Answer _Answer;
        public Answer Answer
        {
            get { return _Answer; }
        }

        private Difficulty _Difficulty;
        public Difficulty Difficulty
        {
            get { return _Difficulty; }
        }

        public Problem(Difficulty difficulty)
        {
            RandomGenerator = new Random();
            this._Difficulty = difficulty;
            GenerateValues();
            GenerateOperators();
            this._Answer = new Answer(this);
        }

        public void GenerateValues()
        {
            int numValues = 0;
            int deviation = 0;
            switch (this.Difficulty)
            {
                case Difficulty.EASY:
                    numValues = 2;
                    break;
                case Difficulty.NORMAL:
                    numValues = 3;
                    deviation = 1;
                    break;
                case Difficulty.HARD:
                    numValues = 4;
                    deviation = 2;
                    break;
                case Difficulty.VERY_HARD:
                    numValues = 6;
                    deviation = 2;
                    break;
                case Difficulty.IMPOSSIBLE:
                    numValues = 10;
                    deviation = 3;
                    break;
                default:
                    numValues = 2;
                    deviation = 0;
                    break;
            }
            List<long> vals = new List<long>(numValues);

        }

        public void GenerateOperators()
        {
            throw new NotImplementedException();
        }

        public bool Validate()
        {
            throw new NotImplementedException();
        }
    }
}
