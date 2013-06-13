using System;
using System.Collections.Generic;
using System.Data;
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

        public static double CalcDouble(List<long> vals, List<Operator> ops)
        {
            string equation = "";
            equation += vals[0];
            for (int i = 0; i < ops.Count; i++)
            {
                equation += OperatorExtensions.OperatorToString(ops[i]) + vals[i + 1];
            }
            double result = Convert.ToDouble(new DataTable().Compute(equation, null).ToString());
            result = Math.Round(result, 2);
            return result;
        }
    }
}
