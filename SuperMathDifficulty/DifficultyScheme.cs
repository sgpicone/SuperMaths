using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMathDifficulty
{
    public class DifficultyScheme
    {
        private Difficulty _Difficulty;
        public Difficulty Difficulty
        {
            get { return _Difficulty; }
            protected set
            {
                _Difficulty = value;
                _OperatorDifficulty = value;
                _RangeDifficulty = value;
                _AnswerDeviationDifficulty = value;
                _NumberOfValuesDifficulty = value;
                _AnswerRangeDifficulty = value;
            }
        }

        /// <summary>
        /// The difficulty that determines what operators
        /// are used in the problem; e.g., on easy, only addition
        /// and subtraction are used; on impossible, addition, subtraction,
        /// multiplication and division are all distributed evenly 
        /// through the problem
        /// </summary>
        private Difficulty _OperatorDifficulty;
        public Difficulty OperatorDifficulty
        {
            get { return _OperatorDifficulty; }
            protected set { _OperatorDifficulty = value; }
        }

        /// <summary>
        /// The difficulty that determines the range of values
        /// that can be used in the problem; e.g., on easy, only
        /// numbers between 0 and 100 are used to create the problem.
        /// </summary>
        private Difficulty _RangeDifficulty;
        public Difficulty RangeDifficulty
        {
            get { return _RangeDifficulty; }
            protected set { _RangeDifficulty = value; }
        }

        /// <summary>
        /// The allowed deviation from the answer; e.g., on hard, answers within
        /// 1.1% of the exact answer are accepted
        /// </summary>
        private Difficulty _AnswerDeviationDifficulty;
        public Difficulty AnswerDeviationDifficulty
        {
            get { return _AnswerDeviationDifficulty; }
            protected set { _AnswerDeviationDifficulty = value; }
        }

        /// <summary>
        /// The allowed deviation from the answer; e.g., on hard, answers within
        /// 1.1% of the exact answer are accepted
        /// </summary>
        private Difficulty _AnswerRangeDifficulty;
        public Difficulty AnswerRangeDifficulty
        {
            get { return _AnswerRangeDifficulty; }
            protected set { _AnswerRangeDifficulty = value; }
        }

        /// <summary>
        /// The difficulty that determines the number of values used in the problem.
        /// Ranges from 2 to 13.
        /// </summary>
        private Difficulty _NumberOfValuesDifficulty;
        public Difficulty NumberOfValuesDifficulty
        {
            get { return _NumberOfValuesDifficulty; }
            protected set { _NumberOfValuesDifficulty = value; }
        }

        public DifficultyScheme(Difficulty AbsoluteDifficulty)
        {
            this.OperatorDifficulty = AbsoluteDifficulty;
            this.RangeDifficulty = AbsoluteDifficulty;
            this.AnswerDeviationDifficulty = AbsoluteDifficulty;
            this.AnswerRangeDifficulty = AbsoluteDifficulty;
            this.NumberOfValuesDifficulty = AbsoluteDifficulty;
        }

        public DifficultyScheme(Difficulty OperatorDifficulty, Difficulty RangeDifficulty, Difficulty AnswerDeviationDifficulty,
                                Difficulty AnswerRangeDifficulty, Difficulty NumberOfValuesDifficulty)
        {
            this.OperatorDifficulty = OperatorDifficulty;
            this.RangeDifficulty = RangeDifficulty;
            this.AnswerDeviationDifficulty = AnswerDeviationDifficulty;
            this.AnswerRangeDifficulty = AnswerRangeDifficulty;
            this.NumberOfValuesDifficulty = NumberOfValuesDifficulty;
        }

        public void IncreaseDifficulty()
        {
            
        }

        private bool allDiffsEqual()
        {
            return (this.OperatorDifficulty == this.RangeDifficulty) &&
                (this.OperatorDifficulty == this.NumberOfValuesDifficulty) &&
                (this.OperatorDifficulty == this.AnswerRangeDifficulty) &&
                (this.OperatorDifficulty == this.AnswerDeviationDifficulty);
        }
    }
}
