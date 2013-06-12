using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMath
{
    public interface IProblem
    {
        List<long> Values
        {
            get;
        }

        List<Operator> Operators
        {
            get;
        }

        Answer Answer
        {
            get;
        }

        Difficulty Difficulty
        {
            get;
        }

        void GenerateValues();
        void GenerateOperators();
        bool Validate();
    }
}
