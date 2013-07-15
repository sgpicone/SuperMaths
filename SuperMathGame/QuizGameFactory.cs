using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMathGame
{
    class QuizGameFactory : AGameFactory
    {
        protected override AGame CreateGame(SuperMathDifficulty.Difficulty diff, bool adult)
        {
            return new QuizGame(diff, adult);
        }
    }
}
