using Frostspark.API.Events.Interfaces;
using Frostspark.API.Worlds;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Events.World
{
    public abstract class SingleTileEvent : TileEvent, IHasTarget<Tile>
    {
        protected SingleTileEvent(Tile tile, Worlds.World world, API.Server server) : base(world, server)
        {
            Tile = tile;
        }

        public Tile Tile { get; }

        Tile IHasTarget<Tile>.Target => Tile;
    }
}
