using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperMathDifficulty;

namespace SuperMathExtensions
{
    /// <summary>
    /// This class provides static extension methods for Difficulties related to Problems.
    /// </summary>
    public static class ProblemDifficultyExtensions
    {
        /// <summary>
        /// Returns the base points value for a problem, given its difficulty
        /// This value is used to generate a problem of a given difficulty.
        /// </summary>
        /// <param name="diff">The expected difficulty level of the problem</param>
        /// <returns>The base points value for this problem</returns>
        public static int ProblemPointBase(this Difficulty diff)
        {
            switch (diff)
            {
                case Difficulty.EASY: return 75;
                case Difficulty.NORMAL: return 125;
                case Difficulty.HARD: return 175;
                case Difficulty.VERY_HARD: return 275;
                case Difficulty.IMPOSSIBLE: return 375;
                default: return 75;
            }        
        }

        /// <summary>
        /// Returns the deviation from the base points value for a problem, given its difficulty
        /// This value is used to generate a problem of a given difficulty.
        /// </summary>
        /// <param name="diff">The expected difficulty level of this problem</param>
        /// <returns>The deviation from the base points for this problem</returns>
        public static int ProblemPointDeviation(this Difficulty diff)
        {
            int dev = 50;
            switch (diff)
            {
                case Difficulty.EASY:
                case Difficulty.NORMAL: return dev *= 1;
                case Difficulty.HARD: 
                case Difficulty.VERY_HARD: return dev *= 2;
                case Difficulty.IMPOSSIBLE: return dev *= 4;
                default: return dev *= 1;
            }
        }

        /// <summary>
        /// Returns the maximum value for values in a problem of the given difficulty
        /// </summary>
        /// <param name="diff">The difficulty of the problem</param>
        /// <returns>The maximum for values of this problem</returns>
        public static int ProblemMaxValue(this Difficulty diff)
        {
            switch (diff)
            {
                case Difficulty.EASY: return 26;
                case Difficulty.NORMAL: return 51;
                case Difficulty.HARD: return 76;
                case Difficulty.VERY_HARD: return 101;
                case Difficulty.IMPOSSIBLE: return 126;
                default: return 26;
            }
        }


        /// <summary>
        /// Get the upper bound for an answer for a problem of this difficulty
        /// </summary>
        /// <param name="diff">The difficulty of the problem</param>
        /// <returns>The upper bound for the answer of the problem</returns>
        public static int ProblemAnswerUpperBound(this Difficulty diff)
        {
            //1 added to all upperbounds because Random.Next(lower,upper) is exclusive
            //on the upper bound
            switch (diff)
            {
                case Difficulty.EASY: return 101;
                case Difficulty.NORMAL: return 251;
                case Difficulty.HARD: return 751;
                case Difficulty.VERY_HARD: return 1501;
                case Difficulty.IMPOSSIBLE: return 10001;
                default: return 0;
            }
        }

        /// <summary>
        /// Get the lower bound for an answer for a problem of this difficulty
        /// </summary>
        /// <param name="diff">The difficulty of the problem</param>
        /// <returns>The lower bound for the answer of the problem</returns>
        public static int ProblemAnswerLowerBound(this Difficulty diff)
        {
            switch (diff)
            {
                case Difficulty.EASY:
                case Difficulty.NORMAL: return 0;
                case Difficulty.HARD: return -100;
                case Difficulty.VERY_HARD: return -500;
                case Difficulty.IMPOSSIBLE: return -1000;
                default: return 0;
            }
        }

        /// <summary>
        /// Return the upper boundary for the values of this problem.
        /// All problems must have values (i.e. operands) less than or equal to this boundary
        /// </summary>
        /// <param name="diff">The difficulty of the problem</param>
        /// <returns>The boundary for this difficulty</returns>
        public static int ProblemValueUpperBound(this Difficulty diff)
        {
            switch (diff)
            {
                case Difficulty.EASY: return 101;
                case Difficulty.NORMAL: return 151;
                case Difficulty.HARD: return 251;
                case Difficulty.VERY_HARD: return 1001;
                case Difficulty.IMPOSSIBLE: return 4001;
                default: return 0;
            }
        }

        /// <summary>
        /// Return the lower boundary for the values of this problem.
        /// All problems must have values (i.e. operands) greater than or equal to this boundary
        /// </summary>
        /// <param name="diff">The difficulty of the problem</param>
        /// <returns>The boundary for this difficulty</returns>
        public static int ProblemValueLowerBound(this Difficulty diff)
        {
            switch (diff)
            {
                case Difficulty.EASY: return 0;
                case Difficulty.NORMAL: return -10;
                case Difficulty.HARD: return -50;
                case Difficulty.VERY_HARD: return -100;
                case Difficulty.IMPOSSIBLE: return -200;
                default: return 0;
            }
        }

