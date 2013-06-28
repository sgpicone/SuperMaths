using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SuperMathGame
{
    public interface IGameFactory
    {
        AGame CreateGame();
    }
}
