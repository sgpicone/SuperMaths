﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperMathDifficulty;
using SuperMathStage;

namespace SuperMathGame
{
    public abstract class AGame
    {
        protected GameMode gameMode;
        protected bool Adult; //if adult mode is on or off
        protected Difficulty Difficulty;

        protected abstract void PrepareGame(Difficulty diff);
    }
}
