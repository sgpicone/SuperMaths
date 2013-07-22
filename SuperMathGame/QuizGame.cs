using SuperMathDifficulty;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMathGame
{
    class QuizGame : AGame
    {
        public QuizGame(Difficulty diff)
        {
            this.gameMode = GameMode.QUIZ;
            PrepareGame(diff);
        }

        protected override void PrepareGame(Difficulty diff)
        {
            
        }
    }
}
