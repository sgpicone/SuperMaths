﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMath
{
    public class QuizStage : IStage
    {
        public List<IProblem> Problems
        {
            get { throw new NotImplementedException(); }
        }

        public List<IDistraction> Distractions
        {
            get { throw new NotImplementedException(); }
        }

        public Difficulty difficulty
        {
            get { throw new NotImplementedException(); }
        }
    }
}
