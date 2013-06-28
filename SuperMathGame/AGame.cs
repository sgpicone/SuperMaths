using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMathGame
{
    public abstract class AGame
    {
        protected List<AStage> levels; //list of levels
        protected GameMode gameMode;
        protected KeyValuePair<DifficultyType, Difficulty> GameDifficulties;
        protected Difficulty RangeDifficulty, //Difficulty for the range of possible answers (0-100, negatives, etc) 
                           ProblemDifficulty, //Difficulty of the problems
                           DistractionDifficulty, //Difficulty of the distractions
                           OperatorDifficulty, //Difficulty - which operators are used
                           NumProbsDifficulty, //Difficulty - number of problems per stage
                           TimeDifficulty; //Difficulty - amount of time per stage
        protected bool Adult; //if adult mode is on or off

        //public AGame(Difficulty range, Difficulty problem, Difficulty distraction,
        //            Difficulty ops, Difficulty numProbs, Difficulty time, GameMode mode, bool adult)
        //{
        //    this.RangeDifficulty = range;
        //    this.ProblemDifficulty = problem;
        //    this.DistractionDifficulty = distraction;
        //    this.OperatorDifficulty = ops;
        //    this.NumProbsDifficulty = numProbs;
        //    this.TimeDifficulty = time;
        //    this.gameMode = mode;
        //    this.Adult = adult;
        //}
        


    }
}
