using Frostspark.API.Enums;
using Frostspark.API.Events.Interfaces;
using Frostspark.API.Worlds;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Events.World
{
    public abstract class LiquidUpdateEvent : SingleTileEvent, ICancellable
    {
        protected LiquidUpdateEvent(BlockLiquidType type, byte level, Tile tile, Worlds.World world, API.Server server) : base(tile, world, server)
        {
            Type = type;
            Level = level;
        }

        public BlockLiquidType Type { get; set; }

        public byte Level { get; set; }
        public bool Cancelled { get; set; }
    }
}
