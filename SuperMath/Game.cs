using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMath
{
    public class Game
    {
        private List<IStage> levels; //list of levels
        private GameMode gameMode;
        private Difficulty RangeDifficulty, //Difficulty for the range of possible answers (0-100, negatives, etc) 
                           ProblemDifficulty, //Difficulty of the problems
                           DistractionDifficulty, //Difficulty of the distractions
                           OperatorDifficulty, //Difficulty - which operators are used
                           NumProbsDifficulty, //Difficulty - number of problems per stage
                           TimeDifficulty; //Difficulty - amount of time per stage
        private bool Adult; //if adult mode is on or off

        public Game(Difficulty range, Difficulty problem, Difficulty distraction,
                    Difficulty ops, Difficulty numProbs, Difficulty time, GameMode mode, bool adult)
        {
            this.RangeDifficulty = range;
            this.ProblemDifficulty = problem;
            this.DistractionDifficulty = distraction;
            this.OperatorDifficulty = ops;
            this.NumProbsDifficulty = numProbs;
            this.TimeDifficulty = time;
            this.gameMode = mode;
            this.Adult = adult;
        }
        


    }
}
