using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMath
{
    public class QuizStage : IStage
    {
        private List<AProblem> _Problems;
        public List<AProblem> Problems
        {
            get { return _Problems; }
        }

        private List<IDistraction> _Distractions;
        public List<IDistraction> Distractions
        {
            get {return _Distractions; }
        }

        private Difficulty _Difficulty;
        public Difficulty Difficulty
        {
            get { return _Difficulty; }
        }
    }
}
