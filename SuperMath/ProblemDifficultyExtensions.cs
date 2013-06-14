﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMath
{
    /// <summary>
    /// This class provides static extension methods for Difficulties related to Problems.
    /// </summary>
    public static class ProblemDifficultyExtensions
    {
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
        /// Easy/Normal     Exact answer
        /// Hard            Within 1.1%
        /// Very Hard       Within 0.5%
        /// Impossible      Within 0.1% 
        /// </summary>
        /// <param name="diff">The difficulty of the problem</param>
        /// <returns>The deviation allowed from the answer</returns>
        public static double ProblemAnswerDeviationAllowed(this Difficulty diff)
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
        public static Operator ProblemOpByDiffAndFreq(this Difficulty diff, double freq)
        {
            switch (diff)
            {
                case Difficulty.EASY: return (freq < .5) ? Operator.PLUS : Operator.MINUS;
                case Difficulty.NORMAL: return (freq >= .9) ? Operator.MULT : (freq < .45) ? Operator.PLUS : Operator.MINUS;
                case Difficulty.HARD: return (freq >= .9) ? Operator.MULT : (freq >= .8) ? Operator.DIV : (freq <.4) ? Operator.PLUS : Operator.MINUS;
                case Difficulty.VERY_HARD: return (freq >= .9) ? Operator.DIV : (freq >= .6) ? Operator.MULT : (freq < .3) ? Operator.PLUS : Operator.MINUS;
                case Difficulty.IMPOSSIBLE: return (freq >= .75) ? Operator.DIV : (freq >= .5) ? Operator.MULT : (freq < .25) ? Operator.PLUS : Operator.MINUS; ;
                default: return 0;
            }
        }
    }
}