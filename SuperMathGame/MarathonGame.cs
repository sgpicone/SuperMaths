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
        private bool adult;


        public MarathonGame(bool adult)
        {
            this.Adult = adult;
            this.gameMode = GameMode.MARATHON;
        }

        public MarathonGame(SuperMathDifficulty.Difficulty diff, bool adult)
        {
            // TODO: Complete member initialization
            this.diff = diff;
            this.adult = adult;
        }

        protected override void PrepareGame(SuperMathDifficulty.Difficulty diff)
        {
            throw new NotImplementedException();
        }
    }
}
