﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMathGame
{
    public class AGameFactory
    {
        public void NewGame(GameMode type, bool adult)
        {
            AGame game = CreateGame(type, adult);
        }

        protected abstract AGame CreateGame(GameMode type, bool adult);
    }
}
