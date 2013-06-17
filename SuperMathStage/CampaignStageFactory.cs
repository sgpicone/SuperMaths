﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMath
{
    public class CampaignStageFactory : IStageFactory
    {
        public AStage CreateStage()
        {
            return new CampaignStage();
        }
    }
}
