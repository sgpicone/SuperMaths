using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMathGame
{
    class CampaignGame : AGame
    {
        public CampaignGame()
        {
            this.gameMode = GameMode.CAMPAIGN;
        }

        protected override void PrepareGame(SuperMathDifficulty.Difficulty diff)
        {
            throw new NotImplementedException();
        }
    }
}
