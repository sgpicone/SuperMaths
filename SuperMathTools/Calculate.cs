using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMathUtils
{
    class Calculate
    {
        public const double INVALID_ANSWER = -9999; //I have a sneaking feeling that this is terrible programming practice.

        /// <summary>
        /// Calculate the answer of a problem with an arbitrary number of values and operations.
        /// </summary>
        /// <param name="vals">The values of the problem</param>
        /// <param name="ops">The operators in the problem</param>
        /// <returns></returns>
        public static long CalcLong(List<long> vals, List<Operator> ops)
        {
            string equation = "";
            equation += vals[0];
            for (int i = 0; i < ops.Count; i++)
            {
                equation += OperatorExtensions.OperatorToString(ops[i]) + vals[i+1];
            }
            double result = Convert.ToDouble(new DataTable().Compute(equation, null).ToString());
            result = Math.Round(result, 0);
            return (long)result;
        }

        /// <summary>
        /// Calculate the answer of a problem with an arbitrary number of values and operations.
        /// </summary>
        /// <param name="vals">The values of the problem</param>
        /// <param name="ops">The operators in the problem</param>
        /// <returns>A double, rounded to 2 decimal places, representing the answer to this problem</returns>
        public static double CalcDouble(List<long> vals, List<Operator> ops)
        {
            string equation = "";
            double result = 0;
            equation += vals[0];
            for (int i = 0; i < ops.Count; i++)
            {
                equation += OperatorExtensions.OperatorToString(ops[i]) + vals[i + 1];
            }
            try
            {
                result = Convert.ToDouble((new DataTable().Compute(equation, null).ToString()));
            }
            catch (OverflowException)
            {
                return INVALID_ANSWER;
            }
            result = Math.Round(result, 2);
            return result;
        }
    }
}