        /// <summary>
        /// For each difficulty, the game will give the player a bit of
        /// leeway for their answers. This method returns what the allowed deviation
        /// is allowed for the player's answer, given the difficulty of the problem
        /// 
        /// DIFFICULTY      DEVIATION
        /// Easy            Within 2.5%
        /// Normal          Within 2.0%
        /// Hard            Within 1.1%
        /// Very Hard       Within 0.5%
        /// Impossible      Exact Answer
        /// </summary>
        /// <param name="diff">The difficulty of the problem</param>
        /// <returns>The deviation allowed from the answer</returns>
        public static double ProblemAnswerDeviationAllowed(this Difficulty diff)
        {
            switch (diff)
            {
                case Difficulty.EASY        :   return 0.025;
                case Difficulty.NORMAL      :   return 0.020;
                case Difficulty.HARD        :   return 0.011;
                case Difficulty.VERY_HARD   :   return 0.005;
                case Difficulty.IMPOSSIBLE  :   return 0;
                default: return 0;
            }
        }

        /// <summary>
        /// For each difficulty, there should be a different frequency for each operator.
        /// On easy, nothing other than + and - should appear, equal frequencies.
        /// Normal, +,-, and with a lower frequency, *
        /// Hard, +,-, and with a lower frequency, *,/
        /// Very Hard, +,-,*, and with a lower frequency, /
        /// Impossible, +,-,*,/ all likely.
        /// 
        /// We do this by generating a random double between 0 and 1 and passing it to this function
        /// Based on that value, we return an operator. Still not sure if this maybe belongs
        /// in OperatorExtensions and not Difficulty extensions.
        /// </summary>
        /// <param name="diff"></param>
        /// <returns></returns>
        //public static Operator ProblemOpByDiffAndFreq(this Difficulty diff, double freq)
        //{
        //    switch (diff)
        //    {
        //        case Difficulty.EASY: return (freq < .5) ? Operator.PLUS : Operator.MINUS;
        //        case Difficulty.NORMAL: return (freq >= .9) ? Operator.MULT : (freq < .45) ? Operator.PLUS : Operator.MINUS;
        //        case Difficulty.HARD: return (freq >= .9) ? Operator.MULT : (freq >= .8) ? Operator.DIV : (freq <.4) ? Operator.PLUS : Operator.MINUS;
        //        case Difficulty.VERY_HARD: return (freq >= .9) ? Operator.DIV : (freq >= .6) ? Operator.MULT : (freq < .3) ? Operator.PLUS : Operator.MINUS;
        //        case Difficulty.IMPOSSIBLE: return (freq >= .75) ? Operator.DIV : (freq >= .5) ? Operator.MULT : (freq < .25) ? Operator.PLUS : Operator.MINUS; ;
        //        default: return 0;
        //    }
        //}

        /// <summary>
        /// Returns the base number of values to use when creating a problem
        /// of the given difficulty
        /// </summary>
        /// <param name="diff">The difficulty of the problem</param>
        /// <returns>The base number of values for the problem, based on the difficulty</returns>
        public static int ProblemNumberOfValues(this Difficulty diff)
        {
            int numValues;
            switch (diff)
            {
                case Difficulty.EASY:
                    numValues = 2;
                    break;
                case Difficulty.NORMAL:
                    numValues = 3;
                    break;
                case Difficulty.HARD:
                    numValues = 4;
                    break;
                case Difficulty.VERY_HARD:
                    numValues = 6;
                    break;
                case Difficulty.IMPOSSIBLE:
                    numValues = 10; 
                    break;
                default:
                    numValues = 2; 
                    break;
            }
            return numValues;
        }

        /// <summary>
        /// Returns the deviation of number of values to use when creating a problem
        /// of the given difficulty.
        /// With the deviation, each problem of a difficulty may not necessarily have the
        /// same number of values every time:
        /// 
        /// DIFFICULTY      BASE        DEV         RANGE
        /// Easy            2           0           2
        /// Normal          3           1           2-4
        /// Hard            4           2           2-6
        /// Very Hard       6           2           4-8
        /// Impossible      10          3           7-13
        /// </summary>
        /// <param name="diff">The difficulty of the problem</param>
        /// <returns>The allowed deviation from the base number of values for the problem</returns>
        public static int ProblemNumberOfValuesDeviation(this Difficulty diff)
        {
            int deviation;
            switch (diff)
            {
                case Difficulty.EASY:
                    deviation = 0;
                    break;
                case Difficulty.NORMAL:
                    deviation = 1;
                    break;
                case Difficulty.HARD:
                    deviation = 2;
                    break;
                case Difficulty.VERY_HARD:
                    deviation = 2;
                    break;
                case Difficulty.IMPOSSIBLE:
                    deviation = 3;
                    break;
                default:
                    deviation = 0;
                    break;
            }
            return deviation;
        }
    }
}
