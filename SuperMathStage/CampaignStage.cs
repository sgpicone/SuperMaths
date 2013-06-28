using SuperMathDifficulty;
using SuperMathDistraction;
using SuperMathProblem;
using System;
using System.Collections.Generic;

namespace SuperMathStage
{
    public class CampaignStage : AStage
    {
        public List<AProblem> Problems
        {
            get { throw new NotImplementedException(); }
        }

        public List<IDistraction> Distractions
        {
            get { throw new NotImplementedException(); }
        }

        public Difficulty Difficulty
        {
            get { throw new NotImplementedException(); }
        }

        public override void PrepareStage()
        {
            throw new NotImplementedException();
        }
    }
}
