using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMath
{
    public enum Difficulty
    {
        EASY, NORMAL, HARD, VERY_HARD, IMPOSSIBLE
    }

    public static class DifficultyExtensions
    {
        public static string DifficultyToString(this Difficulty diff, bool adult)
        {
            if (!adult)
            {
                switch (diff)
                {
                    case Difficulty.EASY: return "Easy";
                    case Difficulty.NORMAL: return "Normal";
                    case Difficulty.HARD: return "Hard";
                    case Difficulty.VERY_HARD: return "Very Hard";
                    case Difficulty.IMPOSSIBLE: return "Impossible";
                    default: return "ERROR";
                }
            }
            else
            {
                switch (diff)
                {
                    case Difficulty.EASY: return "SOFT";
                    case Difficulty.NORMAL: return "SEMI";
                    case Difficulty.HARD: return "HARD";
                    case Difficulty.VERY_HARD: return "RAGING";
                    case Difficulty.IMPOSSIBLE: return "SHOVEL";
                    default: return "FUCK!";
                }
            }
        }

        /// <summary>
        /// Get the upper bound for an answer for a problem of this difficulty
        /// </summary>
        /// <param name="diff">The difficulty of the problem</param>
        /// <returns>The upper bound for the answer of the problem</returns>
        public static int AnswerUpperBound(this Difficulty diff)
        {
            //1 added to all upperbounds because Random.Next(lower,upper) is exclusive
            //on the upper bound
            switch (diff)
            {
                case Difficulty.EASY: return 101;
                case Difficulty.NORMAL: return 251;
                case Difficulty.HARD: return 751;
                case Difficulty.VERY_HARD: return 1501;
                case Difficulty.IMPOSSIBLE: return 100001;
                default: return 0;
            }
        }

        /// <summary>
        /// Get the lower bound for an answer for a problem of this difficulty
        /// </summary>
        /// <param name="diff">The difficulty of the problem</param>
        /// <returns>The lower bound for the answer of the problem</returns>
        public static int AnswerLowerBound(this Difficulty diff)
        {
            switch (diff)
            {
                case Difficulty.EASY:
                case Difficulty.NORMAL: return 0;
                case Difficulty.HARD: return 200;
                case Difficulty.VERY_HARD: return 500;
                case Difficulty.IMPOSSIBLE: return 1000;
                default: return 0;
            }
        }

        public static double AnswerDeviationAllowed(this Difficulty diff)
        {
            switch (diff)
            {
                case Difficulty.EASY:
                case Difficulty.NORMAL: return 0;
                case Difficulty.HARD: return .011;
                case Difficulty.VERY_HARD: return .005;
                case Difficulty.IMPOSSIBLE: return .001;
                default: return 0;
            }
        }


    }
}
