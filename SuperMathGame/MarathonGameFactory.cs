using SuperMathDifficulty;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMathGame
{
    class MarathonGameFactory : AGameFactory
    {
        protected override AGame CreateGame(Difficulty diff, bool adult)
        {
            return new MarathonGame(diff, adult);
        }
    }
}
