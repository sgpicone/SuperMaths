using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMathDifficulty
{
    public enum Difficulty
    {
        EASY, NORMAL, HARD, VERY_HARD, IMPOSSIBLE
    }

    /// AS OF 6/28/2013, SUPERMATHS WILL USE A POINTS SYSTEM FOR DIFFICULTY
    /// AND PROBLEM GENERATION.
    /// All problems will have a base point value and a deviation. A
    /// random number is generated between base-dev and base+dev, and that value
    /// is used to generate the problem as follows:
    ///     The number of values is randomly chosen such that the points earned by it
    ///         do not exceed 20% of the total points allotted to the problem.
    ///         The points earned from the number of values are subtracted from the
    ///         total allotted points, and the resulting value becomes the total
    ///         allotted points for the problem, to be used in future calculations.
    ///     The operators are chosen in a similar fashion, with harder operators (*, /)
    ///         being worth more points than easier operators (+, -), so that easy problems,
    ///         which are worth fewer points, are unlikely to have * or /.
    ///     Values are chosen in a similar fashion, in such a way that each value does not
    ///         exceed a certain percentage of the problem's total points when divided by 10.
    ///         This means that if an easy problem starts with a large value, the remaining values
    ///         will be gradually smaller.

    /// <summary>
    /// This class provides static extension methods for Difficulties.
    /// </summary>
    public static class DifficultyExtensions
    {
        /// <summary>
        /// Returns the string representation of the Difficulty enum
        /// </summary>
        /// <param name="diff">The difficulty</param>
        /// <param name="adult">Whether or not the game is in Adult mode</param>
        /// <returns>A string repesenting the Difficulty</returns>
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
    }
}
