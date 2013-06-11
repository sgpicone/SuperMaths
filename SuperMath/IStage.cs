using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMath
{
    interface IStage
    {
        List<IProblem> Problems;
        List<IDistraction> Distractions;
        Difficulty difficulty
        {
            get;
            set;
        }
    }
}
