using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMathGame
{
    class CampaignGameFactory : IGameFactory
    {
        public AGame CreateGame()
        {
            return new CampaignGame();
        }
    }
}
