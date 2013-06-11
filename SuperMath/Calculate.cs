using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMath
{
    class Calculate
    {
        /// <summary>
        /// Calculate the answer of a problem with an arbitrary number of values and operations.
        /// </summary>
        /// <param name="vals">The values of the problem</param>
        /// <param name="ops">The operators in the problem</param>
        /// <returns></returns>
        public static long Calc(List<long> vals, List<Operator> ops)
        {
            long ans;
            if (ops.Count != vals.Count - 1)
                throw new Exception();
            else
            {
                ans = CalcPart(vals[0], vals[1], ops[0]);
                for (int i = 1; i < ops.Count; i++)
                {
                    ans = CalcPart(ans, vals[i + 1], ops[i]);
                }
            }
            return ans;
        }
        /// <summary>
        /// Calculate part of a
        /// </summary>
        /// <param name="valueOne"></param>
        /// <param name="valueTwo"></param>
        /// <param name="op"></param>
        /// <returns></returns>
        private static long CalcPart(long valueOne, long valueTwo, Operator op)
        {
            long ans;
            switch (op)
            {
                case Operator.PLUS:
                    ans = valueOne + valueTwo;
                    break;
                case Operator.MINUS:
                    ans = valueOne - valueTwo;
                    break;
                case Operator.MULT:
                    ans = valueOne * valueTwo;
                    break;
                case Operator.DIV:
                    ans = valueOne / valueTwo;
                    break;
                default:
                    //this should really never happen...
                    ans = 0;
                    break;
            }
            return ans;
        }
    }
}
