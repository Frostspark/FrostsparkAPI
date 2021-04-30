using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frostspark.API.Events.World
{
    public abstract class TileEvent : WorldEvent
    {
        protected TileEvent(API.Server server, Worlds.World world, Worlds.Tile tile) : base(server, world)
        {
            Tile = tile;
        }

        public Worlds.Tile Tile { get; }
    }
}
