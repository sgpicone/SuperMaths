using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMathGame
{
    class MarathonGame : AGame
    {
        private SuperMathDifficulty.Difficulty diff;

        public MarathonGame()
        {
            this.gameMode = GameMode.MARATHON;
        }

        public MarathonGame(SuperMathDifficulty.Difficulty diff)
        {
            // TODO: Complete member initialization
            this.diff = diff;
        }

        protected override void PrepareGame(SuperMathDifficulty.Difficulty diff)
        {
            throw new NotImplementedException();
        }
    }
}
