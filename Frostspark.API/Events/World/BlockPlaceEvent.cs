using Frostspark.API.Entities;
using Frostspark.API.Events.Interfaces;
using Frostspark.API.Worlds;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Events.World
{
    public abstract class BlockPlaceEvent : SingleTileEvent, ICancellable
    {
        public BlockPlaceEvent(int type, byte style, Tile tile, Worlds.World world, API.Server server) : base(tile, world, server)
        {
            Type = type;
            Style = style;
        }

        public bool Cancelled { get; set; }

        public int Type { get; set; }

        public byte Style { get; set; }
    }
}
