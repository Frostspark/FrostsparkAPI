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
    public abstract class WireEvent : SingleTileEvent
    {
        protected WireEvent(WireColor color, Tile tile, Worlds.World world, API.Server server) : base(tile, world, server)
        {
            Color = color;
        }

        public WireColor Color { get; set; }
    }
}
