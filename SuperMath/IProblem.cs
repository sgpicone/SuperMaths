using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMath
{
    interface IProblem
    {
        List<long> Values
        {
            get;
            set;
        }

        List<Operator> Operators
        {
            get;
            set;
        }

        Answer Answer
        {
            get;
        }
    }
}
