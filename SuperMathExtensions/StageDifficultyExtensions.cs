using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMathExtensions
{
    public static class StageDifficultyExtensions
    {
        /// <summary>
        /// Returns the number of problems for a stage based on the stage's difficulty
        /// </summary>
        /// <param name="diff">The difficulty of the stage</param>
        /// <returns>The number of problems for that stage based on the difficulty</returns>
        public static int StageNumberProblemsDifficulty(this Difficulty diff)
        {
            switch (diff)
            {
                case Difficulty.EASY: return 4;
                case Difficulty.NORMAL: return 6;
                case Difficulty.HARD: return 8;
                case Difficulty.VERY_HARD: return 10;
                case Difficulty.IMPOSSIBLE: return 16;
                default: return 4;
            }
        }

        /// <summary>
        /// Returns the time limit, in seconds, for a stage based on the stage's difficulty
        /// </summary>
        /// <param name="diff">The difficulty of the stage</param>
        /// <returns>The time limit for that stage based on the difficulty</returns>
        public static int StageTimeDifficulty(this Difficulty diff)
        {
            switch (diff)
            {
                case Difficulty.EASY: return 60;
                case Difficulty.NORMAL: return 45;
                case Difficulty.HARD: return 35;
                case Difficulty.VERY_HARD: return 30;
                case Difficulty.IMPOSSIBLE: return 20;
                default: return 45;
            }
        }
    }
}
