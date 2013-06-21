using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMath
{
    public abstract class AStage
    {
        private List<AProblem> _Problems;
        public List<AProblem> Problems
        {
            get { return _Problems; }
            protected set { _Problems = value; }
        }

        private List<IDistraction> _Distractions;
        public List<IDistraction> Distractions
        {
            get { return _Distractions; }
            protected set { _Distractions = value; }
        }

        private Difficulty _Difficulty;
        public Difficulty Difficulty
        {
            get { return _Difficulty; }
            protected set
            {
                _Difficulty = value;
                _OperatorDifficulty = value;
                _RangeDifficulty = value;
                _AnswerDifficulty = value;
                _NumberOfValuesDifficulty = value;
                _DistractionsDifficulty = value;
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

        private Difficulty _DistractionsDifficulty;
        public Difficulty DistractionsDifficulty
        {
            get { return _DistractionsDifficulty; }
            protected set { _DistractionsDifficulty = value; }
        }

        /// <summary>
        /// Populate the stage with a list of problems
        /// based on the difficulty of the stage
        /// </summary>
        public abstract void PrepareStage();
    }
}
