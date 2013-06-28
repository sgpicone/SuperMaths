using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMathStage
{
    public class QuizStageFactory : IStageFactory
    {
        public AStage CreateStage()
        {
            return new QuizStage();
        }
    }
}
