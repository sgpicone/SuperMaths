using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMathGame
{
    public class CampaignGameFactory : AGameFactory
    {
        protected override AGame CreateGame(SuperMathDifficulty.Difficulty diff, bool adult)
        {
            throw new NotImplementedException();
        }
    }
}
