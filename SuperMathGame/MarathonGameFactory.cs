using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMath
{
    class MarathonGameFactory : IGameFactory
    {
        public AGame CreateGame()
        {
            return new MarathonGame();
        }
    }
}
