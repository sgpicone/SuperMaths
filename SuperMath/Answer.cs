﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMath
{
    public class Answer
    {
        IProblem Problem;
        long _Answer;
        public long Ans
        {
            get { return _Answer; }
            private set { _Answer = value;  }
        }
        public Answer(IProblem problem)
        {
            Problem = problem;
            //Ans = Calculate.CalcLong(this.Problem.Values, this.Problem.Operators);
        }

    }
}