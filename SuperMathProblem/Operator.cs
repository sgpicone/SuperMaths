using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMathProblem
{
    /// <summary>
    /// Enum for the different possible operators: multiply, divide, add, subtract.
    /// </summary>
    public enum Operator
    {
        PLUS, MINUS, MULT, DIV
    }

    public static class OperatorExtensions
    {
        public static string OperatorToString(this Operator op)
        {
            switch (op)
            {
                case Operator.PLUS: return "+";
                case Operator.MINUS: return "-";
                case Operator.MULT: return "*";
                case Operator.DIV: return "/";
                default: return "";
            }
        }
    }
}
