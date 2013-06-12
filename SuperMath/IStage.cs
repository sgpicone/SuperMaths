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
            set;
        }
        List<IDistraction> Distractions
        {
            get;
            set;
        }
        Difficulty difficulty
        {
            get;
            set;
        }
    }
}
