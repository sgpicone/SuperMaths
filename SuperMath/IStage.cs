using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMath
{
    public interface IStage
    {
        List<AProblem> Problems
        {
            get;
        }
        List<IDistraction> Distractions
        {
            get;
        }
        Difficulty Difficulty
        {
            get;
        }
    }
}
