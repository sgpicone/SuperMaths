using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMath
{
    public class MarathonStage : AStage
    {
        private List<AProblem> _Problems;
        public List<AProblem> Problems
        {
            get { return _Problems; }
            private set { _Problems = value; }
        }

        private List<IDistraction> _Distractions;
        public List<IDistraction> Distractions
        {
            get { return _Distractions; }
            private set { _Distractions = value; }
        }

        Difficulty _Difficulty;
        Difficulty Difficulty
        {
            get { return _Difficulty; }
            private set { _Difficulty = value; }
        }
    }
}
