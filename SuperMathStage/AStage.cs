#define spoopy 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperMathProblem;
using SuperMathDistraction;
using SuperMathDifficulty;


namespace SuperMathStage
{
    public abstract class AStage
    {
        protected int TimeLimit;
        protected int PointsAwarded;

        private List<double> _Answers;
        public List<double> Answers
        {
            get { return _Answers; }
            protected set { _Answers = value; }
        }

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
                _NumberOfProblemsDifficulty = value;
                _DistractionsDifficulty = value;
                _TimeDifficulty = value;
            }
        }

        private Difficulty _NumberOfProblemsDifficulty;
        public Difficulty NumberOfProblemsDifficulty
        {
            get { return _NumberOfProblemsDifficulty; }
            protected set { _NumberOfProblemsDifficulty = value; }
        }

        private Difficulty _TimeDifficulty;
        public Difficulty TimeDifficulty
        {
            get { return _TimeDifficulty; }
            protected set { _TimeDifficulty = value; }
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
        public abstract bool CheckAnswers();



    }
}
