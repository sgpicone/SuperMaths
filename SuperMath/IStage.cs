using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMath
{
    public interface IStage
    {
        List<IProblem> Problems
        {
            get;
            private set;
        }
        List<IDistraction> Distractions
        {
            get;
            private set;
        }
        Difficulty difficulty
        {
            get;
            private set;
        }
    }
}
