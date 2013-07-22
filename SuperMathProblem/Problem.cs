using SuperMathDifficulty;
using SuperMathExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SuperMathProblem
{
    public class Problem : AProblem
    {
        public Problem(Difficulty diff, Random rgen)
        {
            this.RandomGenerator = rgen;
            this.Difficulty = diff;
            Create();
        }

        public override bool CheckAnswer(double value)
        {
            return this.Answer.VerifyAnswer(value);
        }
    }
}
