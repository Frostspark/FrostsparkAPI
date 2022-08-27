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
    public sealed class MultiblockPlaceEvent : MultiblockTileEvent, IHasSource<Player>, ICancellable
    {
        public MultiblockPlaceEvent(int type, byte style, Player player, Rectangle area, Tile[,] tiles, Worlds.World world, API.Server server) : base(area, tiles, world, server)
        {
            Type = type;
            Style = style;
            Source = player;
        }

        public Player Source { get; }

        public bool Cancelled { get; set; }

        public int Type { get; set; }

        public byte Style { get; set; }
    }
}
