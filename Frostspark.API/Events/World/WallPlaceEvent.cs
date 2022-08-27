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
    public sealed class WallPlaceEvent : SingleTileEvent, IHasSource<Player>, ICancellable
    {
        public WallPlaceEvent(int type, Player source, Tile tile, Worlds.World world, API.Server server) : base(tile, world, server)
        {
            Type = type;
            Source = source;
        }

        public Player Source { get; }

        public bool Cancelled { get; set; }

        public int Type { get; set; }
    }
}
