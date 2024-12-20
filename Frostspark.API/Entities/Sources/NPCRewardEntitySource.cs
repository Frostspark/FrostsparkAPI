﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Entities.Sources
{
    public sealed class NPCRewardEntitySource : EntitySource
    {
        public NPC Gifter { get; private set; }

        public NPCRewardEntitySource(NPC gifter)
        {
            Gifter = gifter;
        }
    }
}
