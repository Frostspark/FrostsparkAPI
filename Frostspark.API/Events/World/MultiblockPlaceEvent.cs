using Frostspark.API.Entities;
using Frostspark.API.Events.Interfaces;
using Frostspark.API.Worlds;

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Events.World
{
    public abstract class MultiblockPlaceEvent : MultiblockTileEvent, ICancellable
    {
        public MultiblockPlaceEvent(int type, byte style, Rectangle area, Tile[,] tiles, Worlds.World world, API.Server server) : base(area, tiles, world, server)
        {
            Type = type;
            Style = style;
        }

        public bool Cancelled { get; set; }

        public int Type { get; set; }

        public byte Style { get; set; }
    }
}
