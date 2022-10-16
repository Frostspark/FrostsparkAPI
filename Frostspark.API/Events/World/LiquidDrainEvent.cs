using Frostspark.API.Events.Interfaces;
using Frostspark.API.Worlds;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Events.World
{
    internal class LiquidDrainEvent : SingleTileEvent, ICancellable
    {
        public LiquidDrainEvent(byte new_level, Tile tile, Worlds.World world, API.Server server) : base(tile, world, server)
        {
            NewLevel = new_level;
        }

        public byte NewLevel { get; set; }

        public bool Cancelled { get; set; }
    }
}
