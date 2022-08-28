﻿using Frostspark.API.Entities;
using Frostspark.API.Events.Interfaces;
using Frostspark.API.Worlds;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Events.World
{
    public abstract class MinecartShapeEvent : SingleTileEvent, ICancellable
    {
        public MinecartShapeEvent(Tile tile, Worlds.World world, API.Server server) : base(tile, world, server)
        {
        }

        public bool Cancelled { get; set; }
    }
}
